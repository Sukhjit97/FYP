using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestClass
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffIDOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            Int32 StaffID = 1;
            //assign the data to the property
            AStaff.StaffID = StaffID;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, StaffID);
        }

        [TestMethod]
        public void AddressOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            String Address = "1a";
            //assign the data to the property
            AStaff.Address = Address;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Address, Address);
        }

        [TestMethod]
        public void EmailAddressOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            String EmailAddress = "d_1@homtail.co.uk";
            //assign the data to the property
            AStaff.EmailAddress = EmailAddress;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.EmailAddress, EmailAddress);
        }

        [TestMethod]
        public void FirstnameOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            String Firstname = "Diljit";
            //assign the data to the property
            AStaff.Firstname = Firstname;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Firstname, Firstname);
        }

        [TestMethod]
        public void SurnameOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff(); ;
            //create some test data to assign to the property 
            String Surname = "Sanghera";
            //assign the data to the property
            AStaff.Surname = Surname;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Surname, Surname);
        }

        [TestMethod]
        public void PasswordOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            String Password = "abc";
            //assign the data to the property
            AStaff.Password = Password;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Password, Password);
        }

        [TestMethod]
        public void TelephoneNumberOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            String TelephoneNumber = "01163456788";
            //assign the data to the property
            AStaff.TelephoneNumber = TelephoneNumber;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.TelephoneNumber, TelephoneNumber);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "Kerry";
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
