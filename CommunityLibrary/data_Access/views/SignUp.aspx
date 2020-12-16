<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="data_Access.views.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <label>User Name</label>
        <asp:TextBox ID="userName" runat="server"></asp:TextBox>
        <label>
        <br />
        Email</label>
        <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
        <label>
        <br />
        Password</label>
        <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
        <label>
        <br />
        Password Again</label>
        <asp:TextBox ID="checkPassword" runat="server"></asp:TextBox>
        <label>
        <br />
        First Name</label>
        <asp:TextBox ID="firstName" runat="server"></asp:TextBox>
        <label>
        <br />
        Last Name</label>
        <asp:TextBox ID="lastName" runat="server"></asp:TextBox>
        <label>
        <br />
        Birth Date</label>
        <asp:TextBox ID="bitrthDate" runat="server" TextMode="DateTime"></asp:TextBox>
        <label>
        <br />
        Phone Number</label>
        <asp:TextBox ID="phoneNumber" runat="server" TextMode="Phone"></asp:TextBox>
        <label>
        <br />
        Country</label>
        <asp:TextBox ID="country" runat="server"></asp:TextBox>
        <label>
        <br />
        State</label>
        <asp:TextBox ID="state" runat="server"></asp:TextBox>


        <label>
        <br />
        City</label>
        <asp:TextBox ID="city" runat="server"></asp:TextBox>
        <label>
        <br />
        Zip/Postal Code</label>
        <asp:TextBox ID="zip" runat="server"></asp:TextBox>

        <label>
        <br />
        Street Address</label>
        <asp:TextBox ID="street" runat="server"></asp:TextBox>

        <label>
        <br />
        House Number</label>
        <asp:TextBox ID="houseNumber" runat="server" TextMode="Number"></asp:TextBox>

        <label>
        <br />
        Enterance</label>
        <asp:TextBox ID="Enterance" runat="server"></asp:TextBox>

        <label>
        <br />
        Apartment Number</label>
        <asp:TextBox ID="apartmentNumber" runat="server" TextMode="Number"></asp:TextBox>
        <asp:Button ID="Send" runat="server" OnClick="Send_OnClick" Text="Send" />
    </form>

</body>
</html>
