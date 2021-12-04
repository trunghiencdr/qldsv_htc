
namespace QLDSV.Forms
{
    partial class frmDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiem));
            this.bdsNhapDiem = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.DANGKYTableAdapter = new QLDSV.DSTableAdapters.DANGKYTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.barBtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSua = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHocKi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNhom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupControlChonThongTin = new DevExpress.XtraEditors.GroupControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.groupControlNhapDiem = new DevExpress.XtraEditors.GroupControl();
            this.gridControlNhapDiem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbGiangVien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhapDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlChonThongTin)).BeginInit();
            this.groupControlChonThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlNhapDiem)).BeginInit();
            this.groupControlNhapDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhapDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // bdsNhapDiem
            // 
            this.bdsNhapDiem.DataMember = "DANGKY";
            this.bdsNhapDiem.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DANGKYTableAdapter
            // 
            this.DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = this.DANGKYTableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // barBtnThem
            // 
            this.barBtnThem.Caption = "Thêm";
            this.barBtnThem.Id = 0;
            this.barBtnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnThem.ImageOptions.SvgImage")));
            this.barBtnThem.Name = "barBtnThem";
            // 
            // barBtnXoa
            // 
            this.barBtnXoa.Caption = "Xóa";
            this.barBtnXoa.Id = 1;
            this.barBtnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnXoa.ImageOptions.SvgImage")));
            this.barBtnXoa.Name = "barBtnXoa";
            // 
            // barBtnSua
            // 
            this.barBtnSua.Caption = "Sửa";
            this.barBtnSua.Id = 2;
            this.barBtnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnSua.ImageOptions.SvgImage")));
            this.barBtnSua.Name = "barBtnSua";
            // 
            // barBtnUndo
            // 
            this.barBtnUndo.Caption = "Phục Hồi";
            this.barBtnUndo.Id = 3;
            this.barBtnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnUndo.ImageOptions.SvgImage")));
            this.barBtnUndo.Name = "barBtnUndo";
            // 
            // barBtnGhi
            // 
            this.barBtnGhi.Caption = "Ghi";
            this.barBtnGhi.Id = 4;
            this.barBtnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnGhi.ImageOptions.SvgImage")));
            this.barBtnGhi.Name = "barBtnGhi";
            // 
            // barBtnHuy
            // 
            this.barBtnHuy.Caption = "Hủy";
            this.barBtnHuy.Id = 5;
            this.barBtnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnHuy.ImageOptions.SvgImage")));
            this.barBtnHuy.Name = "barBtnHuy";
            // 
            // barBtnLamMoi
            // 
            this.barBtnLamMoi.Caption = "Làm Mới";
            this.barBtnLamMoi.Id = 6;
            this.barBtnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnLamMoi.ImageOptions.SvgImage")));
            this.barBtnLamMoi.Name = "barBtnLamMoi";
            // 
            // barBtnThoat
            // 
            this.barBtnThoat.Caption = "Thoát";
            this.barBtnThoat.Id = 7;
            this.barBtnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnThoat.ImageOptions.SvgImage")));
            this.barBtnThoat.Name = "barBtnThoat";
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1247, 0);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 726);
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(529, 35);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(292, 24);
            this.cmbKhoa.TabIndex = 0;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "KHOA:";
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(133, 87);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(292, 24);
            this.cmbNienKhoa.TabIndex = 3;
            this.cmbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbNienKhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "NIÊN KHÓA:";
            // 
            // cmbHocKi
            // 
            this.cmbHocKi.FormattingEnabled = true;
            this.cmbHocKi.Location = new System.Drawing.Point(133, 132);
            this.cmbHocKi.Name = "cmbHocKi";
            this.cmbHocKi.Size = new System.Drawing.Size(292, 24);
            this.cmbHocKi.TabIndex = 5;
            this.cmbHocKi.SelectedIndexChanged += new System.EventHandler(this.cmbHocKi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "HỌC KỲ:";
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(133, 180);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(292, 24);
            this.cmbMonHoc.TabIndex = 7;
            this.cmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbMonHoc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "MÔN HỌC:";
            // 
            // cmbNhom
            // 
            this.cmbNhom.FormattingEnabled = true;
            this.cmbNhom.Location = new System.Drawing.Point(879, 136);
            this.cmbNhom.Name = "cmbNhom";
            this.cmbNhom.Size = new System.Drawing.Size(292, 24);
            this.cmbNhom.TabIndex = 9;
            this.cmbNhom.SelectedIndexChanged += new System.EventHandler(this.cmbNhom_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(791, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "NHÓM:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(754, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "GIẢNG VIÊN:";
            // 
            // groupControlChonThongTin
            // 
            this.groupControlChonThongTin.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlChonThongTin.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControlChonThongTin.Controls.Add(this.label6);
            this.groupControlChonThongTin.Controls.Add(this.cmbGiangVien);
            this.groupControlChonThongTin.Controls.Add(this.label5);
            this.groupControlChonThongTin.Controls.Add(this.cmbNhom);
            this.groupControlChonThongTin.Controls.Add(this.label4);
            this.groupControlChonThongTin.Controls.Add(this.cmbMonHoc);
            this.groupControlChonThongTin.Controls.Add(this.label3);
            this.groupControlChonThongTin.Controls.Add(this.cmbHocKi);
            this.groupControlChonThongTin.Controls.Add(this.label2);
            this.groupControlChonThongTin.Controls.Add(this.cmbNienKhoa);
            this.groupControlChonThongTin.Controls.Add(this.label1);
            this.groupControlChonThongTin.Controls.Add(this.cmbKhoa);
            this.groupControlChonThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlChonThongTin.Location = new System.Drawing.Point(0, 0);
            this.groupControlChonThongTin.Name = "groupControlChonThongTin";
            this.groupControlChonThongTin.Size = new System.Drawing.Size(1247, 266);
            this.groupControlChonThongTin.TabIndex = 0;
            this.groupControlChonThongTin.Text = "NHẬP ĐIỂM MÔN HỌC";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Xóa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Sửa";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Phục Hồi";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Ghi";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Hủy";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Làm Mới";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem7.ImageOptions.SvgImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Thoát";
            this.barButtonItem8.Id = 7;
            this.barButtonItem8.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem8.ImageOptions.SvgImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl5.Location = new System.Drawing.Point(1247, 0);
            this.barDockControl5.Manager = null;
            this.barDockControl5.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl5.Size = new System.Drawing.Size(0, 726);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.button1);
            this.groupControl2.Controls.Add(this.btnHuy);
            this.groupControl2.Controls.Add(this.btnLuu);
            this.groupControl2.Controls.Add(this.btnBatDau);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 266);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1247, 100);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Điều khiển";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(337, 51);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(226, 51);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(103, 51);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(94, 23);
            this.btnBatDau.TabIndex = 0;
            this.btnBatDau.Text = "BẮT ĐẦU";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // groupControlNhapDiem
            // 
            this.groupControlNhapDiem.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlNhapDiem.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControlNhapDiem.Controls.Add(this.gridControlNhapDiem);
            this.groupControlNhapDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlNhapDiem.Location = new System.Drawing.Point(0, 366);
            this.groupControlNhapDiem.Name = "groupControlNhapDiem";
            this.groupControlNhapDiem.Size = new System.Drawing.Size(1247, 360);
            this.groupControlNhapDiem.TabIndex = 19;
            this.groupControlNhapDiem.Text = "BẢNG ĐIỂM MÔN HỌC";
            this.groupControlNhapDiem.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl3_Paint_1);
            // 
            // gridControlNhapDiem
            // 
            this.gridControlNhapDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNhapDiem.Location = new System.Drawing.Point(2, 28);
            this.gridControlNhapDiem.MainView = this.gridView1;
            this.gridControlNhapDiem.Name = "gridControlNhapDiem";
            this.gridControlNhapDiem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControlNhapDiem.Size = new System.Drawing.Size(1243, 330);
            this.gridControlNhapDiem.TabIndex = 0;
            this.gridControlNhapDiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterEnabled = false;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.GridControl = this.gridControlNhapDiem;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowColumnResizing = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView1_ValidatingEditor);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "MALTC";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã sinh viên";
            this.gridColumn2.FieldName = "MASV";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên sinh viên";
            this.gridColumn3.FieldName = "HOTEN";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Điểm chuyên cần";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "DIEM_CC";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Điểm giữa kì";
            this.gridColumn5.ColumnEdit = this.repositoryItemTextEdit1;
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "DIEM_GK";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 94;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Mask.BeepOnError = true;
            this.repositoryItemTextEdit1.Mask.EditMask = "f";
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Điểm cuối kì";
            this.gridColumn6.FieldName = "DIEM_CK";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Điểm tổng";
            this.gridColumn7.FieldName = "DIEM_TONG";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 94;
            // 
            // cmbGiangVien
            // 
            this.cmbGiangVien.FormattingEnabled = true;
            this.cmbGiangVien.Location = new System.Drawing.Point(879, 87);
            this.cmbGiangVien.Name = "cmbGiangVien";
            this.cmbGiangVien.Size = new System.Drawing.Size(292, 24);
            this.cmbGiangVien.TabIndex = 11;
            this.cmbGiangVien.SelectedIndexChanged += new System.EventHandler(this.cmbGiangVien_SelectedIndexChanged);
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 726);
            this.Controls.Add(this.groupControlNhapDiem);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControlChonThongTin);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControl5);
            this.Name = "frmDiem";
            this.Text = "frmDiem";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhapDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlChonThongTin)).EndInit();
            this.groupControlChonThongTin.ResumeLayout(false);
            this.groupControlChonThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlNhapDiem)).EndInit();
            this.groupControlNhapDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhapDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DS dS;
        private DSTableAdapters.DANGKYTableAdapter DANGKYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarButtonItem barBtnThem;
        private DevExpress.XtraBars.BarButtonItem barBtnXoa;
        private DevExpress.XtraBars.BarButtonItem barBtnSua;
        private DevExpress.XtraBars.BarButtonItem barBtnUndo;
        private DevExpress.XtraBars.BarButtonItem barBtnGhi;
        private DevExpress.XtraBars.BarButtonItem barBtnHuy;
        private DevExpress.XtraBars.BarButtonItem barBtnLamMoi;
        private DevExpress.XtraBars.BarButtonItem barBtnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHocKi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNhom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.GroupControl groupControlChonThongTin;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControlNhapDiem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBatDau;
        public System.Windows.Forms.BindingSource bdsNhapDiem;
        private DevExpress.XtraGrid.GridControl gridControlNhapDiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbGiangVien;
    }
}