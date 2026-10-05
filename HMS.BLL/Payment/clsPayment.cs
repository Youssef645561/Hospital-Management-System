using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HMS.DAL;

namespace HMS.BLL
{
    public partial class clsPayment
    {
        private enum enMode { AddNew, Edit }
        private enMode _Mode;

        public enum enMethod { Cash = 1, Card = 2, BankTransfer = 3 }
        public enum enStatus { Completed = 1, Refund = 2 }

        public int? ID { get; set; }
        public decimal? PaidAmount { get; set; }
        public enMethod? Method { get; set; }
        public Guid? TransactionNo { get; set; }
        public enStatus? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? PatientChargeID { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUsername { get; set; }

        public clsPayment()
        {
            this._Mode = enMode.AddNew;
            this.ID = null;
            this.PaidAmount = null;
            this.Method = null;
            this.TransactionNo = null;
            this.Status = null;
            this.CreatedDate = null;
            this.PatientChargeID = null;
            this.CreatedByUserID = null;
            this.CreatedByUsername = null;
        }

        private clsPayment(int? id, decimal? paidamount, enMethod? method, Guid? transactionno, enStatus? status, DateTime? createddate, int? patientchargeid, int? createdbyuserid, string createdbyusername)
        {
            this._Mode = enMode.Edit;
            this.ID = id;
            this.PaidAmount = paidamount;
            this.Method = method;
            this.TransactionNo = transactionno;
            this.Status = status;
            this.CreatedDate = createddate;
            this.PatientChargeID = patientchargeid;
            this.CreatedByUserID = createdbyuserid;
            this.CreatedByUsername = createdbyusername;
        }

        public static async Task<clsPayment> Find(int? id)
        {
            var PaymentData = await clsPaymentData.FindRecord(id);
            if (PaymentData != null)
                return new clsPayment(PaymentData.Value.ID, PaymentData.Value.PaidAmount, (enMethod)PaymentData.Value.Method, PaymentData.Value.TransactionNo, (enStatus?)PaymentData.Value.Status, PaymentData.Value.CreatedDate, PaymentData.Value.PatientChargeID, PaymentData.Value.CreatedByUserID, PaymentData.Value.CreatedByUsername);
            else
                return null;
        }

        public static Task<DataTable> GetAll(int? PatientChargeID)
        {
            return clsPaymentData.GetAllRecordsByPatientChargeID(PatientChargeID);
        }

        public static Task<DataTable> GetPage(int Page, int PageSize)
        {
            return clsPaymentData.GetPageRecords(Page, PageSize);
        }

        public static Task<DataTable> GetPageByFilter(int Page, int PageSize, string Filter, string Value)
        {
            return clsPaymentData.GetPageRecordsByFilter(Page, PageSize, Filter, Value);
        }

        public static Task<int> GetCount()
        {
            return clsPaymentData.GetRecordsCount();
        }

        public static Task<int> GetCountByFilter(string Filter, string Value)
        {
            return clsPaymentData.GetRecordsCountByFilter(Filter, Value);
        }

        private async Task<bool> _AddNew()
        {
            (this.ID, this.TransactionNo) = await clsPaymentData.AddNewRecord(PaidAmount, (byte?)Method, PatientChargeID, CreatedByUserID);
            return this.ID.HasValue && this.TransactionNo.HasValue;
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
                default:
                    return false;
            }
        }

        public static Task<(bool IsRefunded, decimal RefundAmount)> RefundPayment(int? id)
        {
            return clsPaymentData.RefundPaymentRecord(id);
        }
    }
}