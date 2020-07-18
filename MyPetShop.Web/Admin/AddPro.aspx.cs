using MyPetShop.BLL;
using System;
using System.IO;
using System.Web.UI.WebControls;

public partial class Admin_AddPro : System.Web.UI.Page
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
        if(!IsPostBack)
        {
            if(productService.IsExistCS())
            {
                Panel1.Visible = false;
                Label2.Text = "请先添加分类和提供商!";
            }
            else
            {
                Panel1.Visible = true;
                Label2.Text = "";
                Bind();
            }
        }
    }
    protected void Bind()
    {
        var categories = categoryService.GetAllCategories();
        foreach(var category in categories)
        {
            DropDownList1.Items.Add(new ListItem(category.Name, category.CategoryId.ToString()));
        }
        var suppliers = supplierService.GetAllSuppliers();
        foreach (var supplier in suppliers)
        {
            DropDownList2.Items.Add(new ListItem(supplier.Name, supplier.SuppId.ToString()));
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if(productService.IsExistProduct(TextBox1.Text.Trim()))
        {
            Label1.Text = "商品已经存在";
        }
        else
        {
            string fileName;
            string fileFolder;
            string dateTime = "";
            fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
            dateTime += DateTime.Now.Year.ToString();
            dateTime += DateTime.Now.Month.ToString();
            dateTime += DateTime.Now.Day.ToString();
            dateTime += DateTime.Now.Hour.ToString();
            dateTime += DateTime.Now.Minute.ToString();
            dateTime += DateTime.Now.Second.ToString();
            fileName = dateTime + fileName;
            fileFolder = Server.MapPath("~/") + "Prod_Images\\" + DropDownList1.SelectedItem.Text + "\\";
            fileFolder = fileFolder + fileName;
            FileUpload1.PostedFile.SaveAs(fileFolder);
            productService.Add("~\\Prod_Images\\" + DropDownList1.SelectedItem.Text + "\\" + fileName, TextBox1.Text.Trim(), int.Parse(DropDownList1.SelectedValue), int.Parse(DropDownList2.SelectedValue), decimal.Parse(TextBox2.Text.Trim()), decimal.Parse(TextBox3.Text.Trim()), TextBox4.Text.Trim(), int.Parse(TextBox5.Text.Trim()));
            Response.Redirect("ProductMaster.aspx");
        }
    }
}