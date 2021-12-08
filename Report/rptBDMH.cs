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
            initData();
        }

        public rptBDMH()
        {
            InitializeComponent();
        }

        public void initData()
        {
            cmbNienKhoa.DataSource = null;

            cmbHocky.SelectedIndex = 0;

            nienkhoa = "";
            hocki = cmbHocky.Text;
            mamh = "";
            nhom = "";
            // 1. load ds nien khoa vao cbb
            Utils.BindingSqlToComboBox(cmbNienKhoa, "exec sp_ds_nienkhoa", "nienkhoa", null);


        }

        private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNienKhoa.DataSource == null)
            {
                cmbMH.DataSource = null;
                return;
            }
            nienkhoa = cmbNienKhoa.Text;
            hocki = cmbHocky.Text;

            String sql = "EXEC SP_DSMH_FILTER '" + nienkhoa + "', " + hocki;
            Utils.BindingSqlToComboBox(cmbMH, sql, "TENMH", "MAMH");
        }

        private void cmbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMH.DataSource == null)
            {
                cmbNhom.DataSource = null;
                return;
            }
            mamh = cmbMH.SelectedValue.ToString();
            string sql = "EXEC SP_DSNHOM_FILTER '" + nienkhoa + "', " + hocki + ",'" + mamh + "'";
            Utils.BindingSqlToComboBox(cmbNhom, sql, "NHOM", null);
        }

        private void cmbHocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            hocki = cmbHocky.Text;
            if (cmbNienKhoa.DataSource == null)
            {
                return;
            }
            String sql = "EXEC SP_DSMH_FILTER '" + nienkhoa + "', " + hocki;
            Utils.BindingSqlToComboBox(cmbMH, sql, "TENMH", "MAMH");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                nienkhoa = cmbNienKhoa.Text;
                hocki = cmbHocky.Text;
                mamh = cmbMH.SelectedValue.ToString();
                nhom = cmbNhom.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(this.button1, "Vui lòng điền đầy đủ thông tin");
                return;
            }
            XtraReport_BangDiemMonHoc rpt = new XtraReport_BangDiemMonHoc( nienkhoa, hocki,mamh,nhom);
            rpt.xrLabelKhoa.Text = cmbKhoa.Text;
            rpt.xrLabelNienkhoa.Text = nienkhoa;
            rpt.xrLabelHocki.Text = hocki;
            rpt.xrLabelMonhoc.Text = cmbMH.Text;
            rpt.xrLabelNhom.Text = nhom;
            ReportPrintTool p = new ReportPrintTool(rpt);

            p.ShowPreviewDialog();
        }

        private void rptBDMH_Load(object sender, EventArgs e)
        {
            

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
