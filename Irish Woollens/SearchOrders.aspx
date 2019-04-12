<%@ Page Title="" Language="C#" MasterPageFile="~/LogIn.Master" AutoEventWireup="true" CodeBehind="SearchOrders.aspx.cs" Inherits="Irish_Woollens.SearchOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <link href="CSS/Styling.css" rel="stylesheet" />


    <div class="Title">
        Search Orders
            </div>

            <p class="Description">
        Use the table below to search any orders made by the customers:
    </p>
    <br />
    <asp:TextBox ID="txtSearch" runat="server" ></asp:TextBox>

<asp:Button Text="Search" runat="server" OnClick="Search"/> 
    <br />
    <br />

<hr />
<br />
            <asp:GridView ID="gvSearchOrders" runat="server" AutoGenerateColumns="False" DataKeyNames="OrderID" CellPadding="4" ForeColor="#333333" GridLines="None" >
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="OrderID" HeaderText="OrderID" InsertVisible="False" ReadOnly="True" SortExpression="OrderID"></asp:BoundField>
                    <asp:BoundField DataField="OrderDate" HeaderText="OrderDate" SortExpression="OrderDate"></asp:BoundField>
                    <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID"></asp:BoundField>
                    <asp:BoundField DataField="CardNo" HeaderText="CardNo" SortExpression="CardNo"></asp:BoundField>
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>

        <br />

    <hr />
    <br />


                    <p class="Description">
        Use the table below to delete any orders from the system:
    </p>
    <br />

    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="OrderID" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="OrderID" HeaderText="OrderID" InsertVisible="False" ReadOnly="True" SortExpression="OrderID" />
            <asp:BoundField DataField="OrderDate" HeaderText="OrderDate" SortExpression="OrderDate" />
            <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
            <asp:BoundField DataField="CardNo" HeaderText="CardNo" SortExpression="CardNo" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>



        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IrishWoollensConnectionString %>" DeleteCommand="DELETE FROM [tblOrder] WHERE [OrderID] = @OrderID" InsertCommand="INSERT INTO [tblOrder] ([OrderDate], [CustomerID], [CardNo]) VALUES (@OrderDate, @CustomerID, @CardNo)" SelectCommand="SELECT * FROM [tblOrder]" UpdateCommand="UPDATE [tblOrder] SET [OrderDate] = @OrderDate, [CustomerID] = @CustomerID, [CardNo] = @CardNo WHERE [OrderID] = @OrderID">
            <DeleteParameters>
                <asp:Parameter Name="OrderID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter DbType="Date" Name="OrderDate" />
                <asp:Parameter Name="CustomerID" Type="Int32" />
                <asp:Parameter Name="CardNo" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter DbType="Date" Name="OrderDate" />
                <asp:Parameter Name="CustomerID" Type="Int32" />
                <asp:Parameter Name="CardNo" Type="String" />
                <asp:Parameter Name="OrderID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>



        <br />
        <br />
        <br />
        <br />



</asp:Content>
