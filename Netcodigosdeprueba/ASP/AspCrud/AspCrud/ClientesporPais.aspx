<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientesporPais.aspx.cs" Inherits="AspCrud.ClientesporPais" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Seleccione Pais"></asp:Label>
    
    </div>
        <asp:DropDownList ID="ddPaises" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddPaises_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <asp:GridView ID="gvPaises" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
