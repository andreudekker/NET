<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormControles.aspx.cs" Inherits="ASP_niveluno.FormControles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <p>
        f<asp:Label ID="Label1" runat="server" Text="Seleccione una lista"></asp:Label>
        <asp:DropDownList ID="Ddldatosdetablas" runat="server" AutoPostBack="True" DataSourceID="SqlDataFastFood">
        </asp:DropDownList>
        <asp:Button ID="btnListar" runat="server" Text="Listar" />
        <asp:SqlDataSource ID="SqlDataFastFood" runat="server" ConnectionString="<%$ ConnectionStrings:FastFoodConnectionString %>" SelectCommand="sp_mostrarinformacionFastFood" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="Ddldatosdetablas" Name="TABLA" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
    <asp:UpdatePanel ID="UpdatePanelInformacion" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" DataSourceID="SqlDataFastFood">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Ddldatosdetablas" EventName="SelectedIndexChanged" />
        </Triggers>
    </asp:UpdatePanel>
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
