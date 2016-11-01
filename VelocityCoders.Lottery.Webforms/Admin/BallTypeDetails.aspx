<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BallTypeDetails.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.BallTypeDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Ball Type Details</h1>
        <a href="Index.aspx">Index</a>&nbsp;&nbsp; <a href="BallTypeList.aspx">Ball Type List</a>
        <br />
        <br />
        <asp:Label runat="server" ID ="lblMessage" />
        <br />
        <b>Ball Type ID:</b> &nbsp; <asp:Label runat="server" ID ="lblBallTypeId" />
        <br />
        <b>Ball Type Name:</b> &nbsp; <asp:Label runat="server" ID ="lblBallTypeName" />
        <br />
        <b>Sequence:</b> &nbsp; <asp:Label runat="server" ID ="lblSequence" />
    </div>
    </form>
</body>
</html>
