<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GameDetails.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.GameDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Game Details</h1>
        <a href="Index.aspx">Index</a>&nbsp;&nbsp; <a href="GameList.aspx">Game List</a>
        <br />
        <br />
        <asp:Label runat="server" ID ="lblMessage" />
        <br />
        <b>Game ID:</b> &nbsp; <asp:Label runat="server" ID ="lblGameId" />
        <br />
        <b>Game Name:</b> &nbsp; <asp:Label runat="server" ID ="lblGameName" />
        <br />
        <b>Description:</b> &nbsp; <asp:Label runat="server" ID ="lblDescription" />
        <br />
        <b>How to play:</b> &nbsp; <asp:Label runat="server" ID ="lblHowToPlay" />
    </div>
    </form>
</body>
</html>
