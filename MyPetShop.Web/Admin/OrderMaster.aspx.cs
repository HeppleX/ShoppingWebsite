using MyPetShop.BLL;
using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_OrderMaster : System.Web.UI.Page
{
    OrderService orderService = new OrderService();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["AdminId"] == null)
        {
            Response.Redirect("~/LogIn.aspx");
        }
        if (!IsPostBack)
        {
            Bind();
        }
    }

    protected void Bind()
    {
        var orders = orderService.GetAllOrders();
        if(orders.Count()==0)
        {
            Panel1.Visible = false;
            Label1.Text = "尚无订单!";
        }
        else
        {
            Panel1.Visible = true;
            Label1.Text = "";
        }
        GridView1.DataSource = orders;
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        GridView Gridview1 = new GridView();
        GridView1 = (GridView)Page.Master.FindControl("ContentPlaceHolder2").FindControl("GridView1");
        if (GridView1 != null)
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox CheckBox1 = new CheckBox();
                CheckBox1 = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                if (CheckBox1 != null)
                {
                    if (CheckBox1.Checked)
                    {
                        int orderId = int.Parse(GridView1.Rows[i].Cells[2].Text);
                        orderService.UpdateOrder(orderId);
                    }
                }
            }
        }
        Bind();
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        Bind();
    }
}