﻿<%@ Page Title="分类管理" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CategoryMaster.aspx.cs" Inherits="Admin_CategoryMaster" %>

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
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"  TypeName="MyPetShop.BLL.CategoryService" DeleteMethod="DeleteCategory" InsertMethod="InsertCategory" SelectMethod="GetAllCategories" UpdateMethod="UpdateCategory">
        <DeleteParameters>
            <asp:Parameter Name="categoryId" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="categoryId" Type="Int32" />
            <asp:Parameter Name="name" Type="String" />
            <asp:Parameter Name="descn" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="categoryId" Type="Int32" />
            <asp:Parameter Name="name" Type="String" />
            <asp:Parameter Name="descn" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" AutoGenerateRows="False" DataKeyNames="CategoryId" DataSourceID="ObjectDataSource1" OnItemDeleting="DetailsView1_ItemDeleting" AutoGenerateInsertButton="True">
        <Fields>
            <asp:BoundField DataField="CategoryId" HeaderText="分类ID" Visible="False" />
            <asp:BoundField DataField="Name" HeaderText="分类名称" />
            <asp:BoundField DataField="Descn" HeaderText="分类描述" />
        </Fields>
    </asp:DetailsView>
    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
</asp:Content>

