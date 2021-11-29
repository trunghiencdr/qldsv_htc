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

        string nienKhoa, maMH, maGV;
        int hocKy, nhom;
        
        public fmpt_BC_DKLTC()
        {
            InitializeComponent();
        }

        private void panelPD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fmpt_BC_DKLTC_Load(object sender, EventArgs e)
        {
            cmbNienKhoa.SelectedIndex = 0;
            cmbHocKy.SelectedIndex = 0;
            cmbNhom.SelectedIndex = 0;


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

        }

        private void button_IN_Click(object sender, EventArgs e)
        {
            try
            {
                nienKhoa = cmbNienKhoa.Text;
                hocKy = int.Parse(cmbHocKy.Text);
                maMH = cmbMonHoc.SelectedValue.ToString();
                nhom = int.Parse(cmbNhom.Text);
                maGV = cmbGiangVien.SelectedValue.ToString();
            }catch(Exception ex)
            {
                errorProvider1.SetError(this.button_IN, "Vui lòng điền đầy đủ thông tin");
                return;
            }

            /*xrp_DKLTC rpt = new xrp_DKLTC(nienKhoa, hocKy, maMH, nhom);*/


            

            xrp_SVDKLTC2 rpt = new xrp_SVDKLTC2(nienKhoa, hocKy, maMH, maGV, nhom);

            rpt.lblKhoa.Text =  cmbKhoa.Text.ToUpper();
            rpt.lblNienKhoaHocKi.Text = "NIÊN KHÓA: " + nienKhoa + "   -   HỌC KÌ: " + hocKy;
            rpt.lblMonNhom.Text = "MÔN: " + cmbMonHoc.Text + "   -    NHÓM: " + nhom;
            rpt.lblGiangVien.Text = "GIẢNG VIÊN: " + cmbGiangVien.Text;

            string cmd = "EXEC SP_BC_SVDKLTC2 '"
                        + nienKhoa + "', "
                        + hocKy + ", '"
                        + maMH + "', '"
                        + maGV + "', "
                        + nhom;
            try
            {
                DataTable dt = Program.ExecSqlDataTable(cmd);
                rpt.lblSoSV.Text = "SỐ SINH VIÊN ĐĂNG KÝ: "+ dt.Rows.Count;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi chạy sp tìm số sinh viên đăng ký");
            }
           
           
            

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
            this.cmbMonHocTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.cmbMonHocTableAdapter.Fill(this.dS.cmbMonHoc);

            this.cmbGiangVienTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.cmbGiangVienTableAdapter.Fill(this.dS.cmbGiangVien);

           

        }
    }
}