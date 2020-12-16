<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="MainMaster.Master" CodeBehind="SearchBook.aspx.cs" Inherits="data_Access.views.SearchBook" %>

<asp:Content ContentPlaceHolderID="Body" runat="server">

    <form class="form-group" id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" CssClass="form-control" ID="BookToSearch" placeholder="Enter book name to search"></asp:TextBox>
            <asp:Button runat="server" CssClass="btn btn-primary btn-block" ID="Search" Text="Search Book" OnClick="Search_OnClick"/>
            <table class="table table-bordered">
                <tr>
                    <td>Book Name</td>
                    <td>City</td>
                    <td>Street</td>
                    <td>Street Number</td>
                    <td>Apartment Number</td>
                    <td>Phone Number</td>
                    <td>Email Address</td>
                </tr>
                <tbody runat="server" ID="tableBody"></tbody>
            </table>
        </div>
    </form>
</asp:Content>
