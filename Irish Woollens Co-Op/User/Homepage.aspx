<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="User_Homepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
* {box-sizing: border-box}
body {font-family: Verdana, sans-serif; margin:0}
.mySlides {display: none}
img 
{vertical-align: middle;
 margin-left: 29%;
 margin-top: -3%;
}

/* Slideshow container */
.slideshow-container {
  max-width: 1000px;
  position: relative;
  margin: auto;
}

/* Next & previous buttons */
.prev, .next {
  cursor: pointer;
  position: absolute;
  top: 50%;
  width: auto;
  padding: 16px;
  margin-top: -22px;
  color: lightgrey;
  font-weight: bold;
  font-size: 18px;
  transition: 0.6s ease;
  border-radius: 0 3px 3px 0;
  user-select: none;
}

/* Position the "next button" to the right */
.next {
  right: 0;
  border-radius: 3px 0 0 3px;
}

/* On hover, add a white background color with a little bit see-through */
.prev:hover, .next:hover {
  background-color: lightpink;
}

/* Caption text */
.text {
  color: deeppink;
  font-size: 15px;
  padding: 8px 12px;
  position: absolute;
  bottom: 8px;
  width: 100%;
  text-align: center;
}

/* The dots/indicators */
.dot {
  cursor: pointer;
  height: 15px;
  width: 15px;
  margin: 0 2px;
  background-color: #bbb;
  border-radius: 50%;
  display: inline-block;
  transition: background-color 0.6s ease;
}

.active, .dot:hover {
  background-color: #717171;
}

/* Fading animation */
.fade {
  -webkit-animation-name: fade;
  -webkit-animation-duration: 1.5s;
  animation-name: fade;
  animation-duration: 1.5s;
}

@-webkit-keyframes fade {
  from {opacity: .4} 
  to {opacity: 1}
}

@keyframes fade {
  from {opacity: .4} 
  to {opacity: 1}
}

/* On smaller screens, decrease text size */
@media only screen and (max-width: 300px) {
  .prev, .next,.text {font-size: 11px}
}

.description {
	align-items: center;
	text-align: center;
	font-family: "segoe ui";
	font-style: italic;
	background-color:white;
	width: 80%;
    border-radius: 5px;
	border: 5px solid #d3d3d3;
	padding: 15px;
	margin-top: 20px;
	margin-left: 10.5%;
}

.img-container {
  float: left;
  width: 33.33%;
  padding: 5px;
}

.clearfix::after {
  content: "";
  clear: both;
  display: table;
}

.WelcomeMessage{
    margin-left: 15px;
    font-style: italic;
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

</style>


<%--Welcome Message for the User--%>
<div class="WelcomeMessage">
<asp:Label ID="lblUser" runat="server" Text=""></asp:Label>
</div>


<%-- Slideshow HTML Code--%>  
<div class="slideshow-container">

<div class="mySlides fade">
  <img src="Jumper-4.jpg" style="width:40%">
  <div class="text">Design of Jumper</div>
</div>

<div class="mySlides fade">
  <img src="Knitting.jpg" style="width:40%">
  <div class="text">Knitting</div>
</div>

<div class="mySlides fade">
  <img src="KnittingPins.jpg" style="width:40%">
  <div class="text">Knitting Pins</div>
</div>

<div class="mySlides fade">
  <img src="Pattern.jpg" style="width:40%">
  <div class="text">A Knitting Pattern</div>
</div>

<div class="mySlides fade">
  <img src="ColourfulWool.jpg" style="width:40%">
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
    
    <p class="description">Hello and welcome to the Showbiz Reviews website!
      <br />
      <br />This website is based on TV show reviews, where you can read and add reviews about the latest TV shows that are available to watch.
      <br />
      <br />To read the reviews click on the ‘Read Reviews’ button.
      <br />
      <br />The ‘Add a Review’ page is where you can write a review yourself about a TV show by filling out the add review form.
      <br />
      <br />The ‘Information about TV Shows’ page is where you can use the search facility to search information about TV shows that you are interested in or are considering to watch.</p>


    <br />
    <br />

<div class="clearfix">
  <div class="img-container">
  <img src="Jumper-1.jpg" alt="Jumper-1" style="width:50%">
  </div>
  <div class="img-container">
  <img src="Jumper-2.jpg" alt="Jumper-2" style="width:50%">
  </div>
  <div class="img-container">
  <img src="Jumper-3.jpg" alt="Jumper-3" style="width:50%">
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

