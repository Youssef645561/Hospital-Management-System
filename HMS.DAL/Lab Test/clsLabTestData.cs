using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using Common;

namespace HMS.DAL
{
    public static class clsLabTestData
    {
        public static async Task<(int? ID, byte? Status, DateTime? ResultDate, bool? Result, string Notes, DateTime? CreatedDate, byte? TestTypeID, string TestTypeName, int? AppointmentID, int? PatientChargeID, int? CreatedByUserID, string CreatedByUsername)?> FindRecord(int? ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = @"select LT.ID as [ID], LT.Status as [Status], LT.ResultDate as [ResultDate], LT.Result as [Result], LT.Notes as [Notes], LT.CreatedDate as [CreatedDate], LT.TestTypeID as [TestTypeID], TT.Name as [TestTypeName], LT.AppointmentID as [AppointmentID], LT.PatientChargeID as [PatientChargeID], LT.CreatedByUserID as [CreatedByUserID], U.Username as [CreatedByUsername]
                                     from LabTests LT
                                     inner join TestTypes TT on TT.ID = LT.TestTypeID
                                     inner join Users U on U.ID = LT.CreatedByUserID
                                     where LT.ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                                return (reader["ID"] != DBNull.Value ? (int?)reader["ID"] : null, reader["Status"] != DBNull.Value ? (byte?)reader["Status"] : null, reader["ResultDate"] != DBNull.Value ? (DateTime?)reader["ResultDate"] : null, reader["Result"] != DBNull.Value ? (bool?)reader["Result"] : null, reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : null, reader["CreatedDate"] != DBNull.Value ? (DateTime?)reader["CreatedDate"] : null, reader["TestTypeID"] != DBNull.Value ? (byte?)reader["TestTypeID"] : null, reader["TestTypeName"] != DBNull.Value ? (string)reader["TestTypeName"] : null, reader["AppointmentID"] != DBNull.Value ? (int?)reader["AppointmentID"] : null, reader["PatientChargeID"] != DBNull.Value ? (int?)reader["PatientChargeID"] : null, reader["CreatedByUserID"] != DBNull.Value ? (int?)reader["CreatedByUserID"] : null, reader["CreatedByUsername"] != DBNull.Value ? (string)reader["CreatedByUsername"] : null);
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
                    string query = "select ID as [ID], PatientMedicalRecordNo as [Medical Record No], Status as [Status], Result as [Result], ResultDate as [Result Date], TestTypeName as [Test Type] from LabTestsData_View order by ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only";
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
                    string query = $"select ID as [ID], PatientMedicalRecordNo as [Medical Record No], Status as [Status], Result as [Result], ResultDate as [Result Date], TestTypeName as [Test Type] from LabTestsData_View where [{Filter}] like @Value order by ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Page", SqlDbType.Int).Value = Page;
                        cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = PageSize;
                        if (Filter == "ID" || Filter == "Status" || Filter == "TestTypeName")
                            cmd.Parameters.Add("@Value", SqlDbType.NVarChar).Value = Value;
                        else if (Filter == "PatientMedicalRecordNo")
                            cmd.Parameters.Add("@Value", SqlDbType.NVarChar).Value = $"{Value}%";
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
                    string query = @"select count(*) from LabTestsData_View;";
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
                    string query = $"select count(*) from LabTestsData_View where [{Filter}] like @Value";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (Filter == "ID" || Filter == "Status" || Filter == "TestTypeName")
                            cmd.Parameters.Add("@Value", SqlDbType.NVarChar).Value = Value;
                        else if (Filter == "PatientMedicalRecordNo")
                            cmd.Parameters.Add("@Value", SqlDbType.NVarChar).Value = $"{Value}%";
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

        public static async Task<int?> AddNewRecord(byte? TestTypeID, int? AppointmentID, int? CreatedByUserID)
        {
            int? NewRecordID = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AddNewLabTest", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter prmID = cmd.Parameters.Add("@LabTestID", SqlDbType.Int);
                        prmID.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add("@TestTypeID", SqlDbType.TinyInt).Value = TestTypeID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@AppointmentID", SqlDbType.Int).Value = AppointmentID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = CreatedByUserID ?? (object)DBNull.Value;
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

        public static async Task<bool> EditRecord(int? ID, byte? Status, DateTime? ResultDate, bool? Result, string Notes, DateTime? CreatedDate, byte? TestTypeID, int? AppointmentID, int? PatientChargeID, int? CreatedByUserID)
        {
            bool IsEdited = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "update LabTests set Status = @Status, ResultDate = @ResultDate, Result = @Result, Notes = @Notes, CreatedDate = @CreatedDate, TestTypeID = @TestTypeID, AppointmentID = @AppointmentID, PatientChargeID = @PatientChargeID, CreatedByUserID = @CreatedByUserID where ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = Status ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@ResultDate", SqlDbType.DateTime).Value = ResultDate ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Result", SqlDbType.Bit).Value = Result ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = Notes ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = CreatedDate ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@TestTypeID", SqlDbType.TinyInt).Value = TestTypeID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@AppointmentID", SqlDbType.Int).Value = AppointmentID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@PatientChargeID", SqlDbType.Int).Value = PatientChargeID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = CreatedByUserID ?? (object)DBNull.Value;
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

        public static async Task<bool> StartLabTestRecord(int? ID)
        {
            bool IsStarted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "update LabTests set Status = 2 where ID = @ID and Status = 1;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        IsStarted = (await cmd.ExecuteNonQueryAsync() > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                IsStarted = false;
            }
            return IsStarted;
        }
        
        public static async Task<bool> CompleteLabTestRecord(int? ID, bool? Result, string Notes)
        {
            bool IsCompleted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "update LabTests set Status = 3, Result = @Result, ResultDate = getdate(), Notes = @Notes where ID = @ID and Status = 2;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Result", SqlDbType.Bit).Value = Result ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Notes", SqlDbType.VarChar).Value = Notes ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        IsCompleted = (await cmd.ExecuteNonQueryAsync() > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                IsCompleted = false;
            }
            return IsCompleted;
        }

        public static async Task<(bool, decimal)> CancelLabTestRecord(int? ID)
        {
            bool IsCancelled = false;
            decimal RefundAmount = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CancelLabTest", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter prmRefundAmount = cmd.Parameters.Add("@RefundAmount", SqlDbType.SmallMoney);
                        prmRefundAmount.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add("@LabTestID", SqlDbType.Int).Value = ID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                        IsCancelled = true;
                        RefundAmount = prmRefundAmount.Value != DBNull.Value ? (decimal)prmRefundAmount.Value : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                IsCancelled = false;
            }
            return (IsCancelled, RefundAmount);

        }

        public static async Task<bool> DeleteRecord(int? ID)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "delete from LabTests where ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID ?? (object)DBNull.Value;
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