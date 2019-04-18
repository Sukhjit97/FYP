<%@ Page Title="" Language="C#" MasterPageFile="~/LogIn.Master" AutoEventWireup="true" CodeBehind="ViewCatalogue.aspx.cs" Inherits="Irish_Woollens.ViewCatalogue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />


 <style>
html {
  box-sizing: border-box;
}

*, *:before, *:after {
  box-sizing: inherit;
}

.column {
  float: left;
  width: 32%;
  margin-bottom: 16px;
  padding: 0 8px;
        height: 437px;
    }

@media screen and (max-width: 650px) {
  .column {
    width: 50%;
    display: block;
  }
}

.card {
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
        height: 409px;
        width: 343px;
    }

.container {
  padding: 0 16px;
}

.container::after, .row::after {
  content: "";
  clear: both;
  display: table;
}

.titles {
    font-family: "Bradley Hand ITC";
    font-size: 30px;
    font-weight: bold;
}

.Title {
    align-items: center;
    text-align: center;
    font-family: "Bradley Hand ITC";
    font-weight: bold;
    font-size: 25px;
    margin-top: 20px;
}

.ItemDescrip {
    font-family: 'Segoe UI';
}

.button {
        border-style: none;
            border-color: inherit;
            border-width: medium;
            outline: 0;
            display: inline-block;
            padding: 8px;
            color: white;
            background-color: #000;
            text-align: center;
            align-items:center;
            cursor: pointer;
            width: 100%;
}

.button:hover {
  background-color: #555;
}
        .row {
            height: 924px;
        }
    </style>


            <div class="Title">
        Item Catalogue
    </div>
<br>
    <br />

<div class="row">
  <div class="column">
    <div class="card">
      <img src="images/Jumper-7.jpg" alt="Jumper 7" style="width:60%; height: 219px;">
      <div class="container">
        <p class="titles">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £12.00</p>
        <p class ="ItemDescrip">Blue ladies cardigan with a white star design</p>
          <p><asp:Button ID="btnbuynow1" class="button" runat="server" Text="Buy Now" OnClick="btnbuynow1_Click"/></p>
        <p>&nbsp;</p>
      </div>
    </div>
  </div>
  <div class="column">
    <div class="card">
      <img src="images/Jumper-5.jpg" alt="Jumper 5" style="width:60%; height: 233px;">
      <div class="container">
        <p class="titles">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £37.00</p>
        <p class ="ItemDescrip">Cream coloured Men's sweater</p>
        <p><asp:Button ID="btnbuynow2" class="button" runat="server" Text="Buy Now" OnClick="btnbuynow2_Click"/></p>
      </div>
    </div>
  </div>
  <div class="column">
    <div class="card">
      <img src="images/Jumper-6.jpg" alt="Jumper 6" style="width:60%; height: 232px;">
      <div class="container">
        <p class="titles">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £25.50</p>
        <p class ="ItemDescrip">Festive Jumper</p>
        <p><asp:Button ID="btnbuynow3" class="button" runat="server" Text="Buy Now" OnClick="btnbuynow3_Click"/></p>
      </div>
    </div>
  </div>

<br />

<div class="row">
  <div class="column">
    <div class="card">
      <img src="images/Jumper-8.jpg" alt="Jumper 8" style="width:60%; height: 219px;">
      <div class="container">
        <p class="titles">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £18.68</p>
        <p class ="ItemDescrip">Bambi Jumper for ladies</p>
        <p><asp:Button ID="btnbuynow4" class="button" runat="server" Text="Buy Now" OnClick="btnbuynow4_Click"/></p>
      </div>
    </div>
  </div>
  <div class="column">
    <div class="card">
      <img src="images/Jumper-9.jpg" alt="Jumper 9" style="width:68%; height: 219px;">
      <div class="container">
        <p class="titles">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £30.00</p>
        <p class ="ItemDescrip">light coloured sweater</p>
        <p><asp:Button ID="btnbuynow5" class="button" runat="server" Text="Buy Now" OnClick="btnbuynow5_Click"/></p>
      </div>
    </div>
  </div>
  <div class="column">
    <div class="card">
      <img src="images/Jumper-10.jpg" alt="Jumper 10" style="width:60%; height: 219px;">
      <div class="container">
        <p class="titles">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £50.00</p>
        <p class ="ItemDescrip">Nice stylish off shoulders ladies sweater</p>
        <p><asp:Button ID="btnbuynow6" class="button" runat="server" Text="Buy Now" OnClick="btnbuynow6_Click"/></p>
      </div>
    </div>
  </div>

<br />

    <div class="row">
  <div class="column">
    <div class="card">
      <img src="images/Jumper-11.jpeg" alt="Jumper 11" style="width:67%; height: 219px;">
      <div class="container">
        <p class="titles">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £34.00</p>
        <p class ="ItemDescrip">Rainbow coloured striped cardigan</p>
         <p><asp:Button ID="btnbuynow7" class="button" runat="server" Text="Buy Now" OnClick="btnbuynow7_Click" /></p>
        <%--<p><button id="btnbuynow "  onclick="btnbuynow">Buy Now</button></p>--%>
      </div>
    </div>
  </div>
  <div class="column">
      
    <div class="card">
      <img src="images/Jumper-12.jpg" alt="Jumper 12" style="width:75%; height: 219px;">
      <div class="container">
        <p class="titles">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £34.00</p>
        <p class ="ItemDescrip">Rainbow coloured striped cardigan</p>
         <p><asp:Button ID="btnbuynow8" class="button" runat="server" Text="Buy Now" OnClick="btnbuynow8_Click"/></p>
      </div>
    </div>
  </div>
  <div class="column">
    <div class="card">
      <img src="images/Jumper-13.jpg" alt="Jumper 13" style="width:60%; height: 219px;">
      <div class="container">
        <p class="titles">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £22.50</p>
        <p class ="ItemDescrip">Birght Orange/Yellow cardigan</p>
        <p><asp:Button ID="btnbuynow9" class="button" runat="server" Text="Buy Now" OnClick="btnbuynow9_Click"/></p>
      </div>
    </div>
  </div>
</div>
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
