using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestClass
{
    [TestClass]
    public class tstItem
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsItem AnItem = new clsItem();
            //test to see that it exists
            Assert.IsNotNull(AnItem);
        }

        [TestMethod]
        public void ItemIDOk()
        {
            //create an instance of the class we want to create
            clsItem AnItem = new clsItem();
            //create some test data to assign to the property 
            Int32 ItemID = 1;
            //assign the data to the property
            AnItem.ItemID = ItemID;
            //test to see that the two values are the same
            Assert.AreEqual(AnItem.ItemID, ItemID);
        }

        [TestMethod]
        public void NameOk()
        {
            //create an instance of the class we want to create
            clsItem AnItem = new clsItem();
            //create some test data to assign to the property 
            String Name = "Sweater";
            //assign the data to the property
            AnItem.Name = Name;
            //test to see that the two values are the same
            Assert.AreEqual(AnItem.Name, Name);
        }

        [TestMethod]
        public void DescriptionOk()
        {
            //create an instance of the class we want to create
            clsItem AnItem = new clsItem();
            //create some test data to assign to the property 
            String Description = "Blue Dotted Sweater";
            //assign the data to the property
            AnItem.Description = Description;
            //test to see that the two values are the same
            Assert.AreEqual(AnItem.Description, Description);
        }

        [TestMethod]
        public void PriceOk()
        {
            //create an instance of the class we want to create
            clsItem AnItem = new clsItem();
            //create some test data to assign to the property 
            decimal Price = 9.99m;
            //assign the data to the property
            AnItem.Price = Price;
            //test to see that the two values are the same
            Assert.AreEqual(AnItem.Price, Price);
        }

        [TestMethod]
        public void QuantityOk()
        {
            //create an instance of the class we want to create
            clsItem AnItem = new clsItem();
            //create some test data to assign to the property 
            Int32 Quantity = 1;
            //assign the data to the property
            AnItem.Quantity = Quantity;
            //test to see that the two values are the same
            Assert.AreEqual(AnItem.Quantity, Quantity);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsItem AnItem = new clsItem();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Name = "Candyfloss Sweater";
            string Description = "Light Pink Sweater";
            decimal Price = 6.99m;
            Int32 Quantity = 1;
            //invoke the method
            Error = AnItem.Valid(Name, Description, Price, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
