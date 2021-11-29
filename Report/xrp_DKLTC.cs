using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV.Report
{
    public partial class xrp_DKLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public xrp_DKLTC(string nienKhoa, int hocKy, string maMH, int nhom)
        {
            InitializeComponent();

            this.sqlDataSource1.Connection.ConnectionString = Program.URL_Connect;

            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKy;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = maMH;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = nhom;

            this.sqlDataSource1.Fill();
        }

    }
}
