<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Activities.aspx.cs" Inherits="tmdt01.Activities" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:BulletedList ID="BulletedList1" runat="server">
            <asp:ListItem>Computer game</asp:ListItem>
            <asp:ListItem>Basketball</asp:ListItem>
            <asp:ListItem>Movie</asp:ListItem>
            <asp:ListItem>Chat</asp:ListItem>
            <asp:ListItem>Making friends</asp:ListItem>
            <asp:ListItem>Learn new things</asp:ListItem>
        </asp:BulletedList>
    </form>
</asp:Content>