using System;
using System.Collections.Generic;
using ClassLibrary;


    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mThisStaff = new clsStaff();

        //public property for ThisStaff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        //public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list 
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

    //constructor for the class
    public clsStaffCollection()
    {
        //object for data connection
        clsDataConnection DB = new clsDataConnection();
        //execute the stored procedure
        DB.Execute("sproc_tblStaff_SelectAll");
        //populate the array list with the data table
        PopulateArray(DB);
    }

    void PopulateArray (clsDataConnection DB)
    {
        //populate the array list based on data table in the parameter DB
        //var for the index
        Int32 Index = 0;
        //var to store the record count
        Int32 RecordCount;
        //get the count of records
        RecordCount = DB.Count;
        //clear the private array list
        mStaffList = new List<clsStaff>();
        //while there are records to process
        while (Index < RecordCount)
        {
             //create a blank staff record
             clsStaff AStaff = new clsStaff();
             //read in the fields from the current record
             AStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
             AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
             AStaff.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
             AStaff.Firstname = Convert.ToString(DB.DataTable.Rows[Index]["Firstname"]);
             AStaff.Surname = Convert.ToString(DB.DataTable.Rows[Index]["Surname"]);
             AStaff.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
             AStaff.TelephoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["TelephoneNumber"]);
             //add the record to the private data member
             mStaffList.Add(AStaff);
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
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@EmailAddress", mThisStaff.EmailAddress);
            DB.AddParameter("@Firstname", mThisStaff.Firstname);
            DB.AddParameter("@Surname", mThisStaff.Surname);
            DB.AddParameter("@Password", mThisStaff.Password);
            DB.AddParameter("@TelephoneNumber", mThisStaff.TelephoneNumber);
            DB.AddParameter("@RoleId", mThisStaff.RoleId);
        //execute the query returning the primary key value 
        return DB.Execute("sproc_tblStaff_Insert");
        }
    }

  
