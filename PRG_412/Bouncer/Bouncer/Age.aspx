<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Age.aspx.cs" Inherits="Age" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblLoginUser" runat="server"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLogout" runat="server" OnClick="Button1_Click" Text="Logout" />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="+" Width="68px" />
            <asp:Button ID="btnSub" runat="server" OnClick="btnSub_Click" Text="-" Width="60px" />
        </div>
    </form>
</body>
</html>
