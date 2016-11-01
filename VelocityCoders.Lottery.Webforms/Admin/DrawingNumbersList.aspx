<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DrawingNumbersList.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.DrawingNumbersList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Drawing Numbers List</h1>
        <br />
        <a href="Index.aspx">Index</a>
    <table>
        <asp:Repeater runat="server" ID="rptDrawingNumbersList">
            <HeaderTemplate>
                <tr>
                    <td>DrawingNumbersId</td>
                    <td>BallTypeId</td>
                    <td>DrawingId</td>
                    <td>Number</td>
                    <td>&nbsp;</td>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("DrawingNumbersId") %></td>
                    <td><%# Eval("BallTypeId") %></td>
                    <td><%# Eval("DrawingId") %></td>
                    <td><%# Eval("Number") %></td>
                    <td><a href='DrawingNumbersDetails.aspx?DrawingNumbersId=<%# Eval("DrawingNumbersId") %>'>Details</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        </table>
    </div>
    </form>
</body>
</html>
