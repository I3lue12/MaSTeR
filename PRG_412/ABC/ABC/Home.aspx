<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>
<%--directive has a language which is c#, event lets us know that there is code in it, CodeFile ind Inherits come from home--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <asp:Label ID="lblMsg" runat="server" Text="Some Text"></asp:Label>
        </div>
        <asp:ListBox ID="lbMessage" runat="server" Height="300px" Width="424px"></asp:ListBox>
        <br />
        <asp:Label ID="lblUser" runat="server" Text="User:"></asp:Label>
        <asp:TextBox ID="tbName" runat="server" Width="182px"></asp:TextBox>
        <br />
        <asp:Label ID="lblAge" runat="server" Text="Age:"></asp:Label>
        <asp:TextBox ID="tbAge" runat="server" Width="183px"></asp:TextBox>
        <br />
        <asp:Button ID="btnGo" runat="server" OnClick="btnGo_Click" Text="GO" Width="96px" />
        <asp:Button ID="btnIncrement" runat="server" OnClick="btnIncrement_Click" Text="+" Width="44px" />
        <asp:Button ID="btnDecrement" runat="server" OnClick="btnDecrement_Click" Text="-" Width="39px" />
        <br />
        <br />
    </form>
</body>
</html>
