using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.Data.SqlClient;
using DevExpress.Utils;

namespace QLDSV.Forms
{
    public partial class frmDiem : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dtDSMH; //maltc, mh, tên mh, mã gv, nhóm
        String nienKhoa = "";
        int hocKy = -1;
        String maMH = "";
        String maGV = "";
        int nhom = -1;

        string columnPre = "";
        DataTable dtNhapDiem = new DataTable();
        public frmDiem()
        {
            InitializeComponent();
        }

        private void dANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhapDiem.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        public void initData()
        {
            cmbNienKhoa.DataSource = null;
            dtDSMH = new DataTable();
            // 1. load ds nien khoa vao cbb
            Utils.BindingSqlToComboBox(cmbNienKhoa, "exec sp_ds_nienkhoa", "nienkhoa", null);

            //2. load ds hoc ki vao cbb
            cmbHocKi.Items.Clear();
            cmbHocKi.Items.AddRange(new object[] { 1,2,3,4});
            cmbHocKi.SelectedIndex = 0;


        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            //trạng thái phím chức năng

            this.btnBatDau.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;


            // LOAD các combobox vào form
            // 1. load cbb khoa
            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Utils.BindingDataToComBo(cmbKhoa, Program.Bds_Dspm);
            if(Program.MGroup==Program.NhomQuyen[0])//Phòng gv
            {
                cmbKhoa.Enabled = true;
            }
            else if(Program.MGroup==Program.NhomQuyen[1])//khoa
            {
                cmbKhoa.Enabled = false;
                cmbKhoa.SelectedIndex = Program.MKhoa;

            }

            //2. load cbb niên khóa
            // ket noi csdl
            initData();




        }


       

     

        private void cmbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            nienKhoa = cmbNienKhoa.Text;
            if (String.IsNullOrEmpty(nienKhoa))
            {
                return;
            }
            else
            {
                hocKy = int.Parse(cmbHocKi.Text);
               
                // lay dsmh để dùng chung gồm malt, mh, tên mh, mã gv, nhóm
                String sql = "exec sp_dsmh_nhapdiem '" + nienKhoa + "', " + hocKy;
                SqlDataReader rd = Program.ExecSqlDataReader(sql);
                if (!rd.HasRows)
                {
                    cmbMonHoc.DataSource = null;
                    maMH = "";
                    return;
                }
                dtDSMH.Load(rd);

                // group by những môn nào có cùng mã mh va tên mh
                DataTable dtMH = null;
               var rows = dtDSMH.AsEnumerable()
                    .GroupBy(r => new { Col1 = r["mamh"], Col2 = r["tenmh"] })
                    .Select(g=>g.OrderBy(r => r["mamh"]).First());
                if (rows.Any())
                    dtMH = rows.CopyToDataTable();
                else return;
                Utils.BindingDataToComboBox(cmbMonHoc, dtMH, "tenmh", "mamh");
                rd.Close();

            }
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbMonHoc.DataSource == null)
            {
                cmbGiangVien.DataSource = null;
                return;
            }
            else
            {
                maMH = cmbMonHoc.SelectedValue.ToString();
                // lọc từ dtDSMH ra những giáo viên nào dạy môn đã chọn, vì 1 môn học có nhiều gv nên ta group mh lại để lấy gv
                DataTable dtGV = null;
               /* MessageBox.Show(dtDSMH.Rows.Count.ToString() + maMH);*/
                var rows = dtDSMH.AsEnumerable()
                        .Where(row => row.Field<String>("mamh") == maMH)
                         .GroupBy(r => new { Col1 = r["mamh"], Col2 = r["magv"] })
                         .Select(g => g.OrderBy(r => r["magv"]).First());
                if (rows.Any())
                    dtGV = rows.CopyToDataTable();
                else
                {
                    /*MessageBox.Show("khong co giang vien");*/
                    cmbGiangVien.DataSource = null;
                    maGV = "";
                    return;
                }
                
                Utils.BindingDataToComboBox(cmbGiangVien, dtGV, "magv", null);
            }
        }

        private void cmbGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGiangVien.DataSource == null) {
                cmbNhom.DataSource = null;
                return; }
            else
            {
                maGV = cmbGiangVien.Text;
                // lọc từ dtDSMH ra những nhóm nào mà giáo viên đá chọn, dạy môn đã chọn, vì 1 môn học 1 gv có nhiều nhóm nên ta group mh, gv,nhóm lại để lấy nhiều nhóm
                DataTable dtNhom = null;
               /* MessageBox.Show(maMH + maGV);*/
                var rows = dtDSMH.AsEnumerable()
                      .Where(row => row.Field<String>("mamh") == maMH && row.Field<String>("magv") == maGV)
                         .GroupBy(r => new { Col1 = r["mamh"], Col2 = r["magv"], Col3 = r["nhom"] })
                         .Select(g => g.OrderBy(r => r["nhom"]).First());
                if (rows.Any())
                    dtNhom = rows.CopyToDataTable();
                else { 
                    cmbNhom.DataSource = null;
                    nhom = -1;
                    return; }
               
                Utils.BindingDataToComboBox(cmbNhom, dtNhom, "nhom", null);
            }
        }

        private void cmbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNhom.DataSource == null) return;
            nhom = int.Parse(cmbNhom.Text.ToString());
        }

        private void dANGKYGridControl_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            this.groupControlChonThongTin.Enabled = false;
            this.groupControlNhapDiem.Enabled = true;
            errorProvider1.Clear();

            nienKhoa = cmbNienKhoa.Text;
            
            if(String.IsNullOrEmpty(nienKhoa) || hocKy ==-1 || String.IsNullOrEmpty(maMH) || String.IsNullOrEmpty(maGV) || nhom == -1)
            {
                this.btnBatDau.Enabled = true;
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = true;
                errorProvider1.SetError(this.btnBatDau, "Các trường thông tin không được để trống!");
                return;
            }

            this.btnBatDau.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // load ds vao bang

            String cmd = "exec sp_bangdiem '"
                        + nienKhoa + "',"
                        + hocKy + ", '"
                        + maMH + "','"
                        + maGV + "',"
                        + nhom;

             dtNhapDiem = Program.ExecSqlDataTable(cmd);
            this.bdsNhapDiem.DataSource = dtNhapDiem;

            if (this.bdsNhapDiem.Count > 0)
            {
                this.gridControlNhapDiem.DataSource = this.bdsNhapDiem;
            }
            else
            {
                XtraMessageBox.Show("Số lượng sinh viên đăng ký không đủ!", "", MessageBoxButtons.OK);
                this.groupControlChonThongTin.Enabled = true;
                this.groupControlNhapDiem.Enabled = false;
                this.btnBatDau.Enabled = true;
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                return;
            }
        }

        private bool checkEmptyRow()
        {
            // get binding source từ gridcontrol
            BindingSource bdsTemp = (BindingSource)this.gridControlNhapDiem.DataSource;
            int slg = bdsTemp.Count;
            for (int i = 0; i < slg; i++)
            { 
                if (((DataRowView)bdsTemp[i])["DIEM_CC"].ToString() == "" || ((DataRowView)bdsTemp[i])["DIEM_GK"].ToString() == ""
                    || ((DataRowView)bdsTemp[i])["DIEM_CK"].ToString() == "")
                {
                    bdsTemp.Position = i;
                    return true;
                }

            }

            return false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (String.IsNullOrEmpty(nienKhoa) || hocKy == -1 || String.IsNullOrEmpty(maMH) || String.IsNullOrEmpty(maGV) || nhom == -1)
            {
                this.btnBatDau.Enabled = true;
                this.btnLuu.Enabled = false;

                errorProvider1.SetError(this.btnBatDau, "Các trường thông tin nhập điểm không được để trống !");
                return;
            }
           /* if (checkEmptyRow())
            {
                this.btnBatDau.Enabled = false;
                this.btnLuu.Enabled = true;
                errorProvider1.SetError(this.btnLuu, "Bạn chưa nhập hết bản điểm cho sinh viên !");
                return;
            }*/
            if(true)
            {
                //get binding source từ gridcontrol
                BindingSource bdsTemp = (BindingSource)this.gridControlNhapDiem.DataSource;

                // kết thúc việc cập nhật dữ liệu
                this.Validate();
                bdsTemp.EndEdit();


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

                        SqlCommand cmd = new SqlCommand("SP_INSERT_DIEM", conn);
                        cmd.Connection = conn;
                        cmd.Transaction = tran;



                        cmd.CommandType = CommandType.StoredProcedure;
                        string masv = ((DataRowView)bdsTemp[i])["MASV"].ToString();
                        string maLTC = ((DataRowView)bdsTemp[i])["MALTC"].ToString();
                        cmd.Parameters.Add(new SqlParameter("@MALTC", maLTC));
                        cmd.Parameters.Add(new SqlParameter("@MASV", masv));
                        int diemCC = 0;
                        double diemGK = 0;
                        double diemCK = 0;
                        try
                        {
                            diemCC = int.Parse(((DataRowView)bdsTemp[i])["DIEM_CC"].ToString());
                            cmd.Parameters.Add(new SqlParameter("@DIEM_CC", diemCC));

                        }
                        catch(Exception ex)
                        {
                            cmd.Parameters.Add(new SqlParameter("@DIEM_CC", DBNull.Value));
                        }

                        try
                        {
                            diemGK = double.Parse(((DataRowView)bdsTemp[i])["DIEM_GK"].ToString());
                            cmd.Parameters.Add(new SqlParameter("@DIEM_GK", diemGK));

                        }
                        catch (Exception ex)
                        {
                            cmd.Parameters.Add(new SqlParameter("@DIEM_GK", DBNull.Value));
                        }


                        try
                        {
                            diemCK = double.Parse(((DataRowView)bdsTemp[i])["DIEM_CK"].ToString());
                            cmd.Parameters.Add(new SqlParameter("@DIEM_CK", diemCK));

                        }
                        catch (Exception ex)
                        {
                            cmd.Parameters.Add(new SqlParameter("@DIEM_CK", DBNull.Value));
                        }
                       
                      

                        cmd.ExecuteNonQuery();


                    }


                    tran.Commit();
                }
                catch (SqlException sqlex)
                {
                    try
                    {

                        tran.Rollback();
                        XtraMessageBox.Show("Lỗi ghi toàn bộ điểm vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);

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
                this.groupControlNhapDiem.Enabled = false;
                this.groupControlChonThongTin.Enabled = true;
                return;
            }
        }

        private void groupControl3_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {

           

            GridView view = sender as GridView;
            int row = view.FocusedRowHandle;
            if(view.FocusedColumn.FieldName == "DIEM_CC")
            {
                int diem = 0;
                if (string.IsNullOrEmpty(e.Value as string))
                    return;
                try
                {
                    diem = int.Parse(e.Value.ToString());
                }
                catch (Exception ex)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm phải là một số nguyên";
                }
                if (diem < 0 || diem > 10)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm phải lớn hơn không và nhỏ hơn 10";
                }
            }
            else if (view.FocusedColumn.FieldName == "DIEM_GK"  || view.FocusedColumn.FieldName == "DIEM_CK")
            {
                double diem = 0;
                if (string.IsNullOrEmpty(e.Value as string))
                    return;
                try
                {
                    diem = double.Parse(e.Value.ToString());
                }
                catch(Exception ex)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm phải là một số";
                }
                if (diem < 0 || diem > 10)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm phải lớn hơn không và nhỏ hơn 10";
                }
                


            }


            

            


        }


        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

          
            if (e.Value == null || e.Value.ToString() == "") return;

            double diemCC = 0;
            double diemGK = 0;
            double diemCK = 0;

            if (gridView1.GetRowCellValue(e.RowHandle, "DIEM_CC") is DBNull)
            {
                diemCC = 0;
            }
            else
            {

                diemCC = Convert.ToDouble(gridView1.GetRowCellValue(e.RowHandle, "DIEM_CC"));

            }

            if (gridView1.GetRowCellValue(e.RowHandle, "DIEM_GK") is DBNull)
            {
                diemGK = 0;
            }
            else
            {
                diemGK = Math.Round(Convert.ToDouble(gridView1.GetRowCellValue(e.RowHandle, "DIEM_GK")), 1, MidpointRounding.AwayFromZero);
               
            }

            if (gridView1.GetRowCellValue(e.RowHandle, "DIEM_CK") is DBNull)
            {
                diemCK = 0;
            }
            else
            {
                diemCK = Math.Round(Convert.ToDouble(gridView1.GetRowCellValue(e.RowHandle, "DIEM_CK")), 1, MidpointRounding.AwayFromZero);
             
            }

            double diemTong = diemCC * 0.1 + diemGK * 0.3 + diemCK * 0.6;
            diemTong = Math.Round(diemTong, 1, MidpointRounding.AwayFromZero);

            // tránh bị đệ quy khi thay đổi giá trị gridView
            if (!columnPre.Equals(e.Column.FieldName))
            {
                
                switch (e.Column.FieldName)
                {
                    case "DIEM_GK":
                        columnPre = e.Column.FieldName;
                        this.gridView1.SetRowCellValue(e.RowHandle, "DIEM_GK", diemGK);
                        break;
                    case "DIEM_CK":
                        columnPre = e.Column.FieldName;
                        this.gridView1.SetRowCellValue(e.RowHandle, "DIEM_CK", diemCK);
                        break;
                }
                
            }
            Console.WriteLine("Vao changed:"); 

            if (e.Column.FieldName.ToString() == "DIEM_CC" || e.Column.FieldName.ToString() == "DIEM_GK" || e.Column.FieldName.ToString() == "DIEM_CK")
                this.gridView1.SetRowCellValue(e.RowHandle, "DIEM_TONG", diemTong);
          



        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            this.btnBatDau.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.groupControlChonThongTin.Enabled = true;
            this.groupControlNhapDiem.Enabled = false;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
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
                initData();
            }
        }

        private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

       
    
}