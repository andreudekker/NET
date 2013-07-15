<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="gridCodigo.aspx.cs" Inherits="AspGridview.gridCodigo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:GridView ID="GridViewRegistro" runat="server" AllowPaging="True" OnPageIndexChanging="GridViewRegistro_PageIndexChanging" OnRowEditing="GridViewRegistro_RowEditing">
                <Columns>
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
<asp:DropDownList ID="DropDownList1" runat="server">
</asp:DropDownList>
<asp:Button ID="BtnListar" runat="server" Text="BtnListar" />
</asp:Content>
