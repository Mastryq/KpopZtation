<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="TransactionPage.aspx.cs" Inherits="KpopZtation.View.TransactionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<style>
    th,td{border:1px solid black}
</style>
    <div>
        <br />
        <table>
            <tr>
                <th>
                    Transaction ID
                </th>
                <th>
                    Transaction Date
                </th>
                <th>
                    Customer Name
                </th>
                <th>
                    Transaction Detail
                </th>
            </tr>

            <% foreach (var x in transactions) {%>

                <tr>
                    <td>
                        <%=x.TransactionId %>
                    </td>
                    <td>
                        <%=x.TransactionDate.ToLongDateString() %>
                    </td>
                    <td>
                        <%=x.Customer.CustomerName %>
                    </td>
                    <td>
                        <a href="<%="TransactionDetail.aspx?transactionID=" + x.TransactionId%>">
                            Album Details
                        </a>
                    </td>
                </tr>
            <%} %>

        </table>
    </div>

</asp:Content>
