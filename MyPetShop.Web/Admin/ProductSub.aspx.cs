using MyPetShop.BLL;
using System;
using System.IO;
using System.Web.UI.WebControls;

public partial class Admin_ProductSub : System.Web.UI.Page
{
    ProductService productService = new ProductService();
    CategoryService categoryService = new CategoryService();
    SupplierService supplierService = new SupplierService();

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
        if (Request.QueryString["ProductId"] == null)
        {
            Panel1.Visible = false;
        }
        else
        {
            int productId = int.Parse(Request.QueryString["ProductId"]);
            var product = productService.GetProductByProductId(productId);
            var categories = categoryService.GetAllCategories();
            foreach (var category in categories)
            {
                DropDownList1.Items.Add(new ListItem(category.Name, category.CategoryId.ToString()));
            }
            var suppliers = supplierService.GetAllSuppliers();
            foreach (var supplier in suppliers)
            {
                DropDownList2.Items.Add(new ListItem(supplier.Name, supplier.SuppId.ToString()));
            }
            TextBox1.Text = product.Name;
            DropDownList1.SelectedValue = product.CategoryId.ToString();
            TextBox2.Text = product.ListPrice.ToString();
            TextBox3.Text = product.UnitCost.ToString();
            DropDownList2.SelectedValue = product.SuppId.ToString();
            TextBox4.Text = product.Descn;
            TextBox5.Text = product.Qty.ToString();
            Image1.ImageUrl = product.Image;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["ProductId"] != null)
        {
            int productId = int.Parse(Request.QueryString["ProductId"]);
            productService.Update(productId, TextBox1.Text.Trim(), int.Parse(DropDownList1.SelectedValue), int.Parse(DropDownList2.SelectedValue), decimal.Parse(TextBox2.Text.Trim()), decimal.Parse(TextBox3.Text.Trim()), TextBox4.Text.Trim(), int.Parse(TextBox5.Text.Trim()));
            if(FileUpload1.PostedFile.ContentLength!=0)
            {
                string filePath = Server.MapPath("~/") + productService.GetProductByProductId(productId).Image.Substring(2);
                File.Delete(filePath);
                FileUpload1.PostedFile.SaveAs(filePath);
            }
            Response.Buffer = true;
            Response.Redirect("ProductMaster.aspx");
        }
    }
}