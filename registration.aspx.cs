using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace product.guest
{
    public partial class registration : System.Web.UI.Page
    {
        BAL.DeptBAL objdptbl = new BAL.DeptBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }
        protected void btn_Register_Click(object sender, EventArgs e)
        {



            objdptbl.username = username.Text;
            
            objdptbl.address = useraddress.Text;
           
            objdptbl.email = usermail.Text;
            objdptbl.phone = userphone.Text;
            objdptbl.useruname = uname.Text;
            objdptbl.userpassword= password.Text;
            object ob = objdptbl.user_login_insert();
            objdptbl.login_id = ob.ToString();
            int i = objdptbl.insertuser();
           
                Response.Redirect("../guest/loginpage.aspx");



         

           








            }
    }
}