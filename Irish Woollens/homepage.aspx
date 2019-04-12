<%@ Page Title="" Language="C#" MasterPageFile="~/LogIn.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="Irish_Woollens.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <link href="CSS/Styling.css" rel="stylesheet" />

    <style>

            .description {
        align-items: center;
        text-align: center;
        font-family: "segoe ui";
        font-style: italic;
        background-color: white;
        width: 80%;
        border-radius: 5px;
        border: 5px solid #d3d3d3;
        padding: 15px;
        margin-top: 2.5%;
        margin-left: 10.5%;
        height: 190px;
    }


    </style>






<%--Welcome Message for the User--%>
<div class="WelcomeMessage">
<asp:Label ID="lblUser" runat="server" Text=""></asp:Label>
</div>

    <br />
    <br />
    <br />

<%-- Slideshow HTML Code--%>  
<div class="slideshow-container">

<div class="mySlides fade">
  <img src="images/Jumper-4.jpg" style="width:40%">
  <div class="text">Design of Jumper</div>
</div>

<div class="mySlides fade">
  <img src="images/Knitting.jpg" style="width:40%">
  <div class="text">Knitting</div>
</div>

<div class="mySlides fade">
  <img src="images/KnittingPins.jpg" style="width:40%">
  <div class="text">Knitting Pins</div>
</div>

<div class="mySlides fade">
  <img src="images/Pattern.jpg" style="width:40%">
  <div class="text">A Knitting Pattern</div>
</div>

<div class="mySlides fade">
  <img src="images/ColourfulWool.jpg" style="width:40%">
  <div class="text">Colourful Wool</div>
</div>

<a class="prev" onclick="plusSlides(-1)">&#10094;</a>
<a class="next" onclick="plusSlides(1)">&#10095;</a>

</div>
<br>

<div style="text-align:center">
  <span class="dot" onclick="currentSlide(1)"></span> 
  <span class="dot" onclick="currentSlide(2)"></span> 
  <span class="dot" onclick="currentSlide(3)"></span>
  <span class="dot" onclick="currentSlide(4)"></span> 
  <span class="dot" onclick="currentSlide(5)"></span> 
</div>
    
    <p class="description"> Welcome to Irish-Woollens Associates, an Irish based co-operative producing hand-made knitwear! 
      <br />
      <br />Designing and knitting sweaters for all occasions is just a small part of what we do and for the past fifteen years we have strived to provide the highest quality knitwear at wallet friendly prices for all of our customers. 
      <br />
      <br />We pride ourselves in using the finest quality wool for knitting, and taking the upmost care in the production of our knitwear. It is a great honour for us to share our customers’ most important occasions, and we pride ourselves in delivering first-rate customer service as well as beautiful knitted sweaters that meet our customer’s expectations.
    </p>

    <br />
    <br />
    <br />


<div class="row">
  <div class="column">
    <img src="Jumper-1.jpg" alt="Jumper 1" style="width:35%">
  </div>
  <div class="column">
    <img src="Jumper-2.jpg" alt="Jumper 2" style="width:35%">
  </div>
  <div class="column">
    <img src="Jumper-3.jpg" alt="Jumper 3" style="width:35%">
  </div>
</div>

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
var slideIndex = 1;
showSlides(slideIndex);

function plusSlides(n) {
  showSlides(slideIndex += n);
}

function currentSlide(n) {
  showSlides(slideIndex = n);
}

function showSlides(n) {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("dot");
  if (n > slides.length) {slideIndex = 1}    
  if (n < 1) {slideIndex = slides.length}
  for (i = 0; i < slides.length; i++) {
      slides[i].style.display = "none";  
  }
  for (i = 0; i < dots.length; i++) {
      dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex-1].style.display = "block";  
  dots[slideIndex-1].className += " active";
}
</script>
</asp:Content>

