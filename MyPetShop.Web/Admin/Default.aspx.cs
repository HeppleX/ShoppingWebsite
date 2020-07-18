using System;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["AdminId"]==null)
        {
            Response.Redirect("~/LogIn.aspx");
        }
    }
}