using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControl_UserStatus : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] != null || Session["CustomerId"] != null)
        {
            if (Session["AdminId"] != null)
            {
                Label1.Text = "您好，" + Session["AdminName"].ToString();
                LinkButton2.Visible = true;
            }
            else if (Session["CustomerId"] != null)
            {
                Label1.Text = "您好，" + Session["CustomerName"].ToString();
                LinkButton1.Visible = true;
                LinkButton3.Visible = true;
            }
            LinkButton4.Visible = true;
        }
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("~/Default.aspx");
    }
}
