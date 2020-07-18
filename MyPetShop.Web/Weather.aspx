<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Weather.aspx.cs" Inherits="Weather" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>天气预报</title>
    <link href="Styles/Weather.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <table style="text-align:center; border: 0; width: 680px; margin:0 auto;">
                <tr>
                    <td style="text-align:center;height:60px;">
                        <asp:Label Font-Bold="true" ID="Label1" runat="server" Text="国内外主要城市  3天天气预报"></asp:Label>
                        </td>
                    </tr>
            <tr>
                <td>
                    <table style=" border: 0; width: 100%;">
                        <tr>
                            <td style="width:25%;">
                        <strong>选择省/洲</strong>
                        <asp:DropDownList CssClass="list" ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                        </td>
                        <td>
                        <strong>选择城市</strong>
                        <asp:DropDownList CssClass="list" ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                        </asp:DropDownList>
                        </td>
                       </tr>
                    </table>
                    </td>
                </tr>
            <tr>
                <td>
                    <table style=" border: 2px solid #fff; width: 100%;">
                        <tr>
                            <td style="width:15%; height:30px;">&nbsp;
                                </td>
                            <td style="text-align:right;">
                        <asp:Label ID="Label2" runat="server" CssClass="bredfont" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="vertical-align:top;">
                     <strong>今日实况</strong> 
                        </td>
                    <td class="hfont">
                     <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
                </tr>
                <tr>
                    <td style="vertical-align:top;">&nbsp;
                        </td>>
                    <td>&nbsp;
                        </td>
                    </tr>
                        <tr>
                            <td style="vertical-align:top;">
                     <strong>天气预报</strong><span style="color:#FF0033">(今天)</span>
                            </td>
                            <td class="hfont">
                        <asp:Label ID="Label4" runat="server"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Image ID="Image1" runat="server" AlternateText="icon" ImageAlign="AbsMiddle" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:Image ID="Image2" runat="server" AlternateText="icon" ImageAlign="AbsMiddle" />&nbsp;
                    </td>
                </tr>
                <tr>
                    <td style="vertical-align:top;">
                        <strong>今天指数</strong>
                        </td>
                    <td>&nbsp;
                        </td>
                    </tr>
                        <tr>
                            <td colspan="2" style="vertical-align:top;" class="hfont">
                                <asp:Label ID="Label5" runat="server"></asp:Label>
                                 </td>
                    </tr>
                        <tr>
                         <td style="vertical-align:top;">&nbsp;
                             </td>
                            <td>&nbsp;
                            </td>
                            </tr>
                        <tr>
                            <td style="vertical-align:top;">
                     <strong>天气预报</strong><span style="color:#3333FF">(明天)</span>
                                </td>
                            <td class="hfont">
                        <asp:Label ID="Label6" runat="server"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Image ID="Image3" runat="server" AlternateText="icon" ImageAlign="AbsMiddle" />
                        &nbsp;&nbsp;&nbsp; 
                        <asp:Image ID="Image4" runat="server" AlternateText="icon" ImageAlign="AbsMiddle" />
                    </td>
                </tr>
                <tr>
                    <td style="vertical-align:top;">&nbsp;
                        </td>
                    <td>&nbsp;
                        </td>
                    </tr>
                        <tr>
                        <td style="vertical-align:top;"> 
                    <strong>天气预报</strong><span style="color:#006633">(后天)</span>
                            </td>
                            <td class="hfont">
                        <asp:Label ID="Label7" runat="server"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Image ID="Image5" runat="server" AlternateText="icon" ImageAlign="AbsMiddle"/>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Image ID="Image6" runat="server" AlternateText="icon" ImageAlign="AbsMiddle"/>
                        </td>
                            </tr>
                        <tr>
                            <td style="vertical-align:top;">&nbsp;
                                </td>
                            <td>&nbsp;
                                </td>
                            </tr>
                        <tr>
                            <td colspan="2" style="vertical-align:top;">
                                <strong>城市介绍</strong>
                                </td>
                            </tr>
                        <tr>
                            <td colspan="2" style="vertical-align:top;" class="hfont">                      
                      <asp:Label ID="Label8" runat="server"></asp:Label>
                    </td>
                </tr>
                    <tr>
                        <td colspan="2" style="vertical-align:bottom;text-align:right;height:30px">
                            <strong>预报时间</strong>
                             <asp:Label ID="Label9" runat="server"></asp:Label>
                            </td>
                        </tr>
            </table>
                    </td>
                </tr>
            </table>
    </form>
</body>
</html>
