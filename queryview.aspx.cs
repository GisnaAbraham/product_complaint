using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace product.admin
{
    public partial class queryview : System.Web.UI.Page
    {
        BAL.Query_BAL querybal = new BAL.Query_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = querybal.ViewAllQuery();
                GridView1.DataBind();

            }
        }



        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

            Response.Redirect("../admin/viewqueryreplay.aspx");

        }
    }
}