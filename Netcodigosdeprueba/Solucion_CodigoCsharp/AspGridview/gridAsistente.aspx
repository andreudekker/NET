<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="gridAsistente.aspx.cs" Inherits="AspGridview.gridAsistente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <asp:GridView ID="GridViewAdventure" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataSourceID="SqlDataSourceAdventure" ForeColor="Black" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ProductID" Width="600px">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="ProductNumber" HeaderText="ProductNumber" SortExpression="ProductNumber" />
            <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
            <asp:BoundField DataField="rowguid" HeaderText="rowguid" SortExpression="rowguid" />
            <asp:BoundField DataField="ModifiedDate" HeaderText="ModifiedDate" SortExpression="ModifiedDate" />
            <asp:BoundField DataField="StandardCost" HeaderText="StandardCost" SortExpression="StandardCost" />
            <asp:BoundField DataField="ListPrice" HeaderText="ListPrice" SortExpression="ListPrice" />
        </Columns>
    <FooterStyle BackColor="#CCCCCC" />
    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
    <RowStyle BackColor="White" />
    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F1F1F1" />
    <SortedAscendingHeaderStyle BackColor="#808080" />
    <SortedDescendingCellStyle BackColor="#CAC9C9" />
    <SortedDescendingHeaderStyle BackColor="#383838" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSourceAdventure" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:AdventureWorks2012ConnectionString %>" DeleteCommand="DELETE FROM [Person] WHERE [BusinessEntityID] = @original_BusinessEntityID AND [PersonType] = @original_PersonType AND [NameStyle] = @original_NameStyle AND (([Title] = @original_Title) OR ([Title] IS NULL AND @original_Title IS NULL)) AND [FirstName] = @original_FirstName AND (([MiddleName] = @original_MiddleName) OR ([MiddleName] IS NULL AND @original_MiddleName IS NULL)) AND [LastName] = @original_LastName AND (([Suffix] = @original_Suffix) OR ([Suffix] IS NULL AND @original_Suffix IS NULL)) AND [EmailPromotion] = @original_EmailPromotion AND (([AdditionalContactInfo] = @original_AdditionalContactInfo) OR ([AdditionalContactInfo] IS NULL AND @original_AdditionalContactInfo IS NULL)) AND (([Demographics] = @original_Demographics) OR ([Demographics] IS NULL AND @original_Demographics IS NULL)) AND [rowguid] = @original_rowguid AND [ModifiedDate] = @original_ModifiedDate" InsertCommand="INSERT INTO [Person] ([BusinessEntityID], [PersonType], [NameStyle], [Title], [FirstName], [MiddleName], [LastName], [Suffix], [EmailPromotion], [AdditionalContactInfo], [Demographics], [rowguid], [ModifiedDate]) VALUES (@BusinessEntityID, @PersonType, @NameStyle, @Title, @FirstName, @MiddleName, @LastName, @Suffix, @EmailPromotion, @AdditionalContactInfo, @Demographics, @rowguid, @ModifiedDate)" OldValuesParameterFormatString="original_{0}" SelectCommand="ConsultaAdventureWorks" UpdateCommand="UPDATE [Person] SET [PersonType] = @PersonType, [NameStyle] = @NameStyle, [Title] = @Title, [FirstName] = @FirstName, [MiddleName] = @MiddleName, [LastName] = @LastName, [Suffix] = @Suffix, [EmailPromotion] = @EmailPromotion, [AdditionalContactInfo] = @AdditionalContactInfo, [Demographics] = @Demographics, [rowguid] = @rowguid, [ModifiedDate] = @ModifiedDate WHERE [BusinessEntityID] = @original_BusinessEntityID AND [PersonType] = @original_PersonType AND [NameStyle] = @original_NameStyle AND (([Title] = @original_Title) OR ([Title] IS NULL AND @original_Title IS NULL)) AND [FirstName] = @original_FirstName AND (([MiddleName] = @original_MiddleName) OR ([MiddleName] IS NULL AND @original_MiddleName IS NULL)) AND [LastName] = @original_LastName AND (([Suffix] = @original_Suffix) OR ([Suffix] IS NULL AND @original_Suffix IS NULL)) AND [EmailPromotion] = @original_EmailPromotion AND (([AdditionalContactInfo] = @original_AdditionalContactInfo) OR ([AdditionalContactInfo] IS NULL AND @original_AdditionalContactInfo IS NULL)) AND (([Demographics] = @original_Demographics) OR ([Demographics] IS NULL AND @original_Demographics IS NULL)) AND [rowguid] = @original_rowguid AND [ModifiedDate] = @original_ModifiedDate" SelectCommandType="StoredProcedure">
    <DeleteParameters>
        <asp:Parameter Name="original_BusinessEntityID" Type="Int32" />
        <asp:Parameter Name="original_PersonType" Type="String" />
        <asp:Parameter Name="original_NameStyle" Type="Boolean" />
        <asp:Parameter Name="original_Title" Type="String" />
        <asp:Parameter Name="original_FirstName" Type="String" />
        <asp:Parameter Name="original_MiddleName" Type="String" />
        <asp:Parameter Name="original_LastName" Type="String" />
        <asp:Parameter Name="original_Suffix" Type="String" />
        <asp:Parameter Name="original_EmailPromotion" Type="Int32" />
        <asp:Parameter Name="original_AdditionalContactInfo" Type="Object" />
        <asp:Parameter Name="original_Demographics" Type="Object" />
        <asp:Parameter Name="original_rowguid" Type="Object" />
        <asp:Parameter Name="original_ModifiedDate" Type="DateTime" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="BusinessEntityID" Type="Int32" />
        <asp:Parameter Name="PersonType" Type="String" />
        <asp:Parameter Name="NameStyle" Type="Boolean" />
        <asp:Parameter Name="Title" Type="String" />
        <asp:Parameter Name="FirstName" Type="String" />
        <asp:Parameter Name="MiddleName" Type="String" />
        <asp:Parameter Name="LastName" Type="String" />
        <asp:Parameter Name="Suffix" Type="String" />
        <asp:Parameter Name="EmailPromotion" Type="Int32" />
        <asp:Parameter Name="AdditionalContactInfo" Type="Object" />
        <asp:Parameter Name="Demographics" Type="Object" />
        <asp:Parameter Name="rowguid" Type="Object" />
        <asp:Parameter Name="ModifiedDate" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="PersonType" Type="String" />
        <asp:Parameter Name="NameStyle" Type="Boolean" />
        <asp:Parameter Name="Title" Type="String" />
        <asp:Parameter Name="FirstName" Type="String" />
        <asp:Parameter Name="MiddleName" Type="String" />
        <asp:Parameter Name="LastName" Type="String" />
        <asp:Parameter Name="Suffix" Type="String" />
        <asp:Parameter Name="EmailPromotion" Type="Int32" />
        <asp:Parameter Name="AdditionalContactInfo" Type="Object" />
        <asp:Parameter Name="Demographics" Type="Object" />
        <asp:Parameter Name="rowguid" Type="Object" />
        <asp:Parameter Name="ModifiedDate" Type="DateTime" />
        <asp:Parameter Name="original_BusinessEntityID" Type="Int32" />
        <asp:Parameter Name="original_PersonType" Type="String" />
        <asp:Parameter Name="original_NameStyle" Type="Boolean" />
        <asp:Parameter Name="original_Title" Type="String" />
        <asp:Parameter Name="original_FirstName" Type="String" />
        <asp:Parameter Name="original_MiddleName" Type="String" />
        <asp:Parameter Name="original_LastName" Type="String" />
        <asp:Parameter Name="original_Suffix" Type="String" />
        <asp:Parameter Name="original_EmailPromotion" Type="Int32" />
        <asp:Parameter Name="original_AdditionalContactInfo" Type="Object" />
        <asp:Parameter Name="original_Demographics" Type="Object" />
        <asp:Parameter Name="original_rowguid" Type="Object" />
        <asp:Parameter Name="original_ModifiedDate" Type="DateTime" />
    </UpdateParameters>
</asp:SqlDataSource>
<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSourceAdventure" DataTextField="Name" DataValueField="ProductID">
</asp:DropDownList>
<asp:Button ID="Button1" runat="server" Text="Listar" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
