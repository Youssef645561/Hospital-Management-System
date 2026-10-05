using HMS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using static HMS.BLL.clsDoctorSchedule;

namespace HMS.BLL
{
    public class clsPeriod
    {
        public class clsTimeSlot
        {
            public string Text { get; set; }
            public TimeSpan Value { get; set; }

            public clsTimeSlot(string text, TimeSpan value)
            {
                Text = text;
                Value = value;
            }
        }

        public TimeSpan? Start { get; set; }
        public TimeSpan? End { get; set; }
        public byte? SlotDuration { get; set; }

        public clsPeriod()
        {
            this.Start = null;
            this.End = null;
            this.SlotDuration = null;
        }

        private clsPeriod(TimeSpan? start, TimeSpan? end, byte? slotduration)
        {
            this.Start = start;
            this.End = end;
            this.SlotDuration = slotduration;
        }

        private static List<clsTimeSlot> ConvertPeriodToSlots(clsPeriod period)
        {
            List<clsTimeSlot> slots = new List<clsTimeSlot>();

            TimeSpan current = period.Start.Value, next;

            while (current < period.End.Value)
            {
                next = current.Add(TimeSpan.FromMinutes(period.SlotDuration.Value));

                slots.Add(new clsTimeSlot($"{DateTime.Today.Add(current):h tt} to {DateTime.Today.Add(next):h tt}",current));

                current = next;
            }

            return slots;
        }

        public static async Task<(int? DoctorScheduleID, List<clsPeriod.clsTimeSlot> SlotsList)?> GetSlotsList(int DoctorID, string DayOfWeek)
        {
            var PeriodData = await clsPeriodData.FindRecord(DoctorID, DayOfWeek);

            if (PeriodData != null)
                return (PeriodData.Value.DoctorScheduleID, ConvertPeriodToSlots(new clsPeriod(PeriodData.Value.Start, PeriodData.Value.End, PeriodData.Value.SlotDuration)));
            else
                return null;
        }
    }

    public partial class clsDoctorSchedule
    {
        private enum enMode { AddNew, Edit }
        private enMode _Mode;

        public enum enDayOfWeek { Saturday = 1, Sunday = 2, Monday = 3, Tuesday = 4, Wednesday = 5, Thursday = 6, Friday = 7 }

        public int? ID { get; set; }
        public enDayOfWeek? DayOfWeek { get; set; }
        public clsPeriod Period { get; set; }
        public byte? MaxPatientsPerSlot { get; set; }
        public int? DoctorID { get; set; }

        public clsDoctorSchedule()
        {
            this._Mode = enMode.AddNew;
            this.ID = null;
            this.DayOfWeek = null;
            this.Period = new clsPeriod();
            this.MaxPatientsPerSlot = null;
            this.DoctorID = null;
        }

        private clsDoctorSchedule(int? id, enDayOfWeek? dayofweek, clsPeriod period, byte? maxpatientsperslot, int? doctorid)
        {
            this._Mode = enMode.Edit;
            this.ID = id;
            this.DayOfWeek = dayofweek;
            this.Period = period;
            this.MaxPatientsPerSlot = maxpatientsperslot;
            this.DoctorID = doctorid;
        }

        public static async Task<clsDoctorSchedule> Find(int? id)
        {
            var DoctorScheduleData = await clsDoctorScheduleData.FindRecord(id);
            if (DoctorScheduleData != null)
                return new clsDoctorSchedule(DoctorScheduleData.Value.ID, (enDayOfWeek)DoctorScheduleData.Value.DayOfWeek, new clsPeriod() { Start = DoctorScheduleData.Value.StartPeriod, End = DoctorScheduleData.Value.EndPeriod, SlotDuration = DoctorScheduleData.Value.SlotDuration }, DoctorScheduleData.Value.MaxPatientsPerSlot, DoctorScheduleData.Value.DoctorID);
            else
                return null;
        }

        public static Task<bool> Delete(int? id)
        {
            return clsDoctorScheduleData.DeleteRecord(id);
        }
    }
}