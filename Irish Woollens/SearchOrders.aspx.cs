using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Irish_Woollens
{
    public partial class SearchOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)

            {

                this.SearchOrder();

            }
        }

        private void SearchOrder()

        {

            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Key"]);

            using (SqlCommand cmd = new SqlCommand())

            {

                string sql = "SELECT * FROM tblOrder";

                if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))

                {

                    sql += " WHERE OrderID LIKE @OrderID + '%'";

                    cmd.Parameters.AddWithValue("@OrderID", txtSearch.Text.Trim());

                }

                cmd.CommandText = sql;

                cmd.Connection = con;

                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))

                {

                    DataTable dt = new DataTable();

                    sda.Fill(dt);

                    gvSearchOrders.DataSource = dt;

                    gvSearchOrders.DataBind();

                }

            }



        }

        protected void Search(object sender, EventArgs e)
        {
            this.SearchOrder();
        }

        protected void OnPaging(object sender, GridViewPageEventArgs e)

        {

            gvSearchOrders.PageIndex = e.NewPageIndex;

            this.SearchOrder();

        }
    }
}