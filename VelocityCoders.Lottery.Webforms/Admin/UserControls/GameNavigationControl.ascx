<%@ Control Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="GameNavigationControl.ascx.cs" 
    Inherits="VelocityCoders.Lottery.Webforms.Admin.UserControls.GameNavigationControl" %>

<div id="ContainerSubheader" class="SubheaderNavigation BorderRadiusTop">
    <asp:Label runat="server" ID="UCMessage" />
    <div class="SmallPadding">
        <asp:ListView runat="server" ID="GameNavigationList" ItemPlaceholderID="GameNavigationPlaceholder">
            <LayoutTemplate>
                <ul>
                    <asp:PlaceHolder runat="server" ID="GameNavigationPlaceholder" />
                </ul>
            </LayoutTemplate>
            <ItemTemplate>
                <li>
                    <asp:HyperLink  runat="server"
                                    ID="GameNavigationLink" 
                                    NavigateUrl='<%# Eval("Value") %>'
                                    Enabled='<%# Eval("Enabled") %>' >
                        <%# Eval("Text") %>
                        </asp:HyperLink>
                </li>
            </ItemTemplate>
        </asp:ListView>       
    </div>
</div>