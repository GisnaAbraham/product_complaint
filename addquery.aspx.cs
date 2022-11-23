using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace product.user
{
    public partial class addquery : System.Web.UI.Page
    {
        BAL.DeptBAL objdeptbl = new BAL.DeptBAL();
        BAL.Query_BAL queryBal = new BAL.Query_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dr = objdeptbl.viewproduct();
                productlist.DataTextField = "productname";
                productlist.DataValueField = "productid";
                productlist.DataSource = dr;
                productlist.DataBind();

                int userid = Convert.ToInt32(Session["userid"]);
                queryBal.QueryUserId = userid;

                GridView1.DataSource = queryBal.GetSpecificUserQueryDetails();
                GridView1.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            queryBal.QueryProductId = Convert.ToInt32(productlist.SelectedValue);
            queryBal.QueryUserId = Convert.ToInt32(Session["userid"].ToString());
            queryBal.Query = QuestionTextBox.Text;

            int i = queryBal.InsertQuery();
            if (i == 1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Question Posted Successfully" + "');", true);
                QuestionTextBox.Text = string.Empty;

            }

            int userid = Convert.ToInt32(Session["userid"]);
            queryBal.QueryUserId = userid;

            GridView1.DataSource = queryBal.GetSpecificUserQueryDetails();
            GridView1.DataBind();

        }
    }
}
