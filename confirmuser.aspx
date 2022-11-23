<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="confirmuser.aspx.cs" Inherits="product.admin.confirmuser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <h2>User Conformation</h2>
          
<form id="form1" runat="server">

         
            <asp:GridView ID="GridView1" runat="server" DataKeyNames="user_id" OnRowDeleting="GridView1_RowDeleting" >
                <Columns>
                 
                    <asp:CommandField HeaderText="Confirm" ShowDeleteButton="True" DeleteText="confirm" ButtonType="Button" />
                   </Columns> 
               
            </asp:GridView>
    </form>
        <div>
        </div>
   
</body>
</html>
