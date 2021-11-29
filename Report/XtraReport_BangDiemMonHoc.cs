using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV.Report
{
    public partial class XtraReport_BangDiemMonHoc : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_BangDiemMonHoc(String nienkhoa,String hocky,String mamh,String nhom,String magv)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.URL_Connect;
            
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocky;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = mamh;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = nhom;
            this.sqlDataSource1.Queries[0].Parameters[4].Value = magv;
            this.sqlDataSource1.Fill();
        }

    }
}
