using MyPetShop.BLL;
using System;

public partial class SubmitCart : System.Web.UI.Page
{
    OrderService orderService = new OrderService();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["CustomerId"]==null)
        {
            Response.Redirect("~/LogIn.aspx");
        }
        Panel1.Visible = true;
        Label1.Text = "";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        orderService.CreateOrderFromCart(Convert.ToInt32(Session["CustomerId"]), Session["CustomerName"].ToString(), TextBox1.Text.Trim(), TextBox2.Text.Trim(), TextBox3.Text.Trim(), TextBox4.Text.Trim(), TextBox5.Text.Trim(), TextBox6.Text.Trim());
        Panel1.Visible = false;
        Label1.Text = "已经成功结算，谢谢光临！";
    }
}