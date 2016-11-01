<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityList.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.CityList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>City List</h1>
        <br />
        <a href="Index.aspx">Index</a>
    <table>
        <asp:Repeater runat="server" ID="rptCityList">
            <HeaderTemplate>
                <tr>
                    <td>CityId</td>
                    <td>CityName</td>
                    <td>&nbsp;</td>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("CityId") %></td>
                    <td><%# Eval("CityName") %></td>
                    <td><a href='CityDetails.aspx?CityId=<%# Eval("CityId") %>'>Details</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    </div>
    </form>
</body>
</html>
