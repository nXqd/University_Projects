<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
         CodeFile="Page1.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2> Available Serices </h2>
    <div id="content">
        <p>Operations at http://thuongmaidientu2011.apphb.com/ProductService </p>
        <p>Services available at the moment. All reponses in xml format</p>
        <table>            <tr>                <th>Uri</th>                <th>Method</th>                <th>Description</th>            </tr>
            <tr>                <td>GetAll</td>                <td title="http://thuongmaidientu2011.apphb.com/ProductService/GetAll">                    <a rel="operation" href="help/operations/GetProducts">GET</a>                </td>                <td>Service at http://thuongmaidientu2011.apphb.com/ProductService/GetAll</td>            </tr>
            <tr>                <td>Product/Price/{fromPrice}/{toPrice}</td>                <td title="http://thuongmaidientu2011.apphb.com/ProductService/Product/Price/{FROMPRICE}/{TOPRICE}">                    <a rel="operation" href="help/operations/GetProductByPrice">GET</a>                </td>                <td>Service at http://thuongmaidientu2011.apphb.com/ProductService/Product/Price/{FROMPRICE}/{TOPRICE}</td>            </tr>        </table>    </div>
</asp:Content>