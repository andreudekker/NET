<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GriedViewDetailwsViewConAsp.Properties.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="BusinessEntityID,Expr1" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="BusinessEntityID" HeaderText="BusinessEntityID" ReadOnly="True" SortExpression="BusinessEntityID" Visible="False" />
                <asp:BoundField DataField="Expr1" HeaderText="Expr1" ReadOnly="True" SortExpression="Expr1" />
                <asp:BoundField DataField="PersonType" HeaderText="PersonType" SortExpression="PersonType" />
                <asp:CheckBoxField DataField="NameStyle" HeaderText="NameStyle" SortExpression="NameStyle" />
                <asp:BoundField DataField="PasswordSalt" HeaderText="PasswordSalt" SortExpression="PasswordSalt" />
                <asp:BoundField DataField="PasswordHash" HeaderText="PasswordHash" SortExpression="PasswordHash" />
                <asp:BoundField DataField="rowguid" HeaderText="rowguid" SortExpression="rowguid" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorks2012ConnectionString %>" SelectCommand="SELECT Person.Person.BusinessEntityID, Person.Password.BusinessEntityID AS Expr1, Person.Person.PersonType, Person.Person.NameStyle, Person.Password.PasswordSalt, Person.Password.PasswordHash, Person.Password.rowguid FROM Person.Person INNER JOIN Person.Password ON Person.Person.BusinessEntityID = Person.Password.BusinessEntityID"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
