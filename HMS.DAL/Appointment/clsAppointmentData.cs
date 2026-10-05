using Common;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HMS.DAL
{
    public static class clsAppointmentData
    {
        public static async Task<bool> HasLabTestRecord(int? AppointmentID, byte? TestTypeID)
        {
            bool IsExist = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select 1 from LabTests where AppointmentID = @AppointmentID and TestTypeID = @TestTypeID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@AppointmentID", SqlDbType.Int).Value = AppointmentID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@TestTypeID", SqlDbType.TinyInt).Value = TestTypeID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        IsExist = (await cmd.ExecuteScalarAsync() != null);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                IsExist = false;
            }
            return IsExist;
        }

        public static async Task<bool> IsScheduledAppointmentRecordExist(int? PatientID, int? DoctorID)
        {
            bool IsExist = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = @"select 1 from AppointmentsDetails_View where Status = 'Scheduled' and PatientID = @PatientID and DoctorID = @DoctorID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@PatientID", SqlDbType.NVarChar).Value = PatientID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@DoctorID", SqlDbType.NVarChar).Value = DoctorID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        IsExist = (await cmd.ExecuteScalarAsync() != null);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                IsExist = false;
            }
            return IsExist;
        }

        public static async Task<(int? ID, DateTime? Date, byte? Status, byte? Type, DateTime? CreatedDate, int? DoctorScheduleID, string DoctorName, int? PatientID, byte? DoctorSpecializationID, int? CreatedByUserID, string CreatedByUsername)?> FindRecord(int? ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = @"select Appointments.ID as [ID], Appointments.Date as [Date], Appointments.Status as [Status], Appointments.Type as [Type], Appointments.CreatedDate as [CreatedDate], Appointments.DoctorScheduleID as [DoctorScheduleID], concat_ws(' ', People.FirstName, People.SecondName, People.LastName) as [DoctorName], Appointments.PatientID as [PatientID], Specializations.ID as [DoctorSpecializationID], Appointments.CreatedByUserID as [CreatedByUserID], Users.Username as [CreatedByUsername]
                                     from Appointments
                                     inner join Users on Users.ID = Appointments.CreatedByUserID
                                     inner join DoctorSchedules on DoctorSchedules.ID = Appointments.DoctorScheduleID
                                     inner join Doctors on Doctors.ID = DoctorSchedules.DoctorID
                                     inner join People on People.ID = Doctors.PersonID
                                     inner join Specializations on Specializations.ID = Doctors.SpecializationID
                                     where Appointments.ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                                return (reader["ID"] != DBNull.Value ? (int?)reader["ID"] : null, reader["Date"] != DBNull.Value ? (DateTime?)reader["Date"] : null, reader["Status"] != DBNull.Value ? (byte?)reader["Status"] : null, reader["Type"] != DBNull.Value ? (byte?)reader["Type"] : null, reader["CreatedDate"] != DBNull.Value ? (DateTime?)reader["CreatedDate"] : null, reader["DoctorScheduleID"] != DBNull.Value ? (int?)reader["DoctorScheduleID"] : null, reader["DoctorName"] != DBNull.Value ? (string)reader["DoctorName"] : null, reader["PatientID"] != DBNull.Value ? (int?)reader["PatientID"] : null, reader["DoctorSpecializationID"] != DBNull.Value ? (byte?)reader["DoctorSpecializationID"] : null, reader["CreatedByUserID"] != DBNull.Value ? (int?)reader["CreatedByUserID"] : null, reader["CreatedByUsername"] != DBNull.Value ? (string)reader["CreatedByUsername"] : null);
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

        public static async Task<DataTable> GetAllAppointmentsRecordsByPatientID(int? PatientID)
        {
            DataTable dtRecords = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select AppointmentID as [ID], MedicalRecordNo as [Medical Record No], Day, Date, Time, Type, Status from AppointmentsDetails_View where PatientID = @PatientID order by AppointmentID;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@PatientID", SqlDbType.Int).Value = PatientID;

                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                                dtRecords.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return dtRecords;
        }

        public static async Task<DataTable> GetAllWaitingAppointmentsRecords()
        {
            DataTable dtRecords = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select AppointmentID as [ID], MedicalRecordNo as [Medical Record No], Day, Date, Time, Type, Status from AppointmentsDetails_View where Status = 'Waiting' order by AppointmentID;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                                dtRecords.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return dtRecords;
        }

        public static async Task<DataTable> GetPageRecords(int Page, int PageSize)
        {
            DataTable dtRecords = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select AppointmentID as [ID], MedicalRecordNo as [Medical Record No], Day, Date, Time, Type, Status, PatientID from AppointmentsDetails_View order by AppointmentID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Page", SqlDbType.Int).Value = Page;
                        cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = PageSize;

                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                                dtRecords.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return dtRecords;
        }

        public static async Task<DataTable> GetPageRecordsByFilter(int Page, int PageSize, string Filter, string Value)
        {
            DataTable dtRecords = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = $"select AppointmentID as [ID], MedicalRecordNo as [Medical Record No], Day, Date, Time, Type, Status, PatientID from AppointmentsDetails_View where [{Filter}] like @Value order by AppointmentID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Page", SqlDbType.Int).Value = Page;
                        cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = PageSize;
                        if (Filter == "AppointmentID" || Filter == "MedicalRecordNo")
                            cmd.Parameters.Add("@Value", SqlDbType.NVarChar).Value = Value;
                        else
                            cmd.Parameters.Add("@Value", SqlDbType.NVarChar).Value = $"%{Value}%";
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                                dtRecords.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return dtRecords;
        }

        public static async Task<int> GetRecordsCount()
        {
            int Count = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = @"select count(*) from AppointmentsDetails_View;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        await conn.OpenAsync();
                        object result = await cmd.ExecuteScalarAsync();
                        if (result != null && result != DBNull.Value)
                            Count = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                Count = 0;
            }
            return Count;
        }

        public static async Task<int> GetRecordsCountByFilter(string Filter, string Value)
        {
            int Count = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = $"select count(*) from AppointmentsDetails_View where [{Filter}] like @Value";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (Filter == "AppointmentID" || Filter == "MedicalRecordNo")
                            cmd.Parameters.Add("@Value", SqlDbType.NVarChar).Value = Value;
                        else
                            cmd.Parameters.Add("@Value", SqlDbType.NVarChar).Value = $"%{Value}%";
                        await conn.OpenAsync();
                        object result = await cmd.ExecuteScalarAsync();
                        if (result != null && result != DBNull.Value)
                            Count = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                Count = 0;
            }
            return Count;
        }

        public static async Task<int?> ScheduleNewRecord(DateTime? Date, byte? Status, byte? Type, int? DoctorScheduleID, int? PatientID, int? CreatedByUserID)
        {
            int? NewRecordID = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ScheduleAppointment", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter parID = cmd.Parameters.Add("@ID", SqlDbType.Int);
                        parID.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = Date ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Type", SqlDbType.TinyInt).Value = Type ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@DoctorScheduleID", SqlDbType.NVarChar).Value = DoctorScheduleID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@PatientID", SqlDbType.NVarChar).Value = PatientID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@CreatedByUserID", SqlDbType.NVarChar).Value = CreatedByUserID ?? (object)DBNull.Value;

                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();

                        NewRecordID = Convert.ToInt32(parID.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                NewRecordID = null;
            }
            return NewRecordID;
        }

        public static async Task<int?> RescheduleNewRecord(int? ID, DateTime? Date, byte? Status, byte? Type, int? DoctorScheduleID, int? PatientID, int? CreatedByUserID)
        {
            int? NewRecordID = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_RescheduleAppointment", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter parID = cmd.Parameters.Add("@ID", SqlDbType.Int);
                        parID.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = Date ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Type", SqlDbType.TinyInt).Value = Type ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@DoctorScheduleID", SqlDbType.NVarChar).Value = DoctorScheduleID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@PatientID", SqlDbType.NVarChar).Value = PatientID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@CreatedByUserID", SqlDbType.NVarChar).Value = CreatedByUserID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@ScheduledAppointmentID", SqlDbType.Int).Value = ID ?? (object)DBNull.Value;

                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();

                        NewRecordID = Convert.ToInt32(parID.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                NewRecordID = null;
            }
            return NewRecordID;
        }

        public static async Task<bool> CancelAppointmentRecord(int? ID)
        {
            bool IsCancelled = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CancelAppointment", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ID", SqlDbType.TinyInt).Value = ID ?? (object)DBNull.Value;

                        await conn.OpenAsync();
                        IsCancelled = (await cmd.ExecuteNonQueryAsync() > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                IsCancelled = false;
            }
            return IsCancelled;
        }

        public static async Task<bool> DeleteRecord(int? ID)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "delete from Appointments where ID = @ID";
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