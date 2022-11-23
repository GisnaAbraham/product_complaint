<%@ Page Title="" Language="C#" MasterPageFile="~/guest/guestmaster.Master" AutoEventWireup="true" CodeBehind="loginpage.aspx.cs" Inherits="product.guest.loginpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <table align="center" class="auto-style1">
                <tr>
                    <td colspan="2"><h1>LOGIN FORM</h1>
                        <p>&nbsp;</p></td>
                </tr>
                

  <tr>
                    <td>User Name</td>
                    <td>
                        <asp:TextBox ID="uname" runat="server"></asp:TextBox><br /><br />
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="password" runat="server"></asp:TextBox><br /><br />
                    </td>
                </tr>
 <tr>
                    <td colspan="2">
                  &nbsp;&nbsp;&nbsp;
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:Button ID="btn_Register" runat="server" Text="Login" OnClick="btn_Register_Click" />
                       
                    </td>
                </tr>
            </table>
     <br /><br />
</asp:Content>
