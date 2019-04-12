<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="login_manager.aspx.cs" Inherits="Irish_Woollens.login_manager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <link href="CSS/Styling.css" rel="stylesheet" />
                <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />

    <div class="Title">
        Manager Login
    </div>

    <p class="Description">
        Please login to your account;
    </p>

    <div class="Login">


    <asp:Label ID="Label1" runat="server" Text="Email Address:"></asp:Label>
    <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>


        

    <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>




    <asp:Button ID="buttonLogin" runat="server" OnClick="buttonLogin_Click" Text="Login" />

        </div>
        <br />
        <br />

    <br />
    <br />


    <div class="WoolImage">
        <img src="images/Wool.jpg" alt="Jumper-3" style="width:24%; height: 407px;">

    </div>


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
