<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AspProyectoUno.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pagina Proyecto Uno</title>
    <!--Estilo Css-->
    <link rel="stylesheet" href="css/miestilo.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="fechaActual" runat="server" Text="hora"></asp:Label><!--fecha actual-->

            <table style="width: 100%;" border="1">
                <tr>
                    <td id="tituloYahoo">Yahoo</td>
                    <td>
                        <asp:Image runat="server" ImageUrl="~/img/yahoo.jpg" ID="yahooImg" />
                    </td>
                </tr>
                <tr>
                    <td  id="tituloGoogle">Google</td>
                    <td>
                        <asp:Image runat="server" ImageUrl="~/img/google.jpg" ID="googleImg" />
                    </td>
                </tr>
                <tr>
                    <td id="tituloMsn">Msn</td>
                    <td>
                        <asp:Image runat="server" ImageUrl="~/img/Msn.jpg" ID="msnImg" />
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
