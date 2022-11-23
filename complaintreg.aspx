<%@ Page Title="" Language="C#" MasterPageFile="~/user/usermaster.Master" AutoEventWireup="true" CodeBehind="complaintreg.aspx.cs" Inherits="product.user.complaintreg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <center>
        <h3>Complaint Registration</h3><br /><br />
        <table>
            <tr>
                <th>Select Product</th>
                <td>
                    <asp:DropDownList ID="productlist" runat="server" AutoPostBack="True"></asp:DropDownList>

                </td>
            </tr>
            <tr>
                <th></th><td><br /></td>
            </tr>
            <tr>
                <th>Complaint</th>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
                </th>
            </tr>
        </table>
    </center>
</asp:Content>

