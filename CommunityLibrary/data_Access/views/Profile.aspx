<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="MainMaster.Master" CodeBehind="Profile.aspx.cs" Inherits="data_Access.views.Profile" %>

<asp:Content ContentPlaceHolderID="Body" runat="server">
    <form id="form1" runat="server" class="form-group">
        <label>Username:</label>
        <asp:TextBox ID="userName" runat="server" CssClass="form-control"></asp:TextBox><br />

        <label>Password:</label><br />
        <asp:TextBox ID="password" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox><br />

        <label>First Name:</label><br />
        <asp:TextBox ID="firstName" runat="server" CssClass="form-control"></asp:TextBox><br />

        <label>Last Name:</label><br />
        <asp:TextBox ID="lastName" runat="server" CssClass="form-control"></asp:TextBox><br />

        <label>Phone Number:</label><br />
        <asp:TextBox ID="phoneNumber" runat="server" TextMode="Phone" CssClass="form-control"></asp:TextBox><br />

        <label>Country:</label><br />
        <asp:TextBox ID="country" runat="server" CssClass="form-control"></asp:TextBox><br />

        <label>State:</label><br />
        <asp:TextBox ID="state" runat="server" CssClass="form-control"></asp:TextBox><br />

        <label>City:</label><br />
        <asp:TextBox ID="city" runat="server" CssClass="form-control"></asp:TextBox><br />

        <label>Zip/Postal Code:</label><br />
        <asp:TextBox ID="zip" runat="server" CssClass="form-control"></asp:TextBox><br />

        <label>Street Address</label><br />
        <asp:TextBox ID="street" runat="server" CssClass="form-control"></asp:TextBox><br />

        <label>House Number</label><br />
        <asp:TextBox ID="houseNumber" runat="server" CssClass="form-control"></asp:TextBox><br />

        <label>Enterance</label><br />
        <asp:TextBox ID="enterance" runat="server" CssClass="form-control"></asp:TextBox><br />

        <label>Apartment Number</label><br />
        <asp:TextBox ID="apartmentNumber" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox><br />

        <label>Lending Count:</label>
        <asp:Label ID="lendingCount" runat="server"></asp:Label><br />

        <label>Role:</label>
        <asp:Label ID="role" runat="server"></asp:Label><br />

        <asp:Button ID="update" runat="server" OnClick="update_Click" CssClass="btn btn-block btn-danger" Text="Update" />
    </form>
</asp:Content>
