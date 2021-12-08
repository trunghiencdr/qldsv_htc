using DevExpress.XtraEditors;
using System;
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
    public partial class frmLopTinChi : Form
    {
        private int _positionLopTC = 0;
        private string _flagOptionLopTC;
        private string _oldMaLopTC = "";
        public frmLopTinChi()
        {
            InitializeComponent();
        }
        private void loadInitializeData()
        {
            dS.EnforceConstraints = false;
            // kết nối trước rồi mới fill.
            this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.LOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            // TODO: This line of code loads data into the 'dS.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
        }
        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.LOPTINCHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmLopTinChi_Load(object sender, EventArgs e)
        {
            
            // TODO : Load Data
            loadInitializeData();
            errorProvider.Clear();

            lOPTINCHIGridControl.Enabled = true;
            this.grbLTC.Enabled = false;

            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Utils.BindingDataToComBo(cmbKhoa, Program.Bds_Dspm.DataSource);

            // TODO : Role Action
            if (Program.MGroup == Program.NhomQuyen[0])// PGV
            {
                cmbKhoa.Visible = true;
                cmbKhoa.Enabled = true;

                barBtnThem.Enabled
                   = barBtnXoa.Enabled
                   = barBtnSua.Enabled
                   = barBtnUndo.Enabled
                   = barBtnGhi.Enabled
                   = barBtnHuy.Enabled
                   = barBtnLamMoi.Enabled = true;
            }
            else if (Program.MGroup == Program.NhomQuyen[1]) // KHOA
            {
                cmbKhoa.Visible = false;

                barBtnThem.Enabled
                   = barBtnXoa.Enabled
                   = barBtnSua.Enabled
                   = barBtnUndo.Enabled
                   = barBtnGhi.Enabled
                   = barBtnHuy.Enabled
                   = barBtnLamMoi.Enabled = false;

                lblTenKhoa.Text = ((DataRowView)Program.Bds_Dspm[Program.MKhoa])["TENKHOA"].ToString();


            }

            barBtnHuy.Enabled = barBtnGhi.Enabled = false;
            txtMaKhoa.Enabled = false;
            txtMaLTC.Enabled = false;
        }

        private void cmbKhoa_Click(object sender, EventArgs e)
        {
            /*// TODO : Chuyển Bộ Phận
            Utils.ComboboxHelper(this.cmbKhoa);
            // kết nối database với dữ liệu ở đoạn code trên và fill dữ liệu, nếu như có lỗi thì
            // thoát.
            if (Program.KetNoi() == 0)
            {
                XtraMessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                loadInitializeData();
                this.txtMaKhoa.EditValue = Utils.GetMaKhoa();
            }*/
        }

        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _flagOptionLopTC = "ADD";//  Add action


            barBtnGhi.Enabled = barBtnHuy.Enabled = true;
            barBtnXoa.Enabled = barBtnThem.Enabled
                = barBtnSua.Enabled
                = barBtnUndo.Enabled
                = barBtnLamMoi.Enabled = false;


            cmbKhoa.Enabled = false;

            lOPTINCHIGridControl.Enabled = false;
            grbLTC.Enabled = true;
            // thao tác chuẩn bị thêm
            LOPTINCHIBindingSource.AddNew();
            this.txtMaKhoa.EditValue = Utils.GetMaKhoa();
        }

        private void barBtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = this.ValidateInfoLOPTINCHI();
            if (check)
            {
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        barBtnThem.Enabled
                        = barBtnXoa.Enabled
                        = barBtnSua.Enabled
                        = barBtnUndo.Enabled
                        = barBtnLamMoi.Enabled = true;

                        lOPTINCHIGridControl.Enabled = true;

                        this.LOPTINCHIBindingSource.EndEdit();
                        this.LOPTINCHIBindingSource.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                        this.LOPTINCHITableAdapter.Update(this.dS.LOPTINCHI);
                    }
                    catch (Exception ex)
                    {
                        LOPTINCHIBindingSource.RemoveCurrent();
                        XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                // lỗi thì return thôi.
                return;
            }

            //chỉ riêng 1 lệnh  dành cho subform
            loadInitializeData();

            cmbKhoa.Visible = true;
            cmbKhoa.Enabled = true;

            if (_positionLopTC > 0)
            {
                LOPTINCHIBindingSource.Position = _positionLopTC;
            }
            barBtnHuy.Enabled = barBtnGhi.Enabled = false;

        }
        // ====================== SUPPORT VALIDATION ====================== //
        private bool ValidateInfoLOPTINCHI()
        {
                errorProvider.Clear();
            if (txtNIENKHOA.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtNIENKHOA, "Niên khóa không được để trống !");
                return false;
            }
            if (txtHOCKI.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtHOCKI, "Học kì không được để trống !");
                return false;
            }
            if (txtNHOM.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtNHOM, "Nhóm không được để trống !");
                return false;
            }
            if (txtSOSV.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtSOSV, "Số sinh viên không được để trống !");
                return false;
            }
            if (cmbMAMH.SelectedValue.ToString().Trim().Equals(""))
            {
                this.errorProvider.SetError(cmbMAMH, "Mã môn học không được để trống !");
                return false;
            }
            if (cmbMAGV.SelectedValue.ToString().Trim().Equals(""))
            {
                this.errorProvider.SetError(cmbMAGV, "Mã giảng viên không được để trống !");
                return false;
            }
            //TODO: Check mã lớp có tồn tại chưa
            string query1 = "DECLARE  @return_value int \n"
                            + "EXEC  @return_value = SP_CHECKLOPTINCHI \n"
                            + "@NienKhoa = N'" + txtNIENKHOA.Text + "',@HocKy = N'" + txtHOCKI.Text + "',@MaMH = N'" + cmbMAMH.SelectedValue + "',@Nhom = N'" + txtNHOM.Text + "' \n"
                            + "SELECT  'Return Value' = @return_value ";

                int resultMa = Utils.CheckDataHelper(query1);
                if (resultMa == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultMa == 1)
                {
                    this.errorProvider.SetError(txtMaLTC, "Lớp tín chỉ đã tồn tại ở Khoa hiên tại (Niên khóa, Học kì, Mã môn học, Nhóm trùng) !");
                    return false;
                }
                if (resultMa == 2)
                {
                    this.errorProvider.SetError(txtMaLTC, "Lớp tín chỉ đã tồn tại ở Khoa khác (Niên khóa, Học kì, Mã môn học, Nhóm trùng)!");
                    return false;
                }


            return true;

        }

        private void barBtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _flagOptionLopTC = "UPDATE";//  Update action
            _oldMaLopTC = this.txtMaLTC.Text.Trim().ToString();

            // TODO: Display To handle
            lOPTINCHIGridControl.Enabled = false;
            grbLTC.Enabled = true;
            barBtnGhi.Enabled = barBtnHuy.Enabled = true;

            barBtnThem.Enabled
                = barBtnXoa.Enabled
                = barBtnSua.Enabled
                = barBtnUndo.Enabled
                = barBtnLamMoi.Enabled = false;
            cmbKhoa.Enabled = false;
        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DANGKYBindingSource.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa lớp tín chỉ này vì Lớp đã có sinh viên đăng kí.", "", MessageBoxButtons.OK);
                return;
            }
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa Lớp tín chỉ này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    LOPTINCHIBindingSource.RemoveCurrent();
                    this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.URL_Connect;
                    this.LOPTINCHITableAdapter.Update(this.dS.LOPTINCHI);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa Lớp tín chỉ.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.LOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
                    return;

                }
            }
            if (LOPTINCHIBindingSource.Count == 0) barBtnXoa.Enabled = false;


            barBtnLamMoi.Enabled = true;
            grbLTC.Enabled = false;

            if (_positionLopTC > 0)
            {
                LOPTINCHIBindingSource.Position = _positionLopTC;
            }
        }

        private void barBtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LOPTINCHIBindingSource.CancelEdit();

            // load lại cả form...
            frmLopTinChi_Load(sender, e);

            if (_positionLopTC > 0)
            {
                LOPTINCHIBindingSource.Position = _positionLopTC;
            }
        }

        private void barBtnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLopTinChi_Load(sender, e);
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.grbLTC.Enabled)
            {

                String notifi = " Dữ liệu LỚP Tín Chỉ chưa lưu vào Database. \n Bạn có chắc muốn thoát !";


                DialogResult dr = XtraMessageBox.Show(notifi, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    this.Close();

                }
            }
            else
            {
                this.Close();
                return;
            }
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
                loadInitializeData();
                this.txtMaKhoa.EditValue = Utils.GetMaKhoa();
            }
        }

        private void barBtnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LOPTINCHIBindingSource.CancelEdit();
            if (barBtnThem.Enabled == false) LOPTINCHIBindingSource.Position = _positionLopTC;
            lOPTINCHIGridControl.Enabled = true;
            grbLTC.Enabled = true;
            barBtnThem.Enabled = barBtnSua.Enabled = barBtnXoa.Enabled = barBtnLamMoi.Enabled = barBtnThoat.Enabled = true;
            barBtnGhi.Enabled = barBtnUndo.Enabled = false;
        }
    }
}
