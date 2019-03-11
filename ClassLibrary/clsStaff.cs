using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int StaffID { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string TelephoneNumber { get; set; }

        public string Valid(string address, string emailAddress, string firstname, string surname, string password, string telephoneNumber)
        {
            //if the address field is not blank
            if (Address != "")
            {
                //return a blank string
                return "";

            }
            //if the email address field is not blankk
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
            else
            {
                //otherwise return an error message
                return "The fields may not be blank!";
            }
        }
    }
}