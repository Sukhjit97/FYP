using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the CustomerID property
        private Int32 mCustomerID;
        //private data member for the Address
        private string mAddress;
        //private data member for Email Address
        private string mEmailAddress;
        //private data member for Firstname
        private string mFirstname;
        //private data member for Surname
        private string mSurname;
        //private data member for Password
        private string mPassword;
        //private data member for TelephoneNumber
        private string mTelephoneNumber;
        //private int member for RoleId
        private int mRoleId;


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

        //public property for the customer id
        public int CustomerID
        {
            get
            {
                //return the private data 
                return mCustomerID;
            }
            set
            {
                //set the value of the private data member
                mCustomerID = value;
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

        //public property for password
        public string Password
        {
            get
            {
                //return the private data 
                return mPassword;
            }
            set
            {
                //set the private data 
                mPassword = value;
            }
        }

        //public property for roleid
        public int RoleId
        {
            get
            {
                //return the private data 
                return mRoleId;
            }
            set
            {
                //set the private data 
                mRoleId = value;
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

        public string Valid(string Address, string EmailAddress, string Firstname, string Surname, string Password, string TelephoneNumber, int RoleId)
        {
            //string variable to store the error message
            String Error = "";
            //if the address field is more than 50 characters 
            if (Address.Length > 50)
            {
                //return an error message
                Error = Error + "The address field cannot have more than 50 characters";
            }
            if (Address.Length == 0)
            {
                //retrun an error message
                Error = Error + "The address field may not be blank!";
            }
            
            if (EmailAddress.Length > 50)
            {
                //return an error message
                Error = Error + "The email address field cannot have more than 50 characters";
            }
            if (EmailAddress.Length == 0)
            {
                //retrun an error message
                Error = Error + "The email address field may not be blank!";
            }
            //if the firstname field is more than 50 characters
            if (Firstname.Length > 50)
            {
                //return an error message
                Error = Error + "The firstname field cannot have more than 50 characters";
            }
            if (Firstname.Length == 0)
            {
                //retrun an error message
                Error = Error + "The firstname field may not be blank!";
            }
            //if the surname field is more than 50 characters
            if (Surname.Length > 50)
            {
                //return an error message
                Error = Error + "The surname field cannot have more than 50 characters";
            }
            if (Surname.Length == 0)
            {
                //retrun an error message
                Error = Error + "The surname field may not be blank!";
            }
            //if the password field is more than 16 characters
            if (Password.Length > 16)
            {
                //return an error message
                Error = Error + "The password field cannot have more than 16 characters";
            }
            if (Password.Length == 0)
            {
                //retrun an error message
                Error = Error + "The password field may not be blank!";
            }
            //if the telephone number field is more than 11 characters
            if (TelephoneNumber.Length > 11)
            {
                //return an error message
                Error = Error + "The telephone number field cannot have more than 11 characters";
            }
            if (TelephoneNumber.Length == 0)
            {
                //retrun an error message
                Error = Error + "The telephone number field may not be blank!";
            }
            //return any error messages
            return Error;
        }

        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for 
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mFirstname = Convert.ToString(DB.DataTable.Rows[0]["Firstname"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
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