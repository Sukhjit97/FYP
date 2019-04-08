<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="User_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .Login {
            height: 49px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

            <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />

    <style>
            .Login{
            align-items: center;
            text-align: center;
            font-family: "segoe ui";
            border-radius: 5px;
            background-color: #f2f2f2;
            width: 50%;
            border: 4px solid #d3d3d3;
            padding: 15px;
            margin-top: 20px;
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
            margin-top: 40px;
            margin-left: 43%;
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

        .auto-style4 {
            font-weight: bold;
            font-family: "Segoe UI";
            font-size: small;
        }

       </style>

        <div class="Title">
        Login
            </div>



        <p class="Description">
        Login to your account to proceed!
    </p>

    <br />


       <div class="Login"
           style="height: 55px">


    <asp:Label ID="Label1" runat="server" Text="Email Address:" CssClass="auto-style4"></asp:Label>
    <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>


    
    <asp:Label ID="Label2" runat="server" Text="Password:" CssClass="auto-style4"></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>


<asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="Login_Click" />

        </div>

        <br />
    <br />
    <br />
    <br />   
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />   
    <br />
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

