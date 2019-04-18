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
    public partial class SearchItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)

            {

                this.SearchItems();

            }
        }

        private void SearchItems()

        {

            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Key"]);

            using (SqlCommand cmd = new SqlCommand())

            {

                string sql = "SELECT* FROM tblItem";

                if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))

                {

                    sql += " WHERE ItemName LIKE @ItemName + '%'";

                    cmd.Parameters.AddWithValue("@ItemName", txtSearch.Text.Trim());

                }

                cmd.CommandText = sql;

                cmd.Connection = con;

                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))

                {

                    DataTable dt = new DataTable();

                    sda.Fill(dt);

                    gvItem.DataSource = dt;

                    gvItem.DataBind();

                }

            }
        }

        protected void Search(object sender, EventArgs e)

        {

            this.SearchItems();

        }

        protected void OnPaging(object sender, GridViewPageEventArgs e)

        {

            gvItem.PageIndex = e.NewPageIndex;

            this.SearchItems();

        }
    }
}
