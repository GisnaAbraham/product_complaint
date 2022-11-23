<%@ Page Language="C#" MasterPageFile="~/guest/guestmaster.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="product.guest.registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1
        {
            height:582px;
            width:560px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <table align="center" class="auto-style1">
                <tr>
                    <td colspan="2"><h1>USER REGISTRATION FORM</h1>
                        <p>&nbsp;</p></td>
                </tr>

                <tr>
                    <td>Name</td>
                    <td>
                      <asp:TextBox ID="username" runat="server"></asp:TextBox><br /><br />
                    </td>
                </tr>
                
                <tr>
                    <td> Address</td>
                    <td>
                       <asp:TextBox ID="useraddress" runat="server"></asp:TextBox><br /><br />
                    </td>
                </tr>
               
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="usermail" runat="server"></asp:TextBox><br /><br />
                    </td>
                </tr>
                <tr>
                    <td>Phone Number</td>
                    <td>
                        <asp:TextBox ID="userphone" runat="server"></asp:TextBox><br /><br />
                    </td>
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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:Button ID="btn_Register" runat="server" Text="Register" OnClick="btn_Register_Click" />
                       
                    </td>
                </tr>
            </table>
     <br /><br />
</asp:Content>

