<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserStatus.ascx.cs" Inherits="UserControl_UserStatus" %>
<asp:Label ID="Label1" runat="server" Text="您还未登录!"></asp:Label>
            <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="White" PostBackUrl="~/ChangePassword.aspx" Visible="False">密码修改</asp:LinkButton>
            <asp:LinkButton ID="LinkButton2" runat="server" ForeColor="White" PostBackUrl="~/Admin/Default.aspx" Visible="False">系统管理</asp:LinkButton>
            <asp:LinkButton ID="LinkButton3" runat="server" ForeColor="White" PostBackUrl="~/OrderList.aspx" Visible="False">购物记录</asp:LinkButton>
            <asp:LinkButton ID="LinkButton4" runat="server" ForeColor="White" OnClick="LinkButton4_Click" Visible="False">退出登录</asp:LinkButton>