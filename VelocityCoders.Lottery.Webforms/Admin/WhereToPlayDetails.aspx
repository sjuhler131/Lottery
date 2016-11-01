<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WhereToPlayDetails.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.Admin.WhereToPlayDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Where To Play Details</h1>
        <a href="Index.aspx">Index</a>&nbsp;&nbsp; <a href="WhereToPlayList.aspx">Where ToP lay List</a>
        <br />
        <br />
        <asp:Label runat="server" ID ="lblMessage" />
        <br />
        <b>Where To Play ID:</b> &nbsp; <asp:Label runat="server" ID ="lblWhereToPlayId" />
        <br />
        <b>Game ID:</b> &nbsp; <asp:Label runat="server" ID ="lblGameId" />
        <br />
        <b>State ID:</b> &nbsp; <asp:Label runat="server" ID ="lblStateId" />
        <br />
        <b>City ID:</b> &nbsp; <asp:Label runat="server" ID ="lblCityId" />
        <br />
        <b>Address Name:</b> &nbsp; <asp:Label runat="server" ID ="lblAddressName" />
        <br />
        <b>Address Number:</b> &nbsp; <asp:Label runat="server" ID ="lblAddressNumber" />
        <br />
        <b>Street01:</b> &nbsp; <asp:Label runat="server" ID ="lblStreet01" />
        <br />
        <b>Street02:</b> &nbsp; <asp:Label runat="server" ID ="lblStreet02" />
        <br />
        <b>Zip Code:</b> &nbsp; <asp:Label runat="server" ID ="lblZipCode" />
        <br />
        <b>Zip Code Plus Four:</b> &nbsp; <asp:Label runat="server" ID ="lblZipCodePlusFour" />
    </div>
    </form>
</body>
</html>
