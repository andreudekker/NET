<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="producto.aspx.cs" Inherits="ASP_aplicacionregistroIEA.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="PanelModificar" runat="server">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:Label ID="lblEstado" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Panel ID="PanelMostrar" runat="server">
                editar:<br />
                <input id="Text1" type="text" />
                <asp:Button ID="Button2" runat="server" Text="Modificar producto" />
                <br />
                <br />
            </asp:Panel>
            <asp:Panel ID="PanelRegistro" runat="server">
                <table style="width:100%;">
                    <tr>
                        <td>Nombre</td>
                        <td>
                            <asp:TextBox ID="txtnombreproducto" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Descripcion</td>
                        <td>
                            <asp:TextBox ID="txtdescripcion" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Codigodelproveedor</td>
                        <td>
                            <asp:TextBox ID="txtcodigoproveedor" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Precio por Unidad</td>
                        <td>
                            <asp:TextBox ID="txtprecioporunidad" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Unidades en exitencia</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtunidadesenexistencia" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="RegistrarProducto" />
                        </td>
                        <td>
                            <asp:HyperLink ID="HyperLink1" runat="server" Target="_self">Mostrar todos los productos registrados</asp:HyperLink>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
