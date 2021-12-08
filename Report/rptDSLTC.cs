using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.Report
{
    public partial class rptDSLTC : Form
    {
        String  nienkhoa, hocki;
        public rptDSLTC()
        {
            InitializeComponent();
        }

        public void initData()
        {
            cmbNienkhoa.DataSource = null;

            cmbHocki.SelectedIndex = 0;

            nienkhoa = "";
            hocki = cmbHocki.Text;
            // 1. load ds nien khoa vao cbb
            Utils.BindingSqlToComboBox(cmbNienkhoa, "exec sp_ds_nienkhoa", "nienkhoa", null);


        }
        private void button1_Click(object sender, EventArgs e)
        {
            nienkhoa = cmbNienkhoa.Text;
            hocki = cmbHocki.Text;

            XtraReport_DanhSachLopTinChi rpt = new XtraReport_DanhSachLopTinChi(nienkhoa, hocki);
            rpt.xrLabelKhoa.Text = cmbKhoa.Text;
            rpt.xrLabelNienkhoa.Text = cmbNienkhoa.Text;
            rpt.xrLabelHocky.Text = cmbHocki.Text;
            ReportPrintTool p = new ReportPrintTool(rpt);
            
            p.ShowPreviewDialog();
        }

        private void cmbKhoa_Click(object sender, EventArgs e)
        {

        }

        private void rptDSLTC_Load(object sender, EventArgs e)
        {

            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Utils.BindingDataToComBo(cmbKhoa, Program.Bds_Dspm.DataSource);

            // TODO : Role Action
            if (Program.MGroup == Program.NhomQuyen[0])// PGV
            {
                cmbKhoa.Visible = true;
                cmbKhoa.Enabled = true;

                
            }
            else if (Program.MGroup == Program.NhomQuyen[1]) // KHOA
            {
                cmbKhoa.Enabled = false;



            }

        }

        private void cmbNienkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNienkhoa.DataSource == null)
            {
                return;
            }
            nienkhoa = cmbNienkhoa.Text;
            hocki = cmbHocki.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO : Chuyển Bộ Phận
            Utils.ComboboxHelper(this.cmbKhoa);

            // kết nối database với dữ liệu ở đoạn code trên và fill dữ liệu, nếu như có lỗi thì
            // thoát.
            if (Program.KetNoi() == 0)
            {
                XtraMessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {

            }

            initData();
        }
    }
}
