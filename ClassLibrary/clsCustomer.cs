using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the CustomerID property
        private Int32 mCustomerID;
        //private data member for Active
        private Boolean mActive;
        //private data member for the Address
        private string mAddress;
        //private data member for Date Registered
        private DateTime mDateRegistered;
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


        //public property for active
        public bool Active
        {
            get
            {
                //return the private data 
                return mActive;
            }
            set
            {
                //set the private data 
                mActive = value;
            }
        }

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

        //public property for date registered
        public DateTime DateRegistered
        {
            get
            {
                //return the private data 
                return mDateRegistered;
            }
            set
            {
                //set the private data
                mDateRegistered = value;
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

        public string Valid(string Address, string DateRegistered, string EmailAddress, string Firstname, string Surname, string Password, string TelephoneNumber)
        {
            //string variable to store the error message
            string Error = "";
            //create a temporary vairable to store date values
            DateTime DateTemp;
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
            try
            {
                //copy the DateRegistered value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateRegistered);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check the see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";

            }
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
            //if the password field is more than 16 characters
            if (Password.Length > 16)
            {
                //return an error message
                Error = "The password field cannot have more than 16 characters";
            }
            if (Password.Length == 0)
            {
                //retrun an error message
                Error = "The password field may not be blank!";
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
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDateRegistered = Convert.ToDateTime(DB.DataTable.Rows[0]["DateRegistered"]);
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