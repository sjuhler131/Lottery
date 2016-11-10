<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="GameForm.aspx.cs" 
    MasterPageFile="~/MasterPages/Site2Column.Master"
    Theme="Main"
    Inherits="VelocityCoders.Lottery.Webforms.Admin.GameForm.GameForm" %>

<%@ Register
    TagPrefix="CustomVelocityCoders"
    TagName="GameNavigationControl"
    Src="~/Admin/UserControls/GameNavigationControl.ascx"
     %>

<asp:Content ID="Content3" ContentPlaceHolderID="BannerText" runat="server">
    <h1 class="Banner-Text">Game Form</h1>
                    <p>Insert Game information</p>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <CustomVelocityCoders:GameNavigationControl runat="server" id="GameNavigationControl" />
        <br />
        <br />
        <div id="Subtable">
        <table>
            <tr>
              <td><label>Game Name:</label></td>
              <td><asp:TextBox runat="server" ID="txtGameName" MaxLength="50" /></td>
            </tr>
            <tr>
              <td><label>Game Name Abbreviation:</label></td>
              <td><asp:TextBox runat="server" ID="txtGameNameAbbreviation" MaxLength="10" /></td>
            </tr>
            <tr>
                <td><label>How to Play:</label></td>
                <td><asp:TextBox runat="server" ID="txtHowtoPlay" TextMode="MultiLine" /></td>
            </tr>
             <tr>
                <td><label>Description:</label></td>
                <td><asp:TextBox runat="server" ID="txtDescription" TextMode="MultiLine" /></td>
            </tr>
            </table>
            </div>
        <div id="Button">
        <asp:Button runat="server" Text="Save" OnClick="Save_Click" />  
         </div>
        <div>
            <asp:Label runat="server" ID="lblDisplayMessage" />
        </div>
        <br />
    </asp:Content>
     