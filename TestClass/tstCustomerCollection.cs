using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestClass
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see that the data exists
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CustomerListOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Address = "12 Square Street";
            TestItem.CustomerID = 5;
            TestItem.EmailAddress = "Some@hotmail.co.uk";
            TestItem.Firstname = "Hind";
            TestItem.Password = "Town";
            TestItem.Surname = "Sink";
            TestItem.TelephoneNumber = "01164534587";
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property 
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.Address = "12 Square Street";
            TestCustomer.CustomerID = 6;
            TestCustomer.EmailAddress = "Some@hotmail.co.uk";
            TestCustomer.Firstname = "Hind";
            TestCustomer.Password = "Town";
            TestCustomer.Surname = "Sink";
            TestCustomer.TelephoneNumber = "01164534587";
            //assign the data to the property 
            AllCustomer.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Address = "12 Square Street";
            TestItem.CustomerID = 6;
            TestItem.EmailAddress = "Some@hotmail.co.uk";
            TestItem.Firstname = "Hind";
            TestItem.Password = "Town";
            TestItem.Surname = "Sink";
            TestItem.TelephoneNumber = "01164534587";
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data 
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 1;
            //set its properties
            TestItem.Address = "12 Square Street";
            //TestItem.CustomerID = 1;
            TestItem.EmailAddress = "Some@hotmail.co.uk";
            TestItem.Firstname = "Hind";
            TestItem.Surname = "Sink";
            TestItem.Password = "Town";
            TestItem.TelephoneNumber = "01164534587";
            TestItem.RoleId = 3;
            //set ThisStaff to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record 
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }
    }
}
