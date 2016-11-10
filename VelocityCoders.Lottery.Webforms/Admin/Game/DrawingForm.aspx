<%@ Page 
    Language="C#"
    Theme="Main"
    MasterPageFile="~/MasterPages/Site2Column.Master" 
    AutoEventWireup="true" 
    CodeBehind="DrawingForm.aspx.cs" 
    Inherits="VelocityCoders.Lottery.Webforms.Admin.DrawingForm.DrawingForm" %>

<%@ Register
    TagPrefix="CustomVelocityCoders"
    TagName="GameNavigationControl"
    Src="~/Admin/UserControls/GameNavigationControl.ascx"
     %>

<asp:Content ID="Content3" ContentPlaceHolderID="BannerText" runat="server">
    <h1 class="Banner-Text">Drawing Form</h1>
                    <p>Insert Drawing information</p>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <CustomVelocityCoders:GameNavigationControl runat="server" id="GameNavigationControl" />
            <table id="Table">
                <tr>
                    <td><label>Game Name:</label></td>
                    <td>
                        <asp:DropDownList runat="server" ID="drpGameName">
                            <asp:ListItem Text="(Select Game)" Value ="0" />
                            <asp:ListItem Text="Powerball" Value ="Powerball" />
                            <asp:ListItem Text="Mega Millions" Value ="MegaMillions" />
                            <asp:ListItem Text="Gopher 5" Value ="Gopher5" />
                            <asp:ListItem Text="North Star Cash" Value ="NorthStarCash" />
                        </asp:DropDownList>
                        
                    </td>
                </tr>
                <tr>
                    <td><label>Drawing Date:</label></td>
                    <td>
                        <asp:TextBox runat="server" ID="txtDrawingDate"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><label>Jackpot Amount:</label></td>
                    <td>
                        <asp:TextBox runat="server" ID="txtJackpotAmount"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><label>Cash Option Amount</label></td>
                    <td>
                        <asp:TextBox runat="server" ID="txtCashOptionAmount"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><label>Multiplier</label></td>
                    <td>
                        <asp:TextBox runat="server" ID="txtMultiplier"></asp:TextBox>
                    </td>
                </tr>
            </table>
    <div id ="Button">
    <asp:Button runat="server" Text="Save" OnClick="Save_Click" />
        </div>
        <br />
        <div>
            <asp:Label runat="server" ID="lblDisplayMessage" />
        </div>
        <br />
    </asp:Content>
        


 