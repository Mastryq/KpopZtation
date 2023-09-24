<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="KpopZtation.View.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Update Profile Page</h1>

    <h2>Profile</h2>
    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label> <br />
    <asp:TextBox ID="nameBox" runat="server"></asp:TextBox> <br /><br />

    <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label><br />
    <asp:TextBox ID="emailBox" runat="server" /><br /><br />

    <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label><br />
    <asp:RadioButtonList ID="genderCheck" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList><br />

    <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label><br />
    <asp:TextBox ID="addressBox" runat="server" /><br /><br />

    <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label><br />
    <asp:TextBox ID="passwordBox" runat="server" /><br /><br />
    
    <asp:Button ID="updateProfileButton" runat="server" Text="Update Profile" onClick="updateProfileButton_Click"/>
    <asp:Label ID="warningLabel" runat="server" Text=""></asp:Label>

    <h2>Account Deletion</h2>
    <asp:Button ID="deleteAccountButton" runat="server" Text="Delete Account" onClick="deleteAccountButton_Click"/>
    <asp:Label ID="deletionLabel" runat="server" Text=""></asp:Label><br />
    <asp:CheckBox ID="deletionCheckBox" runat="server" /><asp:Label Text="Confirm account deletion" runat="server" />

</asp:Content>
