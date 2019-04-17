using System;
using System.Collections.Generic;
using ClassLibrary;


public class clsCustomerCollection
{
    //private data member for the list
    List<clsCustomer> mCustomerList = new List<clsCustomer>();
    //private data member thisCustomer
    clsCustomer mThisCustomer = new clsCustomer();

    //public property for ThisStaff
    public clsCustomer ThisCustomer
    {
        get
        {
            //return the private data
            return mThisCustomer;
        }
        set
        {
            //set the private data
            mThisCustomer = value;
        }
    }

    //public property for the staff list
    public List<clsCustomer> CustomerList
    {
        get
        {
            //return the private data
            return mCustomerList;
        }
        set
        {
            //set the private data
            mCustomerList = value;
        }
    }

    //public property for count
    public int Count
    {
        get
        {
            //return the count of the list 
            return mCustomerList.Count;
        }
        set
        {
            //we shall worry about this later
        }
    }

    //constructor for the class
    public clsCustomerCollection()
    {
        //object for data connection
        clsDataConnection DB = new clsDataConnection();
        //execute the stored procedure
        DB.Execute("sproc_tblCustomer_SelectAll");
        //populate the array list with the data table
        PopulateArray(DB);
    }

    void PopulateArray(clsDataConnection DB)
    {
        //populate the array list based on data table in the parameter DB
        //var for the index
        Int32 Index = 0;
        //var to store the record count
        Int32 RecordCount;
        //get the count of records
        RecordCount = DB.Count;
        //clear the private array list
        mCustomerList = new List<clsCustomer>();
        //while there are records to process
        while (Index < RecordCount)
        {
            //create a blank staff record
            clsCustomer ACustomer = new clsCustomer();
            //read in the fields from the current record
            ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
            ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
            ACustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
            ACustomer.Firstname = Convert.ToString(DB.DataTable.Rows[Index]["Firstname"]);
            ACustomer.Surname = Convert.ToString(DB.DataTable.Rows[Index]["Surname"]);
            ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
            ACustomer.TelephoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["TelephoneNumber"]);
            //ACustomer.RoleId = Convert.ToInt32(DB.DataTable.Rows[Index]["RoleId"]);
            //add the record to the private data member
            mCustomerList.Add(ACustomer);
            //point at the next record
            Index++;
        }
    }

    public int Add()
    {
        //adds a new record to the database based on the values of thisStaff
        //connect to the database
        clsDataConnection DB = new clsDataConnection();
        //set the parameters for the stored procedure
        DB.AddParameter("@Address", mThisCustomer.Address);
        DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
        DB.AddParameter("@Firstname", mThisCustomer.Firstname);
        DB.AddParameter("@Surname", mThisCustomer.Surname);
        DB.AddParameter("@Password", mThisCustomer.Password);
        DB.AddParameter("@TelephoneNumber", mThisCustomer.TelephoneNumber);
        DB.AddParameter("@RoleId", mThisCustomer.RoleId);
        //execute the query returning the primary key value 
        return DB.Execute("sproc_tblCustomer_Insert");
    }
}

