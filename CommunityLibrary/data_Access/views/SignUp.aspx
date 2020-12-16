<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="MainMaster.Master" CodeBehind="SignUp.aspx.cs" Inherits="data_Access.views.SignUp" %>

<asp:Content ContentPlaceHolderID="Body" runat="server">
    <form id="form1" class="form-group" runat="server">

        <asp:TextBox placeholder="User Name" ID="userName" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:TextBox placeholder="Email" ID="email" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
        <asp:TextBox ID="password" placeholder="`Password" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
        <asp:TextBox ID="checkPassword" placeholder="Password Again" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
        <label>
            <br />
            First Name</label>
        <asp:TextBox ID="firstName" placeholder="First Name" CssClass="form-control" runat="server"></asp:TextBox>
        <label>
            <br />
            Last Name</label>
        <asp:TextBox ID="lastName" runat="server" CssClass="form-control"></asp:TextBox>
        <label>
            <br />
            Birth Date</label>
        <asp:TextBox ID="bitrthDate" runat="server" TextMode="DateTime" CssClass="form-control"></asp:TextBox>
        <label>
            <br />
            Phone Number</label>
        <asp:TextBox ID="phoneNumber" runat="server" TextMode="Phone" CssClass="form-control"></asp:TextBox>
        <label>
            <br />
            Country</label>
        <asp:TextBox ID="country" runat="server" CssClass="form-control"></asp:TextBox>
        <label>
            <br />
            State</label>
        <asp:TextBox ID="state" runat="server" CssClass="form-control"></asp:TextBox>


        <label>
            <br />
            City</label>
        <asp:TextBox ID="city" runat="server" CssClass="form-control"></asp:TextBox>
        <label>
            <br />
            Zip/Postal Code</label>
        <asp:TextBox ID="zip" runat="server" CssClass="form-control"></asp:TextBox>

        <label>
            <br />
            Street Address</label>
        <asp:TextBox ID="street" CssClass="form-control" runat="server"></asp:TextBox>

        <label>
            <br />
            House Number</label>
        <asp:TextBox ID="houseNumber" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>

        <label>
            <br />
            </label>
        <asp:TextBox placeholder="Enterance" ID="Enterance" runat="server" CssClass="form-control"></asp:TextBox>

        <label>
            <br />
            Apartment Number</label>
        <asp:TextBox ID="apartmentNumber" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
        <asp:Button ID="Send" runat="server" OnClick="Send_OnClick" Text="Send" CssClass="btn btn-block btn-success" />
    </form>
</asp:Content>
