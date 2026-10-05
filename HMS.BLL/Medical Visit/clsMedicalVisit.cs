using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HMS.DAL;

namespace HMS.BLL
{
    public partial class clsMedicalVisit
    {
        private enum enMode { AddNew, Edit }
        private enMode _Mode;

        public int? ID { get; set; }
        public string PatientSymptoms { get; set; }
        public string Diagnosis { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? AppointmentID { get; set; }
        public int? PrescriptionID { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUsername { get; set; }

        public clsMedicalVisit()
        {
            this._Mode = enMode.AddNew;
            this.ID = null;
            this.PatientSymptoms = null;
            this.Diagnosis = null;
            this.Notes = null;
            this.CreatedDate = null;
            this.AppointmentID = null;
            this.PrescriptionID = null;
            this.CreatedByUserID = null;
            this.CreatedByUsername = null;
        }

        private clsMedicalVisit(int? id, string patientsymptoms, string diagnosis, string notes, DateTime? createddate, int? appointmentid, int? prescriptionid, int? createdbyuserid, string createdbyusername)
        {
            this._Mode = enMode.Edit;
            this.ID = id;
            this.PatientSymptoms = patientsymptoms;
            this.Diagnosis = diagnosis;
            this.Notes = notes;
            this.CreatedDate = createddate;
            this.AppointmentID = appointmentid;
            this.PrescriptionID = prescriptionid;
            this.CreatedByUserID = createdbyuserid;
            this.CreatedByUsername = createdbyusername;
        }

        public static Task<bool> HasPrescription(int? medicalvisitid)
        {
            return clsMedicalVisitData.HasPrescriptionRecord(medicalvisitid);
        }

        public static async Task<clsMedicalVisit> Find(int? id)
        {
            var MedicalVisitData = await clsMedicalVisitData.FindRecord(id);
            if (MedicalVisitData != null)
                return new clsMedicalVisit(MedicalVisitData.Value.ID, MedicalVisitData.Value.PatientSymptoms, MedicalVisitData.Value.Diagnosis, MedicalVisitData.Value.Notes, MedicalVisitData.Value.CreatedDate, MedicalVisitData.Value.AppointmentID, MedicalVisitData.Value.PrescriptionID, MedicalVisitData.Value.CreatedByUserID, MedicalVisitData.Value.CreatedByUsername);
            else
                return null;
        }

        public static Task<DataTable> GetPage(int Page, int PageSize)
        {
            return clsMedicalVisitData.GetPageRecords(Page, PageSize);
        }

        public static Task<DataTable> GetPageByFilter(int Page, int PageSize, string Filter, string Value)
        {
            return clsMedicalVisitData.GetPageRecordsByFilter(Page, PageSize, Filter, Value);
        }

        public static Task<int> GetCount()
        {
            return clsMedicalVisitData.GetRecordsCount();
        }

        public static Task<int> GetCountByFilter(string Filter, string Value)
        {
            return clsMedicalVisitData.GetRecordsCountByFilter(Filter, Value);
        }

        private async Task<bool> _AddNew()
        {
            this.ID = await clsMedicalVisitData.AddNewRecord(PatientSymptoms, Diagnosis, Notes, AppointmentID, CreatedByUserID);
            return this.ID.HasValue;
        }

        private Task<bool> _Edit()
        {
            return clsMedicalVisitData.EditRecord(ID, PatientSymptoms, Diagnosis, Notes, CreatedDate, AppointmentID, CreatedByUserID);
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
            return clsMedicalVisitData.DeleteRecord(id);
        }
    }
}