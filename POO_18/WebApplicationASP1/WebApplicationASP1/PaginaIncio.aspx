<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaIncio.aspx.cs" Inherits="WebApplicationASP1.PaginaIncio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style type="text/css">
    p {
    text-align:center;
   font-style:oblique;
    font-size:15px;
    margin-top:-20px;
    color:silver;
    }
    h1 {
    text-align:center;
    font-weight:bolder;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>PAGINA DE INICIO</h1>
        <p>Contenido<asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
            <asp:HyperLink ID="HyperLink2" runat="server">HyperLink</asp:HyperLink>
            <asp:HyperLink ID="HyperLink3" runat="server">HyperLink</asp:HyperLink>
        </p>
            <%Response.Write("Mi Nombre Con Apellido") %>
    </div>
    </form>
</body>
</html>
