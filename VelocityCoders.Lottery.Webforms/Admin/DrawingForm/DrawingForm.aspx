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
                        <asp:DropDownList runat="server" ID="drpGameName">
                            <asp:ListItem Text="(Select Game)" Value ="0" />
                            <asp:ListItem Text="Powerball" Value ="Powerball" />
                            <asp:ListItem Text="Mega Millions" Value ="MegaMillions" />
                            <asp:ListItem Text="Gopher 5" Value ="Gopher5" />
                            <asp:ListItem Text="North Star Cash" Value ="NorthStarCash" />
                        </asp:DropDownList>
                        
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
    <asp:Button runat="server" Text="Save" OnClick="Save_Click" />
    </div>
        <br />
        <div>
            <asp:Label runat="server" ID="lblDisplayMessage" />
        </div>
        <br />
        <a href="../GameForm/GameForm.aspx">Go to Game Form</a>
    </form>
</body>
</html>
