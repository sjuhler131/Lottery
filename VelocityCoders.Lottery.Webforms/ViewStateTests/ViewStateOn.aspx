<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStateOn.aspx.cs" Inherits="VelocityCoders.Lottery.Webforms.ViewStateTests.ViewStateOn" EnableViewState="true" %>

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
        Here are some numbers: <asp:Label runat="server" ID="lblPageMessage" EnableViewState="true" />
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
                The Numbers are still there! That means the ViewState is on!
         <br />
            The lblPageMessage stays around even if the page is requested again.
        <br />
        <br />
                <a href="ViewStateOff.aspx">Turn Off ViewState</a>                 
    </div>
    </form>
</body>
</html>
