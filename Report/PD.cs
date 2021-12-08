using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using QLDSV.Forms.Report;

namespace QLDSV.Report
{
    public partial class PD : Form
    {
        public PD()
        {
            InitializeComponent();
        }
        private void assignRoles()
        {

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
        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSINHVIEN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
        private void assignRoles2()
        {
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
        private void PD_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            assignRoles2();
            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Utils.BindingDataToComBo(cmbKhoa, Program.Bds_Dspm.DataSource);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String masv = cmbMASV.Text;
            Xrpt_SP_PHIEUDIEM report = new Xrpt_SP_PHIEUDIEM(masv);
            int postion = bdsSINHVIEN.Position;
            if(postion < 0)
            {
                MessageBox.Show("Sinh viên chưa có điểm của bất kì môn nào");
                return;
            }
            String ho = ((DataRowView)bdsSINHVIEN[postion])["HO"].ToString();
            String ten = ((DataRowView)bdsSINHVIEN[postion])["TEN"].ToString();
            String malop = ((DataRowView)bdsSINHVIEN[postion])["MALOP"].ToString();
            report.lblMASV.Text = masv;
            report.lblHOTEN.Text = ho + " " + ten;
            report.lblLOP.Text = malop;


            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO : Chuyển Bộ Phận
            Utils.ComboboxHelper(this.cmbKhoa);

            // kết nối database với dữ liệu ở đoạn code trên và fill dữ liệu, nếu như có lỗi thì
            // thoát.
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            }
        }
    }
}
