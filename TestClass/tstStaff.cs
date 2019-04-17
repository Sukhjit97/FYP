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
            String Address = "22 Tablet Lane";
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
            String EmailAddress = "Gurjit@live.co.uk";
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
            String Firstname = "Gurjit";
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
            String Surname = "Kaur";
            //assign the data to the property
            AStaff.Surname = Surname;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Surname, Surname);
        }

        [TestMethod]
        public void TelephoneNumberOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            String TelephoneNumber = "01163394569";
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

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = ""; //this should trigger an error
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "Kerry";
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "l"; //this should be ok
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

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "ll"; //this should be ok
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

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "lllllllllllllllllllllllllllllllllllllllllllllllll"; //this should be ok
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

        [TestMethod]
        public void AddressMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "llllllllllllllllllllllllllllllllllllllllllllllllll"; //this should be ok
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

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "lllllllllllllllllllllllllllllllllllllllllllllllllll"; //this should trigger an error
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "Kerry";
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "lllllllllllllllllllllllll"; //this should be ok
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

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = ""; //this should trigger an error
            Address = Address.PadRight(500, 'l');
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "Kerry";
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = ""; //this should trigger an error
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "k"; //this should be ok
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "kk"; //this should be ok
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk"; //this should be ok
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk"; //this should be ok
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk"; //this should trigger an error
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "kkkkkkkkkkkkkkkkkkkkkkkkk"; //this should be ok
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = ""; //this should trigger an error
            Firstname = Firstname.PadRight(500, 'k');
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "Kerry";
            string Surname = ""; //this should trigger an error
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "Kerry";
            string Surname = "s"; //this should be ok
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "Kerry";
            string Surname = "ss"; //this should be ok
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "Kerry";
            string Surname = "sssssssssssssssssssssssssssssssssssssssssssssssss"; //this should be ok
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "Kerry";
            string Surname = "ssssssssssssssssssssssssssssssssssssssssssssssssss"; //this should be ok
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "Kerry";
            string Surname = "sssssssssssssssssssssssssssssssssssssssssssssssssss"; //this should trigger an error
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "Kerry";
            string Surname = "sssssssssssssssssssssssss"; //this should be ok
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "Kerry.Smith@hotmail.co.uk";
            string Firstname = "Kerry";
            string Surname = ""; //this should trigger an error
            Surname = Surname.PadRight(500, 's');
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = ""; //this should trigger an error
            string Firstname = "Kerry";
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "k"; //this should be ok
            string Firstname = "Kerry";
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "kk"; //this should be ok
            string Firstname = "Kerry";
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk"; //this should be ok
            string Firstname = "Kerry";
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk"; //this should be ok
            string Firstname = "Kerry";
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk"; //this should trigger an error
            string Firstname = "Kerry";
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = "kkkkkkkkkkkkkkkkkkkkkkkkk"; //this should be ok
            string Firstname = "Kerry";
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "55 London Road";
            string EmailAddress = ""; //this should trigger an error
            EmailAddress = EmailAddress.PadRight(500, 'k');
            string Firstname = "Kerry";
            string Surname = "Smith";
            string Password = "Leicester";
            string TelephoneNumber = "01169876543";
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMinLessOne()
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
            string TelephoneNumber = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMinBoundary()
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
            string TelephoneNumber = "0"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMinPlusOne()
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
            string TelephoneNumber = "01"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMaxLessOne()
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
            string TelephoneNumber = "0123456789"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMaxBoundary()
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
            string TelephoneNumber = "01234567890"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMaxPlusOne()
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
            string TelephoneNumber = "012345678901"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMid()
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
            string TelephoneNumber = "01234"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberExtremeMax()
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
            string TelephoneNumber = "";
            TelephoneNumber = TelephoneNumber.PadRight(500, '0'); //this should fail
            //invoke the method
            Error = AStaff.Valid(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolen variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 StaffID = 21;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 21;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff id
            if (AStaff.StaffID != 21)
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
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 21;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.Address != "8 Nursery Street, Winterfell")
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
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 21;
            //invoke the method
            Found = AStaff.Find(StaffID);          
            //check the property
            if (AStaff.EmailAddress != "staff@staff.com")
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
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 21;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.Firstname != "Sanza")
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
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 21;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.Surname != "Stark")
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
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 21;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.TelephoneNumber != "15647895234")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}