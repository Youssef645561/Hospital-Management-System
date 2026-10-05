create type tvp_Medicines as table ( ID int NULL )
go

create procedure [dbo].[sp_AddNewLabTest] as begin return; end;
go

create procedure [dbo].[sp_AddNewMedicalVisit] as begin return; end;
go

create procedure [dbo].[sp_AddNewPatientCharge] as begin return; end;
go

create procedure [dbo].[sp_AddNewPayment] as begin return; end;
go

create procedure [dbo].[sp_AddNewPrescription] as begin return; end;
go

create procedure [dbo].[sp_AddNewPrescriptionMedicines] as begin return; end;
go

create procedure [dbo].[sp_CancelAppointment] as begin return; end;
go

create procedure [dbo].[sp_CancelLabTest] as begin return; end;
go

create procedure [dbo].[sp_CancelPatientCharge] as begin return; end;
go

create procedure [dbo].[sp_CheckInAppointment] as begin return; end;
go

create procedure [dbo].[sp_EditPrescription] as begin return; end;
go

create procedure [dbo].[sp_EditPrescriptionMedicines] as begin return; end;
go

create procedure [dbo].[sp_IsPatientChargeRecordExist] as begin return; end;
go

create procedure [dbo].[sp_RefundPayment] as begin return; end;
go

create procedure [dbo].[sp_RescheduleAppointment] as begin return; end;
go

create procedure [dbo].[sp_ScheduleAppointment] as begin return; end;
go

alter procedure [dbo].[sp_AddNewLabTest] @LabTestID int output, @TestTypeID tinyint, @AppointmentID int, @CreatedByUserID int
as begin
	begin try
		begin transaction
			declare @PatientChargeID int;

			declare @ChargeServiceID smallint = 3;

			declare @ServiceFees smallmoney = (select Fees from ChargeServices where ID = @ChargeServiceID);
			declare @TestFees smallmoney = (select Fees from TestTypes where ID = @TestTypeID);
			declare @TotalOriginalFees smallmoney = (@ServiceFees + @TestFees);

			exec @PatientChargeID = sp_AddNewPatientCharge
														  @ServiceFees,
														  @TotalOriginalFees,
														  0,
														  @AppointmentID,
														  @ChargeServiceID,
														  @TestTypeID,
														  @CreatedByUserID;

			if @PatientChargeID is null or @PatientChargeID <= 0
				throw 50001, 'Failed to complete the operation.', 1;

			insert into LabTests (Status, TestTypeID, AppointmentID, PatientChargeID, CreatedByUserID)
			values (1, @TestTypeID, @AppointmentID, @PatientChargeID, @CreatedByUserID);
			
			set @LabTestID = scope_identity();
		commit transaction
	end try
	begin catch
		if @@trancount > 0
			rollback transaction;

		throw;
	end catch
end
go

alter procedure [dbo].[sp_AddNewMedicalVisit]
									   @MedicalVisitID int output,
									   @PatientSymptoms varchar(255),
									   @Diagnosis varchar(255), @Notes varchar(255),
									   @AppointmentID int,
									   @CreatedByUserID int
as begin
	begin try
		begin transaction;
			insert into MedicalVisits (PatientSymptoms, Diagnosis, Notes, AppointmentID, CreatedByUserID)
			values
			(@PatientSymptoms, @Diagnosis, @Notes, @AppointmentID, @CreatedByUserID);

			select @MedicalVisitID = scope_identity();

			update Appointments
			set Status = 3, CheckInDate = getdate()
			where ID = @AppointmentID and Status = 2;
			commit transaction;
	end try
	begin catch
		if @@trancount > 0
			rollback transaction;

		throw;
	end catch
end
go

alter procedure [dbo].[sp_AddNewPatientCharge]
									 @ServiceFees smallmoney,
									 @TotalOriginalFees smallmoney,
									 @DiscountPercentage decimal(5,2),
									 @AppointmentID int,
									 @ChargeServiceID smallint,
									 @TestTypeID tinyint,
									 @CreatedByUserID int
as begin
	if @DiscountPercentage is null
		set @DiscountPercentage = 0;

	if @TestTypeID <= 0
		set @TestTypeID = null;
	
	declare @RemainingFees smallmoney = @TotalOriginalFees * (1 - (@DiscountPercentage / 100));
	
	insert into PatientCharges (ServiceFees, TotalOriginalFees, PaidFees, RemainingFees, DiscountPercentage, Status, AppointmentID, ChargeServiceID, TestTypeID, CreatedByUserID)
	values (@ServiceFees, @TotalOriginalFees, 0, @RemainingFees, @DiscountPercentage, 1, @AppointmentID, @ChargeServiceID, @TestTypeID, @CreatedByUserID);
	
	exec sp_CheckInAppointment @AppointmentID;

	return scope_identity();
end
go

alter procedure [dbo].[sp_AddNewPayment]
								 @PaymentID int output,
								 @TransactionNo uniqueidentifier output,
								 @PaidAmount smallmoney,
								 @Method tinyint,
								 @PatientChargeID int,
								 @CreatedByUserID int
as begin
begin try
	begin transaction;	
		declare @Results table
		(
			InsertedPaymentID int,
			InsertedTransactionNo uniqueidentifier
		);

		update PatientCharges
		set
		PaidFees += @PaidAmount,
		RemainingFees -= @PaidAmount,
		Status =
		case
		when RemainingFees - @PaidAmount > 0 then 2
		when RemainingFees - @PaidAmount = 0 then 3
		else 1
		end

		where ID = @PatientChargeID and RemainingFees > 0 and @PaidAmount > 0 and @PaidAmount <= RemainingFees;

		if @@ROWCOUNT <= 0
			throw 50001, 'Payment could not be added.', 1;

		insert into Payments (PaidAmount, Method, Status, PatientChargeID, CreatedByUserID)
		output inserted.ID, inserted.TransactionNo into @Results
		values (@PaidAmount, @Method, 1, @PatientChargeID, @CreatedByUserID)

		select @PaymentID = InsertedPaymentID, @TransactionNo = InsertedTransactionNo from @Results;

	commit transaction;
end try
begin catch
    if @@trancount > 0
        rollback transaction;

	throw;
end catch
end;
go

alter procedure [dbo].[sp_AddNewPrescription] @PrescriptionID int output, @ExpirationDate date, @MedicalVisitId int, @MedicineIDs dbo.tvp_Medicines readonly, @CreatedByUserID int
as begin
	begin try
		begin transaction;
			insert into Prescriptions (ExpirationDate, Status, MedicalVisitID, CreatedByUserID)
			values
			(@ExpirationDate, 1, @MedicalVisitID, @CreatedByUserID);

			select @PrescriptionID = scope_identity();

			exec sp_AddNewPrescriptionMedicines @PrescriptionID, @MedicineIDs, @CreatedByUserID;
		commit transaction;
	end try
	begin catch
		if @@trancount > 0
			rollback transaction;

		throw;
	end catch
end
go

alter procedure [dbo].[sp_AddNewPrescriptionMedicines] @PrescriptionID int, @MedicineIDs dbo.tvp_Medicines readonly, @CreatedByUserID int
as begin
	insert into PrescriptionMedicines (PrescriptionID, MedicineID, CreatedByUserID)
	select @PrescriptionID, MedicineIDs.ID, @CreatedByUserID from @MedicineIDs as MedicineIDs
	where not exists (select 1 from PrescriptionMedicines where PrescriptionMedicines.PrescriptionID = @PrescriptionID and MedicineID = MedicineIDs.ID);
end
go

alter procedure [dbo].[sp_CancelAppointment] @ID int
as begin
	update Appointments set Status = 3 where ID = @ID;
end;
go

alter procedure [dbo].[sp_CancelLabTest] @LabTestID int, @RefundAmount smallmoney output
as begin
	begin try
		begin transaction;
			update LabTests set Status = 4 where ID = @LabTestID and Status in (1, 2);
			
			if @@rowcount <= 0
			    throw 50002, 'Failed to cancel the lab test.', 1;

			declare @PatientChargeID int = (select PatientChargeID from LabTests where ID = @LabTestID);
			
			exec sp_CancelPatientCharge @PatientChargeID, @RefundAmount output;
		commit transaction;
	end try
	begin catch
		if @@trancount > 0
		    rollback transaction;

		throw;
	end catch
end
go

alter procedure [dbo].[sp_CancelPatientCharge] @PatientChargeID int, @RefundAmount smallmoney output
as begin
	begin try
		begin transaction;
			set @RefundAmount = 0;

			declare @OldStatus table ( Status tinyint )
			
			update PatientCharges set Status = 4
			output deleted.Status into @OldStatus
			where ID = @PatientChargeID
			
			if @@rowcount <= 0
			    throw 50002, 'Failed to cancel the patient charge.', 1;

			if exists (select 1 from @OldStatus where Status = 4)
				throw 50001, 'Patient charge is already cancelled.', 1;

			if exists (select 1 from @OldStatus where Status <> 1)
			begin
				declare @RefundAmounts table ( PaidAmount smallmoney );

				update Payments set Status = 2
				output deleted.PaidAmount into @RefundAmounts
				where PatientChargeID = @PatientChargeID
				
				select @RefundAmount = coalesce(sum(PaidAmount), 0) from @RefundAmounts;
			end
		commit transaction;
	end try
	begin catch
		if @@trancount > 0
		    rollback transaction;

		throw;
	end catch
end
go

alter procedure [dbo].[sp_CheckInAppointment] @ID int
as begin
	update Appointments
	set Status = 2, CheckInDate = getdate()
	where ID = @ID and Status = 1
end
go

alter procedure [dbo].[sp_EditPrescription] @PrescriptionID int, @ExpirationDate date, @Status tinyint, @MedicineIDs dbo.tvp_Medicines readonly, @CreatedByUserID int
as begin
	begin try
		begin transaction;
			update Prescriptions
			set ExpirationDate = @ExpirationDate, Status = @Status where ID = @PrescriptionID

			exec sp_EditPrescriptionMedicines @PrescriptionID, @MedicineIDs, @CreatedByUserID;
			
		commit transaction;
	end try
	begin catch
		if @@trancount > 0
			rollback transaction;

		throw;
	end catch
end
go

alter procedure [dbo].[sp_EditPrescriptionMedicines] @PrescriptionID int, @MedicineIDs dbo.tvp_Medicines readonly, @CreatedByUserID int
as begin
	delete from PrescriptionMedicines
	where PrescriptionID = @PrescriptionID
	and not exists (select 1 from @MedicineIDs where ID = MedicineID);

	exec sp_AddNEwPrescriptionMedicines @PrescriptionID, @MedicineIDs, @CreatedByUserID;
end
go

alter procedure [dbo].[sp_IsPatientChargeRecordExist]
											  @AppointmentID int,
											  @ChargeServiceID smallint,
											  @TestTypeID tinyint
as begin
		if exists
		(
		select 1 from PatientCharges
		where 
		PatientCharges.AppointmentID = @AppointmentID and
		PatientCharges.ChargeServiceID = @ChargeServiceID and
		PatientCharges.Status <> 4 and
		(PatientCharges.ChargeServiceID <> 3 or exists (select 1 from LabTests where LabTests.AppointmentID = @AppointmentID and LabTests.TestTypeID = @TestTypeID and LabTests.Status <> 4))
		)
			return 1;

	return 0;
end
go

alter procedure [dbo].[sp_RefundPayment] @PaymentID int, @RefundAmount smallmoney output
as begin
	begin try
		begin transaction;			
			declare @Results table ( PatientChargeID int, PaidAmount smallmoney );
			declare @PatientChargeID int;
			
			update Payments 
			set Status = 2
			output deleted.PatientChargeID, deleted.PaidAmount into @Results
			where ID = @PaymentID and Status = 1;
			
			select @PatientChargeID = PatientChargeID, @RefundAmount = PaidAmount from @Results;

			if @@rowcount <= 0
				throw 50001, 'Failed to refund the payment.', 1;
			
			update PatientCharges
			set
			PaidFees -= @RefundAmount,
			RemainingFees += @RefundAmount,
			Status = case when PaidFees - @RefundAmount = 0 then 1 else 2 end
			where ID = @PatientChargeID;

			if @@rowcount <= 0
				throw 50001, 'Failed to refund the payment.', 1;
		commit transaction;
	end try
	begin catch
		if @@trancount > 0
		    rollback transaction;

		throw;
	end catch
end
go

alter procedure [dbo].[sp_RescheduleAppointment] @ID int output, @Date datetime, @Type tinyint, @DoctorScheduleID tinyint,  @PatientID int, @CreatedByUserID int, @ScheduledAppointmentID int
as begin
	begin try
		begin transaction;
			
			update Appointments set Status = 4 where ID = @ScheduledAppointmentID and Status = 1;

			exec sp_ScheduleAppointment @ID = @ID output, @Date = @Date, @Type = @Type, @DoctorScheduleID = @DoctorScheduleID, @PatientID = @PatientID, @CreatedByUserID = @CreatedByUserID;
			
		commit transaction;
	end try
	begin catch
	    if @@trancount > 0
			rollback transaction;
		throw;
	end catch
end;
go

alter procedure [dbo].[sp_ScheduleAppointment] @ID int output, @Date datetime, @Type tinyint, @DoctorScheduleID tinyint,  @PatientID int, @CreatedByUserID int
as begin
	insert into Appointments (Date, Status, Type, DoctorScheduleID, PatientID, CreatedByUserID)
	values (@Date, 1, @Type, @DoctorScheduleID, @PatientID, @CreatedByUserID);
	
	set @ID = scope_identity(); 
end;