

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PruebaAsp2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form method="post" action="page.aspx" id="form1" runat="server">
   <div>
    Enter your first name &nbsp;
       <input type="text" name="First Name" />
       <br />
    Enter your last name &nbsp;
       <input type="text" name="Last name" />
       <br />
       <br />
       You program with:
       <br />&nbsp;&nbsp;&nbsp;
       <input type="checkbox" name="cs" />C#
       <br />&nbsp;&nbsp;&nbsp;
       <input type="checkbox" name="Vb" /> VB.NET
       <br /><br />
       <input type="submit" value="submit" id="ok" />

    </div>
    </form>
</body>
</html>
