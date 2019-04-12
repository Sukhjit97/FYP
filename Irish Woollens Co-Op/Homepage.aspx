<%@ Page Title="" Language="C#" MasterPageFile="~/LogIn.master" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="homepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <link href="CSS/Styling.css" rel="stylesheet" />

<%--Welcome Message for the User--%>
<div class="WelcomeMessage">
<asp:Label ID="lblUser" runat="server" Text=""></asp:Label>
</div>


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
  <img src="images/Jumper-1.jpg" alt="Jumper-1" style="width:50%">
  </div>
  <div class="img-container">
  <img src="images/Jumper-2.jpg" alt="Jumper-2" style="width:50%">
  </div>
  <div class="img-container">
  <img src="images/Jumper-3.jpg" alt="Jumper-3" style="width:50%">
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

