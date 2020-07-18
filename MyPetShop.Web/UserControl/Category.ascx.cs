using System;
using MyPetShop.BLL;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class UserControl_Category : System.Web.UI.UserControl
{
    CategoryService categoryService = new CategoryService();

    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = categoryService.GetAllCategories();
        GridView1.DataBind();
    }

    protected string GetProductCountByCategoryId(string id)
    {
        return "(" + categoryService.GetProductCountByCategoryId(int.Parse(id)).ToString() + ")";
    }
}