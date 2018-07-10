<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="New.aspx.cs" Inherits="UserPass.New" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            new<br />
        </div>
        <table>
            <tr>
                <td>Login</td>
                <td>
                    <input type="text" id="login" />
                </td>

            </tr>
            <tr>
                <td>
                    Password 
                </td>
                <td>
                    <input type="text" id="password" />
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnNewUser" runat="server" OnClick="addUser" Text="Add Me!" />
    </form>
</body>
</html>
