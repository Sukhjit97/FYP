<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="WebFeedback.aspx.cs" Inherits="Irish_Woollens.WebFeedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />

<style>
* {
  box-sizing: border-box;
}

input[type=text], select, textarea {
  width: 100%;
  padding: 12px;
  border: 1px solid #ccc;
  border-radius: 4px;
  resize: vertical;
}

label {
  padding: 12px 12px 12px 0;
  display: inline-block;
}

input[type=submit] {
  background-color: #4CAF50;
  color: white;
  padding: 12px 20px;
  border: none;
  border-radius: 4px;
  cursor: pointer;
  float: right;
}

input[type=submit]:hover {
  background-color: #45a049;
}

.container {
  border-radius: 5px;
  background-color: #f2f2f2;
  padding: 15px;
  margin: 25px;
  margin-top: 40px;
  border: 4px solid #d3d3d3;
}

.col-25 {
  float: left;
  width: 25%;
  margin-top: 6px;
}

.col-75 {
  float: left;
  width: 75%;
  margin-top: 6px;
}

/* Clear floats after the columns */
.row:after {
  content: "";
  display: table;
  clear: both;
}

/* Responsive layout - when the screen is less than 600px wide, make the two columns stack on top of each other instead of next to each other */
@media screen and (max-width: 600px) {
  .col-25, .col-75, input[type=submit] {
    width: 100%;
    margin-top: 0;
  }
}

        .Title{
            align-items: center;
            text-align: center;
            font-family: "Bradley Hand ITC";
            font-weight:bold;
            font-size:25px;
            margin-top: 20px;
        }

.footer {
    background-color: lightpink;
}

* {
    padding: 0;
    text-decoration: none;
        margin-left: 0;
        margin-top: 0;
        margin-bottom: 0;
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

#div1 {
  font-size:50px;
  margin-left:48%;
  margin-top: 10px;
}

    .auto-style1 {
        font-family: "Segoe UI";
        font-size: medium;
    }
    .auto-style2 {
        font-family: "Segoe UI";
        font-size: medium;
        color: #FF0000;
    }

</style>

    <div class="Title"> Feedback Form </div>     
    
    <div id="div1" class="fa"></div>
    
<div class="container">
 <form action="/action_page.php">
    <div class="row">
      <div class="col-25">
          <span class="auto-style1">
        <label for="fname">Firstname:</label></span> 
      </div>
      <div class="col-75">
          <asp:TextBox ID="txtfname" runat="server"></asp:TextBox> 
          <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtfname" ErrorMessage="Please type in your firstname" CssClass="auto-style2"></asp:RequiredFieldValidator>
        <%--<input type="text" id="fname" name="firstname" placeholder="Your firstname..">--%>         
      </div>
    </div>
    <div class="row">
      <div class="col-25">
          <span class="auto-style1">
        <label for="lname">Surname:</label></span> 
      </div>
      <div class="col-75">
              <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtlname" ErrorMessage="Please type in your surname" CssClass="auto-style2"></asp:RequiredFieldValidator>
        <%--<input type="text" id="lname" name="lastname" placeholder="Your surname.."> --%>
      </div>
    </div>
    <div class="row">
      <div class="col-25">
          <span class="auto-style1">
        <label for="rating">Rating:</label></span> 
      </div>
      <div class="col-75">
        <select id="rating" name="rating">
          <option value="0">0</option>
          <option value="1">1</option>
          <option value="2">2</option>
          <option value="3">3</option>
          <option value="4">4</option>
          <option value="5">5</option>
          <option value="6">6</option>
          <option value="7">7</option>
          <option value="8">8</option>
          <option value="9">9</option>
          <option value="10">10</option>
        </select>
      </div>
    </div>
    <div class="row">
      <div class="col-25">
          <span class="auto-style1">
        <label for="comments">Comments:</label></span> 
      </div>
      <div class="col-75">
              <asp:TextBox ID="txtcomments" runat="server" TextMode="MultiLine"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtcomments" ErrorMessage="Please type your comments" CssClass="auto-style2"></asp:RequiredFieldValidator>
      <%--  <textarea id="comments" name="subject" placeholder="Write your comments here..." style="height:200px"></textarea>--%>
      </div>
    </div>
    <div class="row">
      
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </div>
  </form>
</div>

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

<script>
function smile() {
  var a;
  a = document.getElementById("div1");
  a.innerHTML = "&#xf118;";
  setTimeout(function () {
      a.innerHTML = "&#xf11a;";
    }, 1000);
  setTimeout(function () {
      a.innerHTML = "&#xf119;";
    }, 2000);
  setTimeout(function () {
      a.innerHTML = "&#xf11a;";
    }, 3000);
}
smile();
setInterval(smile, 4000);
</script>

</asp:Content>
