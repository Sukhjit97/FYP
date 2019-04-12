<%@ Page Title="" Language="C#" MasterPageFile="~/LogIn.Master" AutoEventWireup="true" CodeBehind="ManageStaff.aspx.cs" Inherits="Irish_Woollens.ManageStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <link href="CSS/Styling.css" rel="stylesheet" />


    <div class="Title">
        Manage Staff Details
            </div>

            <p class="Description">
        Use the gridview below to amend any personal details of staff;
    </p>

    <br />
    <asp:gridview ID="gvManageStaff" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="StaffID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="StaffID" HeaderText="StaffID" InsertVisible="False" ReadOnly="True" SortExpression="StaffID" />
            <asp:BoundField DataField="Firstname" HeaderText="Firstname" SortExpression="Firstname" />
            <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname" />
            <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" SortExpression="EmailAddress" />
            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
            <asp:BoundField DataField="TelephoneNumber" HeaderText="TelephoneNumber" SortExpression="TelephoneNumber" />
            <asp:BoundField DataField="RoleId" HeaderText="RoleId" SortExpression="RoleId" />
        </Columns>
</asp:gridview>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IrishWoollensConnectionString %>" DeleteCommand="DELETE FROM [tblStaff] WHERE [StaffID] = @StaffID" InsertCommand="INSERT INTO [tblStaff] ([Firstname], [Surname], [EmailAddress], [Address], [TelephoneNumber], [RoleId]) VALUES (@Firstname, @Surname, @EmailAddress, @Address, @TelephoneNumber, @RoleId)" SelectCommand="SELECT [StaffID], [Firstname], [Surname], [EmailAddress], [Address], [TelephoneNumber], [RoleId] FROM [tblStaff]" UpdateCommand="UPDATE [tblStaff] SET [Firstname] = @Firstname, [Surname] = @Surname, [EmailAddress] = @EmailAddress, [Address] = @Address, [TelephoneNumber] = @TelephoneNumber, [RoleId] = @RoleId WHERE [StaffID] = @StaffID">
        <DeleteParameters>
            <asp:Parameter Name="StaffID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Firstname" Type="String" />
            <asp:Parameter Name="Surname" Type="String" />
            <asp:Parameter Name="EmailAddress" Type="String" />
            <asp:Parameter Name="Address" Type="String" />
            <asp:Parameter Name="TelephoneNumber" Type="String" />
            <asp:Parameter Name="RoleId" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Firstname" Type="String" />
            <asp:Parameter Name="Surname" Type="String" />
            <asp:Parameter Name="EmailAddress" Type="String" />
            <asp:Parameter Name="Address" Type="String" />
            <asp:Parameter Name="TelephoneNumber" Type="String" />
            <asp:Parameter Name="RoleId" Type="Int32" />
            <asp:Parameter Name="StaffID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>

</asp:Content>
