<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStateOff.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.ViewStateTests.ViewStateOff" EnableViewState="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td><label>Enter Some Numbers!</label></td>
            <td>
                <asp:TextBox runat="server" ID="txtEnterSomeNumbers" maxlength="10"/>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" Text="Save" OnClick ="Save_Click" />
            </td>
        </tr>
    </table>
        <br />
        <br />
        <br />
        Here are some numbers: <asp:Label runat="server" ID="lblPageMessage" EnableViewState="false" />
        <br />
        <br />
        <br />
        <table>
        <tr>
            <td>
                <asp:Button runat="server" Text="Click This Button Next" />
                </td>
        </tr>
            </table>
                The Numbers are disappeared! That means the ViewState is off!
         <br />
                That means the lblPageMessage was reset to default. It will do this each time the page is requested.
        <br />
        <br />
                <a href="ViewStateOn.aspx">Turn On ViewState</a>                 
    </div>
    </form>
</body>
</html>
