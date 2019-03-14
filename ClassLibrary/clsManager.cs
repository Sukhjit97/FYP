using System;

namespace ClassLibrary
{
    public class clsManager
    {
        public string Address { get; set; }
        public int ManagerID { get; set; }
        public string EmailAddress { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string TelephoneNumber { get; set; }

        public string Valid(string address, string emailAddress, string firstname, string surname, string password, string telephoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}