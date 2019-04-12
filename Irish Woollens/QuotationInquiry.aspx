<%@ Page Title="" Language="C#" MasterPageFile="~/LogIn.Master" AutoEventWireup="true" CodeBehind="QuotationInquiry.aspx.cs" Inherits="Irish_Woollens.QuotationInquiry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="CSS/Styling.css" rel="stylesheet" />

            <div class="Title">
        Quotation Inquiry
    </div>

        <p class="Description">
        See below for any new quotation inquiries raised by our knitters:
    </p>

    <br />
        <div>

            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="QuotationID" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" Height="88px" Width="413px">
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

<hr />
 
</asp:Content>
