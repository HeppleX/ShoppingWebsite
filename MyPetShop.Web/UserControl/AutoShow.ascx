<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AutoShow.ascx.cs" Inherits="UserControl_AutoShow" %>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
            <ProgressTemplate>
                正在连接服务器，请耐心等待......
            </ProgressTemplate>
        </asp:UpdateProgress>
        <asp:Timer ID="Timer1" runat="server" Enabled="False" Interval="3000" OnTick="Timer1_Tick"></asp:Timer>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging" PagerSettings-Mode="NextPrevious" PageSize="1" Width="100%">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <table style="border: 1px solid #808080; width: 100%;">
                            <tr>
                                <td rowspan="7" style="text-align: center; vertical-align: middle; border-width: 1px; width: 40%">
                                    <asp:Image ID="Image1" runat="server" Height="60px" ImageUrl='<%# Bind("Image")%>' Width="60px" />
                                </td>
                                <td style="border: 1px solid #808080; width: 40%">商品编号:</td>
                                <td style="border: 1px solid #808080; width: 20%">
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("ProductId")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="border-width: 1px; border-style: solid; border-color: #808080">商品名称:</td>
                                <td style="border-width: 1px; border-style: solid; border-color: #808080">
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="border-width: 1px; border-style: solid; border-color: #808080">商品价格:</td>
                                <td style="border-width: 1px; border-style: solid; border-color: #808080">
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("ListPrice") %>'></asp:Label>
                                </td>    
                            </tr>
                            <tr>
                                <td style="border-width: 1px; border-style: solid; border-color: #808080">库存:</td>
                                <td style="border-width: 1px; border-style: solid; border-color: #808080">
                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("Qty") %>'></asp:Label>
                                </td> 
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:HyperLinkField DataNavigateUrlFields="ProductId" DataNavigateUrlFormatString="~/ShopCart.aspx?ProductId={0}" DataTextFormatString="{0:c}" HeaderText="放入购物车" Text="购买" />
            </Columns>
            <PagerSettings FirstPageText="首页" LastPageText="尾页" Mode="NextPrevious" NextPageText="下一页" PreviousPageText="上一页" />
        </asp:GridView>
        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="3秒后显示下一个商品" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
    </Triggers>
</asp:UpdatePanel>

