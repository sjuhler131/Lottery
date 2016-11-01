<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DrawingNumbersDetails.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.DrawingNumbersDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Drawing Numbers Details</h1>
        <a href="Index.aspx">Index</a>&nbsp;&nbsp; <a href="DrawingNumbersList.aspx">Drawing Numbers List</a>
        <br />
        <br />
        <asp:Label runat="server" ID ="lblMessage" />
        <br />
        <b>DrawingNumbers ID:</b> &nbsp; <asp:Label runat="server" ID ="lblDrawingNumbersId" />
        <br />
        <b>Ball Type ID:</b> &nbsp; <asp:Label runat="server" ID ="lblBallTypeId" />
        <br />
        <b>Drawing ID:</b> &nbsp; <asp:Label runat="server" ID ="lblDrawingId" />
        <br />
        <b>Number:</b> &nbsp; <asp:Label runat="server" ID ="lblNumber" />
    </div>
    </form>
</body>
</html>
