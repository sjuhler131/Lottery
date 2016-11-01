<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DrawingList.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.DrawingList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Drawing List</h1>
        <br />
        <a href="Index.aspx">Index</a>
    <table>
        <asp:Repeater runat="server" ID="rptDrawingList">
            <HeaderTemplate>
                <tr>
                    <td>DrawingId</td>
                    <td>GameId</td>
                    <td>DrawingDate</td>
                    <td>Jackpot</td>
                    <td>Multiplier</td>
                    <td>&nbsp;</td>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("DrawingId") %></td>
                    <td><%# Eval("GameId") %></td>
                    <td><%# Eval("DrawingDate") %></td>
                    <td><%# Eval("Jackpot") %></td>
                    <td><%# Eval("Multiplier") %></td>
                    <td><a href='DrawingDetails.aspx?DrawingId=<%# Eval("DrawingId") %>'>Details</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        </table>
    </div>
    </form>
</body>
</html>
