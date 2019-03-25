<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="User_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>


    
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>




    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />





</asp:Content>

