<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="ViewProfilePage.aspx.cs" Inherits="KpopZtation.View.ViewProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Profile</h1>
        <asp:Label ID="Label4" runat="server" Text="Name : "></asp:Label>
        <asp:Label ID="UserNameText" runat="server" Text=""></asp:Label><br /><br />

        <asp:Label ID="Label3" runat="server" Text="Email : "></asp:Label>
        <asp:Label ID="UserEmailText" runat="server" Text=""></asp:Label><br /><br />

        <asp:Label ID="Label2" runat="server" Text="Gender : "></asp:Label>
        <asp:Label ID="UserGenderText" runat="server" Text=""></asp:Label><br /><br />

        <asp:Label ID="Label1" runat="server" Text="Address : "></asp:Label>
        <asp:Label ID="UserAddressText" runat="server" Text=""></asp:Label><br /><br />

        <asp:Label ID="Label5" runat="server" Text="Role : "></asp:Label>
        <asp:Label ID="UserRoleText" runat="server" Text=""></asp:Label><br /><br />

        <asp:Button ID="UpdateProfileButton" runat="server" Text="Update Profile" OnClick="UpdateProfileButton_Click" />

</asp:Content>