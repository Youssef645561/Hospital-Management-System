using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HMS.DAL;

namespace HMS.BLL
{
    public partial class clsPrescription
    {
        private enum enMode { AddNew, Edit }
        private enMode _Mode;

        public enum enStatus { Active = 1, Expired = 2, Cancelled = 3 }

        public int? ID { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public enStatus? Status { get; set; }
        public int? MedicalVisitID { get; set; }
        public DataTable dtMedicines { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUsername { get; set; }

        public clsPrescription()
        {
            this._Mode = enMode.AddNew;
            this.ID = null;
            this.ExpirationDate = null;
            this.Status = null;
            this.MedicalVisitID = null;
            this.dtMedicines = null;
            this.CreatedByUserID = null;
            this.CreatedByUsername = null;
        }

        private clsPrescription(int? id, DateTime? expirationdate, enStatus? status, int? medicalvisitid, DataTable dtmedicines, int? createdbyuserid, string createdbyusername)
        {
            this._Mode = enMode.Edit;
            this.ID = id;
            this.ExpirationDate = expirationdate;
            this.Status = status;
            this.MedicalVisitID = medicalvisitid;
            this.CreatedByUserID = createdbyuserid;
            this.dtMedicines = dtmedicines;
            this.CreatedByUsername = createdbyusername;
        }

        public static async Task<clsPrescription> Find(int? id)
        {
            var PrescriptionData = await clsPrescriptionData.FindRecord(id);
            if (PrescriptionData != null)
                return new clsPrescription(PrescriptionData.Value.ID, PrescriptionData.Value.ExpirationDate, (enStatus)PrescriptionData.Value.Status, PrescriptionData.Value.MedicalVisitID, PrescriptionData.Value.dtMedicines, PrescriptionData.Value.CreatedByUserID, PrescriptionData.Value.CreatedByUsername);
            else
                return null;
        }

        public static Task<DataTable> GetPage(int Page, int PageSize)
        {
            return clsPrescriptionData.GetPageRecords(Page, PageSize);
        }

        public static Task<DataTable> GetPageByFilter(int Page, int PageSize, string Filter, string Value)
        {
            return clsPrescriptionData.GetPageRecordsByFilter(Page, PageSize, Filter, Value);
        }

        public static Task<int> GetCount()
        {
            return clsPrescriptionData.GetRecordsCount();
        }

        public static Task<int> GetCountByFilter(string Filter, string Value)
        {
            return clsPrescriptionData.GetRecordsCountByFilter(Filter, Value);
        }

        private async Task<bool> _AddNew()
        {
            this.ID = await clsPrescriptionData.AddNewRecord(ExpirationDate, MedicalVisitID, dtMedicines.DefaultView.ToTable(false, "ID"), CreatedByUserID);
            return this.ID.HasValue;
        }

        private Task<bool> _Edit()
        {
            return clsPrescriptionData.EditRecord(ID, ExpirationDate, (byte?)Status, MedicalVisitID, dtMedicines.DefaultView.ToTable(false, "ID"), CreatedByUserID);
        }

        public async Task<bool> Save()
        {
            switch (this._Mode)
            {
                case enMode.AddNew:
                    if (await this._AddNew())
                    {
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
            return clsPrescriptionData.DeleteRecord(id);
        }
    }
}