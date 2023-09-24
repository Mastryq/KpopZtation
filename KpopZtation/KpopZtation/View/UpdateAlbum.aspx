<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateAlbum.aspx.cs" Inherits="KpopZtation.View.UpdateAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1>Update Album Page</h1>
    <div style="display: flex; flex-direction: row; width: 35%; align-items: center; justify-content: space-between">
        <div>
            <asp:Image ID="albumImage" runat="server" Width="220px" Height="220px"/><br>
        </div>
        <div>
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
        </div>
    </div>
   
    
    <asp:Button ID="albumUpdateButton" runat="server" Text="Update Album" onClick="albumUpdateButton_Click"/>
    <asp:Label ID="warningLabel" runat="server" Text=""></asp:Label>
</asp:Content>
