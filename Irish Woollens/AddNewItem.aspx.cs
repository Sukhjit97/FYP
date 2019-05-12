using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Irish_Woollens
{
    public partial class AddNewKnitter : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Key"]);

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        ////function for adding new catalogue items
        //void Add()
        //{
        //    clsItemCollection StaffList = new clsItemCollection();
        //    String Error = ItemList.ThisItem.Valid(txtItemName.Text,
        //                                                   txtItemDescription.Text,
        //                                                   txtItemPrice.Text);
        //    if (Error == "")
        //    {
        //        ItemList.ThisStaff.Firstname = txtItemName.Text;
        //        ItemList.ThisStaff.Surname = txtItemDescription.Text;
        //        ItemList.ThisStaff.Address = txtItemPrice.Text;

        //        //Add the record
        //        ItemList.Add();
        //        lblError.Text = "Item added successfully";
        //    }
        //    else
        //    {
        //        //report
        //        lblError.Text = "There were problem(s) with the data you entered: " + Error;
        //    }
        //}

        //protected void btnAddItem_Click(object sender, EventArgs e)
        //{
        //    //add the new record
        //    Add();
        //}

        //protected void btnCancel_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("homepage.aspx");
        //}
    }
}








