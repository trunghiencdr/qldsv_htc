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
    public partial class fmpt_DIEMTONGKET : DevExpress.XtraEditors.XtraForm
    {

        string lop;
        public fmpt_DIEMTONGKET()
        {
            InitializeComponent();
        }

      

        private void fmpt_DIEMTONGKET_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.cmbLOP' table. You can move, or remove it, as needed.

            
            // TODO: This line of code loads data into the 'dS.LOP1' table. You can move, or remove it, as needed.


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

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.ComboboxHelper(this.cmbKhoa);
            // kết nối database với dữ liệu ở đoạn code trên và fill dữ liệu, nếu như có lỗi thì thoát.
            if (Program.KetNoi() == 0)
            {
                XtraMessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }

            this.cmbLOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.cmbLOPTableAdapter.Fill(this.dS.cmbLOP);


        }

        private void button_IN_Click(object sender, EventArgs e)
        {
            try
            {
                lop = cmbLop.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(this.button_IN, "Vui lòng điền đầy đủ thông tin");
                return;
            }

            xrp_DIEMTONGKET rpt = new xrp_DIEMTONGKET(lop);

            string khoaHoc = ((DataRowView)this.cmbLOPBindingSource[cmbLop.SelectedIndex])["KHOAHOC"].ToString();

            rpt.lblLopKhoaHoc.Text = "LỚP: " + lop + "   -   KHÓA HỌC: " + khoaHoc;
            rpt.lblKhoa.Text = cmbKhoa.Text.ToUpper();

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void button_THOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}