<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CostList.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.CostList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Cost List</h1>
        <br />
        <a href="Index.aspx">Index</a>
    <table>
        <asp:Repeater runat="server" ID="rptCostList">
            <HeaderTemplate>
                <tr>
                    <td>CostId</td>
                    <td>GameId</td>
                    <td>CostAmount</td>
                    <td>&nbsp;</td>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("CostId") %></td>
                    <td><%# Eval("GameId") %></td>
                    <td><%# Eval("CostAmount") %></td>
                    <td><a href='CostDetails.aspx?CostId=<%# Eval("CostId") %>'>Details</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        </table>
    </div>
    </form>
</body>
</html>
