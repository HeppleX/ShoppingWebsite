using MyPetShop.BLL;
using System;
using System.Web.UI;

public partial class GetPassword : System.Web.UI.Page
{
    CustomerService customerService = new CustomerService();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            if (!customerService.IsNameExist(TextBox1.Text.Trim()))
            {
                Label1.Text = "用户名不存在！";
            }
            else
            {
                if (!customerService.IsEmailExist(TextBox1.Text.Trim(), TextBox2.Text.Trim()))
                {
                    Label1.Text = "邮箱错误！";
                }
                else
                {
                    customerService.ResetPassword(TextBox1.Text.Trim(), TextBox2.Text.Trim());
                    EmailSender emailSender = new EmailSender(TextBox2.Text.Trim(), TextBox1.Text.Trim());
                    emailSender.Send();
                    Label1.Text = "密码已发送至邮箱！";
                }
            }
        }
    }
}