using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyPetShop.BLL;

public partial class LogIn : System.Web.UI.Page
{
    CustomerService customerservice = new CustomerService();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["name"] != null)
            {
                TextBox1.Text = Request.QueryString["name"];
                Label1.Text = "注册成功，请登录";
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
            if (Page.IsValid)
            {
                int customerId = customerservice.CheckLogin(TextBox1.Text.Trim(), TextBox2.Text.Trim());
                if (customerId > 0)
                {
                    Session.Clear();
                    if (TextBox1.Text.Trim() == "admin")
                    {
                        Session["AdminId"] = customerId;
                        Session["AdminName"] = TextBox1.Text;
                        Response.Redirect("~/Admin/Default.aspx");
                    }
                    else
                    {
                        Session["CustomerId"] = customerId;
                        Session["CustomerName"] = TextBox1.Text;
                        Response.Redirect("~/Default.aspx");
                    }
                }
                else
                {
                    Label1.Text = "用户名或密码错误！";
                }
            }        
    }
}