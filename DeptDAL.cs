using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace product.DAL
{
    public class DeptDAL
    {
       
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public DeptDAL()
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
      



        public int userInsert(BAL.DeptBAL obj)
        {
            string qry = "insert into registration values('" + obj.username + "' ,'"+ obj.address+"','"+obj.email+"','"+obj.phone+ "','"+obj.login_id+"')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public object userlogin(BAL.DeptBAL obj)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login values('" + obj.useruname + "','" + obj.userpassword+ "','Not confirmed','user');select @@IDENTITY";
            object id = cmd.ExecuteScalar();
            return id;
        }
        public int User_login(BAL.DeptBAL obj)
        {
            string s = "select count(*) from login where username='" + obj.useruname + "' and password='" + obj.userpassword + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            int row = (int)cmd.ExecuteScalar();
            return row;
        }
        public int productInsert(BAL.DeptBAL obj)
        {
            string qry = "insert into product values('" + obj.productname + "' ,'" + obj.description + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable viewProduct()
        {
            string s = "select * from product ";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int productupdate(BAL.DeptBAL obj)
        {
            string s = "update product set productname = '" + obj.productname + "',description = '" + obj.description + "'where product_id = '" + obj.productid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());



            return cmd.ExecuteNonQuery();
        }


        public DataTable view_users(BAL.DeptBAL obj)
        {
            string qry  = "select * from registration  t inner join login l ON t.login_id=l.login_id WHERE l.status='not confirmed' AND l.role='user'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int productdelete(BAL.DeptBAL obj)
        {
            string s = "Delete from product where product_id='" + obj.productid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public int Confirm_user(BAL.DeptBAL obj)
        { 
            string s = "update login set status= 'confirmed' where login_id ='"+ obj.login_id+ "'";
            SqlCommand cmd = new SqlCommand(s, Getcon()); 
            return cmd.ExecuteNonQuery();
        }
        public DataTable login_check(BAL.DeptBAL obj)
        {
            string s = "select * from login where uname='" + obj.useruname + "' AND password='" + obj.userpassword + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
       
    }
}
     
    



    

