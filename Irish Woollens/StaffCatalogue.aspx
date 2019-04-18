<%@ Page Title="" Language="C#" MasterPageFile="~/LogIn.Master" AutoEventWireup="true" CodeBehind="StaffCatalogue.aspx.cs" Inherits="Irish_Woollens.StaffCatalogue" %>
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
        height: 396px;
    }

@media screen and (max-width: 650px) {
  .column {
    width: 50%;
    display: block;
  }
}

.card {
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
        height: 353px;
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


.button:hover {
  background-color: #555;
}
        .row {
            height: 924px;
        }

.AddItemButton{
    margin-left: 47%
}
    </style>


            <div class="Title">
        Item Catalogue
    </div>
    <br>

    <hr />
    <div class="AddItemButton">
        <asp:Button ID="btnAddItem" runat="server" Text="Add New Item" OnClick="btnAddItem_Click" />
    </div>

    <br />
    <hr />


<div class="row">
  <div class="column">
    <div class="card">
      <img src="images/Jumper-7.jpg" alt="Jumper 7" style="width:60%; height: 219px;">
      <div class="container">
        <p class="titles">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £12.00</p>
        <p class ="ItemDescrip">Blue ladies cardigan with a white star design</p>
          <p class ="ItemDescrip">&nbsp;</p>
      </div>
    </div>
  </div>
  <div class="column">
    <div class="card">
      <img src="images/Jumper-5.jpg" alt="Jumper 5" style="width:60%; height: 233px;">
      <div class="container">
        <p class="titles">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £37.00</p>
        <p class ="ItemDescrip">Cream coloured Men's sweater</p>
      </div>
    </div>
  </div>
  <div class="column">
    <div class="card">
      <img src="images/Jumper-6.jpg" alt="Jumper 6" style="width:60%; height: 232px;">
      <div class="container">
        <p class="titles">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £25.50</p>
        <p class ="ItemDescrip">Festive Jumper</p>
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
      </div>
    </div>
  </div>
  <div class="column">
    <div class="card">
      <img src="images/Jumper-9.jpg" alt="Jumper 9" style="width:68%; height: 219px;">
      <div class="container">
        <p class="titles">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £30.00</p>
        <p class ="ItemDescrip">light coloured sweater</p>
      </div>
    </div>
  </div>
  <div class="column">
    <div class="card">
      <img src="images/Jumper-10.jpg" alt="Jumper 10" style="width:60%; height: 219px;">
      <div class="container">
        <p class="titles">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £50.00</p>
        <p class ="ItemDescrip">Nice stylish off shoulders ladies sweater</p>
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
      </div>
    </div>
  </div>
  <div class="column">
    <div class="card">
      <img src="images/Jumper-12.jpg" alt="Jumper 12" style="width:68%; height: 219px;">
      <div class="container">
        <p class="titles">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £30.00</p>
        <p class ="ItemDescrip">Black and White Stripes Jumper</p>
      </div>
    </div>
  </div>
  <div class="column">
    <div class="card">
      <img src="images/Jumper-13.jpg" alt="Jumper 13" style="width:60%; height: 219px;">
      <div class="container">
        <p class="titles">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £22.50</p>
        <p class ="ItemDescrip">&nbsp;Birght Orange/Yellow cardigan</p>
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
