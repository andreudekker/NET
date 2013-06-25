<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Asp_BD_Completa.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        REGISTRO CLIENTES<br />
        ----------------------------------------------------------------------------------------------------------------------------------------------------<br />
        <table class="auto-style1">
            <tr>
                <td>Codigo Cliente para Actualizar</td>
                <td>
                    <asp:TextBox ID="TxtCodigoActualizar" runat="server" Width="229px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar" Width="85px" OnClick="BtnActualizar_Click" />
                </td>
            </tr>
        </table>
    -----------------------------------------------------------------------------------------------------------------------------------------------------
        Empresa
        <asp:TextBox ID="TxtEmpresa" runat="server"></asp:TextBox>
        <br />
        <table class="auto-style1">
            <tr>
                <td>Nombre</td>
                <td>
                    <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFV_Nombre" runat="server" ControlToValidate="TxtNombre" ErrorMessage="(*)"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="REV_Nombre" runat="server" ControlToValidate="TxtNombre" ErrorMessage="Solo es valido letras" ValidationExpression="[a-z A-Z]+"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Apellido</td>
                <td>
                    <asp:TextBox ID="TxtApellido" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFV_Apellido" runat="server" ControlToValidate="TxtApellido" ErrorMessage="(*)"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="REV_Apellido" runat="server" ControlToValidate="TxtApellido" ErrorMessage="Solo es valido letras" ValidationExpression="[a-z A-Z]+"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>¨Puesto</td>
                <td>
                    <asp:TextBox ID="TxtPuesto" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFV_Puesto" runat="server" ControlToValidate="TxtPuesto" ErrorMessage="(*)"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Direccion</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TxtDireccion" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFV_Direccion" runat="server" ControlToValidate="TxtDireccion" ErrorMessage="(*)"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Poblacion</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TxtPoblacion" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFV_Poblacion" runat="server" ControlToValidate="TxtPoblacion" ErrorMessage="(*)"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Telefono</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TxtTelefono" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFV_Telefono" runat="server" ControlToValidate="TxtTelefono" ErrorMessage="(*)"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="REV_Telefono" runat="server" ControlToValidate="TxtTelefono" ErrorMessage="El numero del telefono no  es correcto es  XXX-XXXX" ValidationExpression="[0-9][0-9][0-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Codigo Postal</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TxtCodigoPostal" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFV_CodigoPostal" runat="server" ControlToValidate="TxtCodigoPostal" ErrorMessage="(*)"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="REV_CodigoPostal" runat="server" ControlToValidate="TxtCodigoPostal" ErrorMessage="Codigo valido es +503" ValidationExpression="[+][5][0][3]"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" />
                </td>
                <td>
                    <asp:Button ID="BtnMostrarDatos" runat="server" Text="Mostrar Datos" OnClick="BtnMostrarDatos_Click" />
                </td>
            </tr>
        </table>
        ------------------------------------------------------------------------------------------------------------------------------------------------------------------<br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        --------------------------------------------------------------------------------------------------------------------------------------------------------------<br />
        Escriba el codigo de registro que desea eliminar<br />
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:TextBox ID="TxtEliminarRegistro" runat="server" Width="277px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" Width="133px" OnClick="BtnEliminar_Click" />
                </td>
            </tr>
        </table>
        Nota: Una vez elimine el registro no se podra eliminar<br />
    
    </div>
    </form>
</body>
</html>
