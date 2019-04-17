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

OnPageIndexChanging="OnPaging" DataKeyNames="StaffID" CellPadding="4" ForeColor="#333333" GridLines="None" Width="833px"  >

    <AlternatingRowStyle BackColor="White" />

<Columns>

<asp:BoundField DataField="StaffID" HeaderText="StaffID" SortExpression="StaffID" InsertVisible="False" ReadOnly="True" />

<asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />

    <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" SortExpression="EmailAddress"></asp:BoundField>
    <asp:BoundField DataField="Firstname" HeaderText="Firstname" SortExpression="Firstname"></asp:BoundField>
    <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname"></asp:BoundField>
    <asp:BoundField DataField="TelephoneNumber" HeaderText="TelephoneNumber" SortExpression="TelephoneNumber"></asp:BoundField>

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
    <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IrishWoollensConnectionString %>" SelectCommand="SELECT [StaffID], [Address], [EmailAddress], [Firstname], [Surname], [TelephoneNumber] FROM [tblStaff]"></asp:SqlDataSource>--%>
</asp:Content>








