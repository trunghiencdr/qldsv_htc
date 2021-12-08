using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            
            string chuoiketnoi = "Data Source=DESKTOP-EA82EVS;Initial Catalog=" + Program.Database + ";Integrated Security=True";
            //string chuoiketnoi = "Data Source=LAPTOP-COIEBNU4\\MHUAN;Initial Catalog=" + Program.Database + ";Integrated Security=True";
            //string chuoiketnoi = "Data Source=NHAN;Initial Catalog=" + Program.Database + ";Integrated Security=True";
          
            Program.Conn.ConnectionString = chuoiketnoi;
            txtLogin.Text = "ptl";
            DataTable dt = new DataTable();
            //gọi 1 view và trả về dưới dạng datatable
            //dt = Program.ExecSqlDataTable("SELECT * FROM Get_Subscribes1");
            dt = Program.ExecSqlDataTable("SELECT * FROM Get_Subscribes");

            // cất dt vào biến toàn cục Bds_Dspm
            Program.Bds_Dspm.DataSource = dt;

            // fix lỗi nho nhỏ :v
            //Program.Bds_Dspm.Sort = "TENKHOA ASC";
            Program.Bds_Dspm.Sort = "TENSERVER ASC";
            // đoạn code liên kết giữa bds với combobox
            Utils.BindingDataToComBo(cmbKhoa, dt);
        }


        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // gán server đã chọn vào biến toàn cục.
                Program.ServerName = cmbKhoa.SelectedValue.ToString();
            }
            catch (Exception) { };
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            /*  if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
              {
                  XtraMessageBox.Show("Tài khoản đăng nhập không được trống", "Lỗi đăng nhập", MessageBoxButtons.OK);

                  // trỏ con trỏ chuột về ô user...
                  txtLogin.Focus();
                  return;
              }

              Program.MLoginDN = txtLogin.Text;
              Program.PasswordDN = txtPass.Text;
              Program.MKhoa = cmbKhoa.SelectedIndex;// 0: CNTT ,  1: vt, 2: pkt

              Program.MLogin = Program.MLoginDN; // nếu là gv thì MLoginDN = MLogin
              Program.MPassword = Program.PasswordDN;
              String strLenh = "exec SP_DANGNHAP_GV '" + Program.MLogin + "'";
              if (cbSinhVien.Checked == true)
              {
                  if (cmbKhoa.SelectedIndex == 0)
                  {
                      Program.MLogin = "N15DCCN001";
                      Program.MPassword = "123";
                  }
                  else if (cmbKhoa.SelectedIndex == 1)
                  {
                      Program.MLogin = "N15DCVT001";
                      Program.MPassword = "123";
                  }
                  strLenh = "exec SP_DANGNHAP_SV '" + Program.MLogin + "'";
              }
              if (Program.KetNoi() == 0)
              {
                  return;
              }
              Program.MyReader = Program.ExecSqlDataReader(strLenh);
              if (Program.MyReader == null)
              {
                  return;
              }

              Program.MyReader.Read();
              Program.UserName = Program.MyReader.GetString(0);     // Lay user name
              if (Convert.IsDBNull(Program.UserName))
              {
                  XtraMessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\nBạn xem lại username, password", "", MessageBoxButtons.OK);
                  return;
              }

              try
              {
                  Program.MHoten = Program.MyReader.GetString(1);
                  Program.MGroup = Program.MyReader.GetString(2);
              }
              catch (Exception ex)
              {
                  Debug.WriteLine("---> Lỗi: " + ex.ToString());
                  XtraMessageBox.Show("Login bạn nhập không có quyền truy cập vào chương trình", "", MessageBoxButtons.OK);
                  return;
              }

              if (cbSinhVien.Checked)
              {
                  if (Program.KetNoi() == 0)
                  {
                      return;
                  }
                  strLenh = "exec SP_KiemTraDangNhap_SV '" + Program.MLoginDN + "', '" + Program.PasswordDN + "'";
                  Program.MyReader = Program.ExecSqlDataReader(strLenh);
                  if (Program.MyReader == null) return;
                  if (!Program.MyReader.HasRows)
                  {
                      XtraMessageBox.Show("Thông tin đăng nhập không chính xác\nBạn xem lại username, password", "", MessageBoxButtons.OK);
                      return;
                  }
                  Program.MyReader.Read();
                  Program.UserName = Program.MyReader.GetString(0);
                  Program.MHoten = Program.MyReader.GetString(1);
              }

              Program.MyReader.Close();
              Program.Conn.Close();

              // truy cập vào frm main 
              Program.frmMain = new frmMain();

              // hiện thông tin tài khoản
              Program.frmMain.lblMA.Text = "MÃ : " + Program.UserName.Trim();
              Program.frmMain.lblHOTEN.Text = "HỌ VÀ TÊN : " + Program.MHoten.Trim();
              Program.frmMain.lblNHOM.Text = "NHÓM : " + Program.MGroup;

              Program.frmMain.Show();
              Program.FrmDangNhap.Visible = false;*/

            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                XtraMessageBox.Show("Tài khoản đăng nhập không được trống", "Lỗi đăng nhập", MessageBoxButtons.OK);

                // trỏ con trỏ chuột về ô user...
                txtLogin.Focus();
                return;
            }

            Program.MLoginDN = txtLogin.Text;
            Program.PasswordDN = txtPass.Text;
            Program.MKhoa = cmbKhoa.SelectedIndex;// 0: CNTT ,  1: vt, 2: pkt

            Program.MLogin = Program.MLoginDN; // nếu là gv thì MLoginDN = MLogin
            Program.MPassword = Program.PasswordDN;

            String strLenh = "exec SP_DANGNHAP_GV '" + Program.MLogin + "'";
            if (cbSinhVien.Checked)
            {
                Program.MLogin = "TKSV";
                Program.MPassword = "123";

                strLenh = "EXEC SP_DANGNHAP_SV '" + Program.MLogin + "', '" + Program.MLoginDN + "', '" + Program.PasswordDN + "'";
              
            }
            if (Program.KetNoi() == 0)
            {
                return;

            }
            Program.MyReader = Program.ExecSqlDataReader(strLenh);
            if (Program.MyReader == null)
            {
                return;
            }
            // NẾU ĐĂNG NHẬP THÀNH CÔNG THÌ chứng tỏ có login
            Program.MyReader.Read();
            try { 
            Program.UserName = Program.MyReader.GetString(0).ToUpper();     // Lay user name (MÃ)
            Program.MHoten = Program.MyReader.GetString(1); // Lấy họ tên
            Program.MGroup = Program.MyReader.GetString(2);
                if(Program.MGroup == Program.NhomQuyen[2])// sinh vein
                Program.MLop = Program.MyReader.GetString(3);
            }
            catch (Exception ex) // khi hoten = null do sai ma sv or pass word or login vao khong dung
            {
                Debug.WriteLine("---> Lỗi: " + ex.ToString());
                XtraMessageBox.Show("Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }

            Program.MyReader.Close();
            Program.Conn.Close();

            // truy cập vào frm main 
            Program.frmMain = new frmMain();

            // hiện thông tin tài khoản
            Program.frmMain.lblMA.Text = "MÃ : " + Program.UserName.Trim();
            Program.frmMain.lblHOTEN.Text = "HỌ VÀ TÊN : " + Program.MHoten.Trim();
            Program.frmMain.lblNHOM.Text = "NHÓM : " + Program.MGroup;

            Program.frmMain.Show();
            Program.FrmDangNhap.Visible = false;
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = (chkShowPass.Checked) ? false : true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
            
        private void frmDangNhap_VisibleChanged(object sender, EventArgs e)
        {
            Program.Bds_Dspm.RemoveFilter();
            cmbKhoa_SelectedIndexChanged(sender, e);
        }

       

        private void cbSinhVien_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
