using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HMS.DAL;

namespace HMS.BLL
{
    public partial class clsDoctor
    {
        private enum enMode { AddNew, Edit }
        private enMode _Mode;

        public int? ID { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? PersonID { get; set; }
        public clsPerson Person { get; set; }
        public byte? DepartmentID { get; set; }
        public clsDepartment Department { get; set; }
        public byte? SpecializationID { get; set; }
        public clsSpecialization Specialization { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUsername { get; set; }

        public clsDoctor()
        {
            this._Mode = enMode.AddNew;
            this.ID = null;
            this.IsActive = null;
            this.CreatedDate = null;
            this.PersonID = null;
            this.DepartmentID = null;
            this.SpecializationID = null;
            this.CreatedByUserID = null;
            this.CreatedByUsername = null;
        }

        private clsDoctor(int? id, bool? isactive, DateTime? createddate, int? personid, clsPerson person, byte? departmentid, clsDepartment department, byte? specializationid, clsSpecialization specialization, int? createdbyuserid, string createdbyusername)
        {
            this._Mode = enMode.Edit;
            this.ID = id;
            this.IsActive = isactive;
            this.CreatedDate = createddate;
            this.PersonID = personid;
            this.Person = person;
            this.DepartmentID = departmentid;
            this.Department = department;
            this.SpecializationID = specializationid;
            this.Specialization = specialization;
            this.CreatedByUserID = createdbyuserid;
            this.CreatedByUsername = createdbyusername;
        }

        public static Task<bool> IsExist(int? id)
        {
            return clsDoctorData.IsRecordExist(id);
        }

        public static async Task<clsDoctor> Find(int? id)
        {
            var DoctorData = await clsDoctorData.FindRecord(id);
            if (DoctorData != null)
                return new clsDoctor(DoctorData.Value.ID, DoctorData.Value.IsActive, DoctorData.Value.CreatedDate, DoctorData.Value.PersonID, await clsPerson.Find(DoctorData.Value.PersonID), DoctorData.Value.DepartmentID, await clsDepartment.Find(DoctorData.Value.DepartmentID), DoctorData.Value.SpecializationID, await clsSpecialization.Find(DoctorData.Value.SpecializationID), DoctorData.Value.CreatedByUserID, DoctorData.Value.CreatedByUsername);
            else
                return null;
        }

        public static DataTable GetAll(byte SpecializationID)
        {
            return clsDoctorData.GetAllRecords(SpecializationID);
        }

        public static Task<DataTable> GetPage(int Page, int PageSize)
        {
            return clsDoctorData.GetPageRecords(Page, PageSize);
        }

        public static Task<DataTable> GetPageByFilter(int Page, int PageSize, string Filter, string Value)
        {
            return clsDoctorData.GetPageRecordsByFilter(Page, PageSize, Filter, Value);
        }

        public static Task<int> GetCount()
        {
            return clsDoctorData.GetRecordsCount();
        }

        public static Task<int> GetCountByFilter(string Filter, string Value)
        {
            return clsDoctorData.GetRecordsCountByFilter(Filter, Value);
        }

        private async Task<bool> _AddNew()
        {
            this.ID = await clsDoctorData.AddNewRecord(IsActive, PersonID, DepartmentID, SpecializationID, CreatedByUserID);
            return this.ID.HasValue;
        }

        private Task<bool> _Edit()
        {
            return clsDoctorData.EditRecord(ID, IsActive, CreatedDate, PersonID, DepartmentID, SpecializationID, CreatedByUserID);
        }

        public async Task<bool> Save()
        {
            switch (this._Mode)
            {
                case enMode.AddNew:
                    if (await this._AddNew())
                    {
                        this.CreatedDate = DateTime.Now;
                        this._Mode = enMode.Edit;
                        return true;
                    }
                    else
                        return false;
                case enMode.Edit:
                    return await this._Edit();
                default:
                    return false;
            }
        }

        public static Task<bool> Delete(int? id)
        {
            return clsDoctorData.DeleteRecord(id);
        }
    }
}