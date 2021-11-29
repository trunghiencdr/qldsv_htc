using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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
    public partial class frmDangKyLTC : DevExpress.XtraEditors.XtraForm
    {

        BindingSource bdsDSMH = new BindingSource();
        BindingSource bdsDKMH = new BindingSource();
        DataTable dtMH = new DataTable();
        DataTable dtDKMH = new DataTable();
        List<string> listHuyDK = new List<string>();
        int countFocus = 0;
        int btnBatDauClick = 0;
        public frmDangKyLTC()
        {
            InitializeComponent();
        }
        public void initData()
        {

            // lấy thông tin sinh viên

            txtMaSV.Text = Program.MLogin;
            txtMaLop.Text = "lop cn1";
            txtHoTen.Text = Program.MHoten;


            cmbNienKhoa.DataSource = null;
            // 1. load ds nien khoa vao cbb
            Utils.BindingSqlToComboBox(cmbNienKhoa, "exec sp_ds_nienkhoa", "nienkhoa", null);

            //2. load ds hoc ki vao cbb
            cmbHocKi.Items.Clear();
            cmbHocKi.Items.AddRange(new object[] { 1, 2, 3, 4 });
            cmbHocKi.SelectedIndex = 0;


        }
        

       

       

       

        private void frmDangKyLTC_Load(object sender, EventArgs e)
        {
            initData();
            RepositoryItemCheckEdit rep = new RepositoryItemCheckEdit();
            rep.ValueChecked = 1;
            rep.ValueUnchecked = 0;
            gridViewDSMH.Columns["DANGKY"].ColumnEdit = rep;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            // KIEM TRA NIEN KHOA HOC KI
            errorProvider1.Clear();
            this.groupControlDKMH.Enabled = false;
            this.groupControlMH.Enabled = true;
            this.btnBatDau.Enabled = false;
            this.btnHuy.Enabled = true;
            this.btnLuu.Enabled = true;
            if (cmbNienKhoa.Items.Count==0)
            {
                this.btnBatDau.Enabled = true;
                this.btnLuu.Enabled = false;
                errorProvider1.SetError(this.btnBatDau, "Các trường thông tin không được để trống!");
                return;
            }

            this.btnBatDau.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;


            String nienKhoa = cmbNienKhoa.Text;
            int hocKy = int.Parse(cmbHocKi.Text);
            // load ds vao bang

            String cmd = "EXEC SP_DANGKY_MONHOC '"
                        + nienKhoa + "',"
                        + hocKy;

            String cmd1 = "EXEC SP_DS_DKMH '"
                        + txtMaSV.Text + "', '"
                        + nienKhoa + "',"
                        + hocKy;
            dtDKMH = Program.ExecSqlDataTable(cmd1);
            dtMH = Program.ExecSqlDataTable(cmd);
            this.bdsDSMH.DataSource = dtMH;
            this.bdsDKMH.DataSource = dtDKMH;

           

            if (this.bdsDSMH.Count > 0)
            {
                this.gridControlDSMH.DataSource = this.bdsDSMH;
            }else
            {
                XtraMessageBox.Show("Không có môn học trong thời gian này!", "", MessageBoxButtons.OK);
                return;
            }
            
                this.gridControlDKMH.DataSource = this.bdsDKMH;
            

            //xử lí check mon học
            for(int i=0; i<bdsDSMH.Count; i++)
            {
                for(int j=0; j<bdsDKMH.Count; j++)
                {
                    string maLTC1 = ((DataRowView)bdsDSMH[i])["MALTC"].ToString();
                    string maLTC2 = ((DataRowView)bdsDKMH[j])["MALTC"].ToString();
                    if (maLTC1.Equals(maLTC2))
                    {
                        Console.WriteLine("Checked:");
                        this.gridViewDSMH.SetRowCellValue(i, "DANGKY", true);
                    }
                }
                
            }
            for (int i = 0; i < bdsDSMH.Count; i++)
            {
                Console.WriteLine("bdsDangKy:" + this.gridViewDSMH.GetRowCellValue(i, "DANGKY"));
            }

                btnBatDauClick++;
        }





        private void gridViewDSMH_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string check = Convert.ToString(this.gridViewDSMH.GetFocusedValue());

            if (countFocus == 0) // lần thứ 2 click trong cùng ô, nó k thể lấy giá trị mới ta cần đảo nó lại
            {
               
                if (check=="0") check = "1";
                else check = "0";
                Console.WriteLine("O cung o nen check="+check);
                this.gridViewDSMH.SetRowCellValue(e.RowHandle, "DANGKY", check);
            }


            if (check == "0") // checked
            {
                //kiem tra nếu mamh, magv, nhom đã đăng ký trùng với cái vừa click thì 
                // đổi môn đã đk thành mới, xóa cái đk cũ đi
                // bỏ check cái dsmh cũ


                string maLTC = Convert.ToString(this.gridViewDSMH.GetRowCellValue(e.RowHandle, "MALTC"));
                String maMH = Convert.ToString(this.gridViewDSMH.GetRowCellValue(e.RowHandle, "MAMH"));
                String tenMH = Convert.ToString(this.gridViewDSMH.GetRowCellValue(e.RowHandle, "TENMH"));
                String maGV = Convert.ToString(this.gridViewDSMH.GetRowCellValue(e.RowHandle, "MAGV"));
                String gv = Convert.ToString(this.gridViewDSMH.GetRowCellValue(e.RowHandle, "HOTENGV"));
                int nhom = Convert.ToInt16(this.gridViewDSMH.GetRowCellValue(e.RowHandle, "NHOM"));

                // đổi môn học cũ thành mới
                string maLTC_cu = "";
                int flag = 0;
                dtDKMH.AcceptChanges();
                foreach (DataRow rowDK in dtDKMH.Rows)
                {
                    // nếu trùng thì thay thế
                    if (Convert.ToString(rowDK["MAMH"]) == maMH &&
                        Convert.ToString(rowDK["MAGV"]) == maGV)
                    {
                        maLTC_cu = Convert.ToString(rowDK["MALTC"]);
                        rowDK["MALTC"] = maLTC;
                        rowDK["NHOM"] = nhom;

                        // đổi trạng thái huy dang ky thành 1
                        listHuyDK.Add(maLTC_cu);
                        flag = 1;
                        break;
                    }
                }
                dtDKMH.AcceptChanges();
                if (flag == 1)// bị trùng
                {
                    /*// thêm mới
                    DataRow row = dtDKMH.NewRow();
                    row["MALTC"] = maLTC;
                    row["MAMH"] = maMH;
                    row["TENMH"] = tenMH;
                    row["MAGV"] = maGV;
                    row["HOTENGV"] = gv;
                    row["NHOM"] = nhom;
                    dtDKMH.Rows.Add(row);
                    bdsDKMH.DataSource = dtDKMH;*/

                    // bỏ check cái cũ 

                    for (int i = 0; i < gridViewDSMH.RowCount; i++)
                    {
                        if (maLTC_cu == Convert.ToString(gridViewDSMH.GetRowCellValue(i, "MALTC")))
                        {
                            this.gridViewDSMH.SetRowCellValue(i, "DANGKY", 0);
                            break;
                        }
                    }
                }
                else /// nếu không trùng thì thêm mới
                {

                    DataRow row = dtDKMH.NewRow();
                    row["MALTC"] = maLTC;
                    row["MAMH"] = maMH;
                    row["TENMH"] = tenMH;
                    row["MAGV"] = maGV;
                    row["HOTENGV"] = gv;
                    row["NHOM"] = nhom;
                    dtDKMH.Rows.Add(row);
                    bdsDKMH.DataSource = dtDKMH;
                    //remove cái maltc trong list hủy đk đi
                    listHuyDK.Remove(maLTC);
                   

                   
                }      
            }
            else// unchecked
            {
                string maLTC = Convert.ToString(this.gridViewDSMH.GetRowCellValue(e.RowHandle, "MALTC"));
                dtDKMH.AcceptChanges();
                foreach (DataRow row in dtDKMH.Rows)
                {
                    // If this row is offensive then
                    if (Convert.ToString(row["MALTC"]) == maLTC)
                    {
                        row.Delete();
                        // đồng thời thêm ltc vào list hủy đk
                        // có thể chưa có trong bảng đăng ký(csdl)
                        // nên phải cần check có trong bảng đăng ký thì mới đổi huydangky thành 1
                        
                        listHuyDK.Add(maLTC);
                        
                        break;
                    }

                }
                dtDKMH.AcceptChanges();
            }
           
            countFocus = 0;
        }

      

        private void gridViewDSMH_GotFocus(object sender, EventArgs e)
        {
            countFocus = 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (bdsDKMH.Count != 0)
            {
                BindingSource bdsTemp = (BindingSource)this.gridControlDKMH.DataSource;

                // kết thúc việc cập nhật dữ liệu
                this.Validate();
                bdsDSMH.EndEdit();


                // bắt đầu ghi dữ liệu
                SqlConnection conn = new SqlConnection(Program.URL_Connect);
                // bắt đầu transaction
                SqlTransaction tran;

                conn.Open();


                tran = conn.BeginTransaction();

                try
                {


                    for (int i = 0; i < bdsTemp.Count; i++)
                    {

                        SqlCommand cmd = new SqlCommand("SP_INSERT_DKLTC", conn);
                        cmd.Connection = conn;
                        cmd.Transaction = tran;



                        cmd.CommandType = CommandType.StoredProcedure;

                        string maLTC = ((DataRowView)bdsTemp[i])["MALTC"].ToString();
                        cmd.Parameters.Add(new SqlParameter("@MALTC", maLTC));
                        cmd.Parameters.Add(new SqlParameter("@MASV", txtMaSV.Text));

                        cmd.ExecuteNonQuery();


                    }
                    // hủy đăng ký
                    for (int i = 0; i < listHuyDK.Count; i++)
                    {

                        SqlCommand cmd = new SqlCommand("SP_HUY_DKLTC", conn);
                        cmd.Connection = conn;
                        cmd.Transaction = tran;



                        cmd.CommandType = CommandType.StoredProcedure;
                        string maLTC = ((DataRowView)bdsTemp[i])["MALTC"].ToString();
                        cmd.Parameters.Add(new SqlParameter("@MALTC", listHuyDK[i]));
                        cmd.Parameters.Add(new SqlParameter("@MASV", txtMaSV.Text));

                        cmd.ExecuteNonQuery();


                    }


                    tran.Commit();
                }
                catch (SqlException sqlex)
                {
                    try
                    {

                        tran.Rollback();
                        XtraMessageBox.Show("Lỗi ghi toàn bộ ds đăng ký môn học vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);

                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                    conn.Close();
                    return;
                }
                finally
                {
                    conn.Close();
                }
                XtraMessageBox.Show("Thao tác thành công!", "", MessageBoxButtons.OK);
                this.btnBatDau.Enabled = true;
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.groupControlDKMH.Enabled = true;
                this.groupControlMH.Enabled = false;
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            listHuyDK.Clear();
            this.groupControlDKMH.Enabled = true;
            this.groupControlMH.Enabled = false;
            this.btnBatDau.Enabled = true;
            this.btnHuy.Enabled = false;
            this.btnLuu.Enabled = false;
        }
    }
}