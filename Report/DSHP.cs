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
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class DSHP : Form
    {
        public DSHP()
        {
            InitializeComponent();
        }
        
        private void DSHP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            // TODO: This line of code loads data into the 'dS.HOCPHI' table. You can move, or remove it, as needed.
            this.hOCPHITableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.hOCPHITableAdapter.Fill(this.dS.HOCPHI);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.lOPTableAdapter.Fill(this.dS.LOP);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            String malop = this.lookUpEditMaLop.Text.Trim().ToString();
            String nienkhoa = (string)cmbNienKhoa.Text;
            int hocky = (int)spinEditHocKy.Value;
            Xrpt_SP_Danh_sach_dong_HP report = new Xrpt_SP_Danh_sach_dong_HP(malop, nienkhoa, hocky);
            report.lblMaLop.Text = malop;
            //lay ma khoa 
            try
            {
                SqlDataReader dataReader;
                dataReader = Program.ExecSqlDataReader("SELECT MAKHOA FROM LOP WHERE MALOP = '" + malop+"'");
                String makhoa = "";
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        makhoa = dataReader.GetString(0);
                        Console.WriteLine(dataReader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                dataReader.Close();
                report.lblKhoa.Text = makhoa;
                report.lblHocKi.Text = hocky.ToString();
                report.lblNienKhoa.Text = nienkhoa;
            }
            catch (Exception ex)
            {

            }

            

            
            //report.lblHocKi.Text = hocky.ToString();

            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //chọn khoa mo lop theo khoa

        }
    }

}
