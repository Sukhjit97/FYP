<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="Registeration.aspx.cs" Inherits="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="height: 74px">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Firstname:"></asp:Label>
    
    <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
            
        </div>
    <div>
<asp:Label ID="Label2" runat="server" Text="Surname:"></asp:Label>
    
    <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
    </div>

    <div>
<asp:Label ID="Label3" runat="server" Text="Address:"></asp:Label>
    
    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>

    </div>

    <div>
            <asp:Label ID="Label4" runat="server" Text="Email Address:"></asp:Label>
    
    <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
    </div>


<div>
  <asp:Label ID="Label5" runat="server" Text="Password:"></asp:Label>
    
    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
</div>
  
        <div>

    <asp:Label ID="Label6" runat="server" Text="Confirm Password:"></asp:Label>
    
    <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
        </div>

<div>
    <asp:Label ID="Label7" runat="server" Text="Telephone Number:"></asp:Label>
    
    <asp:TextBox ID="txtTelephoneNuber" runat="server"></asp:TextBox>

</div>
    


        <div>
    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="Register_Click" style="height: 26px" />

    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
</div>
</div>









</asp:Content>

