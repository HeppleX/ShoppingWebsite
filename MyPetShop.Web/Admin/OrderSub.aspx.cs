using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyPetShop.BLL;

public partial class Admin_OrderSub : System.Web.UI.Page
{
    OrderService orderService = new OrderService();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)
        {
            Response.Redirect("~/LogIn.aspx");
        }
        if(Request.QueryString.Count==0)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            Bind();
        }
    }

    protected void Bind()
    {
        int orderId = int.Parse(Request.QueryString["OrderId"]);
        var order = orderService.GetOrderListByOrderId(orderId);
        var orderItem = orderService.GetOrderItemByOrderId(orderId);
        GridView1.DataSource = order;
        GridView1.DataBind();
        GridView2.DataSource = orderItem;
        GridView2.DataBind();
    }

    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        Bind();
    }
}