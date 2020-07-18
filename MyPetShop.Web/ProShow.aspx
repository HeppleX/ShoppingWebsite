<%@ Page Title="商品详情" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProShow.aspx.cs" Inherits="ProShow" %>

<%@ Register Src="~/UserControl/PetTree.ascx" TagName="PetTree" TagPrefix="uc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<uc:PetTree ID="PetTree1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="4" Width="100%">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <table style="border:1px solid #808080; width:100%;" >
                        <tr>
                            <td rowspan="7" style="text-align:center;border:1px; vertical-align:middle; width:40%;">
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("Image")%>' Height="100px" Width="100px" />
                            </td>
                            <td style="border:1px solid #808080; width:40%;">商品编号:</td>
                            <td style="border:1px solid #808080; width:20%;">
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("ProductId")%>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="border:1px solid #808080;">商品分类:</td>
                            <td style="border:1px solid #808080;">
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("CategoryId")%>'></asp:Label>
                            </td>                           
                        </tr>
                        <tr>
                            <td style="border:1px solid #808080;">商品名称:</td>
                            <td style="border:1px solid #808080;">
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Name")%>'></asp:Label>
                            </td>                           
                        </tr>
                        <tr>
                             <td style="border:1px solid #808080;">商品价格:</td>
                            <td style="border:1px solid #808080;">
                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("ListPrice")%>'></asp:Label>
                            </td>    
                        </tr>
                        <tr>
                             <td style="border:1px solid #808080;">单位成本:</td>
                            <td style="border:1px solid #808080;">
                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("UnitCost")%>'></asp:Label>
                            </td>    
                        </tr>
                        <tr>
                             <td style="border:1px solid #808080;">商品描述:</td>
                            <td style="border:1px solid #808080;">
                                <asp:Label ID="Label6" runat="server" Text='<%# Bind("Descn")%>'></asp:Label>
                            </td>    
                        </tr>
                        <tr>
                             <td style="border:1px solid #808080;">库存:</td>
                            <td style="border:1px solid #808080;">
                                <asp:Label ID="Label7" runat="server" Text='<%# Bind("Qty")%>'></asp:Label>
                            </td>    
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:HyperLinkField DataNavigateUrlFields="ProductId" DataNavigateUrlFormatString="~/ShopCart.aspx?ProductId={0}" DataTextFormatString="{0:c}" HeaderText="放入购物车" Text="购买" />
        </Columns>
        <PagerSettings FirstPageText="首页" LastPageText="尾页" Mode="NextPrevious" NextPageText="下一页" Position="TopAndBottom" PreviousPageText="上一页" />
    </asp:GridView>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
</asp:Content>

