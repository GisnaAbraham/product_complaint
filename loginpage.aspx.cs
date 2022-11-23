using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace product.guest
{
    public partial class loginpage : System.Web.UI.Page
    {
        BAL.DeptBAL objdeptbl = new BAL.DeptBAL();
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Register_Click(object sender, EventArgs e)
        {
            objdeptbl.useruname = uname.Text;
            objdeptbl.userpassword = password.Text;
            DataTable dt = objdeptbl.checklogin();

            if (dt.Rows.Count == 1)
            {
                Session["uname"] = dt.Rows[0]["uname"].ToString();
                Session["login_id"] = dt.Rows[0]["login_id"].ToString();



                if (dt.Rows[0]["role"].ToString() == "admin")
                    Response.Redirect("../admin/adminhome.aspx");
                else if (dt.Rows[0]["role"].ToString() == "user")
                    if (dt.Rows[0]["status"].ToString() == "confirmed")
                        Response.Redirect("../user/userhome.aspx");
                    else
                        Response.Write("<script>alert(' User Not Vserified');</script>");
                else
                    Response.Write("<script>alert('Invalid Credentials');</script>");






            }
        }
    }
}   