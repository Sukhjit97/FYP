﻿using System;

namespace ClassLibrary
{
    public class clsManager
    {
        //private data member for the Address
        private string mAddress;
        //private data member for the ManagerID property
        private Int32 mManagerID;
        //private data member for Email Address
        private string mEmailAddress;
        //private data member for Firstname
        private string mFirstname;
        //private data member for Surname
        private string mSurname;
        //private data member for TelephoneNumber
        private string mTelephoneNumber;


        //public property for address
        public string Address
        {
            get
            {
                //return the private data 
                return mAddress;
            }
            set
            {
                //set the private data
                mAddress = value;
            }
        }

        //public property for the manager id
        public int ManagerID
        {
            get
            {
                //return the private data 
                return mManagerID;
            }
            set
            {
                //set the value of the private data member
                mManagerID = value;
            }
        }

        //public property for email address
        public string EmailAddress
        {
            get
            {
                //return the private data 
                return mEmailAddress;
            }
            set
            {
                //set the private data 
                mEmailAddress = value;
            }
        }

        //public property for firstname
        public string Firstname
        {
            get
            {
                //return the private data 
                return mFirstname;
            }
            set
            {
                //set the private data 
                mFirstname = value;
            }
        }

        //public property for surname
        public string Surname
        {
            get
            {
                //return the private data 
                return mSurname;
            }
            set
            {
                //set the private data 
                mSurname = value;
            }
        }

        //public property for TelephoneNumber
        public string TelephoneNumber
        {
            get
            {
                //return the private data 
                return mTelephoneNumber;
            }
            set
            {
                //set the private data 
                mTelephoneNumber = value;
            }
        }

        public string Valid(string Address, string EmailAddress, string Firstname, string Surname, string Password, string TelephoneNumber)
        {
            //string variable to store the error message
            string Error = "";
            //if the address field is more than 50 characters
            if (Address.Length > 50)
            {
                //return an error message
                Error = "The address field cannot have more than 50 characters";
            }
            if (Address.Length == 0)
            {
                //retrun an error message
                Error = "The address field may not be blank!";
            }
            //if the email address field is more than 50 characters
            if (EmailAddress.Length > 50)
            {
                //return an error message
                Error = "The email address field cannot have more than 50 characters";
            }
            if (EmailAddress.Length == 0)
            {
                //retrun an error message
                Error = "The email address field may not be blank!";
            }
            //if the firstname field is more than 50 characters
            if (Firstname.Length > 50)
            {
                //return an error message
                Error = "The firstname field cannot have more than 50 characters";
            }
            if (Firstname.Length == 0)
            {
                //retrun an error message
                Error = "The firstname field may not be blank!";
            }
            //if the surname field is more than 50 characters
            if (Surname.Length > 50)
            {
                //return an error message
                Error = "The surname field cannot have more than 50 characters";
            }
            if (Surname.Length == 0)
            {
                //retrun an error message
                Error = "The surname field may not be blank!";
            }           
            //if the telephone number field is more than 11 characters
            if (TelephoneNumber.Length > 11)
            {
                //return an error message
                Error = "The telephone number field cannot have more than 11 characters";
            }
            if (TelephoneNumber.Length == 0)
            {
                //retrun an error message
                Error = "The telephone number field may not be blank!";
            }
            //return any error messages
            return Error;
        }

        public bool Find(int ManagerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the manager id to search for 
            DB.AddParameter("@ManagerID", ManagerID);
            //execute the stored procedure
            DB.Execute("sproc_tblManager_FilterByManagerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mManagerID = Convert.ToInt32(DB.DataTable.Rows[0]["ManagerID"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mFirstname = Convert.ToString(DB.DataTable.Rows[0]["Firstname"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                mTelephoneNumber = Convert.ToString(DB.DataTable.Rows[0]["TelephoneNumber"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}