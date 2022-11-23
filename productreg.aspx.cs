using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace product.admin
{
    public partial class productreg : System.Web.UI.Page
    {
        BAL.DeptBAL objdeptbl = new BAL.DeptBAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objdeptbl.viewproduct();
                GridView1.DataBind();


            }
        }
        protected void btn_Register_Click(object sender, EventArgs e)
        {



            objdeptbl.productname = productname.Text;

            objdeptbl.description = description.Text;


            object ob = objdeptbl.insertproduct();
            objdeptbl.productid = ob.ToString();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objdeptbl.productid = id.ToString();
            int i = objdeptbl.Deleteproduct();
            GridView1.EditIndex = -1;



            GridView1.DataSource = objdeptbl.viewproduct();




            GridView1.DataBind();
        }



        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objdeptbl.viewproduct();

            GridView1.DataBind();
        }



        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox TextBox1 = new TextBox();
            TextBox TextBox2 = new TextBox();
            TextBox1 = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox2 = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];

            objdeptbl.productid = id.ToString();
            objdeptbl.productname = TextBox1.Text;
            objdeptbl.description = TextBox2.Text;
            int i = objdeptbl.updateproduct();

            GridView1.EditIndex = -1;

            GridView1.DataSource = objdeptbl.viewproduct();

            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = objdeptbl.viewproduct();
            GridView1.DataBind();

        }
        protected void Home_Page(object sender, EventArgs e)
        {



            objdeptbl.productname = productname.Text;

            objdeptbl.description = description.Text;


            object ob = objdeptbl.insertproduct();
            objdeptbl.productid = ob.ToString();

        }
        protected void Home_page(object sender, EventArgs e)
        {

            Response.Redirect("../admin/adminhome.aspx");
        }
    }
}