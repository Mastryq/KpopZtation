<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="KpopZtation.View.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Cart</h1>

    <asp:Label ID="WarningLabel" runat="server" Text=""></asp:Label>

    <asp:Repeater ID="albumRepeater" runat="server">
        <ItemTemplate>
            <div class="albumCardContainer" style="width: 47%; height:150px; display: flex; align-items: center; justify-content: center; border-radius: 10px; border: 2px solid black; margin-bottom: 20px; margin-right: 10px">
                <div class="imageInfoContainer" style="display: flex; height: 90%; width: 97%; align-items: center; justify-content: space-evenly">
                    <asp:ImageButton ID="albumImage" runat="server" ImageUrl='<%# Eval("Album.AlbumImage") %>' style="height: 90%; width: 120px;"/>
                    <div class="albumInfoContainer" style="height: 80%; width:75%; display: flex; flex-direction: column; justify-content: space-between">
                        <h3 style="margin: 0">Album Name : <%# Eval("Album.AlbumName") %></h3>
                        <p style="margin: 0;">Price : Rp.<%# Eval("Album.AlbumPrice") %></p>
                        <p style="margin: 0">Quantity : <%# Eval("Qty") %></p>
                        <p style="margin: 0">Subtotal: Rp.<%# Convert.ToDecimal(Eval("Album.AlbumPrice")) * Convert.ToInt32(Eval("Qty")) %></p>
                        <div class="buttonActionContainer" style="width:120px; flex-direction: row;">
                            <asp:Button ID="deleteButton" runat="server" Text="Remove" CommandArgument='<%# Eval("AlbumId") %>' OnCommand="deleteButton_Command"/>
                        </div>
                    </div>
                </div>                       
            </div>
        </ItemTemplate>
    </asp:Repeater>

    <asp:Button ID="CheckoutButton" runat="server" Text="Checkout" OnClick="CheckoutButton_Click" />

</asp:Content>