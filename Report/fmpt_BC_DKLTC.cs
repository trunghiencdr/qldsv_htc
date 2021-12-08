using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.Report
{
    public partial class fmpt_BC_DKLTC : DevExpress.XtraEditors.XtraForm
    {

        string nienKhoa, maMH;
        int hocKy, nhom;
        
        public fmpt_BC_DKLTC()
        {
            InitializeComponent();
        }

        private void panelPD_Paint(object sender, PaintEventArgs e)
        {

        }

        public void initData()
        {
            cmbNienKhoa.DataSource = null;
            
            cmbHocKy.SelectedIndex = 0;
           
            nienKhoa = "";
            hocKy = int.Parse(cmbHocKy.Text);
            maMH = "";
            nhom = 0;
            // 1. load ds nien khoa vao cbb
            Utils.BindingSqlToComboBox(cmbNienKhoa, "exec sp_ds_nienkhoa", "nienkhoa", null);


        }

        private void fmpt_BC_DKLTC_Load(object sender, EventArgs e)
        {

            initData();


            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'KHOA%'";

            Utils.BindingDataToComBo(cmbKhoa, Program.Bds_Dspm);
            if (Program.MGroup == Program.NhomQuyen[0])//Phòng gv
            {
                cmbKhoa.Enabled = true;
            }
            else if (Program.MGroup == Program.NhomQuyen[1])//khoa
            {
                cmbKhoa.Enabled = false;
                cmbKhoa.SelectedIndex = Program.MKhoa;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelMaSV_Click(object sender, EventArgs e)
        {

        }

        private void button_THOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label_TenLop_Click(object sender, EventArgs e)
        {

        }

        private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNienKhoa.DataSource == null)
            {
                cmbMonHoc.DataSource = null;
                return;
            }
            nienKhoa = cmbNienKhoa.Text;
            hocKy = int.Parse(cmbHocKy.Text);

            String sql = "EXEC SP_DSMH_FILTER '" + nienKhoa + "', " + hocKy;
            Utils.BindingSqlToComboBox(cmbMonHoc, sql, "TENMH", "MAMH");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tENMHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonHoc.DataSource == null)
            {
                cmbNhom.DataSource = null;
                return;
            }
            maMH = cmbMonHoc.SelectedValue.ToString();
            string sql = "EXEC SP_DSNHOM_FILTER '" + nienKhoa + "', " + hocKy + ",'" + maMH + "'";
            Utils.BindingSqlToComboBox(cmbNhom, sql, "NHOM", null);
        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            hocKy = int.Parse(cmbHocKy.Text);
            if (cmbNienKhoa.DataSource == null)
            {
                return;
            }
            String sql = "EXEC SP_DSMH_FILTER '" + nienKhoa + "', " + hocKy;
            Utils.BindingSqlToComboBox(cmbMonHoc, sql, "TENMH", "MAMH");
        }

        private void button_IN_Click(object sender, EventArgs e)
        {
            try
            {
                nienKhoa = cmbNienKhoa.Text;
                hocKy = int.Parse(cmbHocKy.Text);
                maMH = cmbMonHoc.SelectedValue.ToString();
                nhom = int.Parse(cmbNhom.Text);
            }catch(Exception ex)
            {
                errorProvider1.SetError(this.button_IN, "Vui lòng điền đầy đủ thông tin");
                return;
            }

            xrp_DKLTC rpt = new xrp_DKLTC(nienKhoa, hocKy, maMH, nhom);

            rpt.lblKhoa.Text =  cmbKhoa.Text.ToUpper();
            rpt.lblNienKhoaHocKi.Text = "NIÊN KHÓA: " + nienKhoa + "   -   HỌC KÌ: " + hocKy;
            rpt.lblMonNhom.Text = "MÔN: " + cmbMonHoc.Text + "   -    NHÓM: " + nhom;

            ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.ComboboxHelper(this.cmbKhoa);
            // kết nối database với dữ liệu ở đoạn code trên và fill dữ liệu, nếu như có lỗi thì thoát.
            if (Program.KetNoi() == 0)
            {
                XtraMessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            initData();

           

        }
    }
}