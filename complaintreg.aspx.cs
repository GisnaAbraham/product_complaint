using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace product.user
{
    public partial class complaintreg : System.Web.UI.Page
    {
        BAL.DeptBAL objdeptbl = new BAL.DeptBAL();
        BAL.Complaint_BAL complaintbal = new BAL.Complaint_BAL();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dr = objdeptbl.viewproduct();
                productlist.DataTextField = "productname";
                productlist.DataValueField = "productid";
                productlist.DataSource = dr;
                productlist.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            complaintbal.ProductId = Convert.ToInt32(productlist.SelectedValue);
            complaintbal.UserId = Convert.ToInt32(Session["user_id"]);
            complaintbal.Complaint = TextBox1.Text;
            int i = complaintbal.InsertingComplaints();
            if (i == 1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Complaint Registered Successfully" + "');", true);

            }
        }
    }
}
