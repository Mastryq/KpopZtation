<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="KpopZtation.View.TransactionDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Transaction Details</h1>

                <asp:Repeater ID="transactionRepeater" runat="server">
                    <ItemTemplate>
                        <div class="albumCardContainer" style="width: 47%; height:150px; display: flex; align-items: center; justify-content: center; border-radius: 10px; border: 2px solid black; margin-bottom: 20px; margin-right: 10px">
                            <div class="imageInfoContainer" style="display: flex; height: 90%; width: 97%; align-items: center; justify-content: space-evenly">
                                <asp:Image ImageUrl='<%# Eval("Album.AlbumImage") %>' runat="server" style="height: 90%; width: 120px;"/>
                                <div class="albumInfoContainer" style="height: 80%; width:75%; display: flex; flex-direction: column; justify-content: space-between">
                                    <h3 style="margin: 0"><%# Eval("Album.AlbumName") %></h3>
                                    <h4 style="margin: 0;">Quantity: <%# Eval("Qty") %></h4>
                                    <p style="margin: 0">Rp. <%# Eval("Album.AlbumPrice") %></p>
                                </div>
                            </div>                       
                        </div>
                    </ItemTemplate>
              </asp:Repeater>

    <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click" />


</asp:Content>
