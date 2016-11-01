<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WhereToPlayList.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.WhereToPlayList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Where To Play List</h1>
        <br />
        <a href="Index.aspx">Index</a>
    <table>
        <asp:Repeater runat="server" ID="rptWhereToPlayList">
            <HeaderTemplate>
                <tr>
                    <td>WhereToPlayId</td>
                    <td>GameId</td>
                    <td>StateId</td>
                    <td>CityId</td>
                    <td>AddressName</td>
                    <td>AddressNumber</td>
                    <td>Street01</td>
                    <td>Street02</td>
                    <td>ZipCode</td>
                    <td>ZipCodePlusFour</td>
                    <td>&nbsp;</td>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("WhereToPlayId") %></td>
                    <td><%# Eval("GameId") %></td>
                    <td><%# Eval("StateId") %></td>
                    <td><%# Eval("CityId") %></td>
                    <td><%# Eval("AddressName") %></td>
                    <td><%# Eval("AddressNumber") %></td>
                    <td><%# Eval("Street01") %></td>
                    <td><%# Eval("Street02") %></td>
                    <td><%# Eval("ZipCode") %></td>
                    <td><%# Eval("ZipCodePlusFour") %></td>
                    <td><a href='WhereToPlayDetails.aspx?WhereToPlayId=<%# Eval("WhereToPlayId") %>'>Details</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    </div>
    </form>
</body>
</html>
