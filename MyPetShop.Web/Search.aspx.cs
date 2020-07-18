using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyPetShop.BLL;

public partial class Search : System.Web.UI.Page
{
    ProductService productService = new ProductService();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Bind();
        }
    }

    protected void Bind()
    {
        if(Request.QueryString["Searchtext"]!=null)
        {
            string str = Request.QueryString["Searchtext"].ToString();
            GridView1.DataSource = productService.GetProductBySearchText(str);
            GridView1.DataBind();
        }
        else
        {
            Label8.Text = "无搜索结果！";
        }
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        Bind();
    }
}