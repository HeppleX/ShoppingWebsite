using System;
using System.Data;
using System.Web.UI.WebControls;
using WeatherService;

public partial class UserControl_Weather : System.Web.UI.UserControl
{
    WeatherWebService weather = new WeatherWebService();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataSet ds = weather.getSupportDataSet();
            if (!IsPostBack)
            {
                DataTable dt = ds.Tables[0];
                DropDownList1.DataSource = dt;
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataTextField = "Zone";
                DropDownList1.DataBind();
                DropDownList2.SelectedIndex = 1;
                CityDataBind("1");
                GetWeather("54511");
            }
        }
        catch (Exception)
        {
            Label6.Text = "网络连接异常";
        }
    }
    protected void CityDataBind(string zoneID)
    {
        DataView dv = new DataView(weather.getSupportDataSet().Tables[1]);
        dv.RowFilter = "[ZoneID]=" + zoneID;
        DropDownList2.DataSource = dv;
        DropDownList2.DataTextField = "Area";
        DropDownList2.DataValueField = "AreaCode";
        DropDownList2.DataBind();
        DropDownList2.Items.Insert(0, new ListItem("选择城市", "0"));
        DropDownList2.SelectedIndex = 0;
    }

    protected void GetWeather(string cityCode)
    {
        string[] wa = weather.getWeatherbyCityName(cityCode.Trim());
        Label2.Text = wa[10];
        Label3.Text = wa[6] + "&nbsp;&nbsp;&nbsp;" + wa[5] + "&nbsp;&nbsp;&nbsp;" + wa[7];
        Label4.Text = wa[13] + "&nbsp;&nbsp;&nbsp;" + wa[12] + "&nbsp;&nbsp;&nbsp;" + wa[14];
        Label5.Text = wa[18] + "&nbsp;&nbsp;&nbsp;" + wa[17] + "&nbsp;&nbsp;&nbsp;" + wa[19];
        Label1.Text = wa[0] + "/" + wa[1];
        Image1.ImageUrl = "~/Images/weather/" + wa[8];
        Image2.ImageUrl = "~/Images/weather/" + wa[9];
        Image3.ImageUrl = "~/Images/weather/" + wa[15];
        Image4.ImageUrl = "~/Images/weather/" + wa[16];
        Image5.ImageUrl = "~/Images/weather/" + wa[20];
        Image6.ImageUrl = "~/Images/weather/" + wa[21];
    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        CityDataBind(DropDownList1.SelectedItem.Value.Trim());
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList2.Items[0].Value == "0")
        {
            DropDownList2.Items.RemoveAt(0);
        }
        GetWeather(DropDownList2.SelectedItem.Value.Trim());
    }
}