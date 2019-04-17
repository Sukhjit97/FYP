<%@ Page Title="" Language="C#" MasterPageFile="~/LogIn.Master" AutoEventWireup="true" CodeBehind="QuotationInquiry.aspx.cs" Inherits="Irish_Woollens.QuotationInquiry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <style>
        .gridview{
          margin-left: 2%;
        }

    </style>
    
    
    <link href="CSS/Styling.css" rel="stylesheet" />

            <div class="Title">
        Quotation Inquiry
    </div>

        <p class="Description">
        See below for any new quotation inquiries raised by our knitters:
    </p>
    <br />
    <hr />

    <br />

        <div class ="gridview">

            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="QuotationID" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" Height="88px" Width="810px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="QuotationID" HeaderText="QuotationID" InsertVisible="False" ReadOnly="True" SortExpression="QuotationID" />
                    <asp:BoundField DataField="Firstname" HeaderText="Firstname" SortExpression="Firstname" />
                    <asp:BoundField DataField="ItemName" HeaderText="ItemName" SortExpression="ItemName" />
                    <asp:BoundField DataField="ItemID" HeaderText="ItemID" SortExpression="ItemID" />
                    <asp:BoundField DataField="Quotation" HeaderText="Quotation" SortExpression="Quotation" />
                    <asp:CheckBoxField DataField="Status" HeaderText="Status" SortExpression="Status" />
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

        </div>
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
    <br />

<hr />
    <br />
            <p class="Description">
        Use the gridview to update any items in the catalogue:
    </p>
    <br />
    <hr />
    <br />

    <div class="gridview">
        <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ItemID" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None" Width="810px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="ItemID" HeaderText="ItemID" InsertVisible="False" ReadOnly="True" SortExpression="ItemID" />
                <asp:BoundField DataField="ItemName" HeaderText="ItemName" SortExpression="ItemName" />
                <asp:BoundField DataField="ItemDescription" HeaderText="ItemDescription" SortExpression="ItemDescription" />
                <asp:BoundField DataField="ItemPrice" HeaderText="ItemPrice" SortExpression="ItemPrice" />
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
