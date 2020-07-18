using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyPetShop.BLL;

public partial class Admin_SupplierMaster : System.Web.UI.Page
{
    ProductService productService = new ProductService();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)
        {
            Response.Redirect("~/LogIn.aspx");
        }
    }


    protected void DetailsView1_ItemDeleting(object sender, DetailsViewDeleteEventArgs e)
    {
        var productCount = productService.GetProductCountBySupplierId(int.Parse(DetailsView1.DataKey.Value.ToString()));
        if (productCount != 0)
        {
            Label1.Text = "Error:该分类下有商品，请先删除商品！";
            e.Cancel = true;
        }
    }
}