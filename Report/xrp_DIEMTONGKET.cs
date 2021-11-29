using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV.Report
{
    public partial class xrp_DIEMTONGKET : DevExpress.XtraReports.UI.XtraReport
    {
        public xrp_DIEMTONGKET(string lop)
        {
            this.
            InitializeComponent();
           
            this.sqlDataSource1.Connection.ConnectionString = Program.URL_Connect;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = lop;
            this.sqlDataSource1.Fill();
        }

    }
}
