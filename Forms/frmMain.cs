using DevExpress.XtraEditors;
using QLDSV.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        // TODO: flag dangxuat giúp giải việc sự nhọc nhằng giữa sự kiện form closing với dòng lệnh Program.frmMain.Close();

        Boolean dangxuat = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Program.MGroup == Program.NhomQuyen[3])// PKT
            {
                this.barButtonItem_Lop.Enabled = false;
                this.barButtonItem_MonHoc.Enabled = false;
                this.barButtonItem_SinhVien.Enabled = false;
                this.barButtonItem_Diem.Enabled = false;
                this.barBtnHocPhi.Enabled = true;
                this.barBtnDangKyLop.Enabled = false;
                this.barBtnMoLop.Enabled = false;

                this.barButton_DSDHP.Enabled = true;
                this.barButton_DSSV.Enabled = false;
                this.barButton_DSTHM.Enabled = false;
                this.barButton_BDMH.Enabled = false;
                this.barButton_PD.Enabled = false;
                this.barButton_BDTK.Enabled = false;
                this.barButtonItem5.Enabled = false;
            }
            else if(Program.MGroup == Program.NhomQuyen[2])//sv
            {
                this.barButtonItem_Lop.Enabled = false;
                this.barButtonItem_MonHoc.Enabled = false;
                this.barButtonItem_SinhVien.Enabled = false;
                this.barButtonItem_Diem.Enabled = false;
                this.barBtnHocPhi.Enabled = false;
                this.barBtnDangKyLop.Enabled = true;
                this.barBtnMoLop.Enabled = false;

                /*this.barButton_DSDHP.Enabled = false;
                this.barButton_DSSV.Enabled = false;
                this.barButton_DSTHM.Enabled = false;
                this.barButton_BDMH.Enabled = false;
                this.barButton_PD.Enabled = false;
                this.barButton_BDTK.Enabled = false;*/
                this.ribbonPageBaoCao.Visible = false;
                this.barButton_Register.Enabled = false;

            }else //gv, khoa
            {

                this.barButton_DSDHP.Enabled = false;
                this.barBtnHocPhi.Enabled = false;
                this.barBtnDangKyLop.Enabled = false;
            }

        }
        // TODO : HANDLE CONTROL CHILDREN
        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }




        // ============================ BUTTON EVENT ============================ //
        private void barButtonItem_Lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((Program.MGroup == Program.NhomQuyen[0]) || (Program.MGroup == Program.NhomQuyen[1]))
            {
                ShowMdiChildren(typeof(frmLop1));
            }
        }
        private void barButtonItem_MonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                ShowMdiChildren(typeof(frmMonHoc));
            Console.WriteLine("Vao mon hoc");
            
        }
        private void barButtonItem_SinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!(Program.MGroup == Program.NhomQuyen[2]))
            {
                ShowMdiChildren(typeof(frmSinhVien));
            }
        }
   
        private void barButton_Diem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }
        private void barButtonItem_ChuyenLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!(Program.MGroup == Program.NhomQuyen[2]))
            {
                //ShowMdiChildren(typeof(frmChuyenLop));
            }
        }




        // TODO : Close Event
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!dangxuat)
            {
                if (XtraMessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    this.Dispose();
                    Program.FrmDangNhap.Close();
                }

            }
        }

        private void barButton_Register_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmDangKy));
        }

        private void barButton_Logout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangxuat = true;
            Program.frmMain.Close();
            Program.FrmDangNhap.Visible = true;
        }



        // ==================== REPORT ZONE ==================== //
        private void barButton_DSSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButton_DSTHM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.fmpt_BC_DKLTC));
        }

        private void barButton_BDMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.rptBDMH));
        }

        private void barButton_PD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.PD));
        }

        private void barButton_DSDHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.DSHP));
        }

        private void barButton_BDTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.fmpt_DIEMTONGKET));
        }

        private void barButton_SinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
                if ((Program.MGroup == Program.NhomQuyen[2]))
                {
                    ShowMdiChildren(typeof(frmDiem));
                }

        }

        private void barButtonItem_Diem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (Program.MGroup == Program.NhomQuyen[1] || Program.MGroup == Program.NhomQuyen[0])
            {
                ShowMdiChildren(typeof(frmDiem));
            }
        }

        private void barBtnHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((Program.MGroup == Program.NhomQuyen[3]))//
            {
                ShowMdiChildren(typeof(frmHocPhi));
            }
        }

        private void barBtnDangKyLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((Program.MGroup == Program.NhomQuyen[2])) // sinh vien
            {
                ShowMdiChildren(typeof(frmDangKyLTC));
            }
        }

        private void barBtnMoLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                ShowMdiChildren(typeof(frmLopTinChi));
            
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if(Program.NhomQuyen[3] == Program.MGroup)// pkt
            ShowMdiChildren(typeof(Report.rptDSLTC));
        }
    }
}

