<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GameForm.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.GameForm.GameForm" %>

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
              <td><asp:TextBox runat="server" ID="txtGameName" MaxLength="50" /></td>
            </tr>
            <tr>
              <td><label>Game Name Abbreviation:</label></td>
              <td><asp:TextBox runat="server" ID="txtGameNameAbbreviation" MaxLength="10" /></td>
            </tr>
            <tr>
                <td><label>How to Play:</label></td>
                <td><asp:TextBox runat="server" ID="txtHowtoPlay" TextMode="MultiLine" /></td>
            </tr>
             <tr>
                <td><label>Description:</label></td>
                <td><asp:TextBox runat="server" ID="txtDescription" TextMode="MultiLine" /></td>
            </tr>
            </table>
        <asp:Button runat="server" Text="Save" OnClick="Save_Click" />
    </div>
        <div>
            <asp:Label runat="server" ID="lblDisplayMessage" />
        </div>
        <br />
        <a href="../DrawingForm/DrawingForm.aspx">Go to Drawing Form</a>
    </form>
</body>
</html>
