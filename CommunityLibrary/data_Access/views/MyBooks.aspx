<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyBooks.aspx.cs" Inherits="data_Access.views.MyBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnProfile" runat="server" Text="Profile" OnClick="btnProfile_Click" />
        <asp:Button ID="btnDiscover" runat="server" Text="Discover" OnClick="btnDiscover_Click" />
        <asp:Button ID="btnOffer" runat="server" Text="Offer Book" OnClick="btnOffer_Click" />

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
</body>
</html>
