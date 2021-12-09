using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.Forms
{
    public partial class frmHocPhi : Form
    {
        private int _position;
        private String masv;
        private String reHocPhi = "";
        private Boolean _flagUpdateHp = false;
        private Boolean _state = true; //true - them,  false - update 
        private Stack UndoList = new Stack();
        public frmHocPhi()
        {
            InitializeComponent();
        }
        private void firstState()
        {
            barBtnThem.Enabled = false;
            barBtnGhi.Enabled = false;
            barBtnXoa.Enabled = false;
            
            barBtnSua.Enabled = false;
            barBtnGhi.Enabled = false;
            barBtnLamMoi.Enabled = true;
            barBtnHuy.Enabled = false;
            gcHocPhi.Enabled = false;
            grcChiTietHP.Enabled = false;
            grcDongHP.Enabled = false;
            panelThongTinHP.Enabled = false;
        }
        private void sencondsState()
        {
            barBtnThem.Enabled = true;
            int countRow = gvHocPhi.RowCount;
            if (countRow == 0) {
                barBtnSua.Enabled = false;
            }
            else
            {
                barBtnSua.Enabled = true;
            }
            barBtnGhi.Enabled = false;
            barBtnXoa.Enabled = false;
           
            
            barBtnGhi.Enabled = false;
            barBtnLamMoi.Enabled = true;
            barBtnHuy.Enabled = false;
            gcHocPhi.Enabled = true;
            grcChiTietHP.Enabled = true;
            grcDongHP.Enabled = true;
        }
        private void loadChiTietHocPhi()
        {
            int hocky = 0;
            try
            {
                int countRow = gvHocPhi.RowCount;
                Console.WriteLine(countRow);
                if (countRow == 0) return;
                //hocky = Int32.Parse(gvHocPhi.GetRowCellValue(gvHocPhi.GetFocusedDataSourceRowIndex(), "HOCKY").ToString());
                hocky = Int32.Parse(((DataRowView)bdsHOCPHI[bdsHOCPHI.Position])["HOCKY"].ToString());
            }
            catch (Exception ex)
            {
                return;
            }


            String nienkhoa = gvHocPhi.GetRowCellValue(gvHocPhi.GetFocusedDataSourceRowIndex(), "NIENKHOA").ToString();
            var selectedSV = cmbSinhVien.GetSelectedDataRow() as DataRowView;
            String masv = selectedSV.Row["MASV"].ToString();

            nienkhoa = ((DataRowView)bdsHOCPHI[bdsHOCPHI.Position])["NIENKHOA"].ToString();
            
            //MessageBox.Show(hocky +"; " + nienkhoa +" ; "+ masv);
            this.CHITETHPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.CHITETHPTableAdapter.Fill(this.dS.Sp_Chi_Tiet_Dong_HP, masv, hocky, nienkhoa);
        }
        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GET_SINHVIEN' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            this.firstState();
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.SINHVIENTableAdapter.Fill(this.dS.GET_SINHVIEN);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.


        }
        private void loadInitializeData()
        {


            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.SINHVIENTableAdapter.Fill(this.dS.GET_SINHVIEN);

            //this.HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            //this.HOCPHITableAdapter.Fill(this.DS.SP_Thong_tin_dong_HP_sinh_vien , "");

        }

        private bool KiemTraMaTrung(string maSV, string nienKhoa, string hocKy)
        {



            string query1 = " DECLARE @return_value int " +

                            " EXEC    @return_value = [dbo].[CHECK_CONFLICT_HP] " +

                            " @masv = N'" + maSV + "', " +

                            " @nienkhoa = N'" + nienKhoa + "', " +

                            " @hocky =" + hocKy +

                            " SELECT  'Return Value' = @return_value ";
            int resultMa = Utils.CheckDataHelper(query1);
            if (resultMa == -1)
            {
                MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (resultMa == 1)
            {
                // trùng
                return true;
            }

            // ko trùng
            return false;
        }

        private void resetData()
        {
            this.HOCPHITableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.HOCPHITableAdapter.Fill(this.dS.SP_Thong_tin_dong_HP_sinh_vien1, "");
            this.CHITETHPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.CHITETHPTableAdapter.Fill(this.dS.Sp_Chi_Tiet_Dong_HP, "", 1, ""); 
   
            txtHoten.Text = txtLop.Text = "";
            gcHocPhi.Enabled = false;
            grcChiTietHP.Enabled = false;
            grcDongHP.Enabled = false;
        }
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.HOCPHITableAdapter.Fill(this.dS.SP_Thong_tin_dong_HP_sinh_vien, masvToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                //this.sP_Thong_tin_dong_HP_sinh_vienTableAdapter.Fill(this.dS.SP_Thong_tin_dong_HP_sinh_vien, masvToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void loadData()
        {
            var selectedSV = cmbSinhVien.GetSelectedDataRow() as DataRowView;
            if (selectedSV == null)
            {
                barBtnThem.Enabled = false;
                resetData();

                return;
            }




            txtHoten.Text = selectedSV.Row["HO"] + " " + selectedSV.Row["TEN"];
            txtLop.Text = selectedSV.Row["MALOP"].ToString();
            this.masv = selectedSV.Row["MASV"].ToString();
            _position = this.bdsSINHVIEN.Find("MASV", selectedSV.Row["MASV"].ToString());
            this.barBtnThem.Enabled = true;


            loadInitializeData();
            this.bdsSINHVIEN.Position = _position;
            this.HOCPHITableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.HOCPHITableAdapter.Fill(this.dS.SP_Thong_tin_dong_HP_sinh_vien1, cmbSinhVien.Text);
            this.CHITETHPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.CHITETHPTableAdapter.Fill(this.dS.Sp_Chi_Tiet_Dong_HP, "", 1, "");

            sencondsState();
            int vtr = bdsHOCPHI.Position;
            if (vtr >= 0)
            {
                loadChiTietHocPhi();
                barBtnXoa.Enabled = true;
            }
            else
            {
                barBtnXoa.Enabled = false;
            }
        }

        private void reloadData()
        {
            this.HOCPHITableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.HOCPHITableAdapter.Fill(this.dS.SP_Thong_tin_dong_HP_sinh_vien1, this.masv);
            bdsHOCPHI.Position = _position;
        }
        private void cmbSinhVien_EditValueChanged(object sender, EventArgs e)
        {
            var selectedSV = cmbSinhVien.GetSelectedDataRow() as DataRowView;
            if (selectedSV == null)
            {
                barBtnThem.Enabled = false;
                resetData();
                
                return;
            }
            
            


            txtHoten.Text = selectedSV.Row["HO"] + " " + selectedSV.Row["TEN"];
            txtLop.Text = selectedSV.Row["MALOP"].ToString();
            this.masv = selectedSV.Row["MASV"].ToString();
            _position = this.bdsSINHVIEN.Find("MASV", selectedSV.Row["MASV"].ToString());
            this.barBtnThem.Enabled = true;
            

            loadInitializeData();
            this.bdsSINHVIEN.Position = _position;
            this.HOCPHITableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.HOCPHITableAdapter.Fill(this.dS.SP_Thong_tin_dong_HP_sinh_vien1, cmbSinhVien.Text);
            this.CHITETHPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.CHITETHPTableAdapter.Fill(this.dS.Sp_Chi_Tiet_Dong_HP, "", 1, "");

            sencondsState();
            int vtr = bdsHOCPHI.Position;
            if(vtr >= 0)
            {
                loadChiTietHocPhi();
                barBtnXoa.Enabled = true;
            }else
            {
                barBtnXoa.Enabled = false;
            }
            if (txtHoten.Text == "")
            {
                barBtnThem.Enabled = false;
                //grcThongTinHP.Enabled = false;
            }
            else
            {
                //stateProceed2();
            }
            
            if (cmbNienKhoa.Text == "") grcDongHP.Enabled = false;
            else grcDongHP.Enabled = true;
        }

        private void sP_Thong_tin_dong_HP_sinh_vien1GridControl_Click(object sender, EventArgs e)
        {
            loadChiTietHocPhi();
        }

        private void barBtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bdsHOCPHI.EndEdit();
            String nienkhoa = cmbNienKhoa.Text;
            String hocky = spinEditHocKy.Text;
            String hocphi = spinEditHocPhi.Value.ToString();
            if (_state)
            {
                if (nienkhoa == "" || hocky == "" || hocphi == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                    return;
                }
                if (KiemTraMaTrung(this.masv, nienkhoa, hocky))
                {
                    MessageBox.Show("Thông tin học phí đã có sẵn");
                    return;
                }
                else //insert
                {
                    String strLenh = "insert into HOCPHI (MASV,NIENKHOA,HOCKY,HOCPHI) values ('" + this.masv + "','" + nienkhoa + "'," + hocky + "," + hocphi + ") ";
                    
                    Console.WriteLine(strLenh);
                    int temp = Program.ExecSqlNonQuery(strLenh);
                    if (temp == 0)
                    {
                        //thanh cong
                        _flagUpdateHp = false;
                        bdsHOCPHI.Position = _position;
                        this.loadChiTietHocPhi();
                        MessageBox.Show("Thêm học phí thành công");
                        UndoList.Push("DELETE#delete from HOCPHI where MASV = '" + this.masv + "' and NIENKHOA = '" + nienkhoa + "' and HOCKY = " + hocky);
                    }
                    else
                    {
                        //that bai
                        MessageBox.Show("Lỗi thêm học phí");
                        return;

                    }

                }
                barBtnLamMoi.Enabled = true;
                barBtnSua.Enabled = true;
            }

            else
            {
                String soTienDaDong = ((DataRowView)bdsHOCPHI[_position])["SOTIENDADONG"].ToString();
                try
                {
                    int hp = Int32.Parse(hocphi);
                    int tdd = Int32.Parse(soTienDaDong);
                    if(hp < tdd)
                    {
                        MessageBox.Show("Học phí không được nhỏ hơn số tiền đóng");
                        return;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chuyển đổi học phí");
                    return;
                }

                if (hocphi != "" )
                {
                    String strLenh = "update HOCPHI set HOCPHI = " + hocphi + " where MASV = '" + masv + "' and NIENKHOA = '" + nienkhoa + "' and HOCKY = " + hocky;
                    
                    Console.WriteLine(strLenh);
                    int temp = Program.ExecSqlNonQuery(strLenh);
                    if (temp == 0)
                    {
                        //thanh cong
                        _flagUpdateHp = false;
                        MessageBox.Show("Cập nhật thành công");
                        UndoList.Push("UPDATE#update HOCPHI set HOCPHI = " + this.reHocPhi + " where MASV = '" + masv + "' and NIENKHOA = '" + nienkhoa + "' and HOCKY = " + hocky +"#"+ this.reHocPhi);
                    }
                    else
                    {
                        //that bai
                        MessageBox.Show("Cập nhật không thành công");
              

                    }
                    cmbNienKhoa.Enabled = true;
                    spinEditHocKy.Enabled = true;
                }
            }
            



            grcThongTinSV.Enabled = true;
            sencondsState();
            panelThongTinHP.Enabled = false;
            barBtnXoa.Enabled = true;
            bdsHOCPHI.Position = _position;
            this.bdsHOCPHI.ResetCurrentItem();
            this.HOCPHITableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.HOCPHITableAdapter.Fill(this.dS.SP_Thong_tin_dong_HP_sinh_vien1, this.masv);
            bdsHOCPHI.Position = _position;
        }

        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bdsHOCPHI.AddNew();
            _state = true;
            _position = bdsHOCPHI.Position;
            panelThongTinHP.Enabled = true;
            barBtnThem.Enabled = false;
            barBtnSua.Enabled = false;
            barBtnXoa.Enabled = false;
            barBtnLamMoi.Enabled = false;

            barBtnGhi.Enabled = true;
            barBtnHuy.Enabled = true;

            gcHocPhi.Enabled = false;
            grcChiTietHP.Enabled = false;
            grcDongHP.Enabled = false;
            grcThongTinSV.Enabled = false;
            _flagUpdateHp = true;
        }

        private void barBtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_state)
            {
                this.bdsHOCPHI.CancelEdit();
                this.bdsHOCPHI.ResetCurrentItem();
            }
            else
            {
                spinEditHocPhi.Text = reHocPhi;
            }
            this.bdsHOCPHI.Position = _position;
            barBtnLamMoi.Enabled = true;
            grcThongTinSV.Enabled = true;
            sencondsState();
            panelThongTinHP.Enabled = false;
            _flagUpdateHp = false;
        }

        private void hOCKYLabel_Click(object sender, EventArgs e)
        {

        }

        private void hOCKYSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnNopHP_Click(object sender, EventArgs e)
        {
            String ngayNopHP = dateEditNgayDongHP.Text;
            float soTien = (float)spinEditTienDong.Value;
            var focusRowViews = gvHocPhi.GetFocusedDataRow();
            float soTienCanDong = 0;
            try
            {
                soTienCanDong = Convert.ToInt32(focusRowViews["SOTIENCANDONG"]);
            }
            catch (Exception ex)
            {
                soTienCanDong = Convert.ToInt32(spinEditHocPhi.Text);
            }
            
            if (ngayNopHP == "" || soTien <= 0)
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
                return;
            }
            else
            {
                if(soTien > soTienCanDong)
                {
                    //
                    MessageBox.Show("Số tiền đóng phải bé hơn số tiền cần đóng");
                    return;
                }else
                {
                    String nienkhoa = cmbNienKhoa.Text;
                    String hocky = spinEditHocKy.Text;
                    int kockyInt = 0;
                    try
                    {
                        kockyInt = Int32.Parse(gvHocPhi.GetRowCellValue(gvHocPhi.GetFocusedDataSourceRowIndex(), "HOCKY").ToString());
                    }
                    catch (Exception ex)
                    {
                        
                    }

                    //insert
                    String strLenh = "insert into CT_DONGHOCPHI (MASV,NIENKHOA,HOCKY,NGAYDONG, SOTIENDONG) values ('" + this.masv + "','" + nienkhoa + "'," + hocky + ",'" + ngayNopHP + "'," + soTien + ")";
                    Console.WriteLine(strLenh);
                    int temp = Program.ExecSqlNonQuery(strLenh);
                    if (temp == 0)
                    {
                        //thanh cong
                    }
                    else
                    {
                        //that bai

                        MessageBox.Show("Đóng học phí không thành công");

                    }
                    this.CHITETHPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
                    this.CHITETHPTableAdapter.Fill(this.dS.Sp_Chi_Tiet_Dong_HP, this.masv, kockyInt, nienkhoa);
                    this.HOCPHITableAdapter.Connection.ConnectionString = Program.URL_Connect;
                    this.HOCPHITableAdapter.Fill(this.dS.SP_Thong_tin_dong_HP_sinh_vien1, this.masv);
                }
            }
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_flagUpdateHp)
            {
                String notifiSV = "Dữ liệu HOC PHI chưa lưu vào Database. \n Bạn có chắc muốn thoát ! ";
                DialogResult dr = MessageBox.Show(notifiSV, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    this.Close();

                }
            }
            this.Close();
        }

        private void barBtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            _position = bdsHOCPHI.Position;
            try
            {
                reHocPhi = ((DataRowView)bdsHOCPHI[_position])["HOCPHI"].ToString();
            }
            catch (Exception ex)
            {

            }
            
            if (_position < 0) return;
            _state = false;
            barBtnThem.Enabled = false;
            barBtnXoa.Enabled = false;
            barBtnSua.Enabled = false;
            barBtnLamMoi.Enabled = false;
            barBtnGhi.Enabled = true;
            barBtnHuy.Enabled = true;
            panelThongTinHP.Enabled = true;
            cmbNienKhoa.Enabled = false;
            spinEditHocKy.Enabled = false;
            grcDongHP.Enabled = false;
            
        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            String nienkhoa = cmbNienKhoa.Text;
            String hocky = spinEditHocKy.Text;
            String hocphi = spinEditHocPhi.Value.ToString();
            String strLenh = "delete from HOCPHI where MASV = '" + masv + "' and NIENKHOA = '" + nienkhoa + "' and HOCKY = " + hocky;

            Console.WriteLine(strLenh);
            if (bdsCHITIETHP.Count > 0)
            {
                MessageBox.Show("Học phí đã có thông tin chi tiết không thể xóa");
                return;
            }


            String notifiSV = "Thông tin về học phí sẽ được xóa. \n Bạn có chắc muốn xóa ? ";
            DialogResult dr = MessageBox.Show(notifiSV, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                return;
            }
            else if (dr == DialogResult.Yes)
            {
                int temp = Program.ExecSqlNonQuery(strLenh);
                if (temp == 0)
                {
                    //thanh cong
                    _flagUpdateHp = false;
                    MessageBox.Show("Xóa thành công");
                    reloadData();
                    bdsHOCPHI.Position = _position--;
                    UndoList.Push("INSERT#insert into HOCPHI (MASV,NIENKHOA,HOCKY,HOCPHI) values ('" + this.masv + "','" + nienkhoa + "'," + hocky + "," + hocphi + ") ");
                }
                else
                {
                    //that bai
                    MessageBox.Show("Xóa không thành công");


                }

            }


            

        }

        private void barBtnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
            loadChiTietHocPhi();
        }

        private void btnSuaCTHP_Click(object sender, EventArgs e)
        {

            String ngaydong = ((DataRowView)bdsCHITIETHP[bdsCHITIETHP.Position])["NGAYDONG"].ToString();
            int sotiendong = Int32.Parse(((DataRowView)bdsCHITIETHP[bdsCHITIETHP.Position])["SOTIENDONG"].ToString());

            dateEditNgayDongHP.Text = ngaydong;
            spinEditHocPhi.EditValue = sotiendong;

            gcChiTietHp.Enabled = false;
            gcHocPhi.Enabled = false;
        }

        private void gvHocPhi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            loadChiTietHocPhi();
        }

        private void barBtnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int Length = UndoList.Count;
            if (Length == 0) return;

            String inStack = (string)UndoList.Pop();
            string[] subs = inStack.Split('#');
            
            if (subs[0] == "DELETE")
            {
                if (bdsCHITIETHP.Count > 0)
                {
                    MessageBox.Show("Học phí đã có thông tin chi tiết không thể phục hồi");
                    return;
                }
                
                
            }
            if (subs[0] == "UPDATE")
            {
                String soTienDaDong = ((DataRowView)bdsHOCPHI[_position])["SOTIENDADONG"].ToString();
                try
                {
                    int hp = Int32.Parse(subs[2]);
                    int tdd = Int32.Parse(soTienDaDong);
                    if (hp < tdd)
                    {
                        MessageBox.Show("Học phí phục hồi nhỏ hơn số tiền đóng không thể thực hiện");
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chuyển đổi học phí");
                    return;
                }
            }
            if (subs[0] == "INSERT")
            {

            }
            Console.WriteLine(inStack);
            int temp = Program.ExecSqlNonQuery(subs[1]);
            if(temp != 0)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình phục hồi");
            }
            reloadData();
        }
    }
}
