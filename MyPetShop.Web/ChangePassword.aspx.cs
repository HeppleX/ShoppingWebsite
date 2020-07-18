using MyPetShop.BLL;
using System;
using System.Web.UI;


public partial class ChangePassword : System.Web.UI.Page
{
    CustomerService customerservice = new CustomerService();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CustomerId"] == null)
        {
            Response.Redirect("~/LogIn.aspx");
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            if (customerservice.CheckLogin(Session["CustomerName"].ToString(), TextBox1.Text) > 0)
            {
                customerservice.ChangePassword(Convert.ToInt32(Session["CustomerId"]), TextBox2.Text);
                Label1.Text = "修改密码成功!";
            }
            else
            {
                Label1.Text = "原密码错误!";
            }
        }
    }
}