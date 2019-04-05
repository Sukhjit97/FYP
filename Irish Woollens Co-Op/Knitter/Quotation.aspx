<%@ Page Title="" Language="C#" MasterPageFile="~/Knitter/Knitter.master" AutoEventWireup="true" CodeFile="Quotation.aspx.cs" Inherits="Knitter_Quatation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="bottom:200px;">


   <div>
       <asp:Label ID="Label1" runat="server" Text="Firstname"></asp:Label><asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>

   </div> 
  
    <div> 
       <asp:Label ID="Label2" runat="server" Text="Item ID"></asp:Label><asp:TextBox ID="txtItemID" runat="server"></asp:TextBox>

   </div> 

  <div> 
      <asp:Label ID="Label3" runat="server" Text="Item Name"></asp:Label><asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>

  </div>   

   <div> <asp:Label ID="Label4" runat="server" Text="Quotation"></asp:Label><asp:TextBox ID="txtQuotation" runat="server"></asp:TextBox>

   </div>

        <asp:Button ID="btnRequestChange" runat="server" Text="Request Change" OnClick="btnRequestChange_Click" />
         </div>
</asp:Content>

