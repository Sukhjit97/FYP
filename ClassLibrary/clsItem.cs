using System;

namespace ClassLibrary
{
    public class clsItem
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public string Valid(string name, string description, decimal price, int quantity)
        {
            //if the name field is not blank
            if (Name != "")
            {
                //return a blank string
                return "";
            }
            //if the description field is not blank
            if (Description != "")
            {
                //return a blank string
                return "";
            }
            //if the price field is not blank
            if (Price != "")
            {
                //return a blank string
                return "";
            }
            //if the name field is not blank
            if (Quantity != "")
            {
                //return a blank string
                return "";
            }
            else
            {
                //otherwise return an error message
                return "Fields may not be left blank!";
            }
        }
    }
}