using MyPetShop.BLL;
using System;
using System.Web.UI.WebControls;

public partial class UserControl_PetTree : System.Web.UI.UserControl
{
    ProductService productService = new ProductService();
    CategoryService categoryService = new CategoryService();

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            BindTree();
        }
    }
    protected void BindTree()
    {
        var categories = categoryService.GetAllCategories();
        foreach(var category in categories)
        {
            TreeNode treeNode = new TreeNode();
            treeNode.Text = category.Name;
            treeNode.Value = category.CategoryId.ToString();
            treeNode.NavigateUrl = "~/ProShow.aspx?CategoryId=" + category.CategoryId.ToString();
            TreeView1.Nodes.Add(treeNode);
            BindTreeChild(treeNode, category.CategoryId);
        }
    }
    protected void BindTreeChild(TreeNode tn, int categoryId)
    {
        var products = productService.GetProductByCategoryId(categoryId);
        foreach(var product in products)
        {
            TreeNode treeNode = new TreeNode();
            treeNode.Text = product.Name;
            treeNode.Value = product.ProductId.ToString();
            treeNode.NavigateUrl = "~/ProShow.aspx?ProductId=" + product.ProductId.ToString();
            tn.ChildNodes.Add(treeNode);
        }
    }
}