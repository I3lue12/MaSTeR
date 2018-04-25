<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>          <!--<asp:Button ID="Button1" runat="server" Text="Button" /> -->
        </div>
        <asp:Label ID="Label1" runat="server" Text="Enter In Somthing:     "></asp:Label>
        <asp:TextBox ID="txtBoxItemEnter" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnListAdd" runat="server" Text="Add To List" OnClick="Button_Click" />
        <br />
        <br />
        <asp:ListBox ID="lstBoxItemsAdded" runat="server" Height="103px" Width="194px" OnInit="SelectedText" OnSelectedIndexChanged="OnSelectedChange" AutoPostBack="true"></asp:ListBox>
        <br />
        <br />
        <asp:Label ID="lbl_ListBoxSelection" runat="server" Text="details of selection" ViewStateMode="Enabled"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;
    </form>
</body>
</html>
