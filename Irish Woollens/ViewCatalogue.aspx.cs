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
    public partial class ViewCatalogue : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Key"]);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnbuynow9_Click(object sender, EventArgs e)
        {
            //redirect to the payment page
            Response.Redirect("Payment.aspx");
        }

        protected void btnbuynow8_Click(object sender, EventArgs e)
        {
            //redirect to the payment page
            Response.Redirect("Payment.aspx");
        }

        protected void btnbuynow7_Click(object sender, EventArgs e)
        {
            //redirect to the payment page
            Response.Redirect("Payment.aspx");
        }

        protected void btnbuynow6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }

        protected void btnbuynow5_Click(object sender, EventArgs e)
        {
            //redirect to the payment page
            Response.Redirect("Payment.aspx");
        }

        protected void btnbuynow4_Click(object sender, EventArgs e)
        {
            //redirect to the payment page
            Response.Redirect("Payment.aspx");
        }

        protected void btnbuynow3_Click(object sender, EventArgs e)
        {
            //redirect to the payment page
            Response.Redirect("Payment.aspx");
        }

        protected void btnbuynow2_Click(object sender, EventArgs e)
        {
            //redirect to the payment page
            Response.Redirect("Payment.aspx");
        }

        protected void btnbuynow1_Click(object sender, EventArgs e)
        {
            //redirect to the payment page
            Response.Redirect("Payment.aspx");
        }
    }
}