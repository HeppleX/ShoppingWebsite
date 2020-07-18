<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NewProduct.ascx.cs" Inherits="UserControl_NewProduct" %>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/arrow.gif" />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:HyperLinkField DataNavigateUrlFields="ProductId" DataNavigateUrlFormatString="~/ProShow.aspx?CategoryId={0}" DataTextField="Name" DataTextFormatString="{0:c}" HeaderText="商品名称" />
        <asp:BoundField DataField="ListPrice" DataFormatString="{0:c}" HeaderText="商品价格">
        <HeaderStyle HorizontalAlign="Center" Width="90px" />
        <ItemStyle HorizontalAlign="Center" />
        </asp:BoundField>
    </Columns>
    <EditRowStyle BackColor="#7C6F57" />
    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#CCCCD4" Font-Bold="True" ForeColor="Black" />
    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#E3EAEB" />
    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
</asp:GridView>