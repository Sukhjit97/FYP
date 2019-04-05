<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Manager.master" AutoEventWireup="true" CodeFile="QuotationInquiry.aspx.cs" Inherits="Manager_Quatation_Inquiry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 507px">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="QuotationID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="QuotationID" HeaderText="QuotationID" InsertVisible="False" ReadOnly="True" SortExpression="QuotationID" />
                <asp:BoundField DataField="Firstname" HeaderText="Firstname" SortExpression="Firstname" />
                <asp:BoundField DataField="ItemName" HeaderText="ItemName" SortExpression="ItemName" />
                <asp:BoundField DataField="ItemID" HeaderText="ItemID" SortExpression="ItemID" />
                <asp:BoundField DataField="Quotation" HeaderText="Quotation" SortExpression="Quotation" />
                <asp:CheckBoxField DataField="Status" HeaderText="Status" SortExpression="Status" />
            </Columns>
        </asp:GridView>
        <br />
        <br />

        <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ItemID" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="ItemID" HeaderText="ItemID" InsertVisible="False" ReadOnly="True" SortExpression="ItemID" />
                <asp:BoundField DataField="ItemName" HeaderText="ItemName" SortExpression="ItemName" />
                <asp:BoundField DataField="ItemDescription" HeaderText="ItemDescription" SortExpression="ItemDescription" />
                <asp:BoundField DataField="ItemPrice" HeaderText="ItemPrice" SortExpression="ItemPrice" />
            </Columns>
        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IrishWoollensConnectionString %>" DeleteCommand="DELETE FROM [tblQuotation] WHERE [QuotationID] = @QuotationID" InsertCommand="INSERT INTO [tblQuotation] ([Firstname], [ItemName], [ItemID], [Quotation], [Status]) VALUES (@Firstname, @ItemName, @ItemID, @Quotation, @Status)" SelectCommand="SELECT * FROM [tblQuotation]" UpdateCommand="UPDATE [tblQuotation] SET [Firstname] = @Firstname, [ItemName] = @ItemName, [ItemID] = @ItemID, [Quotation] = @Quotation, [Status] = @Status WHERE [QuotationID] = @QuotationID">
            <DeleteParameters>
                <asp:Parameter Name="QuotationID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Firstname" Type="String" />
                <asp:Parameter Name="ItemName" Type="String" />
                <asp:Parameter Name="ItemID" Type="Int32" />
                <asp:Parameter Name="Quotation" Type="Decimal" />
                <asp:Parameter Name="Status" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Firstname" Type="String" />
                <asp:Parameter Name="ItemName" Type="String" />
                <asp:Parameter Name="ItemID" Type="Int32" />
                <asp:Parameter Name="Quotation" Type="Decimal" />
                <asp:Parameter Name="Status" Type="Boolean" />
                <asp:Parameter Name="QuotationID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    <div>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:IrishWoollensConnectionString %>" DeleteCommand="DELETE FROM [tblItem] WHERE [ItemID] = @ItemID" InsertCommand="INSERT INTO [tblItem] ([ItemName], [ItemDescription], [ItemPrice]) VALUES (@ItemName, @ItemDescription, @ItemPrice)" SelectCommand="SELECT * FROM [tblItem]" UpdateCommand="UPDATE [tblItem] SET [ItemName] = @ItemName, [ItemDescription] = @ItemDescription, [ItemPrice] = @ItemPrice WHERE [ItemID] = @ItemID">
            <DeleteParameters>
                <asp:Parameter Name="ItemID" Type="Int32" />
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
                <asp:Parameter Name="ItemID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>

</asp:Content>

