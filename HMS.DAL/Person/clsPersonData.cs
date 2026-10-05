using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using Common;

namespace HMS.DAL
{
    public static class clsPersonData
    {
        public static async Task<(int? ID, string FirstName, string SecondName, string LastName, DateTime? DateOfBirth, bool? Gender, string Email, string Phone, byte[] PersonalImage, DateTime? CreatedDate, int? CreatedByUserID)?> FindRecord(int? ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select ID as [ID], FirstName as [FirstName], SecondName as [SecondName], LastName as [LastName], DateOfBirth as [DateOfBirth], Gender as [Gender], Email as [Email], Phone as [Phone], PersonalImage as [PersonalImage], CreatedDate as [CreatedDate], CreatedByUserID as [CreatedByUserID] from People where ID = @ID;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                                return (reader["ID"] != DBNull.Value ? (int?)reader["ID"] : null, reader["FirstName"] != DBNull.Value ? (string)reader["FirstName"] : null, reader["SecondName"] != DBNull.Value ? (string)reader["SecondName"] : null, reader["LastName"] != DBNull.Value ? (string)reader["LastName"] : null, reader["DateOfBirth"] != DBNull.Value ? (DateTime?)reader["DateOfBirth"] : null, reader["Gender"] != DBNull.Value ? (bool?)reader["Gender"] : null, reader["Email"] != DBNull.Value ? (string)reader["Email"] : null, reader["Phone"] != DBNull.Value ? (string)reader["Phone"] : null, reader["PersonalImage"] != DBNull.Value ? (byte[])reader["PersonalImage"] : null, reader["CreatedDate"] != DBNull.Value ? (DateTime?)reader["CreatedDate"] : null, reader["CreatedByUserID"] != DBNull.Value ? (int?)reader["CreatedByUserID"] : null);
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
                    string query = "select ID as [ID], FirstName as [First Name], coalesce(SecondName, '---') as [Second Name], LastName as [Last Name], DateOfBirth as [Date Of Birth], dbo.GetGender(Gender) as [Gender], coalesce(Email, '---') as [Email], Phone as [Phone] from People order by ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only";
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
                    string query = $"select ID as [ID], FirstName as [First Name], coalesce(SecondName, '---') as [Second Name], LastName as [Last Name], DateOfBirth as [Date Of Birth], dbo.GetGender(Gender) as [Gender], coalesce(Email, '---') as [Email], Phone as [Phone] from People where {Filter} like @Value order by ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Page", SqlDbType.Int).Value = Page;
                        cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = PageSize;
                        if (Filter == "ID" || Filter == "CreatedByUserID")
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
                    string query = @"select count(*) from People;";
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
                    string query = $"select count(*) from People where {Filter} like @Value";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (Filter == "ID" || Filter == "CreatedByUserID")
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

        public static async Task<int?> AddNewRecord(string FirstName, string SecondName, string LastName, DateTime? DateOfBirth, bool? Gender, string Email, string Phone, byte[] PersonalImage, int? CreatedByUserID)
        {
            int? NewRecordID = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "insert into People (FirstName, SecondName, LastName, DateOfBirth, Gender, Email, Phone, PersonalImage, CreatedByUserID) values (@FirstName, @SecondName, @LastName, @DateOfBirth, @Gender, @Email, @Phone, @PersonalImage, @CreatedByUserID); select scope_identity();";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@SecondName", SqlDbType.NVarChar).Value = SecondName ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = DateOfBirth ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Gender", SqlDbType.Bit).Value = Gender ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@PersonalImage", SqlDbType.VarBinary).Value = PersonalImage ?? (object)DBNull.Value;
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

        public static async Task<bool> EditRecord(int? ID, string FirstName, string SecondName, string LastName, DateTime? DateOfBirth, bool? Gender, string Email, string Phone, byte[] PersonalImage, DateTime? CreatedDate, int? CreatedByUserID)
        {
            bool IsEdited = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "update People set FirstName = @FirstName, SecondName = @SecondName, LastName = @LastName, DateOfBirth = @DateOfBirth, Gender = @Gender, Email = @Email, Phone = @Phone, PersonalImage = @PersonalImage, CreatedDate = @CreatedDate, CreatedByUserID = @CreatedByUserID where ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@SecondName", SqlDbType.NVarChar).Value = SecondName ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = DateOfBirth ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Gender", SqlDbType.Bit).Value = Gender ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@PersonalImage", SqlDbType.VarBinary).Value = PersonalImage ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = CreatedDate ?? (object)DBNull.Value;
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
                    string query = "delete from People where ID = @ID";
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