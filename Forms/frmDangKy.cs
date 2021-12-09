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

namespace QLDSV.Forms
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GIANGVIEN' table. You can move, or remove it, as needed.
            this.GIANGVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            
            
            this.GIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
            this.checkRolesForRadioButton();
        }
        //check roles
        private void checkRolesForRadioButton()
        {
            if (Program.MGroup == Program.NhomQuyen[1])
            {
                this.radioButtonPGV.Enabled = false;
                this.radioButtonPKT.Enabled = false;
                this.radioButtonKhoa.Checked = true;
            }
            if (Program.MGroup == Program.NhomQuyen[3])
            {
                this.radioButtonPGV.Enabled = false;
                this.radioButtonPKT.Checked = true;
                this.radioButtonKhoa.Enabled = false;
            }
        }

        //kiem tra empty _ null input
        private Boolean checkNullEmptyInput()
        {
            Boolean flag = true;
            if (string.IsNullOrEmpty(txtLoginName.Text))
            {
                lblErorr_LoginName.Visible = true;
                flag = false;
            }else lblErorr_LoginName.Visible = false;
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblError_Password.Visible = true;
                flag = false;
            }
            else lblError_Password.Visible = false;
            if (string.IsNullOrEmpty(txtRePassword.Text))
            {
                lblError_RePassword.Visible = true;
                flag = false;
            }
            else lblError_RePassword.Visible = false;
            //kiem tra xac nhan mat khau
            if (txtPassword.Text == txtRePassword.Text)
            {
                this.lblAlert.Visible = false;     
            }
            else
            {
                this.lblAlert.Visible = true;
                flag = false;
            }

            return flag;
        }
        //kiem tra chon roles
        private Boolean checkRadioButtonRoles()
        {
            if (this.radioButtonPGV.Checked || this.radioButtonKhoa.Checked || this.radioButtonPKT.Checked)
            {
                lblErrorRoles.Visible = false;
                return true;
            }
            lblErrorRoles.Visible = true;
            return false;
        }
        //kiem tra tat ca thong tin dau vao
        private Boolean checkInvalidInfor()
        {
            Boolean check = true;
            if (this.checkNullEmptyInput()) 
            {
                

                //kiem tra chon roles
                if (!this.checkRadioButtonRoles())
                {
                    check = false;
                }


            }else
            {
                check = false;
            }
            return check;
        }
        // tao tai khoan login
        private void createLogin()
        {
            String loginName = txtLoginName.Text;
            String password = txtPassword.Text;
            String magv = (string)this.lookUpEditMaGV.EditValue;


            
            


            if (magv == null)
            {
                lblError_MaGV.Visible = true;
                return;
            }else
            {
                lblError_MaGV.Visible = false;
            }
            String role = radioButtonKhoa.Checked ? Program.NhomQuyen[1] : (radioButtonPGV.Checked ? Program.NhomQuyen[0] : Program.NhomQuyen[3]);

            //tao tai khoan cho khoan choa PGV - KHOA
            String strLenh = " EXEC    @return_value = [dbo].[SP_TAOLOGIN] " +

                            " @LGNAME = N'" + loginName + "', " +
                            " @PASS = N'" + password + "', " +
                            " @USERNAME = N'" + magv + "', " +
                            " @ROLE = N'" + role + "' ";

            //tao tai khoan PGV
            /*
            if (role == Program.NhomQuyen[0])
            {
                Program.KetNoi();
                SqlCommand command = Program.Conn.CreateCommand();
                SqlTransaction transaction;
                transaction = Program.Conn.BeginTransaction("SampleTransaction");
                command.Connection = Program.Conn;
                command.Transaction = transaction;
                try
                {
                    String strQuery = " DECLARE @return_value int " + strLenh +
                         " SELECT  'Return Value' = @return_value ";
                    command.CommandText = strQuery;
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader == null)
                    {
                        MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        int result = int.Parse(dataReader.GetValue(0).ToString());
                        if (result == 1)
                        {
                            lblMessageError.Visible = true;
                            lblMessageError.Text = "Tên đăng nhập bị trùng . Hãy nhập tên đăng nhập khác !";
                        }
                        else if (result == 2)
                        {
                            lblMessageError.Visible = true;
                            lblMessageError.Text = "Giảng viên đã được tạo tài khoản !";
                            

                        }
                        else if (result == 3)
                        {
                            lblMessageError.Visible = true;
                            lblMessageError.Text = "Lỗi thực thi server !";

                        }
                        else if (result == 0)
                        {
                            try
                            {
                                strLenh = " EXEC    @return_value = LINK1.QLDSV.[dbo].[SP_TAOLOGIN] " +

                                            " @LGNAME = N'" + loginName + "', " +
                                            " @PASS = N'" + password + "', " +
                                            " @USERNAME = N'" + magv + "', " +
                                            " @ROLE = N'" + role + "' ";
                                strQuery = " DECLARE @return_value int " + strLenh +
                                " SELECT  'Return Value' = @return_value ";
                                command.CommandText = strQuery;
                                SqlDataReader dataReader2 = command.ExecuteReader();
                                int result2 = int.Parse(dataReader.GetValue(0).ToString());
                                if (result2 == 1)
                                {
                                    lblMessageError.Visible = true;
                                    lblMessageError.Text = "Tên đăng nhập bị trùng . Hãy nhập tên đăng nhập khác !";
                                    transaction.Rollback();
                                  
                                }
                                else if(result2 == 0)
                                {
                                    MessageBox.Show("Tạo tài khoản thành công !", "", MessageBoxButtons.OK);
                                    
                                }
                                else if (result2 == 2)
                                {
                                    lblMessageError.Visible = true;
                                    lblMessageError.Text = "Giảng viên đã được tạo tài khoản !";
                                    transaction.Rollback();

                                }
                                else if (result2 == 3)
                                {
                                    lblMessageError.Visible = true;
                                    lblMessageError.Text = "Lỗi thực thi server !";
                                    transaction.Rollback();
                                }
                            }
                            catch (Exception ex2)
                            {

                            }


                        }
                        return;
                    }

                }
                catch (Exception ex)
                {

                }
            }
            */
            //tao tai khoan cho PKT
            if (role == Program.NhomQuyen[3] && Program.ServerName != ((DataRowView)Program.Bds_Dspm[2])["TENSERVER"].ToString())
            {
                //tu KHOA CNTT -> KETOAN
                strLenh = " EXEC    @return_value = LINK2.QLDSV.[dbo].[SP_TAOLOGIN] " +

                            " @LGNAME = N'" + loginName + "', " +
                            " @PASS = N'" + password + "', " +
                            " @USERNAME = N'" + magv + "', " +
                            " @ROLE = N'" + role + "' ";
            }

            String stringQuery = " DECLARE @return_value int " + strLenh +
                         " SELECT  'Return Value' = @return_value ";
            Console.WriteLine(stringQuery);
            int resultCheckLogin = Utils.CheckDataHelper(stringQuery);

            if (resultCheckLogin == -1)
            {
                MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (resultCheckLogin == 1)
            {
                lblMessageError.Visible = true;
                lblMessageError.Text = "Tên đăng nhập bị trùng . Hãy nhập tên đăng nhập khác !";
            }
            else if (resultCheckLogin == 2)
            {
                lblMessageError.Visible = true;
                lblMessageError.Text = "Giảng viên đã được tạo tài khoản !";

            }
            else if (resultCheckLogin == 3)
            {
                lblMessageError.Visible = true;
                lblMessageError.Text = "Lỗi thực thi server !";

            }
            else if (resultCheckLogin == 0)
            {
                MessageBox.Show("Tạo tài khoản thành công !", "", MessageBoxButtons.OK);

            }

            //nếu là PGV phải tạo user ở cả 2 khoa
            /*
            if (role == Program.NhomQuyen[0])
            {
                //tu KHOA CNTT -> KETOAN
                strLenh = " EXEC    @return_value = LINK1.QLDSV.[dbo].[SP_TAOLOGIN] " +

                            " @LGNAME = N'" + loginName + "', " +
                            " @PASS = N'" + password + "', " +
                            " @USERNAME = N'" + magv + "', " +
                            " @ROLE = N'" + role + "' ";

                stringQuery = " DECLARE @return_value int " + strLenh +
                         " SELECT  'Return Value' = @return_value ";
                Console.WriteLine(stringQuery);
                resultCheckLogin = Utils.CheckDataHelper(stringQuery);
                if (resultCheckLogin == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultCheckLogin == 1)
                {
                    lblMessageError.Visible = true;
                    lblMessageError.Text = "Tên đăng nhập bị trùng . Hãy nhập tên đăng nhập khác !";
                }
                else if (resultCheckLogin == 3)
                {
                    lblMessageError.Visible = true;
                    lblMessageError.Text = "Lỗi thực thi server !";
                }
 
            }*/
            return;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = ckboxShow.Checked ? '\0' : '*';
            txtRePassword.PasswordChar = ckboxShow.Checked ? '\0' : '*';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn hủy thao tác đăng ký tài khoản?",
                      "Xác thực", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
            {
                return;
            }
            else if (dr == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void btnCreateLogin_Click(object sender, EventArgs e)
        {
            if (checkInvalidInfor())
            {
                createLogin();
            }
            else return;
        }

        private void lblError_MaGV_Click(object sender, EventArgs e)
        {

        }
    }
}
