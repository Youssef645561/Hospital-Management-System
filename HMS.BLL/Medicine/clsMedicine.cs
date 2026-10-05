using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HMS.DAL;

namespace HMS.BLL
{
    public partial class clsMedicine
    {
        private enum enMode { AddNew, Edit }
        private enMode _Mode;

        public enum enDosageForm
        {
            Capsule = 1,
            Cream = 2,
            Drops = 3,
            Inhaler = 4,
            Injection = 5,
            Ointment = 6,
            Syrup = 7,
            Tablet = 8
        }

        public int? ID { get; set; }
        public string Name { get; set; }
        public enDosageForm? DosageForm { get; set; }
        public string Strength { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUsername { get; set; }

        public clsMedicine()
        {
            this._Mode = enMode.AddNew;
            this.ID = null;
            this.Name = null;
            this.DosageForm = null;
            this.Strength = null;
            this.Description = null;
            this.IsActive = null;
            this.CreatedDate = null;
            this.CreatedByUserID = null;
            this.CreatedByUsername = null;
        }

        private clsMedicine(int? id, string name, enDosageForm? dosageform, string strength, string description, bool? isactive, DateTime? createddate, int? createdbyuserid, string createdbyusername)
        {
            this._Mode = enMode.Edit;
            this.ID = id;
            this.Name = name;
            this.DosageForm = dosageform;
            this.Strength = strength;
            this.Description = description;
            this.IsActive = isactive;
            this.CreatedDate = createddate;
            this.CreatedByUserID = createdbyuserid;
            this.CreatedByUsername = createdbyusername;
        }

        public static async Task<clsMedicine> Find(int? id)
        {
            var MedicineData = await clsMedicineData.FindRecord(id);
            if (MedicineData != null)
                return new clsMedicine(MedicineData.Value.ID, MedicineData.Value.Name, (enDosageForm)MedicineData.Value.DosageForm, MedicineData.Value.Strength, MedicineData.Value.Description, MedicineData.Value.IsActive, MedicineData.Value.CreatedDate, MedicineData.Value.CreatedByUserID, await clsUser.GetUsernameByID(MedicineData.Value.CreatedByUserID));
            else
                return null;
        }

        public static Task<DataTable> GetPage(int Page, int PageSize)
        {
            return clsMedicineData.GetPageRecords(Page, PageSize);
        }

        public static Task<DataTable> GetPageByFilter(int Page, int PageSize, string Filter, string Value)
        {
            return clsMedicineData.GetPageRecordsByFilter(Page, PageSize, Filter, Value);
        }

        public static Task<int> GetCount()
        {
            return clsMedicineData.GetRecordsCount();
        }

        public static Task<int> GetCountByFilter(string Filter, string Value)
        {
            return clsMedicineData.GetRecordsCountByFilter(Filter, Value);
        }

        private async Task<bool> _AddNew()
        {
            this.ID = await clsMedicineData.AddNewRecord(Name, (byte?)DosageForm, Strength, Description, IsActive, CreatedByUserID);
            return this.ID.HasValue;
        }

        private Task<bool> _Edit()
        {
            return clsMedicineData.EditRecord(ID, Name, (byte?)DosageForm, Strength, Description, IsActive, CreatedDate, CreatedByUserID);
        }

        public async Task<bool> Save()
        {
            switch (this._Mode)
            {
                case enMode.AddNew:
                    if (await this._AddNew())
                    {
                        this.CreatedDate = DateTime.Now;
                        this._Mode = enMode.Edit;
                        return true;
                    }
                    else
                        return false;
                case enMode.Edit:
                    return await this._Edit();
                default:
                    return false;
            }
        }

        public static Task<bool> Delete(int? id)
        {
            return clsMedicineData.DeleteRecord(id);
        }
    }
}