<%@ Page Title="商品详情" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProductSub.aspx.cs" Inherits="Admin_ProductSub" %>

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
        <table style="width:100%;border:3px solid #fff;">
            <tr>
                <td style="text-align:center;" colspan="2">
                    <strong>更新商品</strong>
                </td>
            </tr>
            <tr>
                <td style="width:17%;text-align:right;">商品名称:
                </td>
                <td style="width:83%;">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="不能为空" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:right;">商品分类:
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="不能为空" ControlToValidate="DropDownList1"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align:right;">商品单价:
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="不能为空" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align:right;">单位成本:
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="不能为空" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
               <td style="text-align:right;">提供商:
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="不能为空" ControlToValidate="DropDownList2"></asp:RequiredFieldValidator>
            </td>
                    </tr>
            <tr>
               <td style="text-align:right;">描述:
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Height="89px" TextMode="MultiLine" Width="263px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="不能为空" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align:right;">库存:
                </td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="不能为空" ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align:right;">商品图片:
                </td>
                <td>
                    <asp:Image ID="Image1" runat="server" />
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="不能为空" ControlToValidate="FileUpload1"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align:right;">&nbsp;
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="更新商品" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
</asp:Content>

