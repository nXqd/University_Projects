<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Page3.aspx.cs" Inherits="About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2> Get products from a range of price</h2>
    <div align="center">
        <br />
        <p>
            Product Service
            <asp:TextBox ID="TextBox1" runat="server" Height="22px" ReadOnly="True" 
                Width="344px">http://thuongmaidientu2011.apphb.com/ProductService/</asp:TextBox>
    </p>
        <p>
            Service Function
            <asp:TextBox ID="TextBox2" runat="server"  
                ReadOnly="True" Width="208px">Product/Price/{fromPrice}/{toPrice}</asp:TextBox>
    </p>
        <p>
            Price from <asp:TextBox ID="tbPriceFrom" runat="server" Width="80px"></asp:TextBox>
    &nbsp;to <asp:TextBox ID="tbPriceTo" runat="server" Width="80px"></asp:TextBox>
    </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Call" onclick="Button1_Click" />
    </p>
        <p>
            Name:
            <asp:DropDownList ID="ProductDropdown" runat="server" AutoPostBack="True" 
                onselectedindexchanged="ProductDropdown_SelectedIndexChanged">
            </asp:DropDownList>
    </p>
        <p>
            <asp:Image ID="image" runat="server" />
    </p>
        <p>
            Price:
            <asp:TextBox ID="tbPrice" runat="server" AutoPostBack="True" Width="69px"></asp:TextBox>
    </p>
        <br />
    </div>
</asp:Content>
