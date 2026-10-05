create database HospitalDB;

go

use HospitalDB;

go

--Don't forget statuses & DosageForm

--Tables creation

create table UserRoles
(
	ID tinyint identity(1, 1),
	Name varchar (50) not null,
	Permissions smallint not null,

	constraint PK_UserRoles primary key (ID),
	constraint UQ_UserRoles_Name unique (Name)
)

create table Users
(
	ID int identity(1, 1),
	Username varchar(30) not null,
	Password varchar(260) not null,
	IsActive bit not null,

	CreatedDate datetime not null,

	UserRoleID tinyint not null, --FK

	constraint PK_Users primary key (ID),
	constraint UQ_Users_Username unique (Username),
	constraint DF_Users_CreatedDate default getdate() for CreatedDate
)

create table People
(
	ID int identity(1, 1),
	FirstName varchar(30) not null,
	SecondName varchar(30) null,
	LastName varchar(30) not null,
	DateOfBirth date not null,
	Gender bit not null,
	Email varchar(30) null,
	Phone varchar(20) not null,
	PersonalImage varbinary(max) null,

	CreatedDate datetime not null,

	CreatedByUserID int not null, --FK

	constraint PK_People primary key (ID),
	constraint DF_People_CreatedDate default getdate() for CreatedDate
)

create table Departments
(
	ID tinyint identity(1, 1),
	Name varchar(30) not null,
	Description varchar(255) null,

	constraint PK_Departments primary key (ID),
	constraint UQ_Departments_Name unique (Name)
)

create table Specializations
(
	ID tinyint identity(1, 1),
	Name varchar(30) not null,

	constraint PK_Specializations primary key (ID),
	constraint UQ_Specializations_Name unique (Name)
)

create table Doctors
(
	ID int identity(1, 1),
	IsActive bit not null,

	CreatedDate datetime not null,

	PersonID int not null, --FK
	DepartmentID tinyint not null, --FK
	SpecializationID tinyint not null, --FK
	CreatedByUserID int not null, --FK

	constraint PK_Doctors primary key (ID),
	constraint UQ_Doctors_PersonID unique (PersonID),
	constraint DF_Doctors_CreatedDate default getdate() for CreatedDate
)

create table Patients
(
	ID int identity(1, 1),
	MedicalRecordNo as concat('MR', right(concat('000000', cast(PersonID as varchar(6))), 6)) persisted,
	BloodType varchar(3) not null,

	CreatedDate datetime not null,

	PersonID int not null, --FK
	CreatedByUserID int not null, --FK

	constraint PK_Patients primary key (ID),
	constraint UQ_Patients_PersonID unique (PersonID),
	constraint CK_Patients_BloodType check (upper(BloodType) in ('A+', 'A-', 'B+', 'B-', 'AB+', 'AB-', 'O+', 'O-')),
	constraint DF_Patients_CreatedDate default getdate() for CreatedDate
)

create table DoctorSchedules
(
	ID int identity(1, 1),
	DayOfWeek tinyint not null,
	StartPeriod time,
	EndPeriod time,
	SlotDuration tinyint,
	MaxPatientsPerSlot tinyint,

	DoctorID int not null, --FK

	constraint PK_DoctorSchedules primary key (ID)
)

create table Appointments
(
	ID int identity(1, 1),
	Date datetime not null,
	Status tinyint not null,
	Type tinyint not null,

	DoctorSchedules int not null, --FK
	PatientID int not null, --FK

	CheckInDate datetime null,

	CreatedDate datetime not null,
	CreatedByUserID int not null, --FK

	constraint PK_Appointments primary key (ID),
	constraint DF_Appointments_CreatedDate default getdate() for CreatedDate
)

create table MedicalVisits
(
	ID int identity(1, 1),
	PatientSymptoms varchar(255) not null,
	Diagnosis varchar(255) not null,
	Notes varchar(255) null,

	CreatedDate datetime not null,

	AppointmentID int not null, --FK
	CreatedByUserID int not null, --FK

	constraint PK_MedicalVisits primary key (ID),
	constraint UQ_MedicalVisits_AppointmentID unique (AppointmentID),
	constraint DF_MedicalVisits_CreatedDate default getdate() for CreatedDate
)

create table Prescriptions
(
	ID int identity(1, 1),
	ExpirationDate date not null,
	Status tinyint not null,

	MedicalVisitID int not null, --FK
	CreatedByUserID int not null, --FK

	constraint PK_Prescriptions primary key (ID)
)

create table Medicines
(
	ID int identity(1, 1),
	Name varchar(30) not null,
	DosageForm tinyint not null,
	Strength varchar(50) not null,
	Description varchar(255) null,
	IsActive bit not null,

	CreatedDate datetime not null,

	CreatedByUserID int not null, --FK

	constraint PK_Medicines primary key (ID),
	constraint DF_Medicines_CreatedDate default getdate() for CreatedDate
)

create table PrescriptionMedicines
(
	ID int identity(1, 1),
	--Dosage tinyint not null,
	--Frequency tinyint not null,
	--DaysDuration tinyint not null,
	--UsageInstructions varchar(255) null,

	CreatedDate datetime not null,

	PrescriptionID int not null, --FK
	MedicineID int not null, --FK
	CreatedByUserID int not null, --FK

	constraint PK_PrescriptionMedicines primary key (ID),
	constraint DF_PrescriptionMedicines_CreatedDate default getdate() for CreatedDate
)

create table LabTests
(
	ID int identity(1, 1),
	Status tinyint not null,
	--ExpectedResultDate date not null,
	ResultDate date null,
	Result bit null,
	Notes varchar(255) null,

	CreatedDate datetime not null,

	TestTypeID tinyint not null, --FK
	MedicalVisitID int not null, --FK
	PatientChargeID int not null, --FK
	CreatedByUserID int not null, --FK

	constraint PK_LabTests primary key (ID),
	constraint UQ_LabTests_TestTypeID_MedicalVisitID unique (TestTypeID, MedicalVisitID),
	constraint DF_LabTests_CreatedDate default getdate() for CreatedDate
)

create table TestTypes
(
	ID tinyint identity(1, 1),
	Name varchar(30) not null,
	Description varchar(255) null,
	Fees smallmoney not null,
	IsAvailable bit not null,

	constraint PK_TestTypes primary key (ID),
	constraint UQ_TestTypes_Name unique(Name)
)

create table PatientCharges
(
	ID int identity(1, 1),
	ServiceFees smallmoney not null,
	TotalOriginalFees smallmoney not null,
	DiscountedFees as (cast((TotalOriginalFees * (1 - DiscountPercentage / 100)) as smallmoney)),
	PaidFees smallmoney not null,
	RemainingFees smallmoney not null,
	DiscountPercentage decimal(5,2) not null,
	Status tinyint not null,

	CreatedDate datetime not null,

	AppointmentID int not null, --FK
	ChargeServiceID smallint not null, --FK
	TestTypeID tinyint null, --Fk
	CreatedByUserID int not null, --FK

	constraint PK_PatientCharges primary key (ID),
	constraint DF_PatientCharges_CreatedDate default getdate() for CreatedDate
)

create table ChargeServices
(
	ID smallint identity(1, 1),
	Name varchar(30) not null,
	Fees smallmoney not null,

	constraint PK_ChargeServices primary key (ID),
	constraint UQ_ChargeServices_Name unique(Name)
)

create table Payments
(
	ID int identity(1, 1),
	PaidAmount smallmoney not null,
	Method tinyint not null,
	TransactionNo uniqueidentifier not null,
	Status tinyint not null,

	CreatedDate datetime not null,

	PatientChargeID int not null, --FK
	CreatedByUserID int not null, --FK

	constraint PK_Payments primary key (ID),
	constraint DF_Payments_TransactionNo default newid() for TransactionNo,
	constraint DF_Payments_CreatedDate default getdate() for CreatedDate
)

go

--Unique Indecies

create unique index UX_PatientCharges_AppointmentID_ChargeServiceID
on PatientCharges (AppointmentID, ChargeServiceID)
where ChargeServiceID <> 3;

create unique index UX_PatientCharges_AppointmentID_ChargeServiceID_TestTypeID
on PatientCharges (AppointmentID, ChargeServiceID, TestTypeID)
where ChargeServiceID = 3;

go

--Tables Relationships

alter table Users
add constraint FK_Users_UserRoleID_UserRoles_ID foreign key (UserRoleID) references UserRoles(ID);

alter table People
add constraint FK_People_CreatedByUserID_Users_ID foreign key (CreatedByUserID) references Users(ID);

alter table Doctors
add constraint FK_Doctors_PersonID_People_ID foreign key (PersonID) references People(ID),
	constraint FK_Doctors_DepartmentID_Departments_ID foreign key (DepartmentID) references Departments(ID),
	constraint FK_Doctors_SpecializationID_Specializations_ID foreign key (SpecializationID) references Specializations(ID),
	constraint FK_Doctors_CreatedByUserID_Users_ID foreign key (CreatedByUserID) references Users(ID);

alter table Patients
add constraint FK_Patients_PersonID_People_ID foreign key (PersonID) references People(ID),
	constraint FK_Patients_CreatedByUserID_Users_ID foreign key (CreatedByUserID) references Users(ID);

alter table DoctorSchedules
add constraint FK_DoctorSchedules_DoctorID_Doctors_ID foreign key (DoctorID) references Doctors(ID);

alter table Appointments
add constraint FK_Appointments_DoctorScheduleID_DoctorSchedules_ID foreign key (DoctorScheduleID) references DoctorSchedules(ID),
	constraint FK_Appointments_PatientID_Patients_ID foreign key (PatientID) references Patients(ID),
	constraint FK_Appointments_CreatedByUserID_Users_ID foreign key (CreatedByUserID) references Users(ID);

alter table MedicalVisits
add constraint FK_MedicalVisits_AppointmentID_Appointments_ID foreign key (AppointmentID) references Appointments(ID),
	constraint FK_MedicalVisits_CreatedByUserID_Users_ID foreign key (CreatedByUserID) references Users(ID);

alter table Prescriptions
add constraint FK_Prescriptions_MedicalVisitID_MedicalVisits_ID foreign key (MedicalVisitID) references MedicalVisits(ID),
	constraint FK_Prescriptions_CreatedByUserID_Users_ID foreign key (CreatedByUserID) references Users(ID);

alter table Medicines
add constraint FK_Medicines_CreatedByUserID_Users_ID foreign key (CreatedByUserID) references Users(ID);

alter table PrescriptionMedicines
add constraint FK_PrescriptionMedicines_PrescriptionID_Prescriptions_ID foreign key (PrescriptionID) references Prescriptions(ID),
	constraint FK_PrescriptionMedicines_MedicineID_Medicines_ID foreign key (MedicineID) references Medicines(ID),
	constraint FK_PrescriptionMedicines_CreatedByUserID_Users_ID foreign key (CreatedByUserID) references Users(ID);
	
alter table LabTests
add constraint FK_LabTests_TestTypeID_TestTypes_ID foreign key (TestTypeID) references TestTypes(ID),
	constraint FK_LabTests_AppointmentID_Appointments_ID foreign key (AppointmentID) references Appointments(ID),
	constraint FK_LabTests_PatientChargeID_PatientCharges_ID foreign key (PatientChargeID) references PatientCharges(ID),
	constraint FK_LabTests_CreatedByUserID_Users_ID foreign key (CreatedByUserID) references Users(ID);

alter table PatientCharges
add constraint FK_PatientCharges_AppointmentID_Appointments_ID foreign key (AppointmentID) references Appointments(ID),
	constraint FK_PatientCharges_ChargeServiceID_ChargeServices_ID foreign key (ChargeServiceID) references ChargeServices(ID),
	constraint FK_PatientCharges_TestTypeID_TestTypes_ID foreign key (TestTypeID) references TestTypes(ID),
	constraint FK_PatientCharges_CreatedByUserID_Users_ID foreign key (CreatedByUserID) references Users(ID);

alter table Payments add constraint FK_Payments_PatientChargeID_PatientCharges_ID foreign key (PatientChargeID) references PatientCharges(ID),
	constraint FK_Payments_CreatedByUserID_Users_ID foreign key (CreatedByUserID) references Users(ID);