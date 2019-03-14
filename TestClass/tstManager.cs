using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestClass
{
    [TestClass]
    public class tstManager
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //test to see that it exists
            Assert.IsNotNull(AManager);
        }

        [TestMethod]
        public void AddressOk()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create some test data to assign to the property 
            String Address = "11";
            //assign the data to the property
            AManager.Address = Address;
            //test to see that the two values are the same
            Assert.AreEqual(AManager.Address, Address);
        }

        [TestMethod]
        public void ManagerIDOk()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create some test data to assign to the property 
            Int32 ManagerID = 1;
            //assign the data to the property
            AManager.ManagerID = ManagerID;
            //test to see that the two values are the same
            Assert.AreEqual(AManager.ManagerID, ManagerID);
        }

        [TestMethod]
        public void EmailAddressOk()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create some test data to assign to the property 
            String EmailAddress = "Kourtney.K@gmail.com";
            //assign the data to the property
            AManager.EmailAddress = EmailAddress;
            //test to see that the two values are the same
            Assert.AreEqual(AManager.EmailAddress, EmailAddress);
        }

        [TestMethod]
        public void FirstnameOk()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create some test data to assign to the property 
            String Firstname = "Kourtney";
            //assign the data to the property
            AManager.Firstname = Firstname;
            //test to see that the two values are the same
            Assert.AreEqual(AManager.Firstname, Firstname);
        }

        [TestMethod]
        public void SurnameOk()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create some test data to assign to the property 
            String Surname = "Kardashian";
            //assign the data to the property
            AManager.Surname = Surname;
            //test to see that the two values are the same
            Assert.AreEqual(AManager.Surname, Surname);
        }

        [TestMethod]
        public void PasswordOk()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create some test data to assign to the property 
            String Password = "MasonPR123";
            //assign the data to the property
            AManager.Password = Password;
            //test to see that the two values are the same
            Assert.AreEqual(AManager.Password, Password);
        }

        [TestMethod]
        public void TelephoneNumberOk()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create some test data to assign to the property 
            String TelephoneNumber = "01112234567";
            //assign the data to the property
            AManager.TelephoneNumber = TelephoneNumber;
            //test to see that the two values are the same
            Assert.AreEqual(AManager.TelephoneNumber, TelephoneNumber);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "Kam";
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}
