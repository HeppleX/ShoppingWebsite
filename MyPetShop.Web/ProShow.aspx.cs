using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyPetShop.BLL;

public partial class ProShow : System.Web.UI.Page
{
    ProductService productService = new ProductService();
    
    protected void Page_Load(object sender, EventArgs e)
    {
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
        GridView1.DataSource = productService.GetProductByProductIdorByCategoryId(Request.QueryString["ProductId"], Request.QueryString["CategoryId"]);
        GridView1.DataBind();
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        Bind();
    }
}