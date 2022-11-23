<%@ Page Title="" Language="C#" MasterPageFile="~/user/usermaster.Master" AutoEventWireup="true" CodeBehind="viewqueryreplay.aspx.cs" Inherits="product.user.viewqueryreplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h3>View Reply</h3>
        <table>
            <tr>
                <th>
                    Product
                </th>
                <td></td>
                <td>
                    <asp:TextBox ID="PRoductTextBox1" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th>
                    Question
                </th>
                <td></td>
                <td>
                    <asp:TextBox ID="QuestionTextBox" runat="server" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th>
                    Reply
                </th>
                <td></td>
                <td>
                    <asp:TextBox ID="ReplyTextBox" runat="server" ReadOnly="False" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            
        </table>
    </center>
</asp:Content>
