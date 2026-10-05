using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using Common;

namespace HMS.DAL
{
    public static class clsPrescriptionData
    {
        public static async Task<(int? ID, DateTime? ExpirationDate, byte? Status, int? MedicalVisitID, DataTable dtMedicines, int? CreatedByUserID, string CreatedByUsername)?> FindRecord(int? ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = @"select Prescriptions.ID as [ID], Prescriptions.ExpirationDate as [ExpirationDate], Prescriptions.Status as [Status], Prescriptions.MedicalVisitID as [MedicalVisitID], Prescriptions.CreatedByUserID as [CreatedByUserID], Users.Username as [CreatedByUsername]
                                     from Prescriptions
                                     inner join Users on Users.ID = Prescriptions.CreatedByUserID
                                     where Prescriptions.ID = @ID;

                                     select MedicinesData_View.ID, Name, [Dosage Form], Strength, Active
                                     from MedicinesData_View
                                     inner join PrescriptionMedicines on PrescriptionMedicines.MedicineID = MedicinesData_View.ID
                                     where PrescriptionMedicines.PrescriptionID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID ?? (object)DBNull.Value;
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                int? PrescriptionID = reader["ID"] != DBNull.Value ? (int?)reader["ID"] : null;
                                DateTime? ExpirationDate = reader["ExpirationDate"] != DBNull.Value ? (DateTime?)reader["ExpirationDate"] : null;
                                byte? Status = reader["Status"] != DBNull.Value ? (byte?)reader["Status"] : null;
                                int? MedicalVisitID = reader["MedicalVisitID"] != DBNull.Value ? (int?)reader["MedicalVisitID"] : null;
                                int? CreatedByUserID = reader["CreatedByUserID"] != DBNull.Value ? (int?)reader["CreatedByUserID"] : null;
                                string CreatedByUsername = reader["CreatedByUsername"] != DBNull.Value ? (string)reader["CreatedByUsername"] : null;

                                if(reader.NextResult())
                                {
                                    DataTable dtMedicines = new DataTable();
                                    dtMedicines.Load(reader);
                                    return (PrescriptionID, ExpirationDate, Status, MedicalVisitID, dtMedicines, CreatedByUserID, CreatedByUsername);
                                }
                            }
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
                    string query = "select ID as [ID], dbo.GetPrescriptionStatus(Status) as [Status], ExpirationDate as [Expiration Date], MedicalVisitID as [Medical Visit ID] from Prescriptions order by ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only";
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
                    string query = $"select ID as [ID], dbo.GetPrescriptionStatus(Status) as [Status], ExpirationDate as [Expiration Date], MedicalVisitID as [Medical Visit ID] from Prescriptions where [{Filter}] like @Value order by ID offset ((@Page - 1) * @PageSize) rows fetch next @PageSize rows only";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Page", SqlDbType.Int).Value = Page;
                        cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = PageSize;
                        if (Filter == "ID" || Filter == "Status" || Filter == "MedicalVisitID")
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
                    string query = @"select count(*) from Prescriptions;";
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
                    string query = $"select count(*) from Prescriptions where [{Filter}] like @Value";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (Filter == "ID" || Filter == "Status" || Filter == "MedicalVisitID")
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

        public static async Task<int?> AddNewRecord(DateTime? ExpirationDate, int? MedicalVisitID, DataTable dtMedicineIDs, int? CreatedByUserID)
        {
            int? NewRecordID = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AddNewPrescription", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter prmID = cmd.Parameters.Add("@PrescriptionID", SqlDbType.Int);
                        prmID.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add("@ExpirationDate", SqlDbType.DateTime).Value = ExpirationDate ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@MedicalVisitID", SqlDbType.Int).Value = MedicalVisitID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@MedicineIDs", SqlDbType.Structured).Value = dtMedicineIDs;
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

        public static async Task<bool> EditRecord(int? ID, DateTime? ExpirationDate, byte? Status, int? MedicalVisitID, DataTable dtMedicineIDs, int? CreatedByUserID)
        {
            bool IsEdited = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_EditPrescription", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@PrescriptionID", SqlDbType.Int).Value = ID ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@ExpirationDate", SqlDbType.DateTime).Value = ExpirationDate ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = Status ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@MedicineIDs", SqlDbType.Structured).Value = dtMedicineIDs;
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

        public static async Task<bool> DeleteRecord(int? ID)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    string query = "delete from Prescriptions where ID = @ID";
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