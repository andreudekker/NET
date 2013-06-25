<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PruebaASP_3.WebForm1" %>

<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Enter your first name:&nbsp;
        <input type="text" name="First Name" />
        <br />
        Enter your last name:&nbsp;
        <input type="text" name="last name" />
        <br /> <br />   
        you program with
        <br />&nbsp;&nbsp;&nbsp;
        <input type="checkbox"  name="CS"/> C#
        <br />&nbsp;&nbsp;&nbsp;
        <input type="checkbox" name="VB" />Vb.Net
        <br />
        <br />
        <input type="submit" value="submit" id="ok" />

       <asp:Label id="lblInfo" runat="server" EnableViewState="False">
        </asp:Label>
      <asp:Button id="Button1" runat="server" Text="Button">
        </asp:Button>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:BoundField />
                <asp:CheckBoxField />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Button" />
        <br />
        <uc1:WebUserControl1 ID="WebUserControl11" runat="server" />
        <br />
    </div>
    </form>
</body>
</html>
