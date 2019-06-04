<%@ Page Title="" Language="C#" MasterPageFile="~/LogIn.Master" AutoEventWireup="true" CodeBehind="Quotation.aspx.cs" Inherits="Irish_Woollens.Quotation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />
    <link href="CSS/Styling.css" rel="stylesheet" />


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
    </style>

        <div class="Title">
        Raise a Quotation
    </div>

        <p class="Description">
        Please use the below form to raise a quotation for an item price that may need amending;
    </p>

       <div class="Quotation"
           style="height: 270px">

   <div>
       
       <asp:Label ID="Label1" runat="server" Text="Firstname:" CssClass="auto-style1"></asp:Label> <asp:DropDownList ID="ddlFirstname" runat="server" DataSourceID="SqlDataSource2" DataTextField="Firstname" DataValueField="Firstname" Height="23px" Width="163px"></asp:DropDownList>

       <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=&quot;H:\Desktop\Viva 130419\Irish-Woollens-Co-Op\App_Data\IrishWoollens.mdf&quot;;Integrated Security=True;Connect Timeout=30" SelectCommand="SELECT [Firstname] FROM [tblStaff]"></asp:SqlDataSource>
       <br />

       <br />

   </div> 
  
    <div> 
       <asp:Label ID="Label2" runat="server" Text="Item ID:" CssClass="auto-style1"></asp:Label> <asp:DropDownList ID="ddlItemID" runat="server" DataSourceID="SqlDataSource1" DataTextField="ItemID" DataValueField="ItemID" Height="23px" Width="129px"></asp:DropDownList>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=&quot;H:\Desktop\Viva 130419\Irish-Woollens-Co-Op\App_Data\IrishWoollens.mdf&quot;;Integrated Security=True;Connect Timeout=30" SelectCommand="SELECT [ItemID] FROM [tblItem]"></asp:SqlDataSource>
        <br />

        <br />

   </div> 

  <div> 
      <asp:Label ID="Label3" runat="server" Text="Item Name:" CssClass="auto-style1"></asp:Label> <asp:DropDownList ID="ddlItemName" runat="server" DataSourceID="SqlDataSource3" DataTextField="ItemName" DataValueField="ItemName" Height="23px" Width="214px"></asp:DropDownList>

      <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=&quot;H:\Desktop\Viva 130419\Irish-Woollens-Co-Op\App_Data\IrishWoollens.mdf&quot;;Integrated Security=True;Connect Timeout=30" SelectCommand="SELECT [ItemName] FROM [tblItem]"></asp:SqlDataSource>
      <br />

      <br />

  </div>   

   <div> <asp:Label ID="Label4" runat="server" Text="Quotation:" CssClass="auto-style1"></asp:Label> <asp:TextBox ID="txtQuotation" runat="server"></asp:TextBox>

       <br />

       <br />

       <br />

   </div>
           <asp:Button ID="btnRequestChange" runat="server" Text="Requet Change" OnClick="btnRequestChange_Click" />
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
