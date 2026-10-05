using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HMS.DAL;
using Common;

namespace HMS.BLL
{
    public partial class clsUser
    {
        private enum enMode { AddNew, Edit }
        private enMode _Mode;

        public int? ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public byte? UserRoleID { get; set; }
        public clsUserRole UserRole;

        public clsUser()
        {
            this._Mode = enMode.AddNew;
            this.ID = null;
            this.Username = null;
            this.Password = null;
            this.IsActive = null;
            this.CreatedDate = null;
            this.UserRoleID = null;
            this.UserRole = null;
        }

        private clsUser(int? id, string username, bool? isactive, DateTime? createddate, byte? userroleid, clsUserRole userrole)
        {
            this._Mode = enMode.Edit;
            this.ID = id;
            this.Username = username;
            this.Password = null;
            this.IsActive = isactive;
            this.CreatedDate = createddate;
            this.UserRoleID = userroleid;
            this.UserRole = userrole;
        }

        public static Task<bool> IsUsernameExist(string username)
        {
            return clsUserData.IsUsernameRecordExist(username);
        }

        public static Task<bool> IsPasswordCorrect(int? id, string password)
        {
            return clsUserData.IsPasswordRecordCorrect(id, clsUtility.ComputeHash(password));
        }

        public static Task<bool> ChangePassword(int? id, string newpassword)
        {
            return clsUserData.ChangePasswordRecord(id, clsUtility.ComputeHash(newpassword));
        }

        public static async Task<clsUser> Authenticate(string username, string password)
        {
            var UserData = await clsUserData.FindRecord(username, clsUtility.ComputeHash(password));
            if (UserData != null)
                return new clsUser(UserData.Value.ID, UserData.Value.Username, UserData.Value.IsActive, UserData.Value.CreatedDate, UserData.Value.UserRoleID, await clsUserRole.Find(UserData.Value.UserRoleID));
            else
                return null;
        }

        public static async Task<clsUser> Find(int? id)
        {
            var UserData = await clsUserData.FindRecord(id);
            if (UserData != null)
                return new clsUser(UserData.Value.ID, UserData.Value.Username, UserData.Value.IsActive, UserData.Value.CreatedDate, UserData.Value.UserRoleID, await clsUserRole.Find(UserData.Value.UserRoleID));
            else
                return null;
        }

        public static async Task<string> GetUsernameByID(int? id)
        {
            return await clsUserData.GetUsernameRecord(id);
        }

        public static Task<DataTable> GetPage(int Page, int PageSize)
        {
            return clsUserData.GetPageRecords(Page, PageSize);
        }

        public static Task<DataTable> GetPageByFilter(int Page, int PageSize, string Filter, string Value)
        {
            return clsUserData.GetPageRecordsByFilter(Page, PageSize, Filter, Value);
        }

        public static Task<int> GetCount()
        {
            return clsUserData.GetRecordsCount();
        }

        public static Task<int> GetCountByFilter(string Filter, string Value)
        {
            return clsUserData.GetRecordsCountByFilter(Filter, Value);
        }

        private async Task<bool> _AddNew()
        {
            this.ID = await clsUserData.AddNewRecord(Username, clsUtility.ComputeHash(Password), IsActive, UserRoleID);
            return this.ID.HasValue;
        }

        private Task<bool> _Edit()
        {
            return clsUserData.EditRecord(ID, Username, IsActive, CreatedDate, UserRoleID);
        }

        public async Task<bool> Save()
        {
            bool IsSaved = false;

            switch (this._Mode)
            {
                case enMode.AddNew:
                    IsSaved = await this._AddNew();

                    if (IsSaved)
                    {
                        this._Mode = enMode.Edit;
                        this.CreatedDate = DateTime.Now;
                    }
                    break;
                case enMode.Edit:

                    IsSaved = await this._Edit();

                    break;
                default:
                    IsSaved = false;
                    break;
            }

            if (UserRoleID.HasValue)
                UserRole = await clsUserRole.Find(UserRoleID.Value);

            return IsSaved;
        }

        public static Task<bool> Delete(int? id)
        {
            return clsUserData.DeleteRecord(id);
        }
    }
}