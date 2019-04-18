<%@ Page Title="" Language="C#" MasterPageFile="~/LogIn.Master" AutoEventWireup="true" CodeBehind="SearchItem.aspx.cs" Inherits="Irish_Woollens.SearchItem" %>
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
        Search Catalogue Items
    </div>

        <p class="Description">
        Use the item name to search for the specific item you are looking for:
    </p>
    <br />

    <div class ="controls"> 

<asp:TextBox ID="txtSearch" runat="server" Width="283px" ></asp:TextBox>

<asp:Button Text="Search" runat="server" OnClick="Search" ID="btnSearch"/>
        </div>
    <br />

    
<hr />
    <br />    

    <asp:GridView ID="gvItem" runat="server" AutoGenerateColumns="False" AllowPaging="True"

OnPageIndexChanging="OnPaging" DataKeyNames="ItemID" AllowSorting="True" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="73px" Width="667px"  >

<Columns>

    <asp:CommandField ShowSelectButton="True" />

<asp:BoundField DataField="ItemID" HeaderText="ItemID" SortExpression="ItemID" InsertVisible="False" ReadOnly="True" />

<asp:BoundField DataField="ItemName" HeaderText="ItemName" SortExpression="ItemName" />

    <asp:BoundField DataField="ItemDescription" HeaderText="ItemDescription" SortExpression="ItemDescription"></asp:BoundField>
    <asp:BoundField DataField="ItemPrice" HeaderText="ItemPrice" SortExpression="ItemPrice"></asp:BoundField>

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

    <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IrishWoollensConnectionString %>" SelectCommand="SELECT * FROM [tblItem]"></asp:SqlDataSource>--%>
</asp:Content>
