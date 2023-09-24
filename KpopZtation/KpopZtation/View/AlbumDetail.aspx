<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="AlbumDetail.aspx.cs" Inherits="KpopZtation.View.AlbumDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Album Details</h1>
        <asp:Label ID="Label4" runat="server" Text="Album Cover : "></asp:Label><br />
        <asp:Image ID="AlbumImage" runat="server" style="height: 90%; width: 120px;"/><br /><br />

        <asp:Label ID="Label3" runat="server" Text="Album Name : "></asp:Label>
        <asp:Label ID="AlbumNameText" runat="server" Text=""></asp:Label><br /><br />

        <asp:Label ID="Label2" runat="server" Text="Description : "></asp:Label>
        <asp:Label ID="AlbumDesText" runat="server" Text=""></asp:Label><br /><br />

        <asp:Label ID="Label1" runat="server" Text="Price : Rp."></asp:Label>
        <asp:Label ID="AlbumPriceText" runat="server" Text=""></asp:Label><br /><br />

        <asp:Label ID="Label5" runat="server" Text="Stock Left : "></asp:Label>
        <asp:Label ID="AlbumStockText" runat="server" Text=""></asp:Label><br /><br /><br />


        <asp:Label ID="OrderLabel" runat="server" Text="Order" Visible="false"></asp:Label><br /><br />
        <asp:Label ID="QuantityLabel" runat="server" Text="Quantity : " Visible="false"></asp:Label>
        <asp:TextBox ID="QuantityBox" runat="server" placeholder="Enter quantity" Visible="false"></asp:TextBox>
        <br />
        <asp:Label ID="WarningLabel" runat="server" Text="" Visible="false"></asp:Label>
        <br />
        <asp:Button ID="AddToCartButton" runat="server" Text="AddToCart" OnClick="AddToCartButton_Click" Visible="false"/>

</asp:Content>