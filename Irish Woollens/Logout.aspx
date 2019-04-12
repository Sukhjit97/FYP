<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="Irish_Woollens.Logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

        <link href="CSS/Styling.css" rel="stylesheet" />
                <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />

    <style>

        .Description {
        align-items: center;
        text-align: center;
        font-family: "segoe ui";
        font-style: italic;
        font-size: 25px;
        background-color: white;
        width: 30%;
        border-radius: 5px;
        border: 5px solid #d3d3d3;
        padding: 15px;
        margin-top: 4%;
        margin-left: 33%;
        height: 105px;
    }

        .WoolImage
        {
            margin-left:12%;
            margin-top: 5%;
        }

            </style>



        <p class="Description">
        You are currently logged out!
            <br />
            To access your account please log back in again. 
    </p>

        <div class="WoolImage">
        <img src="images/Wool.jpg" alt="Jumper-3" style="width:24%; height: 407px;">

    </div>




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
