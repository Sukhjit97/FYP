using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestClass
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ActiveOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            Boolean Active = true;
            //assign the data to the property
            ACustomer.Active = Active;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Active, Active);
        }

        [TestMethod]
        public void AddressOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            String Address = "1a";
            //assign the data to the property
            ACustomer.Address = Address;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address, Address);
        }

        [TestMethod]
        public void CustomerIDOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            Int32 CustomerID = 1;
            //assign the data to the property
            ACustomer.CustomerID = CustomerID;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, CustomerID);
        }

        [TestMethod]
        public void DateRegisteredOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            DateTime DateRegistered = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateRegistered = DateRegistered;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateRegistered, DateRegistered);
        }

        [TestMethod]
        public void EmailAddressOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            String EmailAddress = "s_1@homtail.co.uk";
            //assign the data to the property
            ACustomer.EmailAddress = EmailAddress;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.EmailAddress, EmailAddress);
        }

        [TestMethod]
        public void FirstnameOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            String Firstname = "shivani";
            //assign the data to the property
            ACustomer.Firstname = Firstname;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Firstname, Firstname);
        }

        [TestMethod]
        public void SurnameOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            String Surname = "khushal";
            //assign the data to the property
            ACustomer.Surname = Surname;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Surname, Surname);
        }

        [TestMethod]
        public void PasswordOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            String Password = "abc";
            //assign the data to the property
            ACustomer.Password = Password;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Password, Password);
        }

        [TestMethod]
        public void TelephoneNumberOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            String TelephoneNumber = "01163456788";
            //assign the data to the property
            ACustomer.TelephoneNumber = TelephoneNumber;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.TelephoneNumber, TelephoneNumber);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "Sukhjit";
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = ""; //this should trigger an error
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "Sukhjit";
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "a"; //this should be ok
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "Sukhjit";
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "aa"; //this should be ok
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "Sukhjit";
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "Sukhjit";
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "Sukhjit";
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "Sukhjit";
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "Sukhjit";
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "";
            Address = Address.PadRight(500, 'a'); //this should fail
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "Sukhjit";
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = ""; //this should trigger an error
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "s"; //this should be ok
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "ss"; //this should be ok
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "sssssssssssssssssssssssssssssssssssssssssssssssss"; //this should be ok
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "ssssssssssssssssssssssssssssssssssssssssssssssssss"; //this should be ok
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "sssssssssssssssssssssssssssssssssssssssssssssssssss"; //this should trigger an error
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "sssssssssssssssssssssssss"; //this should be ok
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FirstnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "";
            Firstname = Firstname.PadRight(500, 's'); //this should fail
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "Sukhjit"; 
            string Surname = ""; //this should trigger an error
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "Sukhjit"; 
            string Surname = "k"; //this should be ok
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "Sukhjit";
            string Surname = "kk"; //this should be ok
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "Sukhjit";
            string Surname = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk"; //this should be ok
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "Sukhjit";
            string Surname = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk"; //this should be ok
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "Sukhjit";
            string Surname = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk"; //this should trigger an error
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "Sukhjit";
            string Surname = "kkkkkkkkkkkkkkkkkkkkkkkkk"; //this should be ok
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Sukhjit@hotmail.co.uk";
            string Firstname = "Sukhjit";
            string Surname = "";
            Surname = Surname.PadRight(500, 'k'); //this should fail
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = ""; //this should trigger an error
            string Firstname = "Sukhjit";
            string Surname = "Kaur"; 
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "s"; //this should be ok
            string Firstname = "Sukhjit";
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "ss"; //this should be ok
            string Firstname = "Sukhjit";
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "sssssssssssssssssssssssssssssssssssssssssssssssss"; //this should be ok
            string Firstname = "Sukhjit";
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "ssssssssssssssssssssssssssssssssssssssssssssssssss"; //this should be ok
            string Firstname = "Sukhjit";
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "sssssssssssssssssssssssssssssssssssssssssssssssssss"; //this should trigger an error
            string Firstname = "Sukhjit";
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void EmailAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "sssssssssssssssssssssssss"; //this should be ok
            string Firstname = "Sukhjit";
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to use with the method 
            string Address = "20 Star Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(500, 's'); //this should fail
            string Firstname = "Sukhjit";
            string Surname = "Kaur";
            string Password = "Amsterdam";
            string TelephoneNumber = "01161357956";
            //invoke the method
            Error = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }





































    }
}
