using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public string Address { get; set; }
        public int CustomerID { get; set; }
        public DateTime DateRegistered { get; set; }
        public string EmailAddress { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string TelephoneNumber { get; set; }

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
    }
}