<%@ Page Title="订单管理" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OrderMaster.aspx.cs" Inherits="Admin_OrderMaster" %>

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
<asp:Panel ID="Panel1" runat="server"> 
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging" Width="100%" PageSize="10">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate> 
                    <asp:CheckBox ID="CheckBox1" runat="server" /> 
                </ItemTemplate>
            </asp:TemplateField>
            <asp:HyperLinkField DataNavigateUrlFields="OrderId" DataNavigateUrlFormatString="~/Admin/OrderSub.aspx?OrderId={0}" Text="订单详情" DataTextFormatString="{0:c}" HeaderText="订单详情" />
            <asp:BoundField DataField="OrderId" HeaderText="订单ID" />
            <asp:BoundField DataField="UserName" HeaderText="用户" />
            <asp:BoundField DataField="Status" HeaderText="审核状态" />
        </Columns>
        <PagerSettings FirstPageText="首页" LastPageText="尾页" Mode="NextPrevious" NextPageText="下一页" Position="TopAndBottom" PreviousPageText="上一页" />
    </asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="审核商品" OnClick="Button1_Click" />
    </asp:Panel>
    <asp:Label ID="Label1" runat="server"></asp:Label>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
</asp:Content>

