using MyPetShop.BLL;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShopCart : System.Web.UI.Page
{
    CartItemService cartItemService = new CartItemService();
    ProductService productService = new ProductService();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if(Session["CustomerId"]==null)
            {
                Response.Redirect("~/LogIn.aspx");
            }
            if(Request.QueryString["ProductId"]!=null)
            {
                int productId = int.Parse(Request.QueryString["ProductId"]);
                cartItemService.Add(Convert.ToInt32(Session["CustomerId"]), productId, 1);
            }
            Label2.Text = "温馨提示：更改购买数量后，请单击'重新计算'按钮进行更新！";
            Bind();
        }
    }

    protected void Bind()
    {
        Label3.Text = cartItemService.GetTotalPriceByCustomerId(Convert.ToInt32(Session["CustomerId"])).ToString();
        GridView1.DataSource = cartItemService.GetCartItemsByCustomerId(Convert.ToInt32(Session["CustomerId"]));
        GridView1.DataBind();
        if(GridView1.Rows.Count!=0)
        {
            Panel1.Visible = true;
            Label4.Text = "";
        }
        else
        {
            Panel1.Visible = false;
            Label4.Text = "购物车内没有添加商品，请先购物！";
        }
    }

    protected decimal TotalPrice()
    {
        return cartItemService.GetTotalPriceByCustomerId(Convert.ToInt32(Session["CustomerId"]));
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int productId = 0;
        GridView GridView1 = new GridView();
        GridView1 = (GridView)Page.Master.FindControl("ContentPlaceHolder2").FindControl("GridView1");
        if(GridView1 != null)
        {
            for(int i=0;i< GridView1.Rows.Count;i++)
            {
                CheckBox CheckBox1 = new CheckBox();
                CheckBox1 = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                if(CheckBox1 != null)
                {
                    if(CheckBox1.Checked)
                    {
                        productId = int.Parse(GridView1.Rows[i].Cells[1].Text);
                        cartItemService.Delete(Convert.ToInt32(Session["CustomerId"]), productId);
                    }
                }
            }
        }
        Bind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        cartItemService.Clear(Convert.ToInt32(Session["CustomerId"]));
        Response.Redirect("Default.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Label1.Text = "";
        GridView GridView1 = new GridView();
        GridView1 = (GridView)Page.Master.FindControl("ContentPlaceHolder2").FindControl("GridView1");
        if (GridView1 != null)
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                TextBox TextBox1 = new TextBox();
                TextBox1 = (TextBox)GridView1.Rows[i].FindControl("TextBox1");
                if(TextBox1 != null)
                {
                    var product=productService.GetProductByProductId(Convert.ToInt32(GridView1.Rows[i].Cells[1].Text));
                    if(int.Parse(TextBox1.Text)>product.Qty)
                    {
                        Label1.Text += "Error:库存不足，商品名为" + product.Name + "的库存数量为" + product.Qty.ToString() + "<br/>";
                    }
                    else
                    {
                        cartItemService.Update(Convert.ToInt32(Session["CustomerId"]), product.ProductId, Convert.ToInt32(TextBox1.Text));
                    }
                }
            }
        }
        Bind();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        if(Session["CustomerId"]!=null)
        {
            Response.Redirect("SubmitCart.aspx");
        }
        else
        {
            Response.Redirect("LogIn.aspx");
        }
    }
}