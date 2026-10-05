using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HMS.DAL;

namespace HMS.BLL
{
    public partial class clsAppointment
    {
        private enum enMode { Schedule, Reschedule }
        private enMode _Mode;

        public enum enStatus { Scheduled = 1, Waiting = 2, Completed = 3, Cancelled = 4, NoShow = 5 }
        public enum enType { Examination = 1, Consultation = 2 }

        public int? ID { get; set; }
        public DateTime? Date { get; set; }
        public enStatus? Status { get; set; }
        public enType? Type { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? DoctorScheduleID { get; set; }
        public string DoctorName { get; set; }
        public clsDoctorSchedule DoctorSchedule { get; set; }
        public int? PatientID { get; set; }
        public byte? DoctorSpecializationID { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUsername { get; set; }

        public clsAppointment()
        {
            this._Mode = enMode.Schedule;
            this.ID = null;
            this.Date = null;
            this.Status = null;
            this.Type = null;
            this.CreatedDate = null;
            this.DoctorScheduleID = null;
            this.DoctorSchedule = null;
            this.PatientID = null;
            this.DoctorSpecializationID = null;
            this.CreatedByUserID = null;
            this.CreatedByUsername = null;
        }

        private clsAppointment(int? id, DateTime? date, enStatus? status, enType? type, DateTime? createddate, int? doctorscheduleid, string doctorname, clsDoctorSchedule doctorschedule, int? patientid, byte? doctorspecializationid, int? createdbyuserid, string createdbyusername)
        {
            this._Mode = enMode.Reschedule;
            this.ID = id;
            this.Date = date;
            this.Status = status;
            this.Type = type;
            this.CreatedDate = createddate;
            this.DoctorScheduleID = doctorscheduleid;
            this.DoctorName = doctorname;
            this.DoctorSchedule = doctorschedule;
            this.PatientID = patientid;
            this.DoctorSpecializationID = doctorspecializationid;
            this.CreatedByUserID = createdbyuserid;
            this.CreatedByUsername = createdbyusername;
        }

        public static Task<bool> IsScheduledAppointmentExist(int? patientid, int? doctorid)
        {
            return clsAppointmentData.IsScheduledAppointmentRecordExist(patientid, doctorid);
        }

        public static Task<bool> HasLabTest(int? appointmentid, byte? testtypeid)
        {
            return clsAppointmentData.HasLabTestRecord(appointmentid, testtypeid);
        }

        public static async Task<clsAppointment> Find(int? id)
        {
            var AppointmentData = await clsAppointmentData.FindRecord(id);
            if (AppointmentData != null)
                return new clsAppointment(AppointmentData.Value.ID, AppointmentData.Value.Date, (enStatus)AppointmentData.Value.Status, (enType)AppointmentData.Value.Type, AppointmentData.Value.CreatedDate, AppointmentData.Value.DoctorScheduleID, AppointmentData.Value.DoctorName, await clsDoctorSchedule.Find(AppointmentData.Value.DoctorScheduleID), AppointmentData.Value.PatientID, AppointmentData.Value.DoctorSpecializationID, AppointmentData.Value.CreatedByUserID, AppointmentData.Value.CreatedByUsername);
            else
                return null;
        }

        public static Task<DataTable> GetAllByPatientID(int? patientid)
        {
            return clsAppointmentData.GetAllAppointmentsRecordsByPatientID(patientid);
        }

        public static Task<DataTable> GetAllWatings()
        {
            return clsAppointmentData.GetAllWaitingAppointmentsRecords();
        }

        public static Task<DataTable> GetPage(int Page, int PageSize)
        {
            return clsAppointmentData.GetPageRecords(Page, PageSize);
        }

        public static Task<DataTable> GetPageByFilter(int Page, int PageSize, string Filter, string Value)
        {
            return clsAppointmentData.GetPageRecordsByFilter(Page, PageSize, Filter, Value);
        }

        public static Task<int> GetCount()
        {
            return clsAppointmentData.GetRecordsCount();
        }

        public static Task<int> GetCountByFilter(string Filter, string Value)
        {
            return clsAppointmentData.GetRecordsCountByFilter(Filter, Value);
        }

        private async Task<bool> _Schedule()
        {
            this.ID = await clsAppointmentData.ScheduleNewRecord(Date, (byte?)enStatus.Scheduled, (byte?)Type, DoctorScheduleID, PatientID, CreatedByUserID);
            return this.ID.HasValue;
        }

        private async Task<bool> _Reschedule()
        {
            this.ID = await clsAppointmentData.RescheduleNewRecord(ID, Date, (byte?)enStatus.Scheduled, (byte?)Type, DoctorScheduleID, PatientID, CreatedByUserID);
            return this.ID.HasValue;
        }

        public async Task<bool> Schedule()
        {
            if (_Mode == enMode.Schedule)
            {
                if (await this._Schedule())
                {
                    this.CreatedDate = DateTime.Now;
                    this._Mode = enMode.Reschedule;
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public async Task<bool> Reschedule()
        {
            if (_Mode == enMode.Reschedule)
            {
                if (await this._Reschedule())
                {
                    this.CreatedDate = DateTime.Now;
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public static Task<bool> Cancel(int? id)
        {
            return clsAppointmentData.CancelAppointmentRecord(id);
        }

        public static Task<bool> Delete(int? id)
        {
            return clsAppointmentData.DeleteRecord(id);
        }
    }
}