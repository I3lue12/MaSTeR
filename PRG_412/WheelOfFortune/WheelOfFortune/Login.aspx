<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbLogin" runat="server" Text="WHEEL OF FORTUNE"></asp:Label>
            <br />
            <asp:Label ID="lbUserLogin" runat="server" Text="USERNAME: "></asp:Label>
            <br />
            <asp:TextBox ID="tbName" runat="server" OnTextChanged="tbName_TextChanged"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" Width="85px" />
        </div>
    </form>
</body>
</html>
