using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace product.BAL
{
    public class Complaint_BAL
    {
        DAL.Complaint_DAL complaintdal = new DAL.Complaint_DAL();
        private int _complaintId;
        private int _productId;
        private int _userId;
        private string _complaint;
        private string _complaintDate;
        private string _complaintStatus;
        private string _fromDate;
        private string _toDate;

        public int ComplaintId
        {
            get { return _complaintId; }
            set { _complaintId = value; }
        }
        public int ProductId
        {
            set { _productId = value; }
            get { return _productId; }
        }
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Complaint
        {
            get { return _complaint; }
            set { _complaint = value; }
        }

        public string ComplaintDate
        {
            get { return _complaintDate; }
            set
            {
                _complaintDate = value;
            }
        }
        public string ComplaintStatus
        {
            get { return _complaintStatus; }
            set
            {
                _complaintStatus = value;
            }
        }

        public string FromDate
        {
            get { return _fromDate; }
            set { _fromDate = value; }
        }

        public string ToDate
        {
            get { return _toDate; }
            set { _toDate = value; }
        }

        //insert into complaint
        public int InsertingComplaints()
        {
            return complaintdal.InsertComplaint(this);
        }
        //fetching complaints of specific user
        public DataTable ViewComplaints()
        {
            return complaintdal.ViewComplaint(this);
        }

        //fetching all complaints

        public DataTable ViewAllComplaints()
        {
            return complaintdal.ViewAllComplaint(this);
        }

        //fetch complaint of date
        public DataTable ViewDateComplaints()
        {
            return complaintdal.ViewDateComplaint(this);
        }

        public int UpdateComplaint()
        {
            return complaintdal.UpdateComplaint(this);
        }

    }
}
