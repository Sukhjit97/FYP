<%@ Page Title="" Language="C#" MasterPageFile="~/LogIn.Master" AutoEventWireup="true" CodeBehind="SearchKnitter.aspx.cs" Inherits="Irish_Woollens.SearchKnitter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<link href="CSS/Styling.css" rel="stylesheet" />

    <style>
        .controls{
            margin-left:2%
        }
    </style>

            <div class="Title">
        Search Knitter
    </div>

        <p class="Description">
        Use the knitters firstname to search for any knitters in the system:
    </p>
    <br />

    <div class ="controls"> 

<asp:TextBox ID="txtSearch" runat="server" Width="283px" ></asp:TextBox>

<asp:Button Text="Search" runat="server" OnClick="Search"/>
        </div>
    <br />

    
<hr />
    <br />

<asp:GridView ID="gvStaff" runat="server" AutoGenerateColumns="False" AllowPaging="True"

OnPageIndexChanging="OnPaging" DataKeyNames="StaffID" CellPadding="4" Width="833px" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px"  >

<Columns>

<asp:BoundField DataField="StaffID" HeaderText="StaffID" SortExpression="StaffID" InsertVisible="False" ReadOnly="True" />

<asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />

    <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" SortExpression="EmailAddress"></asp:BoundField>
    <asp:BoundField DataField="Firstname" HeaderText="Firstname" SortExpression="Firstname"></asp:BoundField>
    <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname"></asp:BoundField>
    <asp:BoundField DataField="TelephoneNumber" HeaderText="TelephoneNumber" SortExpression="TelephoneNumber"></asp:BoundField>

</Columns>

    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
    <RowStyle BackColor="White" ForeColor="#003399" />
    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
    <sortedascendingcellstyle backcolor="#EDF6F6" />
    <sortedascendingheaderstyle backcolor="#0D4AC4" />
    <sorteddescendingcellstyle backcolor="#D6DFDF" />
    <sorteddescendingheaderstyle backcolor="#002876" />

</asp:GridView>
    <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IrishWoollensConnectionString %>" SelectCommand="SELECT [StaffID], [Address], [EmailAddress], [Firstname], [Surname], [TelephoneNumber] FROM [tblStaff]"></asp:SqlDataSource>--%>
</asp:Content>








