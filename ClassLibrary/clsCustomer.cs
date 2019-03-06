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
            return Error;




            //if the date registered field is not blank
            if (DateRegistered != "")
            {
                //return a blank string
                return "";
            }
            //if the email address field is not blank
            if (EmailAddress != "")
            {
                //return a blank string
                return "";
            }
            //if the firstname field is not blank
            if (Firstname != "")
            {
                //return a blank string
                return "";
            }
            //if the surname field is not blank
            if (Surname != "")
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
