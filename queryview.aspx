<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminmaster.Master" AutoEventWireup="true" CodeBehind="queryview.aspx.cs" Inherits="product.admin.queryview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <center>
        <h3>Complaints</h3>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" >
            <Columns>
                <asp:BoundField DataField="queryId" HeaderText="Id" />
                <asp:BoundField DataField="product_name" HeaderText="Product Name" />
                <asp:BoundField DataField="username" HeaderText="username" />
                <asp:BoundField DataField="query" HeaderText="Query" />
                <asp:BoundField DataField="reply" HeaderText="Reply" />
                <asp:BoundField DataField="query_date" HeaderText="Date" />
                <asp:HyperLinkField DataNavigateUrlFields="queryid" DataNavigateUrlFormatString="Admin_QueryReply.aspx?qid={0}" HeaderText="Reply" Text="reply" />
            </Columns>
        </asp:GridView>
    </center>
</asp:Content>
