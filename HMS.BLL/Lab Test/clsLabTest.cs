using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HMS.DAL;

namespace HMS.BLL
{
    public partial class clsLabTest
    {
        private enum enMode { AddNew, Edit }
        private enMode _Mode;

        public enum enStatus { Pending = 1, InProgress = 2, Completed = 3, Cancelled = 4 }

        public int? ID { get; set; }
        public enStatus? Status { get; set; }
        public DateTime? ResultDate { get; set; }
        public bool? Result { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedDate { get; set; }
        public byte? TestTypeID { get; set; }
        public string TestTypeName { get; set; }
        public int? AppointmentID { get; set; }
        public int? PatientChargeID { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUsername { get; set; }

        public clsLabTest()
        {
            this._Mode = enMode.AddNew;
            this.ID = null;
            this.Status = null;
            this.ResultDate = null;
            this.Result = null;
            this.Notes = null;
            this.CreatedDate = null;
            this.TestTypeID = null;
            this.TestTypeName = null;
            this.AppointmentID = null;
            this.PatientChargeID = null;
            this.CreatedByUserID = null;
            this.CreatedByUsername = null;
        }

        private clsLabTest(int? id, enStatus? status, DateTime? resultdate, bool? result, string notes, DateTime? createddate, byte? testtypeid, string testtypeidname, int? appointmentid, int? patientchargeid, int? createdbyuserid, string createdbyusername)
        {
            this._Mode = enMode.Edit;
            this.ID = id;
            this.Status = status;
            this.ResultDate = resultdate;
            this.Result = result;
            this.Notes = notes;
            this.CreatedDate = createddate;
            this.TestTypeID = testtypeid;
            this.TestTypeName = testtypeidname;
            this.AppointmentID = appointmentid;
            this.PatientChargeID = patientchargeid;
            this.CreatedByUserID = createdbyuserid;
            this.CreatedByUsername = createdbyusername;
        }

        public static async Task<clsLabTest> Find(int? id)
        {
            var LabTestData = await clsLabTestData.FindRecord(id);
            if (LabTestData != null)
                return new clsLabTest(LabTestData.Value.ID, (enStatus)LabTestData.Value.Status, LabTestData.Value.ResultDate, LabTestData.Value.Result, LabTestData.Value.Notes, LabTestData.Value.CreatedDate, LabTestData.Value.TestTypeID, LabTestData.Value.TestTypeName, LabTestData.Value.AppointmentID, LabTestData.Value.PatientChargeID, LabTestData.Value.CreatedByUserID, LabTestData.Value.CreatedByUsername);
            else
                return null;
        }

        public static Task<DataTable> GetPage(int Page, int PageSize)
        {
            return clsLabTestData.GetPageRecords(Page, PageSize);
        }

        public static Task<DataTable> GetPageByFilter(int Page, int PageSize, string Filter, string Value)
        {
            return clsLabTestData.GetPageRecordsByFilter(Page, PageSize, Filter, Value);
        }

        public static Task<int> GetCount()
        {
            return clsLabTestData.GetRecordsCount();
        }

        public static Task<int> GetCountByFilter(string Filter, string Value)
        {
            return clsLabTestData.GetRecordsCountByFilter(Filter, Value);
        }

        private async Task<bool> _AddNew()
        {
            this.ID = await clsLabTestData.AddNewRecord(TestTypeID, AppointmentID, CreatedByUserID);
            return this.ID.HasValue;
        }

        private Task<bool> _Edit()
        {
            return clsLabTestData.EditRecord(ID, (byte?)Status, ResultDate, Result, Notes, CreatedDate, TestTypeID, AppointmentID, PatientChargeID, CreatedByUserID);
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

        public static Task<bool> StartLabTest(int? id)
        {
            return clsLabTestData.StartLabTestRecord(id);
        }

        public static Task<bool> CompleteLabTest(int? id, bool Result, string Notes)
        {
            return clsLabTestData.CompleteLabTestRecord(id, Result, Notes);
        }

        public static Task<(bool, decimal)> CancelLabTest(int? id)
        {
            return clsLabTestData.CancelLabTestRecord(id);
        }

        public static Task<bool> Delete(int? id)
        {
            return clsLabTestData.DeleteRecord(id);
        }
    }
}