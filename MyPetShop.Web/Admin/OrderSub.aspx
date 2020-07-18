<%@ Page Title="订单详情" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OrderSub.aspx.cs" Inherits="Admin_OrderSub" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<a href="CategoryMaster.aspx">分类管理</a>
<br />
<br />
<a href="SupplierMaster.aspx">供应商管理</a>
<br />
<br />
<a href="ProductMaster.aspx">商品管理</a>
<br />
<br />
<a href="OrderMaster.aspx">订单管理</a>
<br />
<br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    订单主表
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <table style="width:100%;border:1px solid #ccc;">
            <tr>
                <td style=" width:20%; border:1px solid #ccc; height:24px; text-align:right;">订单ID:
 
                </td>
                <td style="width:80%;">
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("OrderId") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                 <td style="border:1px solid #ccc; height:24px; text-align:right;">客户名称:
                </td>
                <td style="border:1px solid #ccc; height:24px;">
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("UserName") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                 <td style="border:1px solid #ccc; height:24px; text-align:right;">订购时间:
                </td>
                <td style="border:1px solid #ccc; height:24px;">
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("OrderDate") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                 <td style="border:1px solid #ccc; height:24px; text-align:right;">地址1:
                </td>
                <td style="border:1px solid #ccc; height:24px;">
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("Addr1") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                 <td style="border:1px solid #ccc; height:24px; text-align:right;">地址2:
                </td>
                <td style="border:1px solid #ccc; height:24px;">
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("Addr2") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                 <td style="border:1px solid #ccc; height:24px; text-align:right;">城市:
                </td>
                <td style="border:1px solid #ccc; height:24px;">
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("City") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                 <td style="border:1px solid #ccc; height:24px; text-align:right;">区域:
                </td>
                <td style="border:1px solid #ccc; height:24px;">
                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("State") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                 <td style="border:1px solid #ccc; height:24px; text-align:right;">邮编:
                </td>
                <td style="border:1px solid #ccc; height:24px;">
                    <asp:Label ID="Label8" runat="server" Text='<%# Bind("Zip") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                 <td style="border:1px solid #ccc; height:24px; text-align:right;">手机:
                </td>
                <td style="border:1px solid #ccc; height:24px;">
                    <asp:Label ID="Label9" runat="server" Text='<%# Bind("Phone") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                 <td style="border:1px solid #ccc; height:24px; text-align:right;">审核状态:
                </td>
                <td style="border:1px solid #ccc; height:24px;">
                    <asp:Label ID="Label10" runat="server" Text='<%# Bind("Status") %>'></asp:Label>
                </td>
            </tr>
        </table>
       </ItemTemplate>
      </asp:TemplateField>
     </Columns>
    </asp:GridView>
    购买详情
    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" OnPageIndexChanging="GridView2_PageIndexChanging">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/arrow.gif" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ItemId" HeaderText="序列号" />
            <asp:BoundField DataField="OrderId" HeaderText="订单号" />
            <asp:BoundField DataField="ProName" HeaderText="商品名称" />
            <asp:BoundField DataField="ListPrice" HeaderText="商品单价" />
            <asp:BoundField DataField="Qty" HeaderText="购买数量" />
            <asp:BoundField DataField="TotalPrice" HeaderText="总价" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#CCCCD4" Font-Bold="True" ForeColor="Black" />
        <PagerSettings FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" Position="TopAndBottom" PreviousPageText="上一页" />
        <PagerStyle BackColor="#ffffff" HorizontalAlign="Left" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    </asp:GridView>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
</asp:Content>

