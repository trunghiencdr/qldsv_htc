using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Forms.Report
{
    public partial class Xrpt_SP_PHIEUDIEM : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_SP_PHIEUDIEM()
        {
            InitializeComponent();
        }
        public Xrpt_SP_PHIEUDIEM(String masv)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.URL_Connect;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = masv;
            this.sqlDataSource1.Fill();
        }
    }
}
