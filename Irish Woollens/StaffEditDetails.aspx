<%@ Page Title="" Language="C#" MasterPageFile="~/LogIn.Master" AutoEventWireup="true" CodeBehind="StaffEditDetails.aspx.cs" Inherits="Irish_Woollens.StaffEditDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />
    <link href="CSS/Styling.css" rel="stylesheet" />
    <div class="Title">
        Update Personal Details
    </div>

    <p class="Description">
        Please use the below prefilled form to amend any of your personal details;
    </p>
    <p class="Description">
        When updating your personal details, please also make sure that you type in your password in the password field to update your details. If you dont do this, your details will not get updated.
    </p>
    <br />
    <br />


       <div class="UpdateDetails"
           style="height: 357px">

           <div>

<asp:Label ID="Label1" runat="server" Text="Firstname:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
            
            <br />
            
            <br />
            
        </div>
    <div>
<asp:Label ID="Label2" runat="server" Text="Surname:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
        <br />
        <br />
    </div>

    <div>
<asp:Label ID="Label3" runat="server" Text="Address:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <br />
    </div>

    <div>
            <asp:Label ID="Label4" runat="server" Text="Email Address:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtEmailAddress" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
    </div>


<div>
  <asp:Label ID="Label5" runat="server" Text="Password:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
    <asp:requiredfieldvalidator runat="server" errormessage="Required Field" ControlToValidate="txtPassword" CssClass="auto-style3" style="color: #FF0000"></asp:requiredfieldvalidator>
    <br />
    <br />
</div>
  
        <div>

    <asp:Label ID="Label6" runat="server" Text="Confirm Password:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="lblConfirmPassword" runat="server" ControlToValidate="txtPassword" ControlToCompare="txtConfirmPassword" ErrorMessage="Passwords must match" style="color: #FF0000"></asp:CompareValidator>
            <br />
            <br />
        </div>

<div>
    <asp:Label ID="Label7" runat="server" Text="Telephone Number:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtTelephoneNumber" runat="server"></asp:TextBox>

    <br />

    <br />

            <div>
    <asp:Button ID="btnEditDetails" runat="server" Text="Update Details" style="height: 26px" OnClick="btnEditDetails_Click" />
</div>
</div>

</div>


    <br />
    <br />
    <br />
    <br />



     <!-- footer section of the page -->
<hr />
        <div class="footer">
  <footer>
      <ul class="socialmedia">
		<li><a href="https://www.facebook.com/"><i class="fab fa-facebook-f"></i></a>
  	<li><a href="https://twitter.com/"><i class="fab fa-twitter"></i></a></li>
		<li><a href="https://www.instagram.com/"><i class="fab fa-instagram"></i></a>
	  <li><a href="https://www.youtube.com"><i class="fab fa-youtube"></i></a></li>
		</ul>
      <div class="footer-text">
          <p>Copyright © 2019 Irish Woollens Co-Operative | All Rights Reserved | Sukhjit Kaur</p>
      </div>
  </footer>
       </div>

</asp:Content>
