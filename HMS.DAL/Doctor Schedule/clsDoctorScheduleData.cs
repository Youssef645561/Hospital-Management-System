using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using Common;

namespace HMS.DAL
{
    public static class clsPeriodData
    {
        public static async Task<(int? DoctorScheduleID, TimeSpan? Start, TimeSpan? End, byte? SlotDuration)?> FindRecord(int? DoctorID, string DayOfWeek)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = @"select DoctorScheduleID as [DoctorScheduleID], StartPeriod as [Start], EndPeriod as [End], SlotDuration as [SlotDuration] from DoctorSchedulesDetails_View
                                     where DoctorID = @DoctorID and DayOfWeek = @DayOfWeek;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@DoctorID", SqlDbType.NVarChar).Value = DoctorID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@DayOfWeek", SqlDbType.NVarChar).Value = DayOfWeek ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                                return (reader["DoctorScheduleID"] != DBNull.Value ? (int?)reader["DoctorScheduleID"] : null, reader["Start"] != DBNull.Value ? (TimeSpan?)reader["Start"] : null, reader["End"] != DBNull.Value ? (TimeSpan?)reader["End"] : null, reader["SlotDuration"] != DBNull.Value ? (byte?)reader["SlotDuration"] : null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                return null;
            }
            return null;
        }
    }

    public static class clsDoctorScheduleData
    {
        public static async Task<(int? ID, byte? DayOfWeek, TimeSpan? StartPeriod, TimeSpan? EndPeriod, byte? SlotDuration, byte? MaxPatientsPerSlot, int? DoctorID)?> FindRecord(int? ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select ID as [ID], DayOfWeek as [DayOfWeek], StartPeriod as [StartPeriod], EndPeriod as [EndPeriod], SlotDuration as [SlotDuration], MaxPatientsPerSlot as [MaxPatientsPerSlot], DoctorID as [DoctorID] from DoctorSchedules where ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                                return (reader["ID"] != DBNull.Value ? (int?)reader["ID"] : null, reader["DayOfWeek"] != DBNull.Value ? (byte?)reader["DayOfWeek"] : null, reader["StartPeriod"] != DBNull.Value ? (TimeSpan?)reader["StartPeriod"] : null, reader["EndPeriod"] != DBNull.Value ? (TimeSpan?)reader["EndPeriod"] : null, reader["SlotDuration"] != DBNull.Value ? (byte?)reader["SlotDuration"] : null, reader["MaxPatientsPerSlot"] != DBNull.Value ? (byte?)reader["MaxPatientsPerSlot"] : null, reader["DoctorID"] != DBNull.Value ? (int?)reader["DoctorID"] : null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                return null;
            }
            return null;
        }

        public static async Task<bool> DeleteRecord(int? ID)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "delete from DoctorSchedules where ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        IsDeleted = (await cmd.ExecuteNonQueryAsync() > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                IsDeleted = false;
            }
            return IsDeleted;
        }
    }
}