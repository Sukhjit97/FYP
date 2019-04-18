<%@ Page Title="" Language="C#" MasterPageFile="~/LogIn.Master" AutoEventWireup="true" CodeBehind="AddNewItem.aspx.cs" Inherits="Irish_Woollens.AddNewKnitter" %>
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
        Add New Item
            </div>

        <p class="Description">
        Fill in the form to add a new item to the system;
    </p>

    <br />

        <div class="AddKnitter"
            style="height: 222px">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Item Name:" CssClass="auto-style1"></asp:Label>
    
    <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
            
            <br />
            
            <br />
            
        </div>
    <div>
<asp:Label ID="Label2" runat="server" Text="Item Description:" CssClass="auto-style1"></asp:Label>
    
    <asp:TextBox ID="txtItemDescription" runat="server"></asp:TextBox>
        <br />
        <br />
    </div>

    <div>
<asp:Label ID="Label3" runat="server" Text="Item Price:" CssClass="auto-style1"></asp:Label>
    
    <asp:TextBox ID="txtItemPrice" runat="server"></asp:TextBox>

        <br />

        <br />

    </div>

            <div>
                <asp:Label ID="lblError" runat="server" Text="" style="color: #FF0000; font-family: 'Segoe UI'"></asp:Label>

                <br />
                <br />

            </div>
    
<div>

    <asp:Button ID="btnAddItem" runat="server" Text="Add Item" OnClick="btnAddItem_Click" />

    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />


    </div>
            </div>
    <br />
    <br />











</asp:Content>
