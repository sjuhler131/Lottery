<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StateList.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.StateList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>State List</h1>
        <br />
        <a href="Index.aspx">Index</a>
    <table>
        <asp:Repeater runat="server" ID="rptStateList">
            <HeaderTemplate>
                <tr>
                    <td>StateId</td>
                    <td>StateName</td>
                    <td>StateAbbreviation</td>
                    <td>&nbsp;</td>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("StateId") %></td>
                    <td><%# Eval("StateName") %></td>
                    <td><%# Eval("StateAbbreviation") %></td>
                    <td><a href='StateDetails.aspx?StateId=<%# Eval("StateId") %>'>Details</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    </div>
    </form>
</body>
</html>
