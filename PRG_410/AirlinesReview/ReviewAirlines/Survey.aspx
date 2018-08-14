<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Survey.aspx.cs" Inherits="ReviewAirlines.Survey" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>          
            <asp:Label ID="lblSurvey" runat="server" Text="Label"></asp:Label>
            
            
            
            <!-- Project 8-5
                Create a Web page that stores airline surveys in a database. Save the project in a folder named AirlineSurveys in your Projects folder for Chapter 8. 
                Include fields for the date and time of the flight, flight number, and so on. 
                Also, include groups of radio buttons that allow the user to rate the airline on the following criteria:
            	• Friendliness of customer staff
            	• Space for luggage storage
            	• Comfort of seating
            	• Cleanliness of aircraft
            	• Noise level of aircraft
                The radio buttons for each question should consist of the following options:
                No Opinion, Poor, Fair, Good, or Excellent.
                Separate text files should store the results of a single survey.
-->
            <br />
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="89px" Width="1077px" SelectionMode="Single" OnSelectedIndexChanged="ProcessSelection" AutoPostBack="true">
                <%--<asp:ListItem Text="Item 1"></asp:ListItem>
                <asp:ListItem Text="Item 2"></asp:ListItem> --%>
            </asp:ListBox>
            <br />
            <br />
            Friendliness: <asp:RadioButtonList runat="server" OnSelectedIndexChanged="Unnamed_SelectedIndexChanged" ID="RBListFriend" AutoPostBack="true" RepeatDirection="Horizontal"></asp:RadioButtonList>
            Comort:       <asp:RadioButtonList runat="server" OnSelectedIndexChanged="Unnamed_SelectedIndexChanged" ID ="RBLComfort" AutoPostBack="true" RepeatDirection="Horizontal"></asp:RadioButtonList>
            Noise:        <asp:RadioButtonList runat="server" OnSelectedIndexChanged="Unnamed_SelectedIndexChanged" ID="RBLNoise" AutoPostBack="true" RepeatDirection="Horizontal"></asp:RadioButtonList>
            Cleanliness:  <asp:RadioButtonList runat="server" OnSelectedIndexChanged="Unnamed_SelectedIndexChanged" ID="RBLCleanliness" AutoPostBack="true" RepeatDirection="Horizontal"></asp:RadioButtonList>
            Space:        <asp:RadioButtonList runat="server" OnSelectedIndexChanged="Unnamed_SelectedIndexChanged" ID="RBLSpace" AutoPostBack="true" RepeatDirection="Horizontal"></asp:RadioButtonList>
               
                  <asp:Button ID="Button1" runat="server" Height="28px" OnClick="Get_Survey" Text="Button" Width="78px" />
            <br />
            <br />
               
                <%-- <table runat="server" id="table">
                      <tr><td>Friendliness</td>
                          
                          <td><input type="radio" runat="server" name="gFriendliness" id="F0" onclick="HandleCick_Friendliness"/>No Opinion</td>
                          <td><input type="radio" runat="server" name="gFriendliness" id="F1" onclick="HandleCick_Friendliness"/>Poor</td>
                          <td><input type="radio" runat="server" name="gFriendliness" id="F2" onclick="HandleCick_Friendliness"/>Fair</td>
                          <td><input type="radio" runat="server" name="gFriendliness" id="F3" onclick="HandleCick_Friendliness"/>Good</td>
                          <td><input type="radio" runat="server" name="gFriendliness" id="F4" onclick="HandleCick_Friendliness"/>Excellent</td>
                      </tr>
                      <tr><td>Comfort</td>
                        
                          <td><input type="radio" runat="server" name="gComfort" id="C0" autopostback="true"/>No Opinion</td>                       
                          <td><input type="radio" runat="server" name="gComfort" id="C1" onclick="HandleCick_Comfort"/>Poor</td>
                          <td><input type="radio" runat="server" name="gComfort" id="C2" onclick="HandleCick_Comfort"/>Fair</td>
                          <td><input type="radio" runat="server" name="gComfort" id="C3" onclick="HandleCick_Comfort"/>Good</td>
                          <td><input type="radio" runat="server" name="gComfort" id="C4" onclick="HandleCick_Comfort"/>Excellent</td>

                      </tr>
                      <tr><td>Noise</td>
                          <td><input type="radio" runat="server" name="gNoise" id="N0" autopostback="true"/>No Opinion</td>
                          <td><input type="radio" runat="server" name="gNoise" id="N1" onclick="HandleCick_Noise"/>Poor</td>
                          <td><input type="radio" runat="server" name="gNoise" id="N2" onclick="HandleCick_Noise"/>Fair</td>
                          <td><input type="radio" runat="server" name="gNoise" id="N3" onclick="HandleCick_Noise"/>Good</td>
                          <td><input type="radio" runat="server" name="gNoise" id="N4" onclick="HandleCick_Noise"/>Excellent</td></tr>
                      <tr><td>Cleanliness</td>
                          <td><input type="radio" runat="server" name="gCleanliness" id="Cl0" autopostback="true"/>No Opinion</td>
                          <td><input type="radio" runat="server" name="gCleanliness" id="Cl1" onclick="HandleCick_Cleanliness"/>Poor</td>
                          <td><input type="radio" runat="server" name="gCleanliness" id="Cl2" onclick="HandleCick_Cleanliness"/>Fair</td>
                          <td><input type="radio" runat="server" name="gCleanliness" id="Cl3" onclick="HandleCick_Cleanliness"/>Good</td>
                          <td><input type="radio" runat="server" name="gCleanliness" id="Cl4" onclick="HandleCick_Cleanliness"/>Excellent</td>
                      </tr>
                      <tr><td>Space</td>
                          <td><input type="radio" runat="server" name="gSpace" id="S0" autopostback="true"/>No Opinion</td>
                          <td><input type="radio" runat="server" name="gSpace" id="S1" onclick="HandleCick_Space"/>Poor</td>
                          <td><input type="radio" runat="server" name="gSpace" id="S2" onclick="HandleCick_Space"/>Fair</td>
                          <td><input type="radio" runat="server" name="gSpace" id="S3" onclick="HandleCick_Space"/>Good</td>
                          <td><input type="radio" runat="server" name="gSpace" id="S4" onclick="HandleCick_Space"/>Excellent</td>
                      </tr>
                  </table>--%>
            <br />
            <br />
            <%--<asp:Table ID="Table1" runat="server">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Friendliness</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Comfort</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Cleanliness</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Noise</asp:TableCell>
                </asp:TableRow>
            </asp:Table> --%>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
