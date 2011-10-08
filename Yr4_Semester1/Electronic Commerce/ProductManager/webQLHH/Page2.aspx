<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Page2.aspx.cs" Inherits="About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2> Products information </h2>
    <div align="center">
        <br />
        <p>
        <asp:DropDownList ID="ProductDropdown" runat="server" Height="22px" 
            Width="170px" onselectedindexchanged="ProductDropdown_SelectedIndexChanged" 
                style="margin-left: 0px" AutoPostBack="True">
        </asp:DropDownList>
    </p>
        <p>
            <asp:Image ID="image" runat="server" />
    </p>
        <p>
            Product Price:<asp:TextBox ID="tbPrice" runat="server" Width="80px"></asp:TextBox>
    </p>
        <br />
    </div>
</asp:Content>
