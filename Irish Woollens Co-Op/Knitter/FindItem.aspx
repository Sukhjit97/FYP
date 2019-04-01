﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Knitter/Knitter.master" AutoEventWireup="true" CodeFile="FindItem.aspx.cs" Inherits="Knitter_FindItem" %>

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
</asp:Content>

