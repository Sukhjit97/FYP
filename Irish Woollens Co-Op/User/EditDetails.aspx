<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="EditDetails.aspx.cs" Inherits="User_EditDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-family: "Segoe UI";
            font-size: small;
            font-weight: bold;
        }
        
        .UpdateDetails {
            align-items: center;
            text-align: center;
            font-family: "segoe ui";
            border-radius: 5px;
            background-color: #f2f2f2;
            width: 80%;
            border: 4px solid #d3d3d3;
            padding: 15px;
            margin-top: 18px;
            margin-left: 8.5%;
        }
        .Title{
            align-items: center;
            text-align: center;
            font-family: "Bradley Hand ITC";
            font-weight:bold;
            font-size:25px;
            margin-top: -10px;
        }

        .Description{
           
            text-align: Left;
            font-family: "segoe ui";
            background-color: white;
            margin-top: 15px;
            margin-left: 15px;
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="Title">
        Update Personal Details
    </div>

    <p class="Description">
        Please use the below prefilled form to amend any of your personal details;
    </p>

       <div class="UpdateDetails"
           style="height: 210px">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Firstname:" CssClass="auto-style1"></asp:Label>
    
    <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>           
            
            <br />           
            <br />
            
        </div>
    <div>
<asp:Label ID="Label2" runat="server" Text="Surname:" CssClass="auto-style1"></asp:Label>
    
    <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
        <br />
        <br />
    </div>

    <div>
<asp:Label ID="Label3" runat="server" Text="Address:" CssClass="auto-style1"></asp:Label>
    
    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <br />
    </div>


<div>
    <asp:Label ID="Label7" runat="server" Text="Telephone Number:" CssClass="auto-style1"></asp:Label>
    
    <asp:TextBox ID="txtTelephoneNumber" runat="server"></asp:TextBox>   

    <br />

    <br />

</div>
   
        <div>
    <asp:Button ID="btnUpdate" runat="server" Text="Update Details" style="height: 26px; font-family: 'Arial Unicode MS';" OnClick="btnUpdate_Click1" Width="99px" />

    <asp:Button ID="btnCancel" runat="server" Text="Cancel"  style="height: 26px; font-family: 'Arial Unicode MS';" OnClick="btnCancel_Click" />
            <br />
</div>
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

