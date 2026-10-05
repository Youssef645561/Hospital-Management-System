using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using Common;

namespace HMS.DAL
{
    public static class clsDoctorData
    {
        public static async Task<bool> IsRecordExist(int? PersonID)
        {
            bool IsExist = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select 1 from Doctors where PersonID = @PersonID";
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

        public static async Task<(int? ID, bool? IsActive, DateTime? CreatedDate, int? PersonID, byte? DepartmentID, byte? SpecializationID, int? CreatedByUserID, string CreatedByUsername)?> FindRecord(int? ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select Doctors.ID as [ID], Doctors.IsActive as [IsActive], Doctors.CreatedDate as [CreatedDate], Doctors.PersonID as [PersonID], Doctors.DepartmentID as [DepartmentID], Doctors.SpecializationID as [SpecializationID], Doctors.CreatedByUserID as [CreatedByUserID], Users.Username as [CreatedByUsername] from Doctors inner join Users on Doctors.CreatedByUserID = Users.ID where Doctors.ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                                return (reader["ID"] != DBNull.Value ? (int?)reader["ID"] : null, reader["IsActive"] != DBNull.Value ? (bool?)reader["IsActive"] : null, reader["CreatedDate"] != DBNull.Value ? (DateTime?)reader["CreatedDate"] : null, reader["PersonID"] != DBNull.Value ? (int?)reader["PersonID"] : null, reader["DepartmentID"] != DBNull.Value ? (byte?)reader["DepartmentID"] : null, reader["SpecializationID"] != DBNull.Value ? (byte?)reader["SpecializationID"] : null, reader["CreatedByUserID"] != DBNull.Value ? (int?)reader["CreatedByUserID"] : null, reader["CreatedByUsername"] != DBNull.Value ? (string)reader["CreatedByUsername"] : null);
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

        public static DataTable GetAllRecords(byte? SpecializationID)
        {
            DataTable dtRecords = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = @"select [ID] as [ID], [Full Name] as [Name] from DoctorsData_View
                                     where Active = 'Active' and SpecializationID like @SpecializationID;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@SpecializationID", SqlDbType.TinyInt).Value = SpecializationID ?? (object)DBNull.Value;
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
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
                    string query = @"select ID, [Full Name], DepartmentName, SpecializationName, Active from DoctorsData_View order by ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only;";
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
                    string query = $@"select ID, [Full Name], DepartmentName, SpecializationName, Active from DoctorsData_View where [{Filter}] like @Value order by ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Page", SqlDbType.Int).Value = Page;
                        cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = PageSize;
                        if (Filter == "ID")
                            cmd.Parameters.Add("@Value", SqlDbType.NVarChar).Value = Value;
                        else if (Filter == "Department" || Filter == "Specialization" || Filter == "Active")
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
                    string query = @"select count(*) from DoctorsData_View;";
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
                    string query = $@"select count(*) from DoctorsData_View where [{Filter}] like @Value";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (Filter == "ID")
                            cmd.Parameters.Add("@Value", SqlDbType.NVarChar).Value = Value;
                        else if (Filter == "Department" || Filter == "Specialization" || Filter == "Active")
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

        public static async Task<int?> AddNewRecord(bool? IsActive, int? PersonID, byte? DepartmentID, byte? SpecializationID, int? CreatedByUserID)
        {
            int? NewRecordID = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "insert into Doctors (IsActive, PersonID, DepartmentID, SpecializationID, CreatedByUserID) values (@IsActive, @PersonID, @DepartmentID, @SpecializationID, @CreatedByUserID); select scope_identity();";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = IsActive ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@PersonID", SqlDbType.NVarChar).Value = PersonID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@DepartmentID", SqlDbType.TinyInt).Value = DepartmentID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@SpecializationID", SqlDbType.TinyInt).Value = SpecializationID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@CreatedByUserID", SqlDbType.NVarChar).Value = CreatedByUserID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        object result = await cmd.ExecuteScalarAsync();
                        if (result != null && result != DBNull.Value)
                            NewRecordID = Convert.ToInt32(result);
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

        public static async Task<bool> EditRecord(int? ID, bool? IsActive, DateTime? CreatedDate, int? PersonID, byte? DepartmentID, byte? SpecializationID, int? CreatedByUserID)
        {
            bool IsEdited = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "update Doctors set IsActive = @IsActive, CreatedDate = @CreatedDate, PersonID = @PersonID, DepartmentID = @DepartmentID, SpecializationID = @SpecializationID, CreatedByUserID = @CreatedByUserID where ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = IsActive ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = CreatedDate ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@PersonID", SqlDbType.NVarChar).Value = PersonID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@DepartmentID", SqlDbType.TinyInt).Value = DepartmentID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@SpecializationID", SqlDbType.TinyInt).Value = SpecializationID ?? (object)DBNull.Value;
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
                    string query = "delete from Doctors where ID = @ID";
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