<%@ Page Title="购物车" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShopCart.aspx.cs" Inherits="ShopCart" %>

<%@ Register Src="~/UserControl/PetTree.ascx" TagName="PetTree" TagPrefix="uc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<uc:PetTree ID="PetTree1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="ProId" HeaderText="商品ID" />
                <asp:BoundField DataField="ProName" HeaderText="商品名称" />
                <asp:BoundField DataField="ListPrice" DataFormatString="{0:c}" HeaderText="商品价格" />
                <asp:TemplateField HeaderText="购买数量">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Width="30px" Text='<%#Bind("Qty")%>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label><br />
        <asp:Label ID="Label2" runat="server" ForeColor="Green"></asp:Label><br />
        总价：<asp:Label ID="Label3" runat="server"></asp:Label>
        &nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="删除商品" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="清空购物车" OnClick="Button2_Click" />&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="重新计算" OnClick="Button3_Click" />&nbsp;
        <asp:Button ID="Button4" runat="server" Text="结算" OnClick="Button4_Click" />
    </asp:Panel>
    <asp:Label ID="Label4" runat="server"></asp:Label>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
</asp:Content>

