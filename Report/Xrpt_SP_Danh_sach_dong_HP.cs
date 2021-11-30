using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class Xrpt_SP_Danh_sach_dong_HP : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_SP_Danh_sach_dong_HP()
        {
            InitializeComponent();
        }
        public Xrpt_SP_Danh_sach_dong_HP(String malop, String nienkhoa, int hocky)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.URL_Connect;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = hocky;
            this.sqlDataSource1.Fill();
        }

    }
}
