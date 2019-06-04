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

            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="QuotationID" DataSourceID="SqlDataSource1" CellPadding="4" Height="88px" Width="810px" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
                <Columns>
                    <asp:CommandField ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="QuotationID" HeaderText="QuotationID" InsertVisible="False" ReadOnly="True" SortExpression="QuotationID" />
                    <asp:BoundField DataField="Firstname" HeaderText="Firstname" SortExpression="Firstname" />
                    <asp:BoundField DataField="ItemName" HeaderText="ItemName" SortExpression="ItemName" />
                    <asp:BoundField DataField="ItemID" HeaderText="ItemID" SortExpression="ItemID" />
                    <asp:BoundField DataField="Quotation" HeaderText="Quotation" SortExpression="Quotation" />
                    <asp:CheckBoxField DataField="Status" HeaderText="Status" SortExpression="Status" />
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>

        </div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=&quot;H:\Desktop\Viva 130419\Irish-Woollens-Co-Op\App_Data\IrishWoollens.mdf&quot;;Integrated Security=True;Connect Timeout=30" DeleteCommand="DELETE FROM [tblQuotation] WHERE [QuotationID] = @QuotationID" InsertCommand="INSERT INTO [tblQuotation] ([Firstname], [ItemName], [ItemID], [Quotation], [Status]) VALUES (@Firstname, @ItemName, @ItemID, @Quotation, @Status)" SelectCommand="SELECT * FROM [tblQuotation]" UpdateCommand="UPDATE [tblQuotation] SET [Firstname] = @Firstname, [ItemName] = @ItemName, [ItemID] = @ItemID, [Quotation] = @Quotation, [Status] = @Status WHERE [QuotationID] = @QuotationID">
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
        <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ItemID" DataSourceID="SqlDataSource2" Width="810px" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="ItemID" HeaderText="ItemID" InsertVisible="False" ReadOnly="True" SortExpression="ItemID" />
                <asp:BoundField DataField="ItemName" HeaderText="ItemName" SortExpression="ItemName" />
                <asp:BoundField DataField="ItemDescription" HeaderText="ItemDescription" SortExpression="ItemDescription" />
                <asp:BoundField DataField="ItemPrice" HeaderText="ItemPrice" SortExpression="ItemPrice" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=&quot;H:\Desktop\Viva 130419\Irish-Woollens-Co-Op\App_Data\IrishWoollens.mdf&quot;;Integrated Security=True;Connect Timeout=30" DeleteCommand="DELETE FROM [tblItem] WHERE [ItemID] = @ItemID" InsertCommand="INSERT INTO [tblItem] ([ItemName], [ItemDescription], [ItemPrice]) VALUES (@ItemName, @ItemDescription, @ItemPrice)" SelectCommand="SELECT * FROM [tblItem]" UpdateCommand="UPDATE [tblItem] SET [ItemName] = @ItemName, [ItemDescription] = @ItemDescription, [ItemPrice] = @ItemPrice WHERE [ItemID] = @ItemID">
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
