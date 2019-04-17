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

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = ""; //this should trigger an error
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "Kam";
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinBoundary()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "m"; //this should be ok
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

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "mm"; //this should be ok
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

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm"; //this should be ok
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

        [TestMethod]
        public void AddressMaxBoundary()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm"; //this should be ok
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

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm"; //this should trigger an error
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "Kam";
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "mmmmmmmmmmmmmmmmmmmmmmmmm"; ///this should be ok
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

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "";
            Address = Address.PadRight(500, 'm'); //this should fail
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "Kam";
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = ""; //this should trigger an error
            string Firstname = "Kam";
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinBoundary()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "k"; //this should be ok
            string Firstname = "Kam";
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "kk"; //this should be ok
            string Firstname = "Kam";
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk"; //this should be ok
            string Firstname = "Kam";
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxBoundary()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk"; //this should be ok
            string Firstname = "Kam";
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk"; //this should trigger an error
            string Firstname = "Kam";
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "kkkkkkkkkkkkkkkkkkkkkkkkk"; //this should be ok
            string Firstname = "Kam";
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(500, 'k'); //this should fail
            string Firstname = "Kam";
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = ""; //this should trigger an error
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMinBoundary()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "k"; //this should be ok
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "kk"; //this should be ok
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk"; //this should be ok
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk"; //this should be ok
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk"; //this should trigger an error
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMid()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "kkkkkkkkkkkkkkkkkkkkkkkkk"; //this should be ok
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "Kam";
            Firstname = Firstname.PadRight(500, 'k'); //this should fail
            string Surname = "Kaur";
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "Kam";
            string Surname = "";  //this should trigger an error
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMinBoundary()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "Kam";
            string Surname = "k";  //this should be ok
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "Kam";
            string Surname = "kk";  //this should be ok
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "Kam";
            string Surname = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk";  //this should be ok
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "Kam";
            string Surname = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk";  //this should be ok
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "Kam";
            string Surname = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk";  //this should trigger an error
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMid()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "Kam";
            string Surname = "kkkkkkkkkkkkkkkkkkkkkkkkk";  //this should be ok
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "14 Mayfair Street";
            string EmailAddress = "Kam.Kaur@gmail.com";
            string Firstname = "Kam";
            string Surname = "";
            Surname = Surname.PadRight(500, 'k'); //this should fail
            string Password = "NewYork!";
            string TelephoneNumber = "01169877896";
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMinLessOne()
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
            string TelephoneNumber = ""; //this should trigger an error
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMinBoundary()
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
            string TelephoneNumber = "0"; //this should be ok
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMinPlusOne()
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
            string TelephoneNumber = "01"; //this should be ok
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMaxLessOne()
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
            string TelephoneNumber = "0123456789"; //this should be ok
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMaxBoundary()
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
            string TelephoneNumber = "01234567890"; //this should be ok
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMaxPlusOne()
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
            string TelephoneNumber = "012345678901"; //this should trigger an error
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMid()
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
            string TelephoneNumber = "01234"; //this should be ok
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberExtremeMax()
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
            string TelephoneNumber = "";
            TelephoneNumber = TelephoneNumber.PadRight(500, '0'); //this should fail
            //invoke the method
            Error = AManager.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //boolen variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 ManagerID = 22;
            //invoke the method
            Found = AManager.Find(ManagerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestManagerIDFound()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 ManagerID = 22;
            //invoke the method
            Found = AManager.Find(ManagerID);
            //check the manager id
            if (AManager.ManagerID != 22)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 ManagerID = 22;
            //invoke the method
            Found = AManager.Find(ManagerID);
            //check the property
            if (AManager.Address != "2 Millstone Lane")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailAddressFound()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 ManagerID = 22;
            //invoke the method
            Found = AManager.Find(ManagerID);
            //check the property
            if (AManager.EmailAddress != "admin@admin.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstnameFound()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 ManagerID = 22;
            //invoke the method
            Found = AManager.Find(ManagerID);
            //check the property
            if (AManager.Firstname != "John")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSurnameFound()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 ManagerID = 22;
            //invoke the method
            Found = AManager.Find(ManagerID);
            //check the property
            if (AManager.Surname != "Snow")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTelephoneNumberFound()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 ManagerID = 22;
            //invoke the method
            Found = AManager.Find(ManagerID);
            //check the property
            if (AManager.TelephoneNumber != "45698521654")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
