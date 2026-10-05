create view [dbo].[AppointmentsDetails_View] as
(
select Appointments.ID as [AppointmentID], Patients.ID as [PatientID], Patients.MedicalRecordNo as [MedicalRecordNo], concat_ws(' ', People.FirstName, People.SecondName, People.LastName) as [PatientName], dbo.GetDayOfWeek(DoctorSchedules.DayOfWeek) as [Day], format(Appointments.Date, 'dd/MM/yyyy') as [Date], concat(format(Appointments.Date, 'hh:mm tt'), ' to ', format(dateadd(minute, DoctorSchedules.SlotDuration, Appointments.Date), 'hh:mm tt')) as [Time], DoctorSchedules.SlotDuration as [SlotDuration], dbo.GetAppointmentStatus(Appointments.Status) as [Status], dbo.GetAppointmentType(Appointments.Type) as [Type], Doctors.ID as [DoctorID]
from Appointments
inner join DoctorSchedules on DoctorSchedules.ID = Appointments.DoctorScheduleID
inner join Patients on Appointments.PatientID = Patients.ID
inner join People on People.ID = Patients.PersonID
inner join Doctors on Doctors.ID = DoctorSchedules.DoctorID
)
go

create view [dbo].[DoctorSchedulesDetails_View] as
(
select DoctorSchedules.ID as [DoctorScheduleID], trim(dbo.GetDayOfWeek(DoctorSchedules.DayOfWeek)) as [DayOfWeek], DoctorSchedules.StartPeriod as [StartPeriod], DoctorSchedules.EndPeriod as [EndPeriod], DoctorSchedules.SlotDuration, DoctorSchedules.MaxPatientsPerSlot as [MaxPatientsPerSlot], DoctorSchedules.DoctorID as [DoctorID], case Doctors.IsActive when 1 then 'Active' else 'Inactive' end as [IsDoctorActive], concat_ws(' ', People.FirstName, People.SecondName, People.LastName) as [DoctorFullName], DepartmentID as [DepartmentID], Departments.Name as [DepartmentName], Departments.Description as [DepartmentDescription], Specializations.ID as [SpecializationID], Specializations.Name as [SpecializationName]
from DoctorSchedules
inner join Doctors on Doctors.ID = DoctorSchedules.DoctorID
inner join People on People.ID = Doctors.PersonID
inner join Departments on Departments.ID = Doctors.DepartmentID
inner join Specializations on Specializations.ID = Doctors.SpecializationID
)
go

create view [dbo].[DoctorsData_View] as
(
select Doctors.ID as [ID], concat_ws(' ', People.FirstName, People.SecondName, People.LastName) as [Full Name], Departments.ID as [DepartmentID], Departments.Name as [DepartmentName], Specializations.ID as [SpecializationID], Specializations.Name as [SpecializationName], case Doctors.IsActive when 1 then 'Active' else 'Inactive' end as [Active]
                                     from Doctors
                                     inner join People on Doctors.PersonID = People.ID
                                     inner join Departments on Doctors.DepartmentID = Departments.ID
                                     inner join Specializations on Doctors.SpecializationID = Specializations.ID
)
go

create view [dbo].[LabTestsData_View] as
(
select LT.ID as [ID], P.ID as [PatientID], P.MedicalRecordNo as [PatientMedicalRecordNo], dbo.GetLabTestStatus(LT.Status) as [Status], case LT.Result when 1 then 'Positive' when 0 then 'Negative' else 'No Result Yet' end [Result], LT.ResultDate as [ResultDate], LT.Notes as [Notes], LT.CreatedDate as [CreatedDate], LT.TestTypeID as [TestTypeID], TT.Name as [TestTypeName], LT.AppointmentID as [AppointmentID], LT.PatientChargeID as [PatientChargeID], LT.CreatedByUserID as [CreatedByUserID], U.Username as [CreatedByUsername]
from LabTests LT
inner join Appointments A on A.ID = LT.AppointmentID
inner join Patients P on P.ID = A.PatientID
inner join TestTypes TT on TT.ID = LT.TestTypeID
inner join Users U on U.ID = LT.CreatedByUserID
)
go

create view [dbo].[MedicalVisitsData_View] as
(
select MedicalVisits.ID as [ID], Patients.ID as [PatientID], Patients.MedicalRecordNo as [MedicalRecordNo], concat_ws(' ', People.FirstName, People.SecondName, People.LastName) as [PatientName], dbo.GetGender(People.Gender) as [PatientGender], Patients.BloodType as [BloodType], MedicalVisits.CreatedDate as [MedicalVisitDate], MedicalVisits.AppointmentID as [AppointmentID], Users.Username as [CreatedByUsername]
from MedicalVisits
inner join Appointments on Appointments.ID = MedicalVisits.AppointmentID
inner join Patients on Patients.ID = Appointments.PatientID
inner join People on People.ID = Patients.PersonID
inner join Users on Users.ID = MedicalVisits.CreatedByUserID
)
go

create view [dbo].[MedicinesData_View] as
(
select ID as [ID], Name as [Name], dbo.GetDosageForm(DosageForm) as [Dosage Form], Strength, case IsActive when 1 then 'Active' else 'Inactive' end as [Active] from Medicines
)
go

create view [dbo].[PatientsData_View] as
(
select Pa.ID as [ID], Pa.MedicalRecordNo as [Medical Record No], concat_ws(' ', Pe.FirstName, Pe.SecondName, Pe.LastName) as [Full Name], dbo.GetGender(Pe.Gender) as [Gender], Pe.DateOfBirth as [Date Of Birth], Pe.Phone as [Phone], Pa.BloodType as [Blood Type]
from Patients Pa
inner join People Pe on Pa.PersonID = Pe.ID
)
go