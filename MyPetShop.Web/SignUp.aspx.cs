using MyPetShop.BLL;
using System;
using System.Web.UI;

public partial class SignUp : System.Web.UI.Page
{
    CustomerService customerservice = new CustomerService();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            if (customerservice.IsNameExist(TextBox1.Text.Trim()))
            {
                Label1.Text = "用户名已经存在!";
            }
            else
            {
                customerservice.Insert(TextBox1.Text.Trim(), TextBox3.Text.Trim(), TextBox2.Text.Trim());
                Response.Redirect("LogIn.aspx?name=" + TextBox1.Text);
            }
        }
    }
}