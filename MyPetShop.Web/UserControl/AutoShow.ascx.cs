using MyPetShop.BLL;
using System;
using System.Web.UI.WebControls;

public partial class UserControl_AutoShow : System.Web.UI.UserControl
{
    ProductService productservice = new ProductService();
    protected void Page_Load(object sender, EventArgs e)
    {
        Bind();
    }

    protected void Bind()
    {
        GridView1.DataSource = productservice.GetAllProducts();
        GridView1.DataBind();
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        int newPageIndex = GridView1.PageIndex;
        if (newPageIndex == GridView1.PageCount - 1)
        {
            newPageIndex = 0;
        }
        else
        {
            newPageIndex += 1;
        }
        GridView1.PageIndex = newPageIndex;
        System.Threading.Thread.Sleep(3000);
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        Bind();
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        Timer1.Enabled = CheckBox1.Checked;
    }
}