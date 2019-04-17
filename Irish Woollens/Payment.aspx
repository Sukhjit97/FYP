<%@ Page Title="" Language="C#" MasterPageFile="~/LogIn.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="Irish_Woollens.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />
    <link href="CSS/Styling.css" rel="stylesheet" />
    <div class="Title">
        Payment
    </div>

    <p class="Description">
        Fill in the details below to process the order;
    </p>

       <div class="Payment"
           style="height: 202px">

           <div>

<asp:Label ID="Label1" runat="server" Text="Name on Card:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
            
            <br />
            
            <br />
            
        </div>
    <div>
<asp:Label ID="Label2" runat="server" Text="Account Number:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtAccountNumber" runat="server"></asp:TextBox>
        <br />
        <br />
    </div>

               <div>
<asp:Label ID="Label3" runat="server" Text="Sort Code:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtSortCode" runat="server"></asp:TextBox>
        <br />
        <br />
    </div>
           
           <div>
<asp:Label ID="Label4" runat="server" Text="CVV:" CssClass="auto-style2"></asp:Label>
    
    <asp:TextBox ID="txtCVV" runat="server"></asp:TextBox>
        <br />
        <br />
    </div>

                       <div>
    <asp:Button ID="btnPayNow" runat="server" Text="Pay Now" style="height: 26px"/>
                           </div>








           </div>









</asp:Content>
