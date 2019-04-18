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
    public partial class Quotation : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Key"]);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRequestChange_Click(object sender, EventArgs e)
        {
            {
                //connect to DB
                clsDataConnection DB = new clsDataConnection();
                //set parameters
                DB.AddParameter("@Firstname", ddlFirstname.SelectedItem.Text);
                DB.AddParameter("@ItemID", ddlItemID.SelectedItem.Text);
                DB.AddParameter("@ItemName", ddlItemName.SelectedItem.Text);
                DB.AddParameter("@Quotation", txtQuotation.Text);

                //execute command
                DB.Execute("sproc_tblQuotation_Insert");
                //javascript message to confirm quotation placed 
                Response.Write("<script type='text/javascript'>alert('Thank you for your Quotation. We will take this into consideration.');</script>");
            }
        }
    }
}