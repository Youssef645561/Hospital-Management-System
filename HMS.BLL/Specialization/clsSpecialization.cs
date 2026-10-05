using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HMS.DAL;

namespace HMS.BLL
{
    public partial class clsSpecialization
    {
        private enum enMode { AddNew, Edit }
        private enMode _Mode;

        public byte? ID { get; set; }
        public string Name { get; set; }

        public clsSpecialization()
        {
            this._Mode = enMode.AddNew;
            this.ID = null;
            this.Name = null;
        }

        private clsSpecialization(byte? id, string name)
        {
            this._Mode = enMode.Edit;
            this.ID = id;
            this.Name = name;
        }

        public static async Task<clsSpecialization> Find(byte? id)
        {
            var SpecializationData = await clsSpecializationData.FindRecord(id);
            if (SpecializationData != null)
                return new clsSpecialization(SpecializationData.Value.ID, SpecializationData.Value.Name);
            else
                return null;
        }

        public static Task<DataTable> GetAll()
        {
            return clsSpecializationData.GetAllRecords();
        }
    }
}