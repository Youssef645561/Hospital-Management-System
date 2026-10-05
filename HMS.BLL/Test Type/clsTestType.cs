using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HMS.DAL;

namespace HMS.BLL
{
    public partial class clsTestType
    {
        public static async Task<DataTable> GetAll()
        {
            //List<clsTestType> lTestTypes = new List<clsTestType>();

            //DataTable dtTestTypes = await clsTestTypeData.GetAllRecords();

            //foreach (DataRow row in dtTestTypes.Rows)
            //    lTestTypes.Add(_ConvertDataRowToObj(row));

            return await clsTestTypeData.GetAllRecords();
        }
    }
}