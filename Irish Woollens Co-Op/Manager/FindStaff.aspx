<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Manager.master" AutoEventWireup="true" CodeFile="FindStaff.aspx.cs" Inherits="Manager_FindStaff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TextBox ID="txtSearch" runat="server" ></asp:TextBox>

<asp:Button Text="Search" runat="server" OnClick="Search"/>

<hr />

<asp:GridView ID="gvStaff" runat="server" AutoGenerateColumns="False" AllowPaging="True"

OnPageIndexChanging="OnPaging" DataKeyNames="StaffID"  >

<Columns>

<asp:BoundField DataField="StaffID" HeaderText="StaffID" SortExpression="StaffID" InsertVisible="False" ReadOnly="True" />

<asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />

    <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" SortExpression="EmailAddress"></asp:BoundField>
    <asp:BoundField DataField="Firstname" HeaderText="Firstname" SortExpression="Firstname"></asp:BoundField>
    <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname"></asp:BoundField>
    <asp:BoundField DataField="TelephoneNumber" HeaderText="TelephoneNumber" SortExpression="TelephoneNumber"></asp:BoundField>

</Columns>

</asp:GridView>
    <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IrishWoollensConnectionString %>" SelectCommand="SELECT [StaffID], [Address], [EmailAddress], [Firstname], [Surname], [TelephoneNumber] FROM [tblStaff]"></asp:SqlDataSource>--%>
</asp:Content>

