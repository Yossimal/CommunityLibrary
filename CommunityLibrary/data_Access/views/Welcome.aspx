<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="MainMaster.Master" CodeBehind="Welcome.aspx.cs" Inherits="data_Access.views.Welcome" %>

<asp:Content ContentPlaceHolderID="Body" runat="server">
    <div class="col-lg-12">
        <form id="form1" runat="server" class="form-group">
            <label>User name:</label>
            <asp:TextBox ID="userName" runat="server" CssClass="form-control"></asp:TextBox>
            <label>Password:</label>
            <asp:TextBox ID="password" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox><br />

            <asp:Button ID="signIn" runat="server" CssClass="btn btn-block" OnClick="signIn_Click" Text="Sign In" />
            <asp:Button ID="signUp" runat="server" OnClick="signUp_Click" Text="Sign Up" CssClass="btn btn-success btn-block" /><br />

            <asp:Button ID="discover" runat="server" OnClick="discover_Click" Text="Discover" CssClass="btn btn-info btn-block" />
        </form>
    </div>
</asp:Content>
