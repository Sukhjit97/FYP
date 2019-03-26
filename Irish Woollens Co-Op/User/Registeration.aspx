<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="Registeration.aspx.cs" Inherits="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="height: 424px">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Firstname:"></asp:Label>
    
    <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
            <asp:requiredfieldvalidator runat="server" errormessage="Please enter firstname" ControlToValidate="txtFirstname"></asp:requiredfieldvalidator>
            
        </div>
    <div>
<asp:Label ID="Label2" runat="server" Text="Surname:"></asp:Label>
    
    <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
        <asp:requiredfieldvalidator runat="server" errormessage="Please enter surname" ControlToValidate="txtSurname"></asp:requiredfieldvalidator>
    </div>

    <div>
<asp:Label ID="Label3" runat="server" Text="Address:"></asp:Label>
    
    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
          <asp:requiredfieldvalidator runat="server" errormessage="Please enter address" ControlToValidate="txtAddress"></asp:requiredfieldvalidator>
    </div>

    <div>
            <asp:Label ID="Label4" runat="server" Text="Email Address:"></asp:Label>
    
    <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
          <asp:requiredfieldvalidator runat="server" errormessage="Please enter email address" ControlToValidate="txtEmailAddress"></asp:requiredfieldvalidator>
    </div>


<div>
  <asp:Label ID="Label5" runat="server" Text="Password:"></asp:Label>
    
    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
      <asp:requiredfieldvalidator runat="server" errormessage="Please enter password" ControlToValidate="txtPassword"></asp:requiredfieldvalidator>
</div>
  
        <div>

    <asp:Label ID="Label6" runat="server" Text="Confirm Password:"></asp:Label>
    
    <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
              <asp:requiredfieldvalidator runat="server" errormessage="Please confirm password" ControlToValidate="txtConfirmPassword"></asp:requiredfieldvalidator>
        </div>

<div>
    <asp:Label ID="Label7" runat="server" Text="Telephone Number:"></asp:Label>
    
    <asp:TextBox ID="txtTelephoneNumber" runat="server"></asp:TextBox>
      <asp:requiredfieldvalidator runat="server" errormessage="Please enter telephone number" ControlToValidate="txtTelephoneNumber"></asp:requiredfieldvalidator>

</div>
    


        <div>
    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="Register_Click" style="height: 26px" />

    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
</div>
</div>









</asp:Content>

