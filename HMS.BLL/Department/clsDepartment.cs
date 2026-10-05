using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HMS.DAL;

namespace HMS.BLL
{
    public partial class clsDepartment
    {
        private enum enMode { AddNew, Edit }
        private enMode _Mode;

        public byte? ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public clsDepartment()
        {
            this._Mode = enMode.AddNew;
            this.ID = null;
            this.Name = null;
            this.Description = null;
        }

        private clsDepartment(byte? id, string name, string description)
        {
            this._Mode = enMode.Edit;
            this.ID = id;
            this.Name = name;
            this.Description = description;
        }

        public static async Task<clsDepartment> Find(byte? id)
        {
            var DepartmentData = await clsDepartmentData.FindRecord(id);
            if (DepartmentData != null)
                return new clsDepartment(DepartmentData.Value.ID, DepartmentData.Value.Name, DepartmentData.Value.Description);
            else
                return null;
        }

        public static Task<DataTable> GetAll()
        {
            return clsDepartmentData.GetAllRecords();
        }

        public static Task<bool> Delete(byte? id)
        {
            return clsDepartmentData.DeleteRecord(id);
        }
    }
}