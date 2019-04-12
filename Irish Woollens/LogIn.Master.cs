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
    public partial class LogIn : System.Web.UI.MasterPage
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Key"]);


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmailAddress"] == null)
            {
                //Response.Redirect("Default.aspx");

            }


            if (Session["EmailAddress"] != null)
            {
                int Role = GetUserRole();
                GetUserRole();

                if (Role == 1)
                {
                    //display manager items
                    divManager.Visible = true;
                }
                else if (Role == 2)
                {
                    //display staff items
                    divStaff.Visible = true;
                }
                else if (Role == 3)
                {
                    //display customer items
                    divCustomer.Visible = true;
                }

            }
        }


        public int GetUserRole()
        {
            {
                int userRole = 0;
                int Role = Convert.ToInt32(Session["RoleId"]);

                if (Role == 1)
                {
                    userRole = 1;
                }
                else if (Role == 2)
                {
                    userRole = 2;
                }
                else if (Role == 3)
                {
                    userRole = 3;
                }

                return userRole;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //if ((Session["EmailAddress"] != null) || (Session["EmailAddress"] != ""))
            //{
                //clear session data
                Session["EmailAddress"] = null;
                //Session["EmailAddress"] = "";
                Session.Abandon();
                Session.Clear();
                //Session.RemoveAll();
                Session.Remove("uid");
                Session.Remove("EmailAddress");
                //Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Redirect("Logout.aspx");
            //}
            
            
        }
    }
}



