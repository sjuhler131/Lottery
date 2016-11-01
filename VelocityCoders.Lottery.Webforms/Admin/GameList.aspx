<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GameList.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.GameList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Game List</h1>
        <br />
        <a href="Index.aspx">Index</a>
    <table>
        <asp:Repeater runat="server" ID="rptGameList">
            <HeaderTemplate>
                <tr>
                    <td>GameId</td>
                    <td>GameName</td>
                    <td>Description</td>
                    <td>HowToPlay</td>
                    <td>&nbsp;</td>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("GameId") %></td>
                    <td><%# Eval("GameName") %></td>
                    <td><%# Eval("Description") %></td>
                    <td><%# Eval("HowToPlay") %></td>
                    <td><a href='GameDetails.aspx?GameId=<%# Eval("GameId") %>'>Details</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    </div>
    </form>
</body>
</html>
