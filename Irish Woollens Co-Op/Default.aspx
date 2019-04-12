<%@ Page Title="" Language="C#" MasterPageFile="~/Web.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Email Address:"></asp:Label>
    <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>


    
    <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>




    <asp:Button ID="buttonLogin" runat="server" OnClick="buttonLogin_Click" Text="Login" />
</asp:Content>

