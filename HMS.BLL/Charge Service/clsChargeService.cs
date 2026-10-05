using HMS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace HMS.BLL
{
    public partial class clsChargeService
    {
        public static async Task<DataTable> GetAll()
        {
            return await clsChargeServiceData.GetAllRecords();
        }

        public static Task<bool> Delete(short? id)
        {
            return clsChargeServiceData.DeleteRecord(id);
        }
    }
}