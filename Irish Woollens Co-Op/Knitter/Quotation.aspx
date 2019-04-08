<%@ Page Title="" Language="C#" MasterPageFile="~/Knitter/Knitter.master" AutoEventWireup="true" CodeFile="Quotation.aspx.cs" Inherits="Knitter_Quatation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />

    <style>
            .Quotation {
            align-items: center;
            text-align: center;
            font-family: "segoe ui";
            border-radius: 5px;
            background-color: #f2f2f2;
            width: 50%;
            border: 4px solid #d3d3d3;
            padding: 15px;
            margin-top: 100px;
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

        .auto-style1 {
            font-weight: bold;
            font-family: "Segoe UI";
            font-size: small;
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

        <div class="Title">
        Raise a Quotation
    </div>

        <p class="Description">
        Please use the below form to raise a quotation for an item price that may need amending;
    </p>

       <div class="Quotation"
           style="height: 210px">

   <div>
       <asp:Label ID="Label1" runat="server" Text="Firstname:" CssClass="auto-style1"></asp:Label><asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>

       <br />

       <br />

   </div> 
  
    <div> 
       <asp:Label ID="Label2" runat="server" Text="Item ID:" CssClass="auto-style1"></asp:Label><asp:TextBox ID="txtItemID" runat="server"></asp:TextBox>

        <br />

        <br />

   </div> 

  <div> 
      <asp:Label ID="Label3" runat="server" Text="Item Name:" CssClass="auto-style1"></asp:Label><asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>

      <br />

      <br />

  </div>   

   <div> <asp:Label ID="Label4" runat="server" Text="Quotation:" CssClass="auto-style1"></asp:Label><asp:TextBox ID="txtQuotation" runat="server"></asp:TextBox>

       <br />

       <br />

   </div>

        <asp:Button ID="btnRequestChange" runat="server" Text="Request Change" OnClick="btnRequestChange_Click" style="font-family: 'Arial Unicode MS'" />
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

