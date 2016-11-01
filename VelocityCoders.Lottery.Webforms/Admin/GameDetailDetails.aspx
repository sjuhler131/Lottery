<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GameDetailDetails.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.GameDetailDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Game Detail Details</h1>
        <a href="Index.aspx">Index</a>&nbsp;&nbsp; <a href="GameDetailList.aspx">Game Detail List</a>
        <br />
        <br />
        <asp:Label runat="server" ID ="lblMessage" />
        <br />
        <b>Game Detail ID:</b> &nbsp; <asp:Label runat="server" ID ="lblGameDetailId" />
        <br />
        <b>Game ID:</b> &nbsp; <asp:Label runat="server" ID ="lblGameId" />
        <br />
        <b>Match:</b> &nbsp; <asp:Label runat="server" ID ="lblMatch" />
        <br />
        <b>Odds:</b> &nbsp; <asp:Label runat="server" ID ="lblOdds" />
        <br />
        <b>Prize:</b> &nbsp; <asp:Label runat="server" ID ="lblPrize" />
    </div>
    </form>
</body>
</html>
