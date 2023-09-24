<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="KpopZtation.View.ArtistDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div>
        <h1>Artist Detail</h1>
         <h2>Artist Information</h2>
        <div style="display: flex; flex-direction: row;">
            <asp:Image ID="artistImage" runat="server" Width="100px" Height="100px"/><br>
            <div style="margin-left: 10px;" >
                <asp:Label ID="artistNameLabel" runat="server" Text=""></asp:Label><br>
            </div>
        </div>

        <div>
            <div style="display: flex; align-items: center; flex-direction: row">
                <h2>Artist Albums</h2>
                <asp:Button ID="insertAlbumButton" runat="server" Text="Insert Album" OnClick="insertAlbumButton_Click" Visible='false' style="margin-left: 10px"/>
            </div>
            <div class="albumContainer" style="width: 100%; height: 100%; display: flex; justify-content: flex-start; flex-wrap: wrap;
">
                <asp:Repeater ID="albumRepeater" runat="server">
                    <ItemTemplate>
                        <div class="albumCardContainer" style="width: 47%; height:150px; display: flex; align-items: center; justify-content: center; border-radius: 10px; border: 2px solid black; margin-bottom: 20px; margin-right: 10px">
                            <div class="imageInfoContainer" style="display: flex; height: 90%; width: 97%; align-items: center; justify-content: space-evenly">
                                <asp:ImageButton ID="albumImage" runat="server" ImageUrl='<%# Eval("AlbumImage") %>' style="height: 90%; width: 120px;" OnCommand="selectButton_Command" CommandArgument='<%# Eval("AlbumId") %>'/>
                                <div class="albumInfoContainer" style="height: 80%; width:75%; display: flex; flex-direction: column; justify-content: space-between">
                                    <a href='<%# "AlbumDetail.aspx?AlbumId=" + Eval("AlbumId") %>'>
                                        <h3 style="margin: 0; color: black; text-decoration:none"><%# Eval("AlbumName") %></h3>
                                    </a>
                                    <h4 style="margin: 0;">Rp.<%# Eval("AlbumPrice") %></h4>
                                    <p style="margin: 0"><%# Eval("AlbumDescription") %></p>
                                    <div class="buttonActionContainer" style="width:120px; flex-direction: row;">
                                        <asp:Button ID="updateButton" runat="server" Text="Update" CommandArgument='<%# Eval("AlbumId") %>' OnCommand="updateButton_Command" Visible='<%# isAdmin %>' /> 
                                        <asp:Button ID="deleteButton" runat="server" Text="Delete" CommandArgument='<%# Eval("AlbumId") %>' OnCommand="deleteButton_Command" Visible='<%# isAdmin %>' />
                                    </div>
                                </div>
                            </div>                       
                        </div>
                    </ItemTemplate>
              </asp:Repeater>
            </div>
        </div>
        
    </div>

</asp:Content>
