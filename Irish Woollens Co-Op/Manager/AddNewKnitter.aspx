<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Manager.master" AutoEventWireup="true" CodeFile="AddNewKnitter.aspx.cs" Inherits="Manager_AddNewKnitter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <div style="height: 798px">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Firstname:"></asp:Label>
    
    <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
            
            <br />
            
        </div>
    <div>
<asp:Label ID="Label2" runat="server" Text="Surname:"></asp:Label>
    
    <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
        <br />
    </div>

    <div>
<asp:Label ID="Label3" runat="server" Text="Address:"></asp:Label>
    
    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>

        <br />

    </div>

    <div>
            <asp:Label ID="Label4" runat="server" Text="Email Address:"></asp:Label>
    
    <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
            <br />
    </div>


<div>
  <asp:Label ID="Label5" runat="server" Text="Password:"></asp:Label>
    
    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    <br />
</div>

<div>
    <asp:Label ID="Label7" runat="server" Text="Telephone Number:"></asp:Label>
    
    <asp:TextBox ID="txtTelephoneNumber" runat="server"></asp:TextBox>

    <br />

</div>
            <div>
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>

            </div>
    
<div>

    <asp:Button ID="btnRegister" runat="server" Text="Add Knitter" OnClick="btnRegister_Click1" />

    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />

    <br />

</div>


    <div style="height: 608px"> 

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="StaffID" DataSourceID="SqlDataSource1" GridLines="Vertical" ForeColor="Black">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="StaffID" HeaderText="StaffID" InsertVisible="False" ReadOnly="True" SortExpression="StaffID"></asp:BoundField>
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address"></asp:BoundField>
                <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" SortExpression="EmailAddress"></asp:BoundField>
                <asp:BoundField DataField="Firstname" HeaderText="Firstname" SortExpression="Firstname"></asp:BoundField>
                <asp:BoundField DataField="TelephoneNumber" HeaderText="TelephoneNumber" SortExpression="TelephoneNumber"></asp:BoundField>
                <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname"></asp:BoundField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <sortedascendingcellstyle backcolor="#F1F1F1" />
            <sortedascendingheaderstyle backcolor="#808080" />
            <sorteddescendingcellstyle backcolor="#CAC9C9" />
            <sorteddescendingheaderstyle backcolor="#383838" />
        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Desktop\FYP\Irish-Woollens-Co-Op\App_Data\IrishWoollens.mdf;Integrated Security=True;Connect Timeout=30" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [StaffID], [Address], [EmailAddress], [Firstname], [TelephoneNumber], [Surname] FROM [tblStaff]"></asp:SqlDataSource>

    </div>


</div>



</asp:Content>

