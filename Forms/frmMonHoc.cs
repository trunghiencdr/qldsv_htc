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
    public partial class frmMonHoc : Form
    {
        private int _position = 0;
        private string flagOption; // true = add ; false = update ; default of boolean = false
        private string oldTenMonHoc = "";
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.MONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void formMonHoc_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.MONHOCTableAdapter.Fill(this.dS.MONHOC);

            // TODO : Turn off input
            grbNhapMonHoc.Enabled = false;

            barBtnHuy.Enabled = barBtnGhi.Enabled = false;

            MONHOCGridControl.Enabled = true;
            // TODO : Role Action
            if (Program.MGroup == Program.NhomQuyen[0])// PGV
            {
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
                barBtnThem.Enabled
                    = barBtnXoa.Enabled
                    = barBtnSua.Enabled
                    = barBtnUndo.Enabled
                    = barBtnGhi.Enabled
                    = barBtnHuy.Enabled = false;
            }

        }

        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagOption = "ADD";

            barBtnGhi.Enabled = barBtnHuy.Enabled = true;
            barBtnThem.Enabled
                = barBtnXoa.Enabled
                = barBtnSua.Enabled
                = barBtnUndo.Enabled
                = barBtnLamMoi.Enabled = false;

            grbNhapMonHoc.Enabled = true;
            MONHOCGridControl.Enabled = false;

            // TODO : Thao tác chuẩn bị thêm
            MONHOCBindingSource.AddNew();
        }

        private void barBtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = ValidateInfoMONHOC();
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

                        MONHOCGridControl.Enabled = true;
                        grbNhapMonHoc.Enabled = false;

                        this.MONHOCBindingSource.EndEdit();
                        this.MONHOCBindingSource.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                        this.MONHOCTableAdapter.Update(this.dS.MONHOC);

                    }
                    catch (Exception ex)
                    {
                        MONHOCBindingSource.RemoveCurrent();
                        XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                return;
            }
            grbNhapMonHoc.Enabled = false;
        }
        // ====================== SUPPORT VALIDATION ====================== //
        private bool ValidateInfoMONHOC()
        {
            errorProvider.Clear();

            // TODO : Check khoảng trống ở textField
            if (txtMaMonHoc.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtMaMonHoc, "Mã môn học không được để trống!");
                return false;
            }
            if (txtTenMonHoc.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtTenMonHoc, "Tên môn học không được để trống");
                return false;
            }
            if ((sOTIET_LTSpinEdit.Value + sOTIET_THSpinEdit.Value) % 15 != 0)
            {
                this.errorProvider.SetError(sOTIET_LTSpinEdit, "Tổng số tiết TH và LT phải là bội của 15");
                return false;
            }
            if (flagOption == "ADD")
            {
                //TODO: Check mã môn học có tồn tại chưa
                string query1 = "DECLARE  @return_value int \n"
                            + "EXEC @return_value = SP_CHECKID \n"
                            + "@Code = N'" + txtMaMonHoc.Text + "',@Type = N'MAMONHOC' \n"
                            + "SELECT 'Return Value' = @return_value";

                int resultMa = Utils.CheckDataHelper(query1);
                if (resultMa == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultMa == 1)
                {
                    this.errorProvider.SetError(txtMaMonHoc, "Mã môn học đã tồn tại!");
                    return false;
                }

                // TODO : Check tên môn học có tồn tại chưa
                string query2 = "DECLARE  @return_value int \n"
                            + "EXEC @return_value = SP_CHECKNAME \n"
                            + "@Name = N'" + txtTenMonHoc.Text + "',@Type = N'TENMONHOC' \n"
                            + "SELECT 'Return Value' = @return_value";

                int resultTen = Utils.CheckDataHelper(query2);
                if (resultTen == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultTen == 1)
                {
                    this.errorProvider.SetError(txtTenMonHoc, "Tên môn học đã tồn tại!");
                    return false;
                }
            }

            if (flagOption == "UPDATE")
            {
                if (!this.txtTenMonHoc.Text.Trim().ToString().Equals(oldTenMonHoc))// Nếu tên môn học thay đổi so với ban đầu
                {
                    // TODO : Check tên môn học có tồn tại chưa
                    string query2 = "DECLARE  @return_value int \n"
                                + "EXEC @return_value = SP_CHECKNAME \n"
                                + "@Name = N'" + txtTenMonHoc.Text + "',@Type = N'TENMONHOC' \n"
                                + "SELECT 'Return Value' = @return_value";

                    int resultTen = Utils.CheckDataHelper(query2);
                    if (resultTen == -1)
                    {
                        XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultTen == 1)
                    {
                        this.errorProvider.SetError(txtTenMonHoc, "Tên môn học đã tồn tại!");
                        return false;
                    }
                }
            }

            return true;
        }

        private void barBtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MONHOCBindingSource.CancelEdit();

            formMonHoc_Load(sender, e);
            if (_position > 0)
            {
                MONHOCBindingSource.Position = _position;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (MONHOCBindingSource.Position > 0)
            {
                _position = MONHOCBindingSource.Position;
            }
        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (LOPTINCHIBindingSource.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa môn học này vì đang chứa lớp tín chỉ.", "", MessageBoxButtons.OK);
                return;
            }
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa Lớp này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    MONHOCBindingSource.RemoveCurrent();
                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.URL_Connect;
                    this.MONHOCTableAdapter.Update(this.dS.MONHOC);
                    this.MONHOCBindingSource.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa môn học.\nBạn hãy xem lại\n" + ex.Message, "", MessageBoxButtons.OK);
                }


            }


            if (_position > 0)
            {

                MONHOCBindingSource.Position = _position;
            }
        }

        private void barBtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagOption = "UPDATE";//  Update action
            oldTenMonHoc = this.txtTenMonHoc.Text.Trim().ToString();
            txtMaMonHoc.Enabled = false;

            // TODO: Display To handle
            MONHOCGridControl.Enabled = false;
            grbNhapMonHoc.Enabled = true;

            barBtnGhi.Enabled = barBtnHuy.Enabled = true;

            barBtnThem.Enabled
                = barBtnXoa.Enabled
                = barBtnSua.Enabled
                = barBtnUndo.Enabled
                = barBtnLamMoi.Enabled = false;
        }

        private void barBtnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formMonHoc_Load(sender, e);
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.grbNhapMonHoc.Enabled)
            {
                String notifi = " Dữ liệu Môn Học chưa lưu vào Database. \n Bạn có chắc muốn thoát !";

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
    }
}
