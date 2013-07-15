<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmGridView.aspx.cs" Inherits="ASP_Griedview.FrmGridView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataProductos" Width="847px" AutoGenerateColumns="False" DataKeyNames="idregistro" AllowPaging="True" AllowSorting="True">
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
        <asp:BoundField DataField="idregistro" HeaderText="idregistro" InsertVisible="False" ReadOnly="True" SortExpression="idregistro" />
        <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
        <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido" />
        <asp:BoundField DataField="correoelectronico" HeaderText="correoelectronico" SortExpression="correoelectronico" />
        <asp:BoundField DataField="contraseña" HeaderText="contraseña" SortExpression="contraseña" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataProductos" runat="server" ConnectionString="<%$ ConnectionStrings:FastFoodConnectionString %>" DeleteCommand="DELETE FROM [registro] WHERE [idregistro] = @idregistro" InsertCommand="INSERT INTO [registro] ([nombre], [apellido], [correoelectronico], [contraseña]) VALUES (@nombre, @apellido, @correoelectronico, @contraseña)" SelectCommand="SELECT [idregistro], [nombre], [apellido], [correoelectronico], [contraseña] FROM [registro]" UpdateCommand="UPDATE [registro] SET [nombre] = @nombre, [apellido] = @apellido, [correoelectronico] = @correoelectronico, [contraseña] = @contraseña WHERE [idregistro] = @idregistro">
    <DeleteParameters>
        <asp:Parameter Name="idregistro" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="nombre" Type="String" />
        <asp:Parameter Name="apellido" Type="String" />
        <asp:Parameter Name="correoelectronico" Type="String" />
        <asp:Parameter Name="contraseña" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="nombre" Type="String" />
        <asp:Parameter Name="apellido" Type="String" />
        <asp:Parameter Name="correoelectronico" Type="String" />
        <asp:Parameter Name="contraseña" Type="String" />
        <asp:Parameter Name="idregistro" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>
