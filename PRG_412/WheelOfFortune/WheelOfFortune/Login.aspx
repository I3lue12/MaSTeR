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
            <br />
            <asp:Label ID="lbUserLogin" runat="server" Text="USERNAME: "></asp:Label>
            <br />
            <asp:TextBox ID="tbName" runat="server" OnTextChanged="tbName_TextChanged"></asp:TextBox>
            <br />
            Difficulty:<br />
            <asp:DropDownList ID="ddlDif" runat="server" AutoPostBack="True" Height="18px" OnSelectedIndexChanged="ddlDif_SelectedIndexChanged" Width="123px">
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" Width="85px" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
