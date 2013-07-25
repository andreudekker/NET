<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="fotoASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Seleccione un empleado"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlEmpleado" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEmpleado_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <asp:Image ID="imgEmpleado" runat="server" />
    
    </div>
    </form>
</body>
</html>
