using System;
using System.Web.UI;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("~/SignUp.aspx");
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("~/LogIn.aspx");
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string strQuery = "";
        if(TextBox1.Text.Trim()=="")
        {
            strQuery = "";
        }
        else
        {
            strQuery = "?SearchText=" + TextBox1.Text.Trim();
        }
        Response.Redirect("~/Search.aspx" + strQuery);
    }
}
