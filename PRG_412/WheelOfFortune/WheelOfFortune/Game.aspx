<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Game.aspx.cs" Inherits="Game" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblGameWelcome" runat="server" Text="Welcome to the Game!!!!!!!!"></asp:Label>
            <br />
            <asp:Button ID="btnGameLogout" runat="server" OnClick="btnGameLogout_Click" Text="Logout" />
            <br />
            <asp:Label ID="lblGameUser" runat="server" Text="sah dude!"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="tbHidden" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblGameGuess" runat="server" Text="Guess Character: "></asp:Label>
            <br />
            <asp:TextBox ID="tbGameCharaGuess" runat="server" Width="29px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnGameGuess" runat="server" OnClick="btnGameGuess_Click" Text="Guess" />
            <br />
            <br />
            <asp:Label ID="lblGameReGuesses" runat="server" Text="Remaining Guesses:"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Guesses Made:  "></asp:Label>
            <asp:TextBox ID="tbGameGuessesMade" runat="server" ReadOnly="True" Width="354px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
