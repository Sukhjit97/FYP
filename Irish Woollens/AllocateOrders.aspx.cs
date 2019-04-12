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
    public partial class AllocateOrders : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Key"]);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAllocateOrder_Click(object sender, EventArgs e)
        {
            //connect to DB
            clsDataConnection DB = new clsDataConnection();
            //set parameters
            DB.AddParameter("@OrderID", ddlOrderID.SelectedItem.Text);
            DB.AddParameter("@Note", txtNote.Text);
            DB.AddParameter("@StaffID", ddlStaffID.SelectedItem.Text);
            DB.AddParameter("@StaffSurname", ddlStaffName.SelectedItem.Text);

            //execute command
            DB.Execute("sproc_tblOrderAllocation_Insert");

            Response.Write("<script type='text/javascript'>alert('Allocation Completed Successfully...!');</script>");

        }
    }
}