using MyPetShop.BLL;
using System;
using System.Collections.Generic;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService]
public class SearchService : System.Web.Services.WebService
{

    public SearchService()
    {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string[] GetStrings(string prefixText ,int count)
    {
        ProductService productService = new ProductService();
        var products = productService.GetProductBySearchText(prefixText);
        List<String> list = new List<string>(count);
        foreach (var product in products)
        {
            list.Add(product.Name);
        }
        return list.ToArray();
    }
}
