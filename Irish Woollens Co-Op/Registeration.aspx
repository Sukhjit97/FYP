<%@ Page Title="" Language="C#" MasterPageFile="~/Web.master" AutoEventWireup="true" CodeFile="Registeration.aspx.cs" Inherits="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

            <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />

    <style>
            .Registeration {
            align-items: center;
            text-align: center;
            font-family: "segoe ui";
            border-radius: 5px;
            background-color: #f2f2f2;
            width: 50%;
            border: 4px solid #d3d3d3;
            padding: 15px;
            margin-top: 40px;
            margin-left: 23%;
        }
        .Title{
            align-items: center;
            text-align: center;
            font-family: "Bradley Hand ITC";
            font-weight:bold;
            font-size:25px;
            margin-top: 20px;
        }

        .Description{
           
            text-align: Left;
            font-family: "segoe ui";
            background-color: white;
            margin-top: 15px;
            margin-left: 15px;
        }

                .footer {
    background-color: lightpink;
}

* {
    margin: 0;
    padding: 0;
    text-decoration: none;
}

.socialmedia {
    list-style-type: none;
    text-align: center;
}

    .socialmedia a {
        display: inline-flex;
        width: 60px;
        height: 60px;
        background: #2c3e50;
        color: white;
        margin: 0 6px;
        border-radius: 50%;
        justify-content: center;
        align-items: center;
        transition: 0.4s;
        font-size: 24px;
    }

    .socialmedia li {
        display: inline;
    }

    .socialmedia a:hover {
        background: #FF69B4;
    }

    .socialmedia a i {
        transition: 0.4s all;
    }

.footer-text {
    font-size: 13px;
    font-family: "Segoe UI";
    position: relative;
    text-align: center;
    bottom: 10px;
    margin-top: 8px;
    padding-top: 11px;
}

        .auto-style2 {
            font-weight: bold;
            font-size: small;
        }
        .auto-style3 {
            font-size: small;
            color: #FF0000;
        }

       </style>

        <div class="Title">
        Registeration
    </div>

        <p class="Description">
        Register your account with us today!
    </p>

       <div class="Registeration"
           style="height: 345px">

        <div>
            <asp:Label ID="Label1" runat="server" Text="Firstname:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
            <asp:requiredfieldvalidator runat="server" errormessage="Please enter firstname" ControlToValidate="txtFirstname" CssClass="auto-style3"></asp:requiredfieldvalidator>
            
            <br />
            
            <br />
            
        </div>
    <div>
<asp:Label ID="Label2" runat="server" Text="Surname:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
        <asp:requiredfieldvalidator runat="server" errormessage="Please enter surname" ControlToValidate="txtSurname" CssClass="auto-style3"></asp:requiredfieldvalidator>
        <br />
        <br />
    </div>

    <div>
<asp:Label ID="Label3" runat="server" Text="Address:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
          <asp:requiredfieldvalidator runat="server" errormessage="Please enter address" ControlToValidate="txtAddress" CssClass="auto-style3"></asp:requiredfieldvalidator>
        <br />
        <br />
    </div>

    <div>
            <asp:Label ID="Label4" runat="server" Text="Email Address:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
          <asp:requiredfieldvalidator runat="server" errormessage="Please enter email address" ControlToValidate="txtEmailAddress" CssClass="auto-style3"></asp:requiredfieldvalidator>
            <br />
            <br />
    </div>


<div>
  <asp:Label ID="Label5" runat="server" Text="Password:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
      <asp:requiredfieldvalidator runat="server" errormessage="Please enter password" ControlToValidate="txtPassword" CssClass="auto-style3"></asp:requiredfieldvalidator>
    <br />
    <br />
</div>
  
        <div>

    <asp:Label ID="Label6" runat="server" Text="Confirm Password:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
              <asp:requiredfieldvalidator runat="server" errormessage="Please confirm password" ControlToValidate="txtConfirmPassword" CssClass="auto-style3"></asp:requiredfieldvalidator>
            <br />
            <br />
        </div>

<div>
    <asp:Label ID="Label7" runat="server" Text="Telephone Number:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtTelephoneNumber" runat="server"></asp:TextBox>
      <asp:requiredfieldvalidator runat="server" errormessage="Please enter telephone number" ControlToValidate="txtTelephoneNumber" CssClass="auto-style3"></asp:requiredfieldvalidator>

    <br />

    <br />

</div>
    


        <div>
    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="Register_Click" style="height: 26px" />

    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
</div>
</div>

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

