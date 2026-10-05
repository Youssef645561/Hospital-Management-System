using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using Common;

namespace HMS.DAL
{
    public static class clsPatientChargeData
    {
        public static async Task<bool> IsRecordExist(int? AppointmentID, short? ChargeServiceID, byte? TestTypeID)
        {
            bool IsExist = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_IsPatientChargeRecordExist", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter prmIsExist = cmd.Parameters.Add("@prmIsExist", SqlDbType.Bit);
                        prmIsExist.Direction = ParameterDirection.ReturnValue;

                        cmd.Parameters.Add("@AppointmentID", SqlDbType.Int).Value = AppointmentID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@ChargeServiceID", SqlDbType.SmallInt).Value = ChargeServiceID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@TestTypeID", SqlDbType.TinyInt).Value = TestTypeID ?? (object)DBNull.Value;

                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                        IsExist = Convert.ToBoolean(prmIsExist.Value);
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

        public static async Task<(int? ID, decimal? ServiceFees, decimal? TotalOriginalFees, decimal? DiscountedFees, decimal? PaidFees, decimal? RemainingFees, decimal? DiscountPercentage, byte? Status, DateTime? CreatedDate, int? AppointmentID, short? ChargeServiceID, string ChargeServiceName, byte? TestTypeID, int? CreatedByUserID, string CreatedByUsername)?> FindRecord(int? ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = @"select PatientCharges.ID as [ID], PatientCharges.ServiceFees as [ServiceFees], PatientCharges.TotalOriginalFees as [TotalOriginalFees], PatientCharges.DiscountedFees as [DiscountedFees], PatientCharges.PaidFees as [PaidFees], PatientCharges.RemainingFees as [RemainingFees], PatientCharges.DiscountPercentage as [DiscountPercentage], PatientCharges.Status as [Status], PatientCharges.CreatedDate as [CreatedDate], PatientCharges.AppointmentID as [AppointmentID], PatientCharges.ChargeServiceID as [ChargeServiceID], concat_ws(' - ', ChargeServices.Name, TestTypes.Name)as [ChargeServiceName], PatientCharges.TestTypeID, PatientCharges.CreatedByUserID as [CreatedByUserID], Users.Username as [CreatedByUsername]
                                     from PatientCharges
                                     inner join ChargeServices on ChargeServices.ID = PatientCharges.ChargeServiceID
                                     inner join Users on Users.ID = PatientCharges.CreatedByUserID
									 left join TestTypes on TestTypes.ID = PatientCharges.TestTypeID
                                     where PatientCharges.ID = @ID;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                                return (reader["ID"] != DBNull.Value ? (int?)reader["ID"] : null, reader["ServiceFees"] != DBNull.Value ? (decimal?)reader["ServiceFees"] : null, reader["TotalOriginalFees"] != DBNull.Value ? (decimal?)reader["TotalOriginalFees"] : null, reader["DiscountedFees"] != DBNull.Value ? (decimal?)reader["DiscountedFees"] : null, reader["PaidFees"] != DBNull.Value ? (decimal?)reader["PaidFees"] : null, reader["RemainingFees"] != DBNull.Value ? (decimal?)reader["RemainingFees"] : null, reader["DiscountPercentage"] != DBNull.Value ? (decimal?)reader["DiscountPercentage"] : null, reader["Status"] != DBNull.Value ? (byte?)reader["Status"] : null, reader["CreatedDate"] != DBNull.Value ? (DateTime?)reader["CreatedDate"] : null, reader["AppointmentID"] != DBNull.Value ? (int?)reader["AppointmentID"] : null, reader["ChargeServiceID"] != DBNull.Value ? (short?)reader["ChargeServiceID"] : null, reader["ChargeServiceName"] != DBNull.Value ? (string)reader["ChargeServiceName"] : null, reader["TestTypeID"] != DBNull.Value ? (byte?)reader["TestTypeID"] : null, reader["CreatedByUserID"] != DBNull.Value ? (int?)reader["CreatedByUserID"] : null, reader["CreatedByUsername"] != DBNull.Value ? (string)reader["CreatedByUsername"] : null);
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
                    string query = "select ID as [ID], DiscountedFees as [Fees], PaidFees as [Paid], RemainingFees as [Remaining], dbo.GetChargeStatus(Status) as [Status], Status as [StatusNum],AppointmentID as [Appointment ID] from PatientCharges order by ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only";
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
                    string query = $"select ID as [ID], DiscountedFees as [Fees], PaidFees as [Paid], RemainingFees as [Remaining], dbo.GetChargeStatus(Status) as [Status], Status as [StatusNum], AppointmentID as [Appointment ID] from PatientCharges where [{Filter}] like @Value order by ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Page", SqlDbType.Int).Value = Page;
                        cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = PageSize;
                        if (Filter == "ID" || Filter == "Status" || Filter == "AppointmentID" || Filter == "ChargeServiceID" || Filter == "CreatedByUserID")
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
                    string query = @"select count(*) from PatientCharges;";
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
                    string query = $"select count(*) from PatientCharges where [{Filter}] like @Value";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (Filter == "ID" || Filter == "Status" || Filter == "AppointmentID" || Filter == "ChargeServiceID" || Filter == "CreatedByUserID")
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

        public static async Task<int?> AddNewRecord(decimal? ServiceFees, decimal? TotalOriginalFees, decimal? DiscountPercentage, int? AppointmentID, short? ChargeServiceID, byte? TestTypeID, int? CreatedByUserID)
        {
            int? NewRecordID = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AddNewPatientCharge", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ServiceFees", SqlDbType.Decimal).Value = ServiceFees ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@TotalOriginalFees", SqlDbType.Decimal).Value = TotalOriginalFees ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@DiscountPercentage", SqlDbType.Decimal).Value = DiscountPercentage ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@AppointmentID", SqlDbType.Int).Value = AppointmentID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@ChargeServiceID", SqlDbType.SmallInt).Value = ChargeServiceID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@TestTypeID", SqlDbType.TinyInt).Value = TestTypeID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = CreatedByUserID ?? (object)DBNull.Value;

                        SqlParameter InsertedID = cmd.Parameters.Add("@ID", SqlDbType.Int);
                        InsertedID.Direction = ParameterDirection.ReturnValue;

                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();

                        NewRecordID = InsertedID.Value == DBNull.Value ? null : (int?)InsertedID.Value;
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

        public static async Task<bool> EditRecord(int? ID, decimal? OriginalFees, decimal? DiscountPercentage, short? ChargeServiceID)
        {
            bool IsEdited = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "update PatientCharges set OriginalFees = @OriginalFees, DiscountPercentage = @DiscountPercentage, ChargeServiceID = @ChargeServiceID where ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@OriginalFees", SqlDbType.Decimal).Value = OriginalFees ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@DiscountPercentage", SqlDbType.Decimal).Value = DiscountPercentage ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@ChargeServiceID", SqlDbType.SmallInt).Value = ChargeServiceID ?? (object)DBNull.Value;
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

        public static async Task<decimal?> CancelRecord(int? ID)
        {
            decimal? RefundAmount = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CancelPatientCharge", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter prmRefundAmount = cmd.Parameters.Add("@RefundAmount", SqlDbType.SmallMoney);
                        prmRefundAmount.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add("@PatientChargeID", SqlDbType.Int).Value = ID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                        RefundAmount = prmRefundAmount.Value == DBNull.Value ? null : (decimal?)prmRefundAmount.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                RefundAmount = null;
            }
            return RefundAmount;
        }

        public static async Task<bool> DeleteRecord(int? ID)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "delete from PatientCharges where ID = @ID";
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