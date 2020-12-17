<%@ Page Language="C#" MasterPageFile="~/views/MainMaster.Master" AutoEventWireup="true" CodeBehind="MyBooks.aspx.cs" Inherits="data_Access.views.MyBooks" %>

<asp:Content ContentPlaceHolderID="Body" runat="server">
    <form id="form1" runat="server" class="form-group">
        <asp:Panel ID="tablePanel" runat="server">
            <table class="table table-bordered">
                <tr>
                    <td>Book Name</td>
                    <td>Status</td>
                    <td>Date Created</td>
                    <td>Days For Give</td>
                    <td>Days For Return</td>
                </tr>
                <tbody runat="server" id="tableBody"></tbody>
            </table>
        </asp:Panel>
        <asp:Panel ID="emptyPanel" Visible="false" runat="server">
            <label>You didn't offer any books,</label>
            <a href="OfferBook.aspx">click here</a>
            <label> to offer a book.</label>
        </asp:Panel>
    </form>
</asp:Content>
