<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BallTypeList.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.BallTypeList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Ball Type List</h1>
        <br />
        <a href="Index.aspx">Index</a>
    <table>
        <asp:Repeater runat="server" ID="rptBallTypeList">
            <HeaderTemplate>
                <tr>
                    <td>BallTypeId</td>
                    <td>BallTypeName</td>
                    <td>Sequence</td>
                    <td>&nbsp;</td>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("BallTypeId") %></td>
                    <td><%# Eval("BallTypeName") %></td>
                    <td><%# Eval("Sequence") %></td>
                    <td><a href='BallTypeDetails.aspx?BallTypeId=<%# Eval("BallTypeId") %>'>Details</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    </div>
    </form>
</body>
</html>
