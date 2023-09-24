<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="InsertAlbum.aspx.cs" Inherits="KpopZtation.View.InsertAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
        <h1>Insert Album Page - <%= Request["ArtistId"] %></h1>

        <asp:Label ID="Label1" runat="server" Text="Album Name"></asp:Label> <br />
        <asp:TextBox ID="albumNameBox" runat="server"></asp:TextBox> <br /><br />

        <asp:Label ID="Label2" runat="server" Text="Album Description"></asp:Label><br />
        <asp:TextBox ID="albumDescriptionBox" runat="server" /><br /><br />

        <asp:Label ID="Label3" runat="server" Text="Album Price"></asp:Label><br />
        <asp:TextBox ID="albumPriceBox" runat="server" /><br /><br />

        <asp:Label ID="Label4" runat="server" Text="Album Stock"></asp:Label><br />
        <asp:TextBox ID="albumStockBox" runat="server" /><br /><br />

        <asp:Label ID="Label5" runat="server" Text="Album Image"></asp:Label><br />
        <asp:FileUpload ID="albumImageUpload" runat="server" /><br /><br />
    
        <asp:Button ID="albumInsertButton" runat="server" Text="Insert Album" onClick="albumInsertButton_Click"/>
        <asp:Label ID="warningLabel" runat="server" Text=""></asp:Label>

</asp:Content>