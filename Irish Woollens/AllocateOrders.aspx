<%@ Page Title="" Language="C#" MasterPageFile="~/LogIn.Master" AutoEventWireup="true" CodeBehind="AllocateOrders.aspx.cs" Inherits="Irish_Woollens.AllocateOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSS/Styling.css" rel="stylesheet" />


    <div class="Title">
        Allocate Orders
            </div>

            <p class="Description">
        Use the form below to allocate orders to knitters:
    </p>
    <br />

    <div>
        <br />
        <h3>Select Order ID</h3>
        <br />
        <asp:DropDownList ID="ddlOrderID" runat="server" DataSourceID="SqlDataSource1" DataTextField="OrderID" DataValueField="OrderID" OnSelectedIndexChanged="ddlOrderID_SelectedIndexChanged"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=&quot;H:\Desktop\Viva 130419\Irish-Woollens-Co-Op\App_Data\IrishWoollens.mdf&quot;;Integrated Security=True;Connect Timeout=30" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [OrderID] FROM [tblOrder]"></asp:SqlDataSource>
        <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IrishWoollensConnectionString %>" SelectCommand="SELECT [OrderID] FROM [tblOrder]"></asp:SqlDataSource>--%>
        <br />
        <br />
        <h3>Select Staff ID</h3>
        <br />
        <asp:DropDownList ID="ddlStaffID" runat="server" DataSourceID="SqlDataSource2" DataTextField="StaffID" DataValueField="StaffID"></asp:DropDownList>

        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=&quot;H:\Desktop\Viva 130419\Irish-Woollens-Co-Op\App_Data\IrishWoollens.mdf&quot;;Integrated Security=True;Connect Timeout=30" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [StaffID] FROM [tblStaff]"></asp:SqlDataSource>

<%--        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:IrishWoollensConnectionString %>" SelectCommand="SELECT [StaffID] FROM [tblStaff]"></asp:SqlDataSource>--%>
        <br />
        <br />
        <h3>Select Staff&#39;s Surname</h3>
        <asp:DropDownList ID="ddlStaffName" runat="server" DataSourceID="SqlDataSource3" DataTextField="Surname" DataValueField="Surname"></asp:DropDownList>
       
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=&quot;H:\Desktop\Viva 130419\Irish-Woollens-Co-Op\App_Data\IrishWoollens.mdf&quot;;Integrated Security=True;Connect Timeout=30" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [Surname] FROM [tblStaff]"></asp:SqlDataSource>
       
        <%--<asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:IrishWoollensConnectionString %>" SelectCommand="SELECT [Surname] FROM [tblStaff]"></asp:SqlDataSource>--%>
        <br />
        <br />
        <h3>Add Note</h3>
        <asp:TextBox ID="txtNote" runat="server" Height="64px" TextMode="MultiLine" Width="322px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAllocateOrder" runat="server" Text="Allocate Order" OnClick="btnAllocateOrder_Click" />
        <br />
    </div>

    <hr />











</asp:Content>
