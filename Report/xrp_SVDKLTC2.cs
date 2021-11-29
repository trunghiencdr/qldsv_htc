using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV.Report
{
    public partial class xrp_SVDKLTC2 : DevExpress.XtraReports.UI.XtraReport
    {
        public xrp_SVDKLTC2(string nienKhoa, int hocKy, string maMH, string maGV, int nhom)
        {
            InitializeComponent();

            this.sqlDataSource1.Connection.ConnectionString = Program.URL_Connect;

            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKy;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = maMH;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = maGV;
            this.sqlDataSource1.Queries[0].Parameters[4].Value = nhom;

            this.sqlDataSource1.Fill();
        }

    }
}
