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
            //return the value Error
            return Error;


            //if the date registered field is not blank
            if (DateRegistered != "")
            {
                //return a blank string
                return "";
            }
            //if the password field is not blank
            if (Password != "")
            {
                //return a blank string
                return "";
            }
            //if the telephone number field is not blank
            if (TelephoneNumber != "")
            {
                //return a blank string
                return "";
            }
        }
    }
}
