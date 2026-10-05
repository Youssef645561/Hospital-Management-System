using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HMS.DAL;

namespace HMS.BLL
{
    public partial class clsPatientCharge
    {
        private enum enMode { AddNew, Edit }
        private enMode _Mode;

        public enum enStatus { Unpaid = 1, PartiallyPaid = 2, Paid = 3, Cancelled = 4 }

        public int? ID { get; set; }
        public decimal? ServiceFees { get; set; }
        public decimal? TotalOriginalFees { get; set; }
        public decimal? DiscountedFees { get; set; }
        public decimal? PaidFees { get; set; }
        public decimal? RemainingFees { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public enStatus? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? AppointmentID { get; set; }
        public short? ChargeServiceID { get; set; }
        public string ChargeServiceName { get; set; }
        public byte? TestTypeID { get; set; }        
        public int? CreatedByUserID { get; set; }
        public string CreatedByUsername { get; set; }

        public clsPatientCharge()
        {
            this._Mode = enMode.AddNew;
            this.ID = null;
            this.ServiceFees = null;
            this.TotalOriginalFees = null;
            this.DiscountedFees = null;
            this.PaidFees = null;
            this.RemainingFees = null;
            this.DiscountPercentage = null;
            this.Status = null;
            this.CreatedDate = null;
            this.AppointmentID = null;
            this.ChargeServiceID = null;
            this.ChargeServiceName = null;
            this.TestTypeID = null;
            this.CreatedByUserID = null;
            this.CreatedByUsername = null;
        }

        private clsPatientCharge(int? id, decimal? servicefees, decimal? totaloriginalfees, decimal? discountedfees, decimal? paidfees, decimal? remainingfees, decimal? discountpercentage, enStatus? status, DateTime? createddate, int? appointmentid, short? chargeserviceid, string chargeservicename, byte? testtypeid, int? createdbyuserid, string createdbyusername)
        {
            this._Mode = enMode.Edit;
            this.ID = id;
            this.ServiceFees = servicefees;
            this.TotalOriginalFees = totaloriginalfees;
            this.DiscountedFees = discountedfees;
            this.PaidFees = paidfees;
            this.RemainingFees = remainingfees;
            this.DiscountPercentage = discountpercentage;
            this.Status = status;
            this.CreatedDate = createddate;
            this.AppointmentID = appointmentid;
            this.ChargeServiceID = chargeserviceid;
            this.ChargeServiceName = chargeservicename;
            this.TestTypeID = testtypeid;
            this.CreatedByUserID = createdbyuserid;
            this.CreatedByUsername = createdbyusername;
        }

        public static Task<bool> IsExist(int? appointmentid, short? chargeserviceid, byte? testtypeid)
        {
            return clsPatientChargeData.IsRecordExist(appointmentid, chargeserviceid, testtypeid);
        }

        public static async Task<clsPatientCharge> Find(int? id)
        {
            var PatientChargeData = await clsPatientChargeData.FindRecord(id);
            if (PatientChargeData != null)
                return new clsPatientCharge(PatientChargeData.Value.ID, PatientChargeData.Value.ServiceFees, PatientChargeData.Value.TotalOriginalFees, PatientChargeData.Value.DiscountedFees, PatientChargeData.Value.PaidFees, PatientChargeData.Value.RemainingFees, PatientChargeData.Value.DiscountPercentage, (enStatus?)PatientChargeData.Value.Status, PatientChargeData.Value.CreatedDate, PatientChargeData.Value.AppointmentID, PatientChargeData.Value.ChargeServiceID, PatientChargeData.Value.ChargeServiceName, PatientChargeData.Value.TestTypeID, PatientChargeData.Value.CreatedByUserID, PatientChargeData.Value.CreatedByUsername);
            else
                return null;
        }

        public static Task<DataTable> GetPage(int Page, int PageSize)
        {
            return clsPatientChargeData.GetPageRecords(Page, PageSize);
        }

        public static Task<DataTable> GetPageByFilter(int Page, int PageSize, string Filter, string Value)
        {
            return clsPatientChargeData.GetPageRecordsByFilter(Page, PageSize, Filter, Value);
        }

        public static Task<int> GetCount()
        {
            return clsPatientChargeData.GetRecordsCount();
        }

        public static Task<int> GetCountByFilter(string Filter, string Value)
        {
            return clsPatientChargeData.GetRecordsCountByFilter(Filter, Value);
        }

        private async Task<bool> _AddNew()
        {
            this.ID = await clsPatientChargeData.AddNewRecord(ServiceFees, TotalOriginalFees, DiscountPercentage, AppointmentID, ChargeServiceID, TestTypeID, CreatedByUserID);
            return this.ID.HasValue;
        }

        private Task<bool> _Edit()
        {
            return clsPatientChargeData.EditRecord(ID, TotalOriginalFees, DiscountPercentage, ChargeServiceID);
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

        public static Task<decimal?> Cancel(int? id)
        {
            return clsPatientChargeData.CancelRecord(id);
        }

        public static Task<bool> Delete(int? id)
        {
            return clsPatientChargeData.DeleteRecord(id);
        }
    }
}