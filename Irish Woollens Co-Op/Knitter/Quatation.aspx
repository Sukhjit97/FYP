<%@ Page Title="" Language="C#" MasterPageFile="~/Knitter/Knitter.master" AutoEventWireup="true" CodeFile="Quatation.aspx.cs" Inherits="Knitter_Quatation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="bottom:200px;">


   <div>
       <asp:Label ID="Label1" runat="server" Text="Knitter Name"></asp:Label><asp:TextBox ID="txtname" runat="server"></asp:TextBox>

   </div> 
  
    <div> 
       <asp:Label ID="Label2" runat="server" Text="Product Name"></asp:Label><asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>

   </div> 

  <div> 
      <asp:Label ID="Label3" runat="server" Text="Product ID"></asp:Label><asp:TextBox ID="txtProductId" runat="server"></asp:TextBox>

  </div>   

   <div> <asp:Label ID="Label4" runat="server" Text="Quatation"></asp:Label><asp:TextBox ID="txtQuatation" runat="server"></asp:TextBox>

   </div>

        <asp:Button ID="btnSubmit" runat="server" Text="Request change" OnClick="btnSubmit_Click" />
         </div>
</asp:Content>

