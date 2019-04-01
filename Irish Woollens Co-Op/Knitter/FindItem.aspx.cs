using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Knitter_FindItem: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!this.IsPostBack)

        {

            this.SearchStaff();

        }
    }


    private void SearchStaff()

    {

        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Key"]);

        using (SqlCommand cmd = new SqlCommand())

        {

            string sql = "SELECT* FROM tblStaff";

            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))

            {

                sql += " WHERE Firstname LIKE @Firstname + '%'";

                cmd.Parameters.AddWithValue("@Firstname", txtSearch.Text.Trim());

            }

            cmd.CommandText = sql;

            cmd.Connection = con;

            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))

            {

                DataTable dt = new DataTable();

                sda.Fill(dt);

                gvStaff.DataSource = dt;

                gvStaff.DataBind();

            }

        }



    }





    protected void Search(object sender, EventArgs e)

    {

        this.SearchStaff();

    }

    protected void OnPaging(object sender, GridViewPageEventArgs e)

    {

        gvStaff.PageIndex = e.NewPageIndex;

        this.SearchStaff();

    }





}

　













