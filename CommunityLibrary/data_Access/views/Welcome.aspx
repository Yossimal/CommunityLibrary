<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="data_Access.views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <label>User name:</label>
        <asp:TextBox id="userName" runat="server"></asp:TextBox>
        <label>Password:</label>
        <asp:TextBox id="password" runat="server" TextMode="Password"></asp:TextBox><br />

        <asp:Button ID="signIn" runat="server" OnClick="signIn_Click" Text="Sign In"/>
        <label>or</label>
        <asp:Button ID="signUp" runat="server" OnClick="signUp_Click" Text="Sign Up"/><br />

        <asp:Button ID="discover" runat="server" OnClick="discover_Click" Text="Discover"/>
    </form>
</body>
</html>