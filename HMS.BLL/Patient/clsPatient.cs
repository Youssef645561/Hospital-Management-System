using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HMS.DAL;

namespace HMS.BLL
{
    public partial class clsPatient
    {
        private enum enMode { AddNew, Edit }
        private enMode _Mode;

        public int? ID { get; set; }
        public string MedicalRecordNo { get; set; }
        public string BloodType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? PersonID { get; set; }
        public clsPerson Person { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUsername { get; set; }

        public clsPatient()
        {
            this._Mode = enMode.AddNew;
            this.ID = null;
            this.MedicalRecordNo = null;
            this.BloodType = null;
            this.CreatedDate = null;
            this.PersonID = null;
            this.CreatedByUserID = null;
            this.CreatedByUsername = null;
            this.Person = null;
        }

        private clsPatient(int? id, string medicalrecordno, string bloodtype, DateTime? createddate, int? personid, int? createdbyuserid, string createdbyusername, clsPerson person)
        {
            this._Mode = enMode.Edit;
            this.ID = id;
            this.MedicalRecordNo = medicalrecordno;
            this.BloodType = bloodtype;
            this.CreatedDate = createddate;
            this.PersonID = personid;
            this.CreatedByUserID = createdbyuserid;
            this.CreatedByUsername = createdbyusername;
            this.Person = person;
        }

        public static Task<bool> IsExist(int? personid)
        {
            return clsPatientData.IsRecordExist(personid);
        }

        public static async Task<clsPatient> Find(int? id)
        {
            var PatientData = await clsPatientData.FindRecord(id);
            if (PatientData != null)
                return new clsPatient(PatientData.Value.ID, PatientData.Value.MedicalRecordNo, PatientData.Value.BloodType, PatientData.Value.CreatedDate, PatientData.Value.PersonID, PatientData.Value.CreatedByUserID, await clsUser.GetUsernameByID(PatientData.Value.CreatedByUserID), await clsPerson.Find(PatientData.Value.PersonID));
            else
                return null;
        }

        public static async Task<clsPatient> Find(string medicalrecordno)
        {
            var PatientData = await clsPatientData.FindRecord(medicalrecordno);
            if (PatientData != null)
                return new clsPatient(PatientData.Value.ID, PatientData.Value.MedicalRecordNo, PatientData.Value.BloodType, PatientData.Value.CreatedDate, PatientData.Value.PersonID, PatientData.Value.CreatedByUserID, await clsUser.GetUsernameByID(PatientData.Value.CreatedByUserID), await clsPerson.Find(PatientData.Value.PersonID));
            else
                return null;
        }

        public static Task<DataTable> GetPage(int Page, int PageSize)
        {
            return clsPatientData.GetPageRecords(Page, PageSize);
        }

        public static Task<DataTable> GetPageByFilter(int Page, int PageSize, string Filter, string Value)
        {
            return clsPatientData.GetPageRecordsByFilter(Page, PageSize, Filter, Value);
        }

        public static Task<int> GetCount()
        {
            return clsPatientData.GetRecordsCount();
        }

        public static Task<int> GetCountByFilter(string Filter, string Value)
        {
            return clsPatientData.GetRecordsCountByFilter(Filter, Value);
        }

        private async Task<bool> _AddNew()
        {
            var result = await clsPatientData.AddNewRecord(BloodType, PersonID, CreatedByUserID);
            if (result != null)
            {
                this.ID = result.Value.ID;
                this.MedicalRecordNo = result.Value.MedicalRecordNo;
                return (this.ID != null && this.MedicalRecordNo != null);
            }
            else
                return false;
        }

        private Task<bool> _Edit()
        {
            return clsPatientData.EditRecord(ID, BloodType);
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
            return clsPatientData.DeleteRecord(id);
        }
    }
}