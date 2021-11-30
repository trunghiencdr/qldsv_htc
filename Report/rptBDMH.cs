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
    public partial class rptBDMH : Form
    {
        String nienkhoa, hocki,mamh,nhom;

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.ComboboxHelper(this.cmbKhoa);
            // kết nối database với dữ liệu ở đoạn code trên và fill dữ liệu, nếu như có lỗi thì thoát.
            if (Program.KetNoi() == 0)
            {
                XtraMessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
        }

        public rptBDMH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nienkhoa = txtNienkhoa.Text;
            hocki = spinEditHocKy.Text;
            mamh = cmbMH.SelectedValue.ToString();
            nhom = spinEditNhom.Text;
            XtraReport_BangDiemMonHoc rpt = new XtraReport_BangDiemMonHoc( nienkhoa, hocki,mamh,nhom);
            rpt.xrLabelKhoa.Text = cmbKhoa.Text;
            rpt.xrLabelNienkhoa.Text = txtNienkhoa.Text;
            rpt.xrLabelHocki.Text = spinEditHocKy.Text;
            rpt.xrLabelMonhoc.Text = cmbMH.Text;
            rpt.xrLabelNhom.Text = spinEditNhom.Text;
            ReportPrintTool p = new ReportPrintTool(rpt);

            p.ShowPreviewDialog();
        }

        private void rptBDMH_Load(object sender, EventArgs e)
        {
            this.cmbGiangVienTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            // TODO: This line of code loads data into the 'dS.cmbGiangVien' table. You can move, or remove it, as needed.
            this.cmbGiangVienTableAdapter.Fill(this.dS.cmbGiangVien);
            // TODO: This line of code loads data into the 'dS.cmbGiangVien' table. You can move, or remove it, as needed.

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
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

        private void cmbKhoa_Click(object sender, EventArgs e)
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
        }
    }
}
