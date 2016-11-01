<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DrawingDetails.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.DrawingDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Drawing Details</h1>
        <a href="Index.aspx">Index</a>&nbsp;&nbsp; <a href="DrawingList.aspx">Drawing List</a>
        <br />
        <br />
        <asp:Label runat="server" ID ="lblMessage" />
        <br />
        <b>Drawing ID:</b> &nbsp; <asp:Label runat="server" ID ="lblDrawingId" />
        <br />
        <b>Game ID:</b> &nbsp; <asp:Label runat="server" ID ="lblGameId" />
        <br />
        <b>Drawing Date:</b> &nbsp; <asp:Label runat="server" ID ="lblDrawingDate" />
        <br />
        <b>Jackpot:</b> &nbsp; <asp:Label runat="server" ID ="lblJackpot" />
        <br />
        <b>Multiplier:</b> &nbsp; <asp:Label runat="server" ID ="lblMultiplier" />
    </div>
    </form>
</body>
</html>
