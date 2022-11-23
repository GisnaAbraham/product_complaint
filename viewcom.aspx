<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminmaster.Master" AutoEventWireup="true" CodeBehind="viewcom.aspx.cs" Inherits="product.admin.viewcom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <center>
        <h1>Complaints</h1>
        <table>
            <tr>
                <th>Complaints from</th>
                <td></td>
                <td>
                    <asp:DropDownList ID="FromDate" runat="server"></asp:DropDownList>

                </td>
                <td>
                    <asp:DropDownList ID="FromMonth" runat="server"></asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="FromYear" runat="server"></asp:DropDownList>
                </td>
                <td></td>
                <th>To</th>
                <td></td>
                <td>
                    <asp:DropDownList ID="ToDate" runat="server"></asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="ToMonth" runat="server"></asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="ToYear" runat="server"></asp:DropDownList>
                </td>
                <td></td>
                <th>
                    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
                </th>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="complaintid" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound">
            <Columns>
                <asp:BoundField DataField="complaintid" HeaderText="Complaint Id" ReadOnly="True" />
                <asp:BoundField DataField="product_name" HeaderText="Product" />
                <asp:BoundField DataField="username" HeaderText="User" />
                <asp:BoundField DataField="complaint" HeaderText="Complaint" />
                <asp:BoundField DataField="date" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Date" />
                <asp:BoundField DataField="status" HeaderText="Status" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
                            <asp:ListItem>Select </asp:ListItem>
                            <asp:ListItem>Processed</asp:ListItem>
                            <asp:ListItem>Not Processed</asp:ListItem>
                            <asp:ListItem>Cancel</asp:ListItem>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </center>
</asp:Content>


