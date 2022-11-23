using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace product.DAL
{
    public class Query_DAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Query_DAL()
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
        public int InsertQuerys(BAL.Query_BAL querybal)
        {
            string q = "INSERT INTO tbl_query values('" + querybal.QueryProductId + "','" + querybal.QueryUserId + "','" + querybal.Query + "',' ','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            SqlCommand cmd = new SqlCommand(q, Getcon());
            return cmd.ExecuteNonQuery();
        }

     


        public DataTable ViewAllQuerys()
        {
            string qry = "SELECT l.username,p.*,q.* FROM tbl_query q INNER JOIN login l ON l.login_id= q.login_id INNER JOIN product p ON p.product_id = q.product_id";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }

        public DataTable ViewSpecificQueryDetails(BAL.Query_BAL querybal)
        {
            string v = "SELECT l.username,p.*,q.* FROM tbl_query q INNER JOIN registration l ON l.user_id= q.user_id INNER JOIN product p ON p.product_id = q.product_id WHERE q.query_Id='" + querybal.QueryId + "'";
            string qry = v;
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }

      

        public int GiveReplyDetails(BAL.Query_BAL querybal)
        {
            string qry = "UPDATE  tbl_query SET reply = '" + querybal.QueryReply + "' where queryId = '" + querybal.QueryId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable GetSpecificUserQueryDetails(BAL.Query_BAL querybal)
        {
            string qry = "SELECT l.username,p.*,q.* FROM tbl_query q INNER JOIN login l ON l.login_id= q.login_id INNER JOIN product p ON p.product_id = q.product_id where q.login_id='" + querybal.QueryUserId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }

       
    }
}