<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Manager.master" AutoEventWireup="true" CodeFile="AddNewKnitter.aspx.cs" Inherits="Manager_AddNewKnitter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-family: "Segoe UI";
            font-size: small;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />

    <style>
            .AddKnitter{
            align-items: center;
            text-align: center;
            font-family: "segoe ui";
            border-radius: 5px;
            background-color: #f2f2f2;
            width: 59%;
            border: 4px solid #d3d3d3;
            padding: 15px;
            margin-top: 5px;
            margin-left: 19%;
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
            margin-top: 20px;
            margin-left: 1%;
        }

        .AddKnitterGridview{
            margin-left: 9%;
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

        .auto-style4 {
            font-weight: bold;
            font-family: "Segoe UI";
            font-size: small;
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
            style="height: 735px">
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
    
    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
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
                <asp:Label ID="lblError" runat="server" Text="" style="color: #FF0000; font-family: 'Segoe UI'"></asp:Label>

                <br />

                <br />

            </div>
    
<div>

    <asp:Button ID="btnRegister" runat="server" Text="Add Knitter" OnClick="btnRegister_Click1" />

    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />

    <br />
    <br />

    <br />

</div>


    <div class ="AddKnitterGridview" 
        style="height: 371px"> 

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="StaffID" DataSourceID="SqlDataSource1" GridLines="None" ForeColor="#333333" Height="353px" Width="916px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="StaffID" HeaderText="StaffID" InsertVisible="False" ReadOnly="True" SortExpression="StaffID"></asp:BoundField>
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address"></asp:BoundField>
                <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" SortExpression="EmailAddress"></asp:BoundField>
                <asp:BoundField DataField="Firstname" HeaderText="Firstname" SortExpression="Firstname"></asp:BoundField>
                <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname"></asp:BoundField>
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password"></asp:BoundField>
                <asp:BoundField DataField="TelephoneNumber" HeaderText="TelephoneNumber" SortExpression="TelephoneNumber" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <sortedascendingcellstyle backcolor="#F5F7FB" />
            <sortedascendingheaderstyle backcolor="#6D95E1" />
            <sorteddescendingcellstyle backcolor="#E9EBEF" />
            <sorteddescendingheaderstyle backcolor="#4870BE" />
        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IrishWoollensConnectionString %>" SelectCommand="SELECT * FROM [tblStaff]" DeleteCommand="DELETE FROM [tblStaff] WHERE [StaffID] = @StaffID" InsertCommand="INSERT INTO [tblStaff] ([Address], [EmailAddress], [Firstname], [Surname], [Password], [TelephoneNumber]) VALUES (@Address, @EmailAddress, @Firstname, @Surname, @Password, @TelephoneNumber)" UpdateCommand="UPDATE [tblStaff] SET [Address] = @Address, [EmailAddress] = @EmailAddress, [Firstname] = @Firstname, [Surname] = @Surname, [Password] = @Password, [TelephoneNumber] = @TelephoneNumber WHERE [StaffID] = @StaffID">
            <DeleteParameters>
                <asp:Parameter Name="StaffID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Address" Type="String" />
                <asp:Parameter Name="EmailAddress" Type="String" />
                <asp:Parameter Name="Firstname" Type="String" />
                <asp:Parameter Name="Surname" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="TelephoneNumber" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Address" Type="String" />
                <asp:Parameter Name="EmailAddress" Type="String" />
                <asp:Parameter Name="Firstname" Type="String" />
                <asp:Parameter Name="Surname" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="TelephoneNumber" Type="String" />
                <asp:Parameter Name="StaffID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>

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

