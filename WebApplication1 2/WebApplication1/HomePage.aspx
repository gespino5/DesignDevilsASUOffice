<%@ Page Title="" Language="C#" MasterPageFile="~/DesignTemp.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebApplication1.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 421px;
        }
        .auto-style2 {
            width: 205px;
        }
    .auto-style111 {
        width: 476px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;Description:
    Our mission has always been to provide customers with the highest quality products while maintaining low prices. Through our quality assurance plan, customer can shop confortably knowing that they&#39;ll be recieving the products they have purchased as shown/described on our site.
    <br />
    <br />
    <table style="width:100%;">
        <tr>
            <td class="auto-style2">
                <asp:Button ID="searchButton" runat="server" Text="Search" Width="175px" OnClick="searchButton_Click" />
            </td>
            <td class="auto-style111">
                <asp:TextBox ID="searchTextBox" runat="server" style="margin-left: 0px" Width="350px"></asp:TextBox>
            </td>
            <td>
                <em>e.g. product id, product name, description</em></td>
        </tr>
        
    </table>
</asp:Content>
