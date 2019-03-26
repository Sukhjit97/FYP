using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestClass
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that the data exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Address = "12 Square Street";
            TestItem.StaffID = 5;
            TestItem.EmailAddress = "Some@hotmail.co.uk";
            TestItem.Firstname = "Hind";
            TestItem.Password = "Town";
            TestItem.Surname = "Sink";
            TestItem.TelephoneNumber = "01164534587";
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property 
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.Address = "12 Square Street";
            TestStaff.StaffID = 6;
            TestStaff.EmailAddress = "Some@hotmail.co.uk";
            TestStaff.Firstname = "Hind";
            TestStaff.Password = "Town";
            TestStaff.Surname = "Sink";
            TestStaff.TelephoneNumber = "01164534587";
            //assign the data to the property 
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Address = "12 Square Street";
            TestItem.StaffID = 6;
            TestItem.EmailAddress = "Some@hotmail.co.uk";
            TestItem.Firstname = "Hind";
            TestItem.Password = "Town";
            TestItem.Surname = "Sink";
            TestItem.TelephoneNumber = "01164534587";
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 1;
            //set its properties
            TestItem.Address = "12 Square Street";
            //TestItem.StaffID = 1;
            TestItem.EmailAddress = "Some@hotmail.co.uk";
            TestItem.Firstname = "Hind";
            TestItem.Surname = "Sink";
            TestItem.Password = "Town";
            TestItem.TelephoneNumber = "01164534587";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record 
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
    }
}
