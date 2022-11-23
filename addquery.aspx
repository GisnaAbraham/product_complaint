<%@ Page Title="" Language="C#" MasterPageFile="~/user/usermaster.Master" AutoEventWireup="true" CodeBehind="addquery.aspx.cs" Inherits="product.user.addquery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <center>
        <h3>Add Query</h3>
        <table>
            <tr>
                <th>
                    Select Product
                </th>
                <td></td>
                   <tr>
                <th>Select Product</th>
                <td>
                    <asp:DropDownList ID="productlist" runat="server" AutoPostBack="True"></asp:DropDownList>

                </td>
            </tr>
            <tr>
                <th>
                    Ask a Question
                </th>
                <td></td>
                <td>
                    <asp:TextBox ID="QuestionTextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <th colspan="3">
                    <asp:Button ID="Button1" runat="server" Text="OK" OnClick="Button1_Click" />
                </th>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="queryId" HeaderText="Query Id" ReadOnly="true" />
                <asp:BoundField DataField="productname" HeaderText="Product Name" />
                <asp:BoundField DataField="query" HeaderText="Query" />
               
                <asp:BoundField DataField="query_date" HeaderText="Date" />
                <asp:HyperLinkField DataNavigateUrlFields="queryId" HeaderText="Details" Text="view details" DataNavigateUrlFormatString="Customer_ViewQueryReply.aspx?qid={0}" />
            </Columns>
        </asp:GridView>

    </center>
</asp:Content>
