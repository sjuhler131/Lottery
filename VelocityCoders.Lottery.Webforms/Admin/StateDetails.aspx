<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StateDetails.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.StateDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>State Details</h1>
        <a href="Index.aspx">Index</a>&nbsp;&nbsp; <a href="StateList.aspx">State List</a>
        <br />
        <br />
        <asp:Label runat="server" ID ="lblMessage" />
        <br />
        <b>State ID:</b> &nbsp; <asp:Label runat="server" ID ="lblStateId" />
        <br />
        <b>State Name:</b> &nbsp; <asp:Label runat="server" ID ="lblStateName" />
        <br />
        <b>State Abbreviation:</b> &nbsp; <asp:Label runat="server" ID ="lblStateAbbreviation" />
    </div>
    </form>
</body>
</html>
