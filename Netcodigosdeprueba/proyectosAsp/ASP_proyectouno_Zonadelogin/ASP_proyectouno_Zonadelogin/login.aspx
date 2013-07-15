<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ASP_proyectouno_Zonadelogin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;">
            <tr>
                <td>usuario</td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblMensaje" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>clave</td>
                <td>
                    <asp:TextBox ID="TxtClave" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Btnlogin" runat="server" OnClick="Btnlogin_Click" Text="login" />
                </td>
            </tr>
       
        </table>
    </div>
    </form>
</body>
</html>
