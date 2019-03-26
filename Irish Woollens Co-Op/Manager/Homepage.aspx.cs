using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manager_Homepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void AddKnitter_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indictae this is a new record
        Session["StaffID"] = -1;
        //redirect to the Add New Knitter Page
        Response.Redirect("AddNewKnitter.aspx");
    }
}