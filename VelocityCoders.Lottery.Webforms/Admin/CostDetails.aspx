<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CostDetails.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.CostDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Cost Details</h1>
        <a href="Index.aspx">Index</a>&nbsp;&nbsp; <a href="CostList.aspx">Cost List</a>
        <br />
        <br />
        <asp:Label runat="server" ID ="lblMessage" />
        <br />
        <b>Cost ID:</b> &nbsp; <asp:Label runat="server" ID ="lblCostId" />
        <br />
        <b>Game ID:</b> &nbsp; <asp:Label runat="server" ID ="lblGameId" />
        <br />
        <b>Cost Amount:</b> &nbsp; <asp:Label runat="server" ID ="lblCostAmount" />
    </div>
    </form>
</body>
</html>
