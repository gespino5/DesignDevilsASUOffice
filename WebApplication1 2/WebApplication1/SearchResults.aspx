<%@ Page Title="" Language="C#" MasterPageFile="~/DesignTemp.Master" AutoEventWireup="true" CodeBehind="SearchResults.aspx.cs" Inherits="WebApplication1.SearchResults" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Search Results....</p>
    <p>
        <asp:SqlDataSource ID="new" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT ID, Name, Description, Price FROM product"></asp:SqlDataSource>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Width="415px">
        </asp:CheckBoxList>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        
            <asp:Button ID="addButton" runat="server" Text="Add To Cart" OnClick="addButton_Click" />
        
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="goToCartButton" runat="server" PostBackUrl="~/ShoppingCart.aspx" Text="Go to Cart" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="homeButton" runat="server" PostBackUrl="~/HomePage.aspx" Text="Return to Home" />
        
    </p>
</asp:Content>
