<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Irish_Woollens.Registeration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />
    <link href="CSS/Styling.css" rel="stylesheet" />

    <style>
        .Registration {
    align-items: center;
    text-align: center;
    font-family: "segoe ui";
    border-radius: 5px;
    background-color: #f2f2f2;
    width: 50%;
    border: 4px solid #d3d3d3;
    padding: 15px;
    margin-top: 40px;
    margin-left: 25%;
}

.Title {
    align-items: center;
    text-align: center;
    font-family: "Bradley Hand ITC";
    font-weight: bold;
    font-size: 25px;
    margin-top: 20px;
}

.Description {
    text-align: Left;
    font-family: "segoe ui";
    background-color: white;
    margin-top: 15px;
    margin-left: 15px;
}
    </style>

        <div class="Title">
        Registration
    </div>

        <p class="Description">
        Register your account with us today and start placing your orders online!
    </p>

       <div class="Registration"
           style="height: 500px">

        <div>
            <asp:Label ID="Label1" runat="server" Text="Firstname:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
            <asp:requiredfieldvalidator runat="server" errormessage="Please enter firstname" ControlToValidate="txtFirstname" CssClass="auto-style3" style="color: #FF0000"></asp:requiredfieldvalidator>
            
            <br />           
            <br />
            
        </div>
    <div>
<asp:Label ID="Label2" runat="server" Text="Surname:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
        <asp:requiredfieldvalidator runat="server" errormessage="Please enter surname" ControlToValidate="txtSurname" CssClass="auto-style3" style="color: #FF0000"></asp:requiredfieldvalidator>
        <br />
        <br />
    </div>

    <div>
<asp:Label ID="Label3" runat="server" Text="Address:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
          <asp:requiredfieldvalidator runat="server" errormessage="Please enter address" ControlToValidate="txtAddress" CssClass="auto-style3" style="color: #FF0000"></asp:requiredfieldvalidator>
        <br />
        <br />
    </div>

    <div>
            <asp:Label ID="Label4" runat="server" Text="Email Address:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
          <asp:requiredfieldvalidator runat="server" errormessage="Please enter email address" ControlToValidate="txtEmailAddress" CssClass="auto-style3" style="color: #FF0000"></asp:requiredfieldvalidator>
            <br />
            <br />
    </div>


<div>
  <asp:Label ID="Label5" runat="server" Text="Password:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
      <asp:requiredfieldvalidator runat="server" errormessage="Please enter password" ControlToValidate="txtPassword" CssClass="auto-style3" style="color: #FF0000"></asp:requiredfieldvalidator>
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
      <asp:requiredfieldvalidator runat="server" errormessage="Please enter telephone number" ControlToValidate="txtTelephoneNumber" CssClass="auto-style3" style="color: #FF0000"></asp:requiredfieldvalidator>

    <br />

    <br />

</div>
           <div>
               <asp:Label ID="lblRole" runat="server" Text="Role:"></asp:Label> 
               
               <asp:TextBox ID="txtRole" runat="server" placeholder="3" ReadOnly="true"></asp:TextBox>
               <br />
               <br />
           </div>
    

           <div>
               <asp:Label ID="lblError" runat="server" Text="" style="color: #FF0000"></asp:Label>
               <br />
               <br />
           </div>

        <div>
    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="Register_Click" style="height: 26px" />

            <br />
            

</div>
</div>

        <br />
    <br />
    <br />
    <br />
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

