using MyPetShop.BLL;
using System;
using System.Web.UI.WebControls;

public partial class Admin_CategoryMaster : System.Web.UI.Page
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
        var productCount = productService.GetProductCountByCategoryId(int.Parse(DetailsView1.DataKey.Value.ToString()));
        if(productCount!=0)
        {
            Label1.Text = "Error:该分类下有商品，请先删除商品！";
                e.Cancel = true;
        }
    }
}