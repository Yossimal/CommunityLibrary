<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="MainMaster.Master" CodeBehind="OfferBook.aspx.cs" Inherits="data_Access.views.OfferBook" %>

<asp:Content ContentPlaceHolderID="Body" runat="server">
    <form id="form1" runat="server">
        <div>
            <input type="text" placeholder="Enter The Book Name" runat="server" ID="bookName"/>
            <input type="text" placeholder="Enter the book code" runat="server" ID="bookCode"/>
            <input type="text" placeholder="Enter the book Author" runat="server" ID="bookAuthor"/>
            <input type="number" placeholder="How many days you need to provide the book after the order" class="form-control" runat="server" ID="timeToProvide"/>
            <input type="number" placeholder ="For how many days you want want to give tha book" class="form-control" runat="server" ID="timeToReturn"/>
            <textarea placeholder="Add some description about the book status." runat="server" ID="statusDescription"></textarea>
            <asp:Button runat="server" CssClass="btn btn-block btn-info" Text="Offer Book" OnClick="OnClick"/>
        </div>
    </form>
</asp:Content>