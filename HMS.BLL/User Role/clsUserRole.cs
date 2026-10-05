using HMS.DAL;
using System;
using System.Data;
using System.Threading.Tasks;

namespace HMS.BLL
{
    public partial class clsUserRole
    {
        private enum enMode { AddNew, Edit }
        private enMode _Mode;

        public byte? ID { get; set; }
        public string Name { get; set; }
        public short? Permissions { get; set; }

        public clsUserRole()
        {
            this._Mode = enMode.AddNew;
            this.ID = null;
            this.Name = null;
            this.Permissions = null;
        }

        private clsUserRole(byte? id, string name, short? permissions)
        {
            this._Mode = enMode.Edit;
            this.ID = id;
            this.Name = name;
            this.Permissions = permissions;
        }

        public static Task<bool> IsExist(string Name)
        {
            return clsUserRoleData.IsRecordExist(Name);
        }

        public static async Task<clsUserRole> Find(byte? id)
        {
            var UserRoleData = await clsUserRoleData.FindRecord(id);
            if (UserRoleData != null)
                return new clsUserRole(UserRoleData.Value.ID, UserRoleData.Value.Name, UserRoleData.Value.Permissions);
            else
                return null;
        }

        public static Task<DataTable> GetAll(bool GetPermissions = true)
        {
            return clsUserRoleData.GetAllRecords(GetPermissions);
        }

        private async Task<bool> _AddNew()
        {
            var result = await clsUserRoleData.AddNewRecord(Name);

            if (result != null)
            {
                this.ID = result.Value.ID;
                this.Permissions = result.Value.Permissions;
                return (this.ID != null && this.Permissions != null);
            }
            else
                return false;
        }

        private Task<bool> _Edit()
        {
            return clsUserRoleData.EditRecord(ID, Name, Permissions);
        }

        public async Task<bool> Save()
        {
            switch (this._Mode)
            {
                case enMode.AddNew:
                    if (await this._AddNew())
                    {
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

        public static Task<bool> Delete(byte? id)
        {
            return clsUserRoleData.DeleteRecord(id);
        }
    }
}