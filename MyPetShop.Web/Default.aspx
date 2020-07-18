﻿<%@ Page Title="MyPetShop-首页" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="~/UserControl/NewProduct.ascx" TagName="NewProduct" TagPrefix="uc" %>
<%@ Register Src="~/UserControl/Category.ascx" TagName="Category" TagPrefix="uc" %>
<%@ Register Src="~/UserControl/Weather.ascx" TagName="Weather" TagPrefix="uc" %>
<%@ Register Src="~/UserControl/AutoShow.ascx" TagName="AutoShow" TagPrefix="uc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        p{
            margin:5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <p>最新商品</p>
            <uc:NewProduct ID="NewProduct1" runat="server" title="最新商品" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <uc:Weather ID="Weather1" runat="server" title="天气预报" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <p>商品分类</p>
            <uc:Category ID="Category1" runat="server" title="商品分类" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
            <uc:AutoShow ID="AutoShow1" runat="server" title="热销商品" />
</asp:Content>

