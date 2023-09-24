<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateArtist.aspx.cs" Inherits="KpopZtation.View.UpdateArtist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
        <h1>Update Artist</h1>
      <asp:Image ID="artistImage" runat="server" Width="220px" Height="220px"/><br />
      <asp:Label ID="artistName" runat="server" Text="" Font-Bold="true" Font-Size="Large"></asp:Label><br />
        
      <br />
      <asp:Label ID="Label1" runat="server" Text="Artist Name"></asp:Label> <br />
      <asp:TextBox ID="artistNameBox" runat="server"></asp:TextBox> <br /><br />

      <asp:Label ID="Label2" runat="server" Text="Image"></asp:Label><br />
      <asp:FileUpload ID="imageUpload" runat="server" /><br /><br />

      <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" /><br />
      <asp:Label ID="warningLabel" runat="server" Text=""></asp:Label>

</asp:Content>
