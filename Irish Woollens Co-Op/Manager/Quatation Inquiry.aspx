<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Manager.master" AutoEventWireup="true" CodeFile="Quatation Inquiry.aspx.cs" Inherits="Manager_Quatation_Inquiry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="QuatationId" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="QuatationId" HeaderText="QuatationId" InsertVisible="False" ReadOnly="True" SortExpression="QuatationId" />
            <asp:BoundField DataField="knittername" HeaderText="knittername" SortExpression="knittername" />
            <asp:BoundField DataField="productname" HeaderText="productname" SortExpression="productname" />
            <asp:BoundField DataField="productid" HeaderText="productid" SortExpression="productid" />
            <asp:BoundField DataField="quatation" HeaderText="quatation" SortExpression="quatation" />
            <asp:CheckBoxField DataField="status" HeaderText="status" SortExpression="status" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IrishWoollensConnectionString %>" SelectCommand="SELECT * FROM [tblQuatation]" DeleteCommand="DELETE FROM [tblQuatation] WHERE [QuatationId] = @QuatationId" InsertCommand="INSERT INTO [tblQuatation] ([knittername], [productname], [productid], [quatation], [status]) VALUES (@knittername, @productname, @productid, @quatation, @status)" UpdateCommand="UPDATE [tblQuatation] SET [knittername] = @knittername, [productname] = @productname, [productid] = @productid, [quatation] = @quatation, [status] = @status WHERE [QuatationId] = @QuatationId">
        <DeleteParameters>
            <asp:Parameter Name="QuatationId" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="knittername" Type="String" />
            <asp:Parameter Name="productname" Type="String" />
            <asp:Parameter Name="productid" Type="Int32" />
            <asp:Parameter Name="quatation" Type="String" />
            <asp:Parameter Name="status" Type="Boolean" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="knittername" Type="String" />
            <asp:Parameter Name="productname" Type="String" />
            <asp:Parameter Name="productid" Type="Int32" />
            <asp:Parameter Name="quatation" Type="String" />
            <asp:Parameter Name="status" Type="Boolean" />
            <asp:Parameter Name="QuatationId" Type="Int32" />
        </UpdateParameters>
</asp:SqlDataSource>


    <div>



    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="itemId" DataSourceID="ItemDataSource">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="itemId" HeaderText="itemId" InsertVisible="False" ReadOnly="True" SortExpression="itemId" />
            <asp:BoundField DataField="ItemName" HeaderText="ItemName" SortExpression="ItemName" />
            <asp:BoundField DataField="ItemDescription" HeaderText="ItemDescription" SortExpression="ItemDescription" />
            <asp:BoundField DataField="ItemPrice" HeaderText="ItemPrice" SortExpression="ItemPrice" />
        </Columns>
    </asp:GridView>

    <asp:SqlDataSource ID="ItemDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:IrishWoollensConnectionString %>" DeleteCommand="DELETE FROM [tblItem] WHERE [itemId] = @itemId" InsertCommand="INSERT INTO [tblItem] ([ItemName], [ItemDescription], [ItemPrice]) VALUES (@ItemName, @ItemDescription, @ItemPrice)" SelectCommand="SELECT * FROM [tblItem]" UpdateCommand="UPDATE [tblItem] SET [ItemName] = @ItemName, [ItemDescription] = @ItemDescription, [ItemPrice] = @ItemPrice WHERE [itemId] = @itemId">
        <DeleteParameters>
            <asp:Parameter Name="itemId" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ItemName" Type="String" />
            <asp:Parameter Name="ItemDescription" Type="String" />
            <asp:Parameter Name="ItemPrice" Type="Decimal" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="ItemName" Type="String" />
            <asp:Parameter Name="ItemDescription" Type="String" />
            <asp:Parameter Name="ItemPrice" Type="Decimal" />
            <asp:Parameter Name="itemId" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
        </div>
</asp:Content>

