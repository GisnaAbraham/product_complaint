using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace product.BAL
{
    public class Query_BAL
    {
        DAL.Query_DAL queryDal = new DAL.Query_DAL();
        private int _queryId;
        private int _productId;
        private int _userId;
        private string _query;
        private string _queryReply;
        private string _queryDate;



        public int QueryId
        {
            get { return _queryId; }
            set { _queryId = value; }
        }
        public int QueryProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public int QueryUserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Query
        {
            get { return _query; }
            set
            {
                _query = value;
            }
        }

        public string QueryReply
        {
            get { return _queryReply; }
            set
            {
                _queryReply = value;
            }
        }

        public string QueryDate
        {
            get { return _queryDate; }
            set
            {
                _queryDate = value;
            }
        }

        public int InsertQuery()
        {
            return queryDal.InsertQuerys(this);
        }

        //view all queries

        public DataTable ViewAllQuery()
        {
            return queryDal.ViewAllQuerys();
        }

        public DataTable ViewSpecificQuery()
        {
            return queryDal.ViewSpecificQueryDetails(this);
        }

        public int GiveReply()
        {
            return queryDal.GiveReplyDetails(this);
        }

        public DataTable GetSpecificUserQueryDetails()
        {
            DataTable result = queryDal.GetSpecificUserQueryDetails(this);
            return result;
        }
    }
}
