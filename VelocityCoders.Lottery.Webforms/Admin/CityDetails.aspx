<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityDetails.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.CityDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>City Details</h1>
        <a href="Index.aspx">Index</a>&nbsp;&nbsp; <a href="CityList.aspx">City List</a>
        <br />
        <br />
        <asp:Label runat="server" ID ="lblMessage" />
        <br />
        <b>City ID:</b> &nbsp; <asp:Label runat="server" ID ="lblCityId" />
        <br />
        <b>City Name:</b> &nbsp; <asp:Label runat="server" ID ="lblCityName" />
    </div>
    </form>
</body>
</html>
