<%@ Page Title="" Language="C#" MasterPageFile="~/DesignTemp.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="WebApplication1.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 165px;
        }
        .auto-style2 {
            width: 297px;
        }
    .auto-style3 {
        margin-left: 0px;
    }
        .auto-style4 {
            background-color: #FFFFFF;
        }
        .auto-style100 {
            width: 218px;
        }
        .auto-style101 {
            width: 238px;
        }
        .auto-style102 {
            color: #FFFFFF;
            margin-left: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Shopping Cart</h1>
    <p>
        <asp:ListBox ID="shoppingCartListBox" runat="server" Height="135px" Width="352px" OnSelectedIndexChanged="shoppingCartListBox_SelectedIndexChanged"></asp:ListBox>
    </p>
        <table style="width:100%;">
            <tr>
                <td class="auto-style100">PreTax Total</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="$"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style100">Tax</td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="$"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style100">Shipping</td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="$"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style100">Total</td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="$"></asp:Label>
                </td>
            </tr>
        </table>
    
    <table style="width:100%;" class="auto-style4">
        <tr>
            <td class="auto-style2">
                <asp:Button ID="continueButton" runat="server" Text="Continue Shopping" PostBackUrl="~/HomePage.aspx" Width="241px" />
            </td>
            <td class="auto-style101">
                <asp:Button ID="cancelButton" runat="server" Text="Cancel" Width="154px" PostBackUrl="~/HomePage.aspx" />
            </td>
            <td>
                <asp:Button ID="submitButton" runat="server" Text="Submit Order" Width="179px" CssClass="auto-style102" ForeColor="Black" />
            </td>
        </tr>
    </table>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
</asp:Content>
