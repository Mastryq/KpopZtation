<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/View/NavigationBar.Master" CodeBehind="InsertArtist.aspx.cs" Inherits="KpopZtation.View.InsertArtist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h1>Insert Artist</h1>
    <asp:Label ID="Label1" runat="server" Text="Artist Name"></asp:Label> <br />
    <asp:TextBox ID="artistNameBox" runat="server"></asp:TextBox> <br /><br />

    <asp:Label ID="Label2" runat="server" Text="Image"></asp:Label><br />
    <asp:FileUpload ID="imageUpload" runat="server" /><br /><br />

    <asp:Button ID="insertButton" runat="server" Text="Insert" OnClick="insertButton_Click" /><br />
    <asp:Label ID="warningLabel" runat="server" Text=""></asp:Label>
</asp:Content>