using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using Common;

namespace HMS.DAL
{
    public static class clsPatientData
    {
        public static async Task<bool> IsRecordExist(int? PersonID)
        {
            bool IsExist = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select 1 from Patients where PersonID = @PersonID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@PersonID", SqlDbType.NVarChar).Value = PersonID ?? (object)DBNull.Value;
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

        public static async Task<(int? ID, string MedicalRecordNo, string BloodType, DateTime? CreatedDate, int? PersonID, int? CreatedByUserID)?> FindRecord(int? ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select ID as [ID], MedicalRecordNo as [MedicalRecordNo], BloodType as [BloodType], CreatedDate as [CreatedDate], PersonID as [PersonID], CreatedByUserID as [CreatedByUserID] from Patients where ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                                return (reader["ID"] != DBNull.Value ? (int?)reader["ID"] : null, reader["MedicalRecordNo"] != DBNull.Value ? (string)reader["MedicalRecordNo"] : null, reader["BloodType"] != DBNull.Value ? (string)reader["BloodType"] : null, reader["CreatedDate"] != DBNull.Value ? (DateTime?)reader["CreatedDate"] : null, reader["PersonID"] != DBNull.Value ? (int?)reader["PersonID"] : null, reader["CreatedByUserID"] != DBNull.Value ? (int?)reader["CreatedByUserID"] : null);
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

        public static async Task<(int? ID, string MedicalRecordNo, string BloodType, DateTime? CreatedDate, int? PersonID, int? CreatedByUserID)?> FindRecord(string MedicalRecordNo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select ID as [ID], MedicalRecordNo as [MedicalRecordNo], BloodType as [BloodType], CreatedDate as [CreatedDate], PersonID as [PersonID], CreatedByUserID as [CreatedByUserID] from Patients where MedicalRecordNo = @MedicalRecordNo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MedicalRecordNo", SqlDbType.NVarChar).Value = MedicalRecordNo ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                                return (reader["ID"] != DBNull.Value ? (int?)reader["ID"] : null, reader["MedicalRecordNo"] != DBNull.Value ? (string)reader["MedicalRecordNo"] : null, reader["BloodType"] != DBNull.Value ? (string)reader["BloodType"] : null, reader["CreatedDate"] != DBNull.Value ? (DateTime?)reader["CreatedDate"] : null, reader["PersonID"] != DBNull.Value ? (int?)reader["PersonID"] : null, reader["CreatedByUserID"] != DBNull.Value ? (int?)reader["CreatedByUserID"] : null);
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
                    string query = "select ID, [Medical Record No], [Full Name], Gender, [Date Of Birth], Phone, [Blood Type] from PatientsData_View order by ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only";
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
                    string query = $@"select ID, [Medical Record No], [Full Name], Gender, [Date Of Birth], Phone, [Blood Type] from PatientsData_View
                                      where [{Filter}] like @Value order by ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Page", SqlDbType.Int).Value = Page;
                        cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = PageSize;
                        if (Filter == "ID")
                            cmd.Parameters.Add("@Value", SqlDbType.NVarChar).Value = Value;
                        else if (Filter == "Gender" || Filter == "Blood Type" || Filter == "Medical Record No")
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
                    string query = @"select count(*) from PatientsData_View;";
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
                    string query = $"select count(*) from PatientsData_View where [{Filter}] like @Value";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (Filter == "ID")
                            cmd.Parameters.Add("@Value", SqlDbType.NVarChar).Value = Value;
                        else if (Filter == "Gender" || Filter == "Blood Type" || Filter == "Medical Record No")
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

        public static async Task<(int? ID, string MedicalRecordNo)?> AddNewRecord(string BloodType, int? PersonID, int? CreatedByUserID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "insert into Patients (BloodType, PersonID, CreatedByUserID) output inserted.ID, inserted.MedicalRecordNo values(@BloodType, @PersonID, @CreatedByUserID);";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@BloodType", SqlDbType.NVarChar).Value = BloodType ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@PersonID", SqlDbType.NVarChar).Value = PersonID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@CreatedByUserID", SqlDbType.NVarChar).Value = CreatedByUserID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                                return (reader["ID"] != DBNull.Value ? (int?)reader["ID"] : null, reader["MedicalRecordNo"] != DBNull.Value ? (string)reader["MedicalRecordNo"] : null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return null;
        }

        public static async Task<bool> EditRecord(int? ID, string BloodType)
        {
            bool IsEdited = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "update Patients set BloodType = @BloodType where ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@BloodType", SqlDbType.NVarChar).Value = BloodType ?? (object)DBNull.Value;

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
                    string query = "delete from Patients where ID = @ID";
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