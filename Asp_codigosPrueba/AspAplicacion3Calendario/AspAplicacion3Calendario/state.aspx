<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="state.aspx.cs" Inherits="AspAplicacion3Calendario.state" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table  border="1">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                            <TodayDayStyle BackColor="#CCCCCC" />
                        </asp:Calendar>
                    </td>
                  
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BtnConfigurarHora" runat="server" OnClick="BtnConfigurarHora_Click" Text="Configurar Hora" />
                    </td>
                    <td>
                        <asp:Button ID="btnPlanPostBack" runat="server" Text="Plan Postback" />
                    </td>
                
                </tr>
                
            </table>
        </div>
    </form>
</body>
</html>
