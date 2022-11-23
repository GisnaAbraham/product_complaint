using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace product.admin
{
    public partial class confirmuser : System.Web.UI.Page
    {
        BAL.DeptBAL objdeptbl = new BAL.DeptBAL();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objdeptbl.viewusers();
                GridView1.DataBind();
            }
       


        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string s = GridView1.DataKeys[e.RowIndex].Value.ToString();
            objdeptbl.login_id = s;

            int i = objdeptbl.confirmuser();
            GridView1.DataSource = objdeptbl.viewusers();
            GridView1.DataBind();
            Response.Redirect("../admin/adminhome.aspx");
        }
      
    }
}

        
    

