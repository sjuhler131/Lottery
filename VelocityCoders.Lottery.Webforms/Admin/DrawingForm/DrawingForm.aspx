<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DrawingForm.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.DrawingForm.DrawingForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <img src="/Images/MN-lottery-header.jpg" />
        <br />
        <br />
            <table>
                <tr>
                    <td><label>Game Name:</label></td>
                    <td>
                        <asp:DropDownList runat="server" ID="drpGameName"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><label>Drawing Date:</label></td>
                    <td>
                        <asp:TextBox runat="server" ID="txtDrawingDate"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><label>Jackpot Amount:</label></td>
                    <td>
                        <asp:TextBox runat="server" ID="txtJackpotAmount"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><label>Cash Option Amount</label></td>
                    <td>
                        <asp:TextBox runat="server" ID="txtCashOptionAmount"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><label>Multiplier</label></td>
                    <td>
                        <asp:TextBox runat="server" ID="txtMultiplier"></asp:TextBox>
                    </td>
                </tr>
            </table>
    </div>
    </form>
</body>
</html>
