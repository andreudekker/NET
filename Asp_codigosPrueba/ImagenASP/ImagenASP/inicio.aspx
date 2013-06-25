<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="ImagenASP.imagenes.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="idcliente" HeaderText="idcliente" InsertVisible="False" ReadOnly="True" SortExpression="idcliente" />
                <asp:BoundField DataField="cliente" HeaderText="cliente" SortExpression="cliente" />
                <asp:BoundField DataField="Habitacion" HeaderText="Habitacion" SortExpression="Habitacion" />
                <asp:ImageField AlternateText="homero" DataImageUrlField="foto" FooterText="homero" HeaderText="Foto" >
                </asp:ImageField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HabitacionFotoConnectionString %>" SelectCommand="SELECT [idcliente], [cliente], [foto], [Habitacion] FROM [HabitacionFoto]"></asp:SqlDataSource>
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
