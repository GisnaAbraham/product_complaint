using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace product.DAL
{
    public class Complaint_DAL
    {

        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Complaint_DAL()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public int InsertComplaint(BAL.Complaint_BAL complaintbal)
        {
            string q = "INSERT INTO complaint values('" + complaintbal.ProductId + "','" + complaintbal.UserId + "','" + complaintbal.Complaint + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','not processed')";
            SqlCommand cmd = new SqlCommand(q, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable ViewComplaint(BAL.Complaint_BAL complaintbal)
        {
            string qry = "SELECT p.*,c.* FROM complaint c INNER JOIN product p ON p.productid = c.productid AND userid = '" + complaintbal.UserId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }

        //view complaint of all users
        public DataTable ViewAllComplaint(BAL.Complaint_BAL complaintbal)
        {
            string qry = "SELECT l.uname,p.*,c.* FROM complaint c INNER JOIN login l ON l.userid= c.userid INNER JOIN product_table p ON p.productid = c.productid";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }

        //view complaint via date range
        public DataTable ViewDateComplaint(BAL.Complaint_BAL complaintbal)
        {
            string qry = "SELECT l.uname,p.*,c.* FROM complaint c INNER JOIN login l ON l.userid= c.userid INNER JOIN product p ON p.productid = c.productid WHERE c.date BETWEEN '" + complaintbal.FromDate + "'  AND '" + complaintbal.ToDate + "' ";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }

        public int UpdateComplaint(BAL.Complaint_BAL complaintbal)
        {
            string qry = "update complaint set status = '" + complaintbal.ComplaintStatus + "' where complaint_id = '" + complaintbal.ComplaintId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        
    }
}