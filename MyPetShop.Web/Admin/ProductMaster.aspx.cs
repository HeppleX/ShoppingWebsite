using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using MyPetShop.BLL;

public partial class Admin_ProductMaster : System.Web.UI.Page
{
    ProductService productService = new ProductService();
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
        var product = productService.GetAllProducts();
        if(product.Count()==0)
        {
            Panel1.Visible = false;
            Label1.Text = "数据库中无商品，请添加商品!";
        }
        else
        {
            Panel1.Visible = true;
            Label1.Text = "";
        }
        GridView1.DataSource = product;
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int productId = 0;
        GridView GridView1 = new GridView();
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
                        productId = int.Parse(GridView1.Rows[i].Cells[1].Text);
                        productService.DeletePro(productId);
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