<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GameDetailList.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.GameDetailList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Game Detail List</h1>
        <br />
        <a href="Index.aspx">Index</a>
    <table>
        <asp:Repeater runat="server" ID="rptGameDetailList">
            <HeaderTemplate>
                <tr>
                    <td>GameDetailId</td>
                    <td>GameId</td>
                    <td>Match</td>
                    <td>Odds</td>
                    <td>Prize</td>
                    <td>&nbsp;</td>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("GameDetailId") %></td>
                    <td><%# Eval("GameId") %></td>
                    <td><%# Eval("Match") %></td>
                    <td><%# Eval("Odds") %></td>
                    <td><%# Eval("Prize") %></td>
                    <td><a href='GameDetailDetails.aspx?GameDetailId=<%# Eval("GameDetailId") %>'>Details</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    </div>
    </form>
</body>
</html>
