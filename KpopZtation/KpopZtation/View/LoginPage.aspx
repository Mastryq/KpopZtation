<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="KpopZtation.View.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Login Account</h1>

    <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label> <br />
    <asp:TextBox ID="emailBox" runat="server"></asp:TextBox> <br />

    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label> <br />
    <asp:TextBox ID="passwordBox" runat="server"></asp:TextBox> <br />

    <asp:CheckBox ID="rememberMe" runat="server" Text="Remember Me"/><br /><br />

    <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" />
    <asp:Label ID="warningLabel" runat="server" Text=""></asp:Label>
</asp:Content>
