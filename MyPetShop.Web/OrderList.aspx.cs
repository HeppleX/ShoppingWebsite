using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyPetShop.BLL;

public partial class OrderList : System.Web.UI.Page
{
    OrderService orderService = new OrderService();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["CustomerId"] == null)
        {
            Response.Redirect("~/LogIn.aspx");
        }
        Bind();
    }
    protected void Bind()
    {
        GridView1.DataSource = orderService.GetOrderByCustomerId(Convert.ToInt32(Session["CustomerId"]));
        GridView1.DataBind();
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        Bind();
    }
}