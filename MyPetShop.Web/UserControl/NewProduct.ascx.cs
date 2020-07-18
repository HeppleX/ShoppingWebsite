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

public partial class UserControl_NewProduct : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductService productService = new ProductService();
        GridView1.DataSource = productService.GetNewProduct(7);
        GridView1.DataBind();
    }
}