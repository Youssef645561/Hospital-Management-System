using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using Common;

namespace HMS.DAL
{
    public static class clsPaymentData
    {
        public static async Task<(int? ID, decimal? PaidAmount, byte? Method, Guid? TransactionNo, byte? Status, DateTime? CreatedDate, int? PatientChargeID, int? CreatedByUserID, string CreatedByUsername)?> FindRecord(int? ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = @"select Payments.ID as [ID], Payments.PaidAmount as [PaidAmount], Payments.Method as [Method], Payments.TransactionNo as [TransactionNo], Payments.Status as [Status], Payments.CreatedDate as [CreatedDate], Payments.PatientChargeID as [PatientChargeID], Payments.CreatedByUserID as [CreatedByUserID], Users.Username as [CreatedByUsername]
                                     from Payments
                                     inner join Users on Users.ID = Payments.CreatedByUserID
                                     where Payments.ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                                return (reader["ID"] != DBNull.Value ? (int?)reader["ID"] : null, reader["PaidAmount"] != DBNull.Value ? (decimal?)reader["PaidAmount"] : null, reader["Method"] != DBNull.Value ? (byte?)reader["Method"] : null, reader["TransactionNo"] != DBNull.Value ? (Guid?)reader["TransactionNo"] : null, reader["Status"] != DBNull.Value ? (byte?)reader["Status"] : null, reader["CreatedDate"] != DBNull.Value ? (DateTime?)reader["CreatedDate"] : null, reader["PatientChargeID"] != DBNull.Value ? (int?)reader["PatientChargeID"] : null, reader["CreatedByUserID"] != DBNull.Value ? (int?)reader["CreatedByUserID"] : null, reader["CreatedByUsername"] != DBNull.Value ? (string)reader["CreatedByUsername"] : null);
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

        public static async Task<DataTable> GetAllRecordsByPatientChargeID(int? PatientChargeID)
        {
            DataTable dtRecords = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "select ID as [ID], PaidAmount as [PaidAmount], dbo.GetPaymentMethod(Method) as [Method], dbo.GetPaymentStatus(Status) as [Status], PatientChargeID as [PatientChargeID] from Payments where PatientChargeID = @PatientChargeID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@PatientChargeID", SqlDbType.Int).Value = PatientChargeID ?? (object)DBNull.Value;
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
                    string query = "select ID as [ID], PaidAmount as [PaidAmount], dbo.GetPaymentMethod(Method) as [Method], dbo.GetPaymentStatus(Status) as [Status], PatientChargeID as [PatientChargeID] from Payments order by ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only";
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
                    string query = $"select ID as [ID], PaidAmount as [PaidAmount], dbo.GetPaymentMethod(Method) as [Method], dbo.GetPaymentStatus(Status) as [Status], PatientChargeID as [PatientChargeID] from Payments where [{Filter}] like @Value order by ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Page", SqlDbType.Int).Value = Page;
                        cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = PageSize;
                        if (Filter == "ID" || Filter == "Method" || Filter == "Status")
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
                    string query = @"select count(*) from Payments;";
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
                    string query = $"select count(*) from Payments where [{Filter}] like @Value";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (Filter == "ID" || Filter == "Method" || Filter == "Status")
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

        public static async Task<(int? ID, Guid? TransactionNo)> AddNewRecord(decimal? PaidAmount, byte? Method, int? PatientChargeID, int? CreatedByUserID)
        {
            int? NewRecordID = null;
            Guid? NewRecordTransactionNo = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AddNewPayment", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter InsertedID = cmd.Parameters.Add("@PaymentID", SqlDbType.Int);
                        InsertedID.Direction = ParameterDirection.Output;

                        SqlParameter InsertedTransactionNo = cmd.Parameters.Add("@TransactionNo", SqlDbType.UniqueIdentifier);
                        InsertedTransactionNo.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add("@PaidAmount", SqlDbType.Decimal).Value = PaidAmount ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Method", SqlDbType.TinyInt).Value = Method ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@PatientChargeID", SqlDbType.Int).Value = PatientChargeID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = CreatedByUserID ?? (object)DBNull.Value;
                        
                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();

                        NewRecordID = (InsertedID.Value == DBNull.Value) ? null : (int?)InsertedID.Value;
                        NewRecordTransactionNo = (InsertedTransactionNo.Value == DBNull.Value) ? null : (Guid?)InsertedTransactionNo.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                NewRecordID = null;
                NewRecordTransactionNo = null;
            }
            return (NewRecordID, NewRecordTransactionNo);
        }

        public static async Task<(bool IsRefunded, decimal RefundAmount)> RefundPaymentRecord(int? ID)
        {
            bool IsRefunded = false;
            decimal RefundAmount = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_RefundPayment", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter prmRefundAmount = cmd.Parameters.Add("@RefundAmount", SqlDbType.SmallMoney);
                        prmRefundAmount.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add("@PaymentID", SqlDbType.Int).Value = ID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                        IsRefunded = true;
                        RefundAmount = Convert.ToDecimal(prmRefundAmount.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                IsRefunded = false;
            }
            return (IsRefunded, RefundAmount);
        }
    }
}