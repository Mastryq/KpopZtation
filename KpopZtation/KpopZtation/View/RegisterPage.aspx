<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="KpopZtation.View.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Register Account</h1>

    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="nameBox" runat="server" style="margin-left: 10px"></asp:TextBox> <br />

    <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="emailBox" runat="server" style="margin-left: 10px"></asp:TextBox><br /><br />

    <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label><br />
    <asp:RadioButtonList ID="genderCheck" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList><br />

    <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
    <asp:TextBox ID="addressBox" runat="server" style="margin-left: 10px"></asp:TextBox><br />

    <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="passwordBox" runat="server" style="margin-left: 10px"></asp:TextBox><br /><br />

    <asp:Button ID="registerButton" runat="server" Text="Register" OnClick="registerButton_Click" /> <br />
    <asp:Label ID="warningBox" runat="server" Text="" ForeColor="IndianRed"></asp:Label>

</asp:Content>
