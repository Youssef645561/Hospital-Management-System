insert into Departments (Name, Description)
values
('Internal Medicine', 'Diagnosis and treatment of internal diseases'),
('Cardiology', 'Diagnosis and treatment of heart diseases'),
('Pediatrics', 'Medical care for children'),
('Dermatology', 'Diagnosis and treatment of skin diseases'),
('Neurology', 'Diagnosis and treatment of nervous system disorders'),
('Orthopedics', 'Diagnosis and treatment of musculoskeletal conditions'),
('Ophthalmology', 'Diagnosis and treatment of eye diseases'),
('ENT', 'Diagnosis and treatment of ear, nose, and throat disorders'),
('General Surgery', 'Surgical diagnosis and treatment'),
('Dentistry', 'Dental diagnosis and treatment');

insert into Specializations (Name)
values
('Internal Medicine'),
('Cardiology'),
('Pediatrics'),
('Dermatology'),
('Neurology'),
('Orthopedics'),
('Ophthalmology'),
('ENT'),
('General Surgery'),
('Dentistry');

insert into TestTypes (Name, Description, Fees, IsAvailable)
values
('Blood Test', 'General blood analysis', 30, 1),
('Urine Test', 'Urine analysis', 10, 1),
('Stool Test', 'Stool analysis', 20, 1),
('Liver Function Test', 'Liver function analysis', 50, 1),
('Kidney Function Test', 'Kidney function analysis', 45, 1),
('Blood Glucose Test', 'Blood glucose measurement', 25, 1);

insert into ChargeServices (Name, Fees)
values
('Examination', 100),
('Consultation', 75),
('Lab Test', 10);

insert into UserRoles (Name, Permissions)
values
('Administrator', -1),
('Receptionist', 1),
('Doctor', 2),
('Laboratory Technician', 4),
('Pharmacist', 8),
('Accountant', 16);

insert into Users (Username, Password, IsActive, UserRoleID) values
-- Administrator (UserRoleID: 1)
('admin', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 1),

-- Receptionists (UserRoleID: 2)
('user_rec_01', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 2), ('user_rec_02', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 2), ('user_rec_03', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 0, 2), ('user_rec_04', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 2), ('user_rec_05', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 2),
('user_rec_06', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 0, 2), ('user_rec_07', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 2), ('user_rec_08', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 2), ('user_rec_09', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 0, 2), ('user_rec_10', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 2),

-- Doctors (UserRoleID: 3)
('user_doc_01', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 3), ('user_doc_02', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 3), ('user_doc_03', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 3), ('user_doc_04', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 0, 3), ('user_doc_05', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 3),
('user_doc_06', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 3), ('user_doc_07', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 0, 3), ('user_doc_08', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 3), ('user_doc_09', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 3), ('user_doc_10', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 3),
('user_doc_11', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 0, 3), ('user_doc_12', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 3), ('user_doc_13', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 3), ('user_doc_14', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 0, 3), ('user_doc_15', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 3),

-- Laboratory Technicians (UserRoleID: 4)
('user_lab_01', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 4), ('user_lab_02', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 0, 4), ('user_lab_03', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 4), ('user_lab_04', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 4), ('user_lab_05', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 4),
('user_lab_06', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 0, 4), ('user_lab_07', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 4), ('user_lab_08', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 4), ('user_lab_09', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 0, 4),

-- Pharmacists (UserRoleID: 5)
('user_ph_01', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 5), ('user_ph_02', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 5), ('user_ph_03', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 0, 5), ('user_ph_04', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 5), ('user_ph_05', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 5),
('user_ph_06', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 0, 5), ('user_ph_07', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 5), ('user_ph_08', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 5),

-- Accountants (UserRoleID: 6)
('user_acc_01', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 6), ('user_acc_02', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 0, 6), ('user_acc_03', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 6), ('user_acc_04', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 6), ('user_acc_05', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 0, 6),
('user_acc_06', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 6), ('user_acc_07', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 6), ('user_acc_08', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, 6);

--Metadata

-- Gender
exec sys.sp_addextendedproperty
	@name = N'MS_Description',
	@value = N'Male = 1, Female = 0',
	@level0type = N'SCHEMA',
	@level0name = N'dbo',
	@level1type = N'TABLE',
	@level1name = N'People',
	@level2type = N'COLUMN',
	@level2name = N'Gender';

go

create function GetGender(@Gender bit)
returns varchar(6) as
begin
	if (@Gender = 1)
		return 'Male';
	
	return 'Female';
end

go

-- Day Of Week
exec sys.sp_addextendedproperty
	@name = N'MS_Description',
	@value = N'Saturday = 1, Sunday = 2, Monday = 3, Tuesday = 4, Wednesday = 5, Thursday = 6, Friday = 7',
	@level0type = N'SCHEMA',
	@level0name = N'dbo',
	@level1type = N'TABLE',
	@level1name = N'DoctorSchedules',
	@level2type = N'COLUMN',
	@level2name = N'DayOfWeek';

go

create function GetDayOfWeek(@DayOfWeek tinyint)
returns varchar(9) as
begin
	if (@DayOfWeek = 1)
		return 'Saturday';
	
	if (@DayOfWeek = 2)
		return 'Sunday';

	if (@DayOfWeek = 3)
		return 'Monday';

	if (@DayOfWeek = 4)
		return 'Tuesday';

	if (@DayOfWeek = 5)
		return 'Wednesday';

	if (@DayOfWeek = 6)
		return 'Thursday';

	return 'Friday';
end;

go

-- Appointment Status
exec sys.sp_addextendedproperty
	@name = N'MS_Description',
	@value = N'Scheduled = 1, Waiting = 2, Completed = 3, Cancelled = 4, No Show = 5',
	@level0type = N'SCHEMA',
	@level0name = N'dbo',
	@level1type = N'TABLE',
	@level1name = N'Appointments',
	@level2type = N'COLUMN',
	@level2name = N'Status';

go

create function GetAppointmentStatus(@Status tinyint)
returns varchar(9) as
begin 
	if (@Status = 1)
		return 'Scheduled';
	
	if (@Status = 2)
		return 'Waiting';

	if (@Status = 3)
		return 'Completed';

	if (@Status = 4)
		return 'Cancelled';

	return 'No Show';
end;

go

-- Appointment Type
exec sys.sp_addextendedproperty
	@name = N'MS_Description',
	@value = N'Examination = 1, Consultation = 2',
	@level0type = N'SCHEMA',
	@level0name = N'dbo',
	@level1type = N'TABLE',
	@level1name = N'Appointments',
	@level2type = N'COLUMN',
	@level2name = N'Type';

go

create function GetAppointmentType(@Type tinyint)
returns varchar(12) as
begin
	if (@Type = 1)
		return 'Examination';

	return 'Consultation';
end;

go

-- Prescription Status
exec sys.sp_addextendedproperty
	@name = N'MS_Description',
	@value = N'Active = 1, Expired = 2, Cancelled = 3',
	@level0type = N'SCHEMA',
	@level0name = N'dbo',
	@level1type = N'TABLE',
	@level1name = N'Prescriptions',
	@level2type = N'COLUMN',
	@level2name = N'Status';

go

create function GetPrescriptionStatus(@Status tinyint)
returns varchar(9) as
begin
	if (@Status = 1)
		return 'Active';
	if (@Status = 2)
		return 'Expired';

	return 'Cancelled';
end;

go

-- LabTest Status
exec sys.sp_addextendedproperty
	@name = N'MS_Description',
	@value = N'Pending = 1, In Progress = 2, Completed = 3, Cancelled = 4',
	@level0type = N'SCHEMA',
	@level0name = N'dbo',
	@level1type = N'TABLE',
	@level1name = N'LabTests',
	@level2type = N'COLUMN',
	@level2name = N'Status';

go

create function GetLabTestStatus(@Status tinyint)
returns varchar(11) as
begin
	if (@Status = 1)
		return 'Pending';
	
	if (@Status = 2)
		return 'In Progress';

	if (@Status = 3)
		return 'Completed';

	return 'Cancelled';
end;

go

-- PatientCharge Status
exec sys.sp_addextendedproperty
	@name = N'MS_Description',
	@value = N'Unpaid = 1, Partially Paid = 2, Paid = 3, Cancelled = 4',
	@level0type = N'SCHEMA',
	@level0name = N'dbo',
	@level1type = N'TABLE',
	@level1name = N'PatientCharges',
	@level2type = N'COLUMN',
	@level2name = N'Status';

go

create function GetChargeStatus(@Status tinyint)
returns varchar(14) as
begin
	if (@Status = 1)
		return 'Unpaid';

	if (@Status = 2)
		return 'Partially Paid';

	if (@Status = 3)
		return 'Paid';

	return 'Cancelled';
end;

go

-- Payment Method
exec sys.sp_addextendedproperty
	@name = N'MS_Description',
	@value = N'Cash = 1, Card = 2, Bank Transfer = 3',
	@level0type = N'SCHEMA',
	@level0name = N'dbo',
	@level1type = N'TABLE',
	@level1name = N'Payments',
	@level2type = N'COLUMN',
	@level2name = N'Method';

go

create function GetPaymentMethod(@Method tinyint)
returns varchar(13) as
begin
	if (@Method = 1)
		return 'Cash';

	if (@Method = 2)
		return 'Card';

	return 'Bank Transfer';
end;

go

-- Payment Status
exec sys.sp_addextendedproperty
	@name = N'MS_Description',
	@value = N'Completed = 1, Refunded = 2',
	@level0type = N'SCHEMA',
	@level0name = N'dbo',
	@level1type = N'TABLE',
	@level1name = N'Payments',
	@level2type = N'COLUMN',
	@level2name = N'Status';

go

create function GetPaymentStatus(@Status tinyint)
returns varchar(9) as
begin
	if (@Status = 1)
		return 'Completed';

	return 'Refunded';
end;

go

-- Medicine DosageForm
exec sys.sp_addextendedproperty
	@name = N'MS_Description',
	@value = N'Capsule = 1, Cream = 2, Drops = 3, Inhaler = 4, Injection = 5, Ointment = 6, Syrup = 7, Tablet = 8',
	@level0type = N'SCHEMA',
	@level0name = N'dbo',
	@level1type = N'TABLE',
	@level1name = N'Medicines',
	@level2type = N'COLUMN',
	@level2name = N'DosageForm';

go

create function GetDosageForm(@Form tinyint)
returns varchar(9) as
begin
	if (@Form = 1)
		return 'Capsule';
	
	if (@Form = 2)
		return 'Cream';
	
	if (@Form = 3)
		return 'Drops';
	
	if (@Form = 4)
		return 'Inhaler';
	
	if (@Form = 5)
		return 'Injection';
	
	if (@Form = 6)
		return 'Ointment';
	
	if (@Form = 7)
		return 'Syrup';

	return 'Tablet';
end;