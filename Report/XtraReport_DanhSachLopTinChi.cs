using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV.Report
{
    public partial class XtraReport_DanhSachLopTinChi : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_DanhSachLopTinChi(String nienkhoa,String hocki,String khoa)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.URL_Connect;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocki;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = khoa;
            this.sqlDataSource1.Fill();
        }

    }
}
