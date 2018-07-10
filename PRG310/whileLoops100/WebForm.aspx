<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="whileLoops100.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
               <%

                   int goTo = 0;
                   List<int> tenOrLess, Twenty, thirty, fourty, fifty, sixty, seventy, eighty, ninty,lessHundred;
                   tenOrLess = new List<int>();
                   Twenty = new List<int>();
                   thirty = new List<int>();
                   fourty = new List<int>();
                   fifty = new List<int>();
                   sixty = new List<int>();
                   seventy = new List<int>();
                   eighty = new List<int>();
                   ninty = new List<int>();
                   lessHundred = new List<int>();
                   Response.Write("count to hundred: ");
                   while( goTo < 100)
                   {
                       Response.Write(goTo += 2);
                   }
                   Response.Write("</br>");
                   Response.Write("Primes: 1, 2");
                   for(int i=3;i<=100;i++)
                   {
                       bool isPrime=true;
                       for(int j=2;j<=Math.Sqrt(i);j++)
                       {
                           if(i%j==0)
                           {
                               isPrime=false;
                               break;
                           }
                       }
                       if(isPrime)
                       {

                           Response.Write(", "+i);
                           if(i < 11)
                           {
                               tenOrLess.Add(1);
                               tenOrLess.Add(2);
                               tenOrLess.Add(i);
                           }
                           else if(11 < i && i < 21 )
                           {
                               Twenty.Add(i);
                           }
                           else if(20 < i && i < 31)
                           {
                               thirty.Add(i);
                           }
                           else if(30 < i && i < 41)
                           {
                               fourty.Add(i);
                           }
                           else if(40 < i && i < 51)
                           {
                               fifty.Add(i);
                           }
                           else if(50 < i && i < 61)
                           {
                               sixty.Add(i);
                           }
                           else if(60 < i && i < 71)
                           {
                               seventy.Add(i);
                           }
                           else if(70 < i && i < 81)
                           {
                               eighty.Add(i);
                           }
                           else if(80 < i && i<91)
                           {
                               ninty.Add(i);
                           }
                           else
                           {
                               lessHundred.Add(i);
                           }

                           //add two more counters
                       }
                   }
                   Response.Write("</br>");
                   Response.Write("how many primes between 10's: ");
                   Response.Write(tenOrLess.Count.ToString() + ","
                                 + Twenty.Count.ToString() + ","
                                 + thirty.Count.ToString() + ","
                                 + fourty.Count.ToString() + ","
                                 + fifty.Count.ToString() + ","
                                 + sixty.Count.ToString() + ","
                                 + seventy.Count.ToString() + ","
                                 + eighty.Count.ToString() + ","
                                 + ninty.Count.ToString() + ","
                                 + lessHundred.Count.ToString());




                   %>
        </div>
    </form>
</body>
</html>
