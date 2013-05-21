<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Miformuario1.aspx.cs" Inherits="WebApplicationASP1.Miformuario1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Formulario de prueba</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="Accion" OnClick="Button1_Click" />
               <br />
             <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
        </div>
    </form>
</body>
</html>
