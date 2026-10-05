using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HMS.DAL;

namespace HMS.BLL
{
    public partial class clsPerson
    {
        private enum enMode { AddNew, Edit }
        private enMode _Mode;

        public enum enGender { Female = 0, Male = 1 }

        public int? ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName}{" " + SecondName} {LastName}"; } }
        public DateTime? DateOfBirth { get; set; }
        public enGender? Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte[] PersonalImage { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUsername { get; set; }

        public clsPerson()
        {
            this._Mode = enMode.AddNew;
            this.ID = null;
            this.FirstName = null;
            this.SecondName = null;
            this.LastName = null;
            this.DateOfBirth = null;
            this.Gender = null;
            this.Email = null;
            this.Phone = null;
            this.PersonalImage = null;
            this.CreatedDate = null;
            this.CreatedByUserID = null;
            this.CreatedByUsername = null;
        }

        private clsPerson(int? id, string firstname, string secondname, string lastname, DateTime? dateofbirth, enGender? gender, string email, string phone, byte[] personalimage, DateTime? createddate, int? createdbyuserid, string createdbyusername)
        {
            this._Mode = enMode.Edit;
            this.ID = id;
            this.FirstName = firstname;
            this.SecondName = secondname;
            this.LastName = lastname;
            this.DateOfBirth = dateofbirth;
            this.Gender = gender;
            this.Email = email;
            this.Phone = phone;
            this.PersonalImage = personalimage;
            this.CreatedDate = createddate;
            this.CreatedByUserID = createdbyuserid;
            this.CreatedByUsername = createdbyusername;
        }

        public static async Task<clsPerson> Find(int? id)
        {
            var PersonData = await clsPersonData.FindRecord(id);
            if (PersonData != null)
                return new clsPerson(PersonData.Value.ID, PersonData.Value.FirstName, PersonData.Value.SecondName, PersonData.Value.LastName, PersonData.Value.DateOfBirth, PersonData.Value.Gender == true ? enGender.Male : enGender.Female, PersonData.Value.Email, PersonData.Value.Phone, PersonData.Value.PersonalImage, PersonData.Value.CreatedDate, PersonData.Value.CreatedByUserID, await clsUser.GetUsernameByID(PersonData.Value.CreatedByUserID));
            else
                return null;
        }

        public static Task<DataTable> GetPage(int Page, int PageSize)
        {
            return clsPersonData.GetPageRecords(Page, PageSize);
        }

        public static Task<DataTable> GetPageByFilter(int Page, int PageSize, string Filter, string Value)
        {
            return clsPersonData.GetPageRecordsByFilter(Page, PageSize, Filter, Value);
        }

        public static Task<int> GetCount()
        {
            return clsPersonData.GetRecordsCount();
        }

        public static Task<int> GetCountByFilter(string Filter, string Value)
        {
            return clsPersonData.GetRecordsCountByFilter(Filter, Value);
        }

        private async Task<bool> _AddNew()
        {
            this.ID = await clsPersonData.AddNewRecord(FirstName, SecondName, LastName, DateOfBirth, Gender == enGender.Male, Email, Phone, PersonalImage, CreatedByUserID);
            return this.ID.HasValue;
        }

        private Task<bool> _Edit()
        {
            return clsPersonData.EditRecord(ID, FirstName, SecondName, LastName, DateOfBirth, Gender == enGender.Male, Email, Phone, PersonalImage, CreatedDate, CreatedByUserID);
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
            return clsPersonData.DeleteRecord(id);
        }
    }
}