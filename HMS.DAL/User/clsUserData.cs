using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using Common;

namespace HMS.DAL
{
    public static class clsUserData
    {
        public static async Task<bool> IsUsernameRecordExist(string Username)
        {
            bool IsExist = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select 1 from Users where Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username ?? (object)DBNull.Value;
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

        public static async Task<(int? ID, string Username, bool? IsActive, DateTime? CreatedDate, byte? UserRoleID)?> FindRecord(string Username, string Password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select ID as [ID], Username as [Username], IsActive as [IsActive], CreatedDate as [CreatedDate], UserRoleID as [UserRoleID] from Users where Username = @Username and Password = @Password;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                                return (reader["ID"] != DBNull.Value ? (int?)reader["ID"] : null, reader["Username"] != DBNull.Value ? (string)reader["Username"] : null, reader["IsActive"] != DBNull.Value ? (bool?)reader["IsActive"] : null, reader["CreatedDate"] != DBNull.Value ? (DateTime?)reader["CreatedDate"] : null, reader["UserRoleID"] != DBNull.Value ? (byte?)reader["UserRoleID"] : null);
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

        public static async Task<(int? ID, string Username, bool? IsActive, DateTime? CreatedDate, byte? UserRoleID)?> FindRecord(int? ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select ID as [ID], Username as [Username], IsActive as [IsActive], CreatedDate as [CreatedDate], UserRoleID as [UserRoleID] from Users where ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                                return (reader["ID"] != DBNull.Value ? (int?)reader["ID"] : null, reader["Username"] != DBNull.Value ? (string)reader["Username"] : null, reader["IsActive"] != DBNull.Value ? (bool?)reader["IsActive"] : null, reader["CreatedDate"] != DBNull.Value ? (DateTime?)reader["CreatedDate"] : null, reader["UserRoleID"] != DBNull.Value ? (byte?)reader["UserRoleID"] : null);
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

        public static async Task<bool> IsPasswordRecordCorrect(int? ID, string Password)
        {
            bool IsCorrect = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select 1 from Users where ID = @ID and Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        IsCorrect = (await cmd.ExecuteScalarAsync() != null);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                IsCorrect = false;
            }
            return IsCorrect;
        }

        public static async Task<bool> ChangePasswordRecord(int? ID, string NewPassword)
        {
            bool IsEdited = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "update Users set Password = @NewPassword where ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@NewPassword", SqlDbType.NVarChar).Value = NewPassword ?? (object)DBNull.Value;

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

        public static async Task<string> GetUsernameRecord(int? ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select Username from Users where ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        object result = await cmd.ExecuteScalarAsync();
                        if (result != null && result != DBNull.Value)
                            return (string)result;
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
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
                    string query = "select Users.ID as [ID], Username as [Username], case IsActive when 1 then 'Active' else 'Inactive' end as [Active], UserRoles.Name as [User Role] from Users inner join UserRoles on Users.UserRoleID = UserRoles.ID order by ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only;";
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

            if (Filter == "ID")
                Filter = "Users.ID";
            else if (Filter == "UserRoleID")
                Filter = "Users.UserRoleID";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = $"select Users.ID as [ID], Username as [Username], case IsActive when 1 then 'Active' else 'Inactive' end as [Active], UserRoles.Name as [User Role] from Users inner join UserRoles on Users.UserRoleID = UserRoles.ID where {Filter} like @Value order by Users.ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Page", SqlDbType.Int).Value = Page;
                        cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = PageSize;
                        if (Filter == "Users.ID" || Filter == "Users.UserRoleID")
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
                    string query = @"select count(*) from Users;";
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

            if (Filter == "ID")
                Filter = "Users.ID";
            else if (Filter == "UserRoleID")
                Filter = "Users.UserRoleID";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = $"select count(*) from Users where {Filter} like @Value";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (Filter == "Users.ID" || Filter == "Users.UserRoleID")
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

        public static async Task<int?> AddNewRecord(string Username, string Password, bool? IsActive, byte? UserRoleID)
        {
            int? NewRecordID = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "insert into Users (Username, Password, IsActive, UserRoleID) values (@Username, @Password, @IsActive, @UserRoleID); select scope_identity();";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = Username ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = IsActive ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@UserRoleID", SqlDbType.TinyInt).Value = UserRoleID ?? (object)DBNull.Value;
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

        public static async Task<bool> EditRecord(int? ID, string Username, bool? IsActive, DateTime? CreatedDate, byte? UserRoleID)
        {
            bool IsEdited = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "update Users set Username = @Username, IsActive = @IsActive, CreatedDate = @CreatedDate, UserRoleID = @UserRoleID where ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = Username ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = IsActive ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = CreatedDate ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@UserRoleID", SqlDbType.TinyInt).Value = UserRoleID ?? (object)DBNull.Value;
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
                    string query = "delete from Users where ID = @ID";
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