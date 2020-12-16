<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="data_Access.views.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <label>Username:</label>
        <asp:TextBox id="userName" runat="server"></asp:TextBox><br />

        <label>Password:</label><br />
        <asp:TextBox id="password" runat="server" TextMode="Password"></asp:TextBox><br />

        <label>First Name:</label><br />
        <asp:TextBox id="firstName" runat="server"></asp:TextBox><br />

        <label>Last Name:</label><br />
        <asp:TextBox id="lastName" runat="server"></asp:TextBox><br />

        <label>Phone Number:</label><br />
        <asp:TextBox id="phoneNumber" runat="server" TextMode="Phone"></asp:TextBox><br />

        <label>Country:</label><br />
        <asp:TextBox id="country" runat="server"></asp:TextBox><br />

        <label>State:</label><br />
        <asp:TextBox id="state" runat="server"></asp:TextBox><br />

        <label>City:</label><br />
        <asp:TextBox id="city" runat="server"></asp:TextBox><br />

        <label>Zip/Postal Code:</label><br />
        <asp:TextBox id="zip" runat="server"></asp:TextBox><br />

        <label>Street Address</label><br />
        <asp:TextBox id="street" runat="server"></asp:TextBox><br />

        <label>House Number</label><br />
        <asp:TextBox id="houseNumber" runat="server"></asp:TextBox><br />

        <label>Enterance</label><br />
        <asp:TextBox id="enterance" runat="server"></asp:TextBox><br />

        <label>Apartment Number</label><br />
        <asp:TextBox id="apartmentNumber" runat="server" TextMode="Number"></asp:TextBox><br />

        <label> Lending Count:</label>
        <asp:Label ID="lendingCount" runat="server"></asp:Label><br />

        <label> Role:</label>
        <asp:Label ID="role" runat="server"></asp:Label><br />

        <asp:Button ID="update" runat="server" OnClick="update_Click" Text="Update"/>
    </form>
</body>
</html>
