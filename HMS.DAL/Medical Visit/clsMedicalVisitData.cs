using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using Common;

namespace HMS.DAL
{
    public static class clsMedicalVisitData
    {
        public static async Task<bool> HasPrescriptionRecord(int? MedicalVisitID)
        {
            bool IsExist = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select 1 from Prescriptions where MedicalVisitID = @MedicalVisitID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MedicalVisitID", SqlDbType.Int).Value = MedicalVisitID ?? (object)DBNull.Value;
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

        public static async Task<(int? ID, string PatientSymptoms, string Diagnosis, string Notes, DateTime? CreatedDate, int? AppointmentID, int? PrescriptionID, int? CreatedByUserID, string CreatedByUsername)?> FindRecord(int? ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = @"select MedicalVisits.ID as [ID], MedicalVisits.PatientSymptoms as [PatientSymptoms], MedicalVisits.Diagnosis as [Diagnosis], MedicalVisits.Notes as [Notes], MedicalVisits.CreatedDate as [CreatedDate], MedicalVisits.AppointmentID as [AppointmentID], Prescriptions.ID as [PrescriptionID], MedicalVisits.CreatedByUserID as [CreatedByUserID], Users.Username as [CreatedByUsername]
                                     from MedicalVisits
									 left join Prescriptions on Prescriptions.MedicalVisitID = MedicalVisits.ID
                                     inner join Users on Users.ID = MedicalVisits.CreatedByUserID
                                     where MedicalVisits.ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                                return (reader["ID"] != DBNull.Value ? (int?)reader["ID"] : null, reader["PatientSymptoms"] != DBNull.Value ? (string)reader["PatientSymptoms"] : null, reader["Diagnosis"] != DBNull.Value ? (string)reader["Diagnosis"] : null, reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : null, reader["CreatedDate"] != DBNull.Value ? (DateTime?)reader["CreatedDate"] : null, reader["AppointmentID"] != DBNull.Value ? (int?)reader["AppointmentID"] : null, reader["PrescriptionID"] != DBNull.Value ? (int?)reader["PrescriptionID"] : null, reader["CreatedByUserID"] != DBNull.Value ? (int?)reader["CreatedByUserID"] : null, reader["CreatedByUsername"] != DBNull.Value ? (string)reader["CreatedByUsername"] : null);
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

        public static async Task<DataTable> GetPageRecords(int Page, int PageSize)
        {
            DataTable dtRecords = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select ID as [ID], PatientID as [PatientID], MedicalRecordNo as [Medical Record No], PatientName as [Patient Name], PatientGender as [Gender], BloodType as [Blood Type], MedicalVisitDate as [Date] from MedicalVisitsData_View order by ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only";
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
                    string query = $"select ID as [ID], PatientID as [PatientID], MedicalRecordNo as [Medical Record No], PatientName as [Patient Name], PatientGender as [Gender], BloodType as [Blood Type], MedicalVisitDate as [Date] from MedicalVisitsData_View where [{Filter}] like @Value order by ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Page", SqlDbType.Int).Value = Page;
                        cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = PageSize;
                        if (Filter == "ID")
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
                    string query = @"select count(*) from MedicalVisitsData_View;";
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
                    string query = $"select count(*) from MedicalVisitsData_View where [{Filter}] like @Value";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (Filter == "ID")
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

        public static async Task<int?> AddNewRecord(string PatientSymptoms, string Diagnosis, string Notes, int? AppointmentID, int? CreatedByUserID)
        {
            int? NewRecordID = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AddNewMedicalVisit", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter prmID = cmd.Parameters.Add("@MedicalVisitID", SqlDbType.Int);
                        prmID.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add("@PatientSymptoms", SqlDbType.NVarChar).Value = PatientSymptoms ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Diagnosis", SqlDbType.NVarChar).Value = Diagnosis ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = Notes ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@AppointmentID", SqlDbType.NVarChar).Value = AppointmentID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@CreatedByUserID", SqlDbType.NVarChar).Value = CreatedByUserID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                        NewRecordID = prmID.Value != DBNull.Value ? (int?)prmID.Value : null;
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

        public static async Task<bool> EditRecord(int? ID, string PatientSymptoms, string Diagnosis, string Notes, DateTime? CreatedDate, int? AppointmentID, int? CreatedByUserID)
        {
            bool IsEdited = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "update MedicalVisits set PatientSymptoms = @PatientSymptoms, Diagnosis = @Diagnosis, Notes = @Notes, CreatedDate = @CreatedDate, AppointmentID = @AppointmentID, CreatedByUserID = @CreatedByUserID where ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@PatientSymptoms", SqlDbType.NVarChar).Value = PatientSymptoms ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Diagnosis", SqlDbType.NVarChar).Value = Diagnosis ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = Notes ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = CreatedDate ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@AppointmentID", SqlDbType.NVarChar).Value = AppointmentID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@CreatedByUserID", SqlDbType.NVarChar).Value = CreatedByUserID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        IsEdited = (await cmd.ExecuteNonQueryAsync() > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                IsEdited = false;
            }
            return IsEdited;
        }

        public static async Task<bool> DeleteRecord(int? ID)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "delete from MedicalVisits where ID = @ID";
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