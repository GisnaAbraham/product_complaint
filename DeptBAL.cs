using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace product.BAL
{
    public class DeptBAL
    {
        //create object pf dataAccess layer
        DAL.DeptDAL objdeptdl = new DAL.DeptDAL();
        //create two variables based on table
        private string _username;
        private string _userid;
        private string _address;
        private string _email;
        private string _phone;
        private string _useruname;
        private string _userpassword;
        private string _productname;
        private string _description;
        private string _login_id;
        private string _productid;
      

        public string userid
        {

            get
            {
                return _userid;
            }
            set
            {
                _userid = value;
            }
        }
        public string username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        public string address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public string phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }
        public string useruname
        {
            get
            {
                return _useruname;
            }
            set
            {
                _useruname = value;
            }
        }
        public string userpassword
        {
            get
            {
                return _userpassword;
            }
            set
            {
                _userpassword = value;
            }
        }
        public string productname
        {
            get
            {
                return _productname;
            }
            set
            {
                _productname = value;
            }
        }
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        public string login_id
        {
            get
            {
                return _login_id;
            }
            set
            {
                _login_id = value;
            }
        }
        public string productid
        {

            get
            {
                return _productid;
            }
            set
            {
                _productid = value;
            }
        }
     

        public int insertuser()
        {
            return objdeptdl.userInsert(this);
        }
        public object user_login_insert()
        {
            return objdeptdl.userlogin(this);
        }
        public object insertproduct()
        {
            return objdeptdl.productInsert(this);
        }
        public DataTable viewusers()
        {
            return objdeptdl.view_users(this);
        }
        public DataTable checklogin()
        {
            return objdeptdl.login_check(this);
        }

        public int confirmuser()
        {
            return objdeptdl.Confirm_user(this);
        }
        public DataTable viewproduct()
        {
            return objdeptdl.viewProduct();
        }
        public int updateproduct()
        {
            return objdeptdl.productupdate(this);
        }
        public int Deleteproduct()
        {
            return objdeptdl.productdelete(this);
        }
  
        
    }
}



      



       

   