<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Weather.ascx.cs" Inherits="UserControl_Weather" %>
 <table style="border: 0; width: 100%; padding-right: 2px; padding-left: 2px; margin-right: 2px; margin-left: 2px;">
                <tr>
                    <td>
                        <strong>选择省/洲&nbsp;</strong>
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                        <strong>&nbsp; 选择城市</strong>&nbsp;&nbsp;
                        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label1" runat="server" ForeColor="#CC0033"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                     <strong>今日实况&nbsp;</strong>                       
                     <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
                </tr>
                <tr>
                    <td>
                     <strong>天气预报</strong><span style="color:#FF0033">(今天)</span>&nbsp;&nbsp;
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Image ID="Image1" runat="server" AlternateText="icon" ImageAlign="AbsMiddle" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:Image ID="Image2" runat="server" AlternateText="icon" ImageAlign="AbsMiddle" />&nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                     <strong>天气预报</strong><span style="color:#3333FF">(明天)</span>&nbsp;&nbsp;
                        <asp:Label ID="Label4" runat="server"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Image ID="Image3" runat="server" AlternateText="icon" ImageAlign="AbsMiddle" />
                        &nbsp;&nbsp;&nbsp; 
                        <asp:Image ID="Image4" runat="server" AlternateText="icon" ImageAlign="AbsMiddle" />
                    </td>
                </tr>
                <tr>
                    <td>
                    <strong>天气预报</strong><span style="color:#006633">(后天)</span>&nbsp;&nbsp;
                        <asp:Label ID="Label5" runat="server"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Image ID="Image5" runat="server" AlternateText="icon" ImageAlign="AbsMiddle"/>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Image ID="Image6" runat="server" AlternateText="icon" ImageAlign="AbsMiddle"/>
                        &nbsp;&nbsp;&nbsp;
                        <br />
                       <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#666666" NavigateUrl="~/Weather.aspx" Target="_blank">更多信息</asp:HyperLink>
                       &nbsp;&nbsp;&nbsp;
                      <asp:Label ID="Label6" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>