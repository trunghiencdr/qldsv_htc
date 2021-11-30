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
    public partial class frmSinhVien : Form
    {
        private int _positon;
        private String malop;
        private Boolean _flagUpdateSV = false;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void loadInitializeData()
        {
            // kết nối trước rồi mới fill.
            this.LOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
           

            this.LOPTableAdapter.Fill(this.dS.LOP);
            this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            

        }
        //phan quyen
        private void assignRoles()
        {
            barBtnThem.Enabled = true;
            barBtnUndo.Enabled
                           = barBtnGhi.Enabled
                           = barBtnHuy.Enabled
                           =  false;
            panelControllThongTinSV.Enabled = false;
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
        private void SinhVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Utils.BindingDataToComBo(cmbKhoa, Program.Bds_Dspm.DataSource);
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.LOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Fill(this.dS.LOP);
            assignRoles();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
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
                loadInitializeData();
                //this.txtMaKhoa.EditValue = Utils.GetMaKhoa();
            }
        }

        private void mASVTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void hOTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pHAICheckEdit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dIACHITextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _positon = bdsSINHVIEN.Position;
            panelControllThongTinSV.Enabled = true;
            gcLop.Enabled = gcSinhVien.Enabled = false;
            this.malop = txtEditMalop.Text;
            bdsSINHVIEN.AddNew();
            mALOPTextEdit.Text = gvLop.GetRowCellValue(bdsLOP.Position, "MALOP").ToString().Trim();
            barBtnGhi.Enabled = barBtnHuy.Enabled = true;
            barBtnXoa.Enabled = barBtnSua.Enabled = false;
            _flagUpdateSV = true;
            pHAICheckEdit.Checked =  dANGHIHOCCheckEdit.Checked =  barBtnLamMoi.Enabled = false;
        }

        private void barBtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcLop.Enabled = gcSinhVien.Enabled = true;
            panelControllThongTinSV.Enabled = false;
            bdsSINHVIEN.CancelEdit();
            this.errorProvider.Clear();
            bdsSINHVIEN.Position = _positon;
            barBtnGhi.Enabled = false;
            barBtnHuy.Enabled = false;
            _flagUpdateSV = false;
            barBtnLamMoi.Enabled = true;
            barBtnXoa.Enabled = barBtnSua.Enabled = true;
        }
        
        private Boolean ValidateInfoSINHVIEN()
        {
            String masv = mASVTextEdit.Text;
            String ho = hOTextEdit.Text;
            String ten = tENTextEdit.Text;
            Boolean check = true;
            this.errorProvider.Clear();
            if (masv == "" )
            {
                this.errorProvider.SetError(mASVTextEdit, "Mã lớp không được để trống !");
                check = false;
            }
            if (ho == "")
            {
                this.errorProvider.SetError(hOTextEdit, "Mã lớp không được để trống !");
                check = false;
            }
            if (ten == "")
            {
                this.errorProvider.SetError(tENTextEdit, "Mã lớp không được để trống !");
                check = false;
            }
            return check; 
        }
        private void barBtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateInfoSINHVIEN())
            {
                try
                {
                    barBtnThem.Enabled
                    = barBtnXoa.Enabled
                    = barBtnSua.Enabled
                    = barBtnUndo.Enabled
                    = barBtnLamMoi.Enabled = true;

                    gcSinhVien.Enabled = true;
                    gcLop.Enabled = true;
                    barBtnThem.Enabled = true;
                    panelControllThongTinSV.Enabled = false;

                    this.bdsSINHVIEN.EndEdit();
                    this.bdsSINHVIEN.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                    this.SINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                    
                    MessageBox.Show("Cập nhật dữ liệu thành công !");
                }
                catch (Exception ex)
                {
                    bdsLOP.RemoveCurrent();
                    gcLop.Enabled = true;
                    gcSinhVien.Enabled = true;
                    barBtnThem.Enabled = true;
                  
                    MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                barBtnXoa.Enabled

                               = barBtnUndo.Enabled
                               = barBtnGhi.Enabled
                               = barBtnHuy.Enabled = false;
                barBtnLamMoi.Enabled = true;
                barBtnSua.Enabled = true;
                _flagUpdateSV = false;
            }
        }

        private void barBtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int vitri = bdsSINHVIEN.Position;
            if(vitri < 0)
            {
                MessageBox.Show("Hãy chọn sinh viên cần sửa");
                return;
            }

            panelControllThongTinSV.Enabled = true;
            gcLop.Enabled = false;
            gcSinhVien.Enabled = false;
            barBtnGhi.Enabled = true;
            barBtnHuy.Enabled = true;
            barBtnThem.Enabled = false;
            _flagUpdateSV = true;
            barBtnLamMoi.Enabled = false;
            barBtnSua.Enabled = false;

        }

        private void barBtnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadInitializeData();
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_flagUpdateSV)
            {
                String notifiSV = "Dữ liệu SINH VIÊN chưa lưu vào Database. \n Bạn có chắc muốn thoát ! ";
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
    }
}
