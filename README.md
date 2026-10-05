# Hospital Management System

A desktop-based Hospital Management System built with **C# WinForms**, **ADO.NET**, and **SQL Server**, following a **3-Tier Architecture**.

The system is designed to manage core hospital operations including people, doctors, patients, appointments, medical visits, laboratory tests, prescriptions, pharmacy, payments, users, and roles.

## Features

### 👥 People Management

* **People Management**

  * View Details
  * Add
  * Edit

* **Doctors Management**

  * View Details
  * Add
  * Edit

* **Patients Management**

  * View Details
  * Add
  * Edit

* **Patient Appointments History**

### 🏥 Medical Operations

* **Patient Queue**

  * View waiting patients
  * Start medical visit

* **Appointments Management**

  * View Details
  * Schedule New Appointment
  * Check In
  * Reschedule
  * Cancel
  * View Patient Appointments History

* **Laboratory**

  * View Test Results
  * Start Test
  * Complete Test
  * Cancel Test
  * View Patient Appointments History

* **Medical Visits Management**

  * View Details
  * Edit Medical Visit
  * Manage Symptoms
  * Diagnosis
  * Notes
  * Prescriptions

* **Prescriptions Management**

  * View Details
  * Add Prescription
  * Edit Prescription
  * Link Prescription to Medical Visit

### 💊 Pharmacy

* **Medicines Management**

  * View Details
  * Add
  * Edit
  * Delete

### 💰 Financial Management

* **Patient Charges**

  * View Details
  * Perform Payment
  * View Payment History

* **Payments**

  * View Details
  * Perform Payment
  * Refund Payments

### 👤 Administration

* **Users Management**

  * View Details
  * Add
  * Edit
  * Delete

* **Roles Management**

  * View Details
  * Add
  * Edit
  * Delete

### ⚙️ Settings

* **Current User Profile**

  * View Details

* **Change Password**

---

## Application Workflow

The system connects different hospital operations into a continuous workflow.

```text
Appointment
     │
     ▼
  Check In
     │
     ▼
Patient Queue
     │
     ▼
 Start Medical Visit
     │
     ├──────────────► Prescription
     │
     └──────────────► Laboratory Test
                            │
                            ▼
                       Lab Processing
                            │
                            ▼
                          Result
```

Financial operations are integrated with the workflow through patient charges and payments.

```text
Hospital Service
      │
      ▼
Patient Charge
      │
      ├──► Payment
      │
      └──► Payment History
                │
                └──► Refund
```

---

## Architecture

The application follows a **3-Tier Architecture** to separate responsibilities and make the system easier to maintain and extend.

```text
┌──────────────────────────────┐
│          HMS                 │
│       Presentation           │
│         WinForms             │
└──────────────┬───────────────┘
               │
               ▼
┌──────────────────────────────┐
│         HMS.BLL              │
│      Business Logic          │
└──────────────┬───────────────┘
               │
               ▼
┌──────────────────────────────┐
│         HMS.DAL              │
│      Data Access Layer       │
│          ADO.NET             │
└──────────────┬───────────────┘
               │
               ▼
┌──────────────────────────────┐
│        SQL Server            │
│        HospitalDB            │
└──────────────────────────────┘
```

### Projects

The solution is divided into five projects:

* **HMS** — Presentation layer and application UI
* **HMS.BLL** — Business logic and application rules
* **HMS.DAL** — Database access and SQL communication
* **Common** — Shared utilities and common functionality
* **Youssef.WinForms.Controls** — Reusable custom WinForms controls

The repository also contains the SQL database scripts and application resources.

---

## Technologies

* **C#**
* **.NET Framework**
* **Windows Forms**
* **ADO.NET**
* **SQL Server**
* **T-SQL**
* **Krypton Toolkit**
* **3-Tier Architecture**
* **Object-Oriented Programming**
* **Asynchronous Programming**
* **DataTable / DataGridView**
* **Stored Procedures**
* **SQL Views**
* **Transactions**
* **Reflection**
* **Custom WinForms Controls**

---

## Database

The system uses **SQL Server** with a database named:

`HospitalDB`

The database handles major hospital entities including:

* Users & Roles
* People
* Doctors
* Patients
* Departments
* Specializations
* Appointments
* Medical Visits
* Prescriptions
* Medicines
* Laboratory Tests
* Test Types
* Patient Charges
* Payments

The repository includes SQL scripts for database objects such as **Views** and **Stored Procedures**.

---

## Key Design Considerations

### Separation of Responsibilities

Business logic is kept separate from the UI and database access through the 3-tier architecture.

### Reusable Components

Common UI functionality was extracted into reusable custom WinForms controls to reduce duplication across the application.

### Transactional Financial Operations

Payment-related operations use database transactions to keep financial data consistent when updating charges and creating payment records.

### Payment & Refund Handling

The system supports:

* Full payments
* Partial payments
* Payment history
* Payment refunds
* Remaining balance tracking
* Charge status management

### Audit Information

Important records include creation information such as:

* `CreatedDate`
* `CreatedByUserID`

This allows the system to track who created records and when.

### Appointment-Based Medical Workflow

Medical operations are connected to appointments, allowing the system to track the patient's journey from appointment scheduling through check-in, medical visit, prescriptions, and laboratory requests.

---

## Project Structure

```text
Hospital-Management-System/
│
├── Common/
├── HMS/
├── HMS.BLL/
├── HMS.DAL/
├── HMS_DB/
├── Icons/
├── Youssef.WinForms.Controls/
│
├── .gitignore
└── Hospital_Management_System.slnx
```

---

## Getting Started

### Requirements

* Windows
* Visual Studio
* .NET Framework
* SQL Server
* SQL Server Management Studio (recommended)

### Installation

1. Clone the repository:

```bash
git clone https://github.com/Youssef645561/Hospital-Management-System.git
```

2. Open the solution:

```text
Hospital_Management_System.slnx
```

3. Create the `HospitalDB` database using the SQL scripts provided in the `HMS_DB` folder.

4. Configure the application's database connection string in:

```text
HMS/App.config
```

5. Build and run the application.

---

## Purpose

This project was developed as a practical application of **C# Level 2** and **T-SQL** concepts, with a focus on applying object-oriented programming, database design, ADO.NET, business logic separation, asynchronous operations, and WinForms application development in a relatively large-scale desktop application.

The project also serves as a foundation for future development and can be extended with additional features or used as a backend foundation for a future web-based API.

---

## Future Improvements

Possible future extensions include:

* ASP.NET Core Web API
* Web-based client application
* More advanced role-based permissions
* Reporting and analytics
* Additional hospital departments and workflows
* Improved authentication and security
* Appointment notifications
* More advanced laboratory and pharmacy workflows

---

## Author

**Youssef Ahmed**

Computer & Information student focused on **.NET development, backend development, databases, and software architecture**.

---

## License

This project is intended primarily as a learning and portfolio project.
