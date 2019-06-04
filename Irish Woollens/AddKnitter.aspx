<%@ Page Title="" Language="C#" MasterPageFile="~/LogIn.Master" AutoEventWireup="true" CodeBehind="AddKnitter.aspx.cs" Inherits="Irish_Woollens.AddKnitter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="CSS/Styling.css" rel="stylesheet" />

            <style>
        .gridview{
          margin-left: 15%;
        }

    </style>




<div class="Title">
        Add New Knitter
            </div>

        <p class="Description">
        Fill in the form to add a new knitter to the system;
    </p>

    <br />

        <div class="AddKnitter"
            style="height: 418px">
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
            <asp:Label ID="Label4" runat="server" Text="Email Address:" CssClass="auto-style1"></asp:Label>
    
    <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
            <br />
            <br />
    </div>


<div>
  <asp:Label ID="Label5" runat="server" Text="Password:" CssClass="auto-style1"></asp:Label>
    
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
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
               <asp:Label ID="lblRole" runat="server" Text="Role"></asp:Label>  :<asp:TextBox ID="txtRole" runat="server" placeholder="2" ReadOnly="true"></asp:TextBox>
                <br />
                <br />
           </div>

            <div>
                <asp:Label ID="lblError" runat="server" Text="" style="color: #FF0000; font-family: 'Segoe UI'"></asp:Label>

                <br />
                <br />

            </div>
    
<div>

    <asp:Button ID="btnAddKnitter" runat="server" Text="Add Knitter" OnClick="btnAddKnitter_Click" />

    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />


    </div>
            </div>
    <br />
    <br />

<div class="gridview">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="StaffID" DataSourceID="SqlDataSource1" Width="976px" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
        <Columns>
            <asp:BoundField DataField="StaffID" HeaderText="StaffID" InsertVisible="False" ReadOnly="True" SortExpression="StaffID" />
            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
            <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" SortExpression="EmailAddress" />
            <asp:BoundField DataField="Firstname" HeaderText="Firstname" SortExpression="Firstname" />
            <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname" />
            <asp:BoundField DataField="TelephoneNumber" HeaderText="TelephoneNumber" SortExpression="TelephoneNumber" />
            <asp:BoundField DataField="RoleId" HeaderText="RoleId" SortExpression="RoleId" />
        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />
    </asp:GridView>    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=&quot;H:\Desktop\Viva 130419\Irish-Woollens-Co-Op\App_Data\IrishWoollens.mdf&quot;;Integrated Security=True;Connect Timeout=30" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [StaffID], [Address], [EmailAddress], [Firstname], [Surname], [TelephoneNumber], [RoleId] FROM [tblStaff]"></asp:SqlDataSource>
<%--    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IrishWoollensConnectionString %>" SelectCommand="SELECT * FROM [tblStaff]"></asp:SqlDataSource>--%>
</div>


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


