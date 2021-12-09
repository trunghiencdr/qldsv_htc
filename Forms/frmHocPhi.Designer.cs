namespace QLDSV.Forms
{
    partial class frmHocPhi
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
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCPHILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocPhi));
            this.barManagerSinhVien = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSua = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bdsSINHVIEN = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.SINHVIENTableAdapter = new QLDSV.DSTableAdapters.GET_SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.grcThongTinSV = new DevExpress.XtraEditors.GroupControl();
            this.cmbSinhVien = new DevExpress.XtraEditors.LookUpEdit();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grcThongTinHP = new DevExpress.XtraEditors.GroupControl();
            this.grcChiTietHP = new DevExpress.XtraEditors.GroupControl();
            this.grcDongHP = new DevExpress.XtraEditors.GroupControl();
            this.spinEditTienDong = new DevExpress.XtraEditors.SpinEdit();
            this.btnNopHP = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditNgayDongHP = new DevExpress.XtraEditors.DateEdit();
            this.gcChiTietHp = new DevExpress.XtraGrid.GridControl();
            this.bdsCHITIETHP = new System.Windows.Forms.BindingSource(this.components);
            this.gvChiTietHp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNGAYDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelThongTinHP = new System.Windows.Forms.Panel();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.bdsHOCPHI = new System.Windows.Forms.BindingSource(this.components);
            this.spinEditHocPhi = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.HOCPHITableAdapter = new QLDSV.DSTableAdapters.SP_Thong_tin_dong_HP_sinh_vien1TableAdapter();
            this.gcHocPhi = new DevExpress.XtraGrid.GridControl();
            this.gvHocPhi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENCANDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CHITETHPTableAdapter = new QLDSV.DSTableAdapters.Sp_Chi_Tiet_Dong_HPTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            hOCKYLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCPHILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcThongTinSV)).BeginInit();
            this.grcThongTinSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSinhVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcThongTinHP)).BeginInit();
            this.grcThongTinHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcChiTietHP)).BeginInit();
            this.grcChiTietHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDongHP)).BeginInit();
            this.grcDongHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditTienDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayDongHP.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayDongHP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCHITIETHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietHp)).BeginInit();
            this.panelThongTinHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOCPHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditHocPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(283, 11);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(55, 17);
            hOCKYLabel.TabIndex = 0;
            hOCKYLabel.Text = "Học kỳ:";
            hOCKYLabel.Click += new System.EventHandler(this.hOCKYLabel_Click);
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(37, 12);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(76, 17);
            nIENKHOALabel.TabIndex = 2;
            nIENKHOALabel.Text = "Niên khóa:";
            // 
            // hOCPHILabel
            // 
            hOCPHILabel.AutoSize = true;
            hOCPHILabel.Location = new System.Drawing.Point(54, 53);
            hOCPHILabel.Name = "hOCPHILabel";
            hOCPHILabel.Size = new System.Drawing.Size(60, 17);
            hOCPHILabel.TabIndex = 4;
            hOCPHILabel.Text = "Học phí:";
            // 
            // barManagerSinhVien
            // 
            this.barManagerSinhVien.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManagerSinhVien.DockControls.Add(this.barDockControlTop);
            this.barManagerSinhVien.DockControls.Add(this.barDockControlBottom);
            this.barManagerSinhVien.DockControls.Add(this.barDockControlLeft);
            this.barManagerSinhVien.DockControls.Add(this.barDockControlRight);
            this.barManagerSinhVien.Form = this;
            this.barManagerSinhVien.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnThem,
            this.barBtnXoa,
            this.barBtnSua,
            this.barBtnUndo,
            this.barBtnGhi,
            this.barBtnHuy,
            this.barBtnLamMoi,
            this.barBtnThoat});
            this.barManagerSinhVien.MainMenu = this.bar2;
            this.barManagerSinhVien.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barBtnThem
            // 
            this.barBtnThem.Caption = "Thêm";
            this.barBtnThem.Id = 0;
            this.barBtnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnThem.ImageOptions.SvgImage")));
            this.barBtnThem.Name = "barBtnThem";
            this.barBtnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThem_ItemClick);
            // 
            // barBtnXoa
            // 
            this.barBtnXoa.Caption = "Xóa";
            this.barBtnXoa.Id = 1;
            this.barBtnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnXoa.ImageOptions.SvgImage")));
            this.barBtnXoa.Name = "barBtnXoa";
            this.barBtnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnXoa_ItemClick);
            // 
            // barBtnSua
            // 
            this.barBtnSua.Caption = "Sửa";
            this.barBtnSua.Id = 2;
            this.barBtnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnSua.ImageOptions.SvgImage")));
            this.barBtnSua.Name = "barBtnSua";
            this.barBtnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSua_ItemClick);
            // 
            // barBtnUndo
            // 
            this.barBtnUndo.Caption = "Phục Hồi";
            this.barBtnUndo.Id = 3;
            this.barBtnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnUndo.ImageOptions.SvgImage")));
            this.barBtnUndo.Name = "barBtnUndo";
            this.barBtnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUndo_ItemClick);
            // 
            // barBtnGhi
            // 
            this.barBtnGhi.Caption = "Ghi";
            this.barBtnGhi.Id = 4;
            this.barBtnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnGhi.ImageOptions.SvgImage")));
            this.barBtnGhi.Name = "barBtnGhi";
            this.barBtnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGhi_ItemClick);
            // 
            // barBtnHuy
            // 
            this.barBtnHuy.Caption = "Hủy";
            this.barBtnHuy.Id = 5;
            this.barBtnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnHuy.ImageOptions.SvgImage")));
            this.barBtnHuy.Name = "barBtnHuy";
            this.barBtnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnHuy_ItemClick);
            // 
            // barBtnLamMoi
            // 
            this.barBtnLamMoi.Caption = "Làm Mới";
            this.barBtnLamMoi.Id = 6;
            this.barBtnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnLamMoi.ImageOptions.SvgImage")));
            this.barBtnLamMoi.Name = "barBtnLamMoi";
            this.barBtnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLamMoi_ItemClick);
            // 
            // barBtnThoat
            // 
            this.barBtnThoat.Caption = "Thoát";
            this.barBtnThoat.Id = 7;
            this.barBtnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnThoat.ImageOptions.SvgImage")));
            this.barBtnThoat.Name = "barBtnThoat";
            this.barBtnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerSinhVien;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1385, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 667);
            this.barDockControlBottom.Manager = this.barManagerSinhVien;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1385, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManagerSinhVien;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 637);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1385, 30);
            this.barDockControlRight.Manager = this.barManagerSinhVien;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 637);
            // 
            // bdsSINHVIEN
            // 
            this.bdsSINHVIEN.DataMember = "GET_SINHVIEN";
            this.bdsSINHVIEN.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // grcThongTinSV
            // 
            this.grcThongTinSV.Controls.Add(this.cmbSinhVien);
            this.grcThongTinSV.Controls.Add(this.txtLop);
            this.grcThongTinSV.Controls.Add(this.labelControl3);
            this.grcThongTinSV.Controls.Add(this.txtHoten);
            this.grcThongTinSV.Controls.Add(this.labelControl2);
            this.grcThongTinSV.Controls.Add(this.labelControl1);
            this.grcThongTinSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.grcThongTinSV.Location = new System.Drawing.Point(0, 30);
            this.grcThongTinSV.Margin = new System.Windows.Forms.Padding(4);
            this.grcThongTinSV.Name = "grcThongTinSV";
            this.grcThongTinSV.Size = new System.Drawing.Size(1385, 86);
            this.grcThongTinSV.TabIndex = 15;
            this.grcThongTinSV.Text = "Thông tin sinh viên";
            // 
            // cmbSinhVien
            // 
            this.cmbSinhVien.Location = new System.Drawing.Point(166, 44);
            this.cmbSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSinhVien.Name = "cmbSinhVien";
            this.cmbSinhVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSinhVien.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MASV", "MASV", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbSinhVien.Properties.DataSource = this.bdsSINHVIEN;
            this.cmbSinhVien.Properties.DisplayMember = "MASV";
            this.cmbSinhVien.Properties.NullText = "Nhập mã sinh viên ...";
            this.cmbSinhVien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbSinhVien.Properties.ValueMember = "MASV";
            this.cmbSinhVien.Size = new System.Drawing.Size(212, 22);
            this.cmbSinhVien.TabIndex = 14;
            this.cmbSinhVien.EditValueChanged += new System.EventHandler(this.cmbSinhVien_EditValueChanged);
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(784, 43);
            this.txtLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(200, 22);
            this.txtLop.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(741, 47);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 17);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Lớp:";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(495, 43);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.ReadOnly = true;
            this.txtHoten.Size = new System.Drawing.Size(200, 22);
            this.txtHoten.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(419, 47);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 17);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Họ tên:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(59, 47);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 16);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Mã sinh viên: ";
            // 
            // grcThongTinHP
            // 
            this.grcThongTinHP.Controls.Add(this.grcChiTietHP);
            this.grcThongTinHP.Controls.Add(this.panelThongTinHP);
            this.grcThongTinHP.Dock = System.Windows.Forms.DockStyle.Left;
            this.grcThongTinHP.Location = new System.Drawing.Point(0, 116);
            this.grcThongTinHP.Margin = new System.Windows.Forms.Padding(4);
            this.grcThongTinHP.Name = "grcThongTinHP";
            this.grcThongTinHP.Size = new System.Drawing.Size(603, 551);
            this.grcThongTinHP.TabIndex = 16;
            this.grcThongTinHP.Text = "Thông tin học phí";
            // 
            // grcChiTietHP
            // 
            this.grcChiTietHP.Controls.Add(this.grcDongHP);
            this.grcChiTietHP.Controls.Add(this.gcChiTietHp);
            this.grcChiTietHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcChiTietHP.Location = new System.Drawing.Point(2, 133);
            this.grcChiTietHP.Name = "grcChiTietHP";
            this.grcChiTietHP.Size = new System.Drawing.Size(599, 416);
            this.grcChiTietHP.TabIndex = 2;
            this.grcChiTietHP.Text = "Chi tiết đóng học phí";
            // 
            // grcDongHP
            // 
            this.grcDongHP.Controls.Add(this.spinEditTienDong);
            this.grcDongHP.Controls.Add(this.btnNopHP);
            this.grcDongHP.Controls.Add(this.labelControl5);
            this.grcDongHP.Controls.Add(this.labelControl4);
            this.grcDongHP.Controls.Add(this.dateEditNgayDongHP);
            this.grcDongHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDongHP.Location = new System.Drawing.Point(2, 144);
            this.grcDongHP.Name = "grcDongHP";
            this.grcDongHP.Size = new System.Drawing.Size(595, 270);
            this.grcDongHP.TabIndex = 2;
            this.grcDongHP.Text = "Đóng học phí";
            // 
            // spinEditTienDong
            // 
            this.spinEditTienDong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditTienDong.Location = new System.Drawing.Point(363, 40);
            this.spinEditTienDong.MenuManager = this.barManagerSinhVien;
            this.spinEditTienDong.Name = "spinEditTienDong";
            this.spinEditTienDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditTienDong.Size = new System.Drawing.Size(163, 24);
            this.spinEditTienDong.TabIndex = 5;
            // 
            // btnNopHP
            // 
            this.btnNopHP.Location = new System.Drawing.Point(240, 86);
            this.btnNopHP.Name = "btnNopHP";
            this.btnNopHP.Size = new System.Drawing.Size(122, 36);
            this.btnNopHP.TabIndex = 4;
            this.btnNopHP.Text = "Nộp học phí";
            this.btnNopHP.Click += new System.EventHandler(this.btnNopHP_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(295, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 18);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Số tiền:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(37, 42);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 18);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Ngày đóng:";
            // 
            // dateEditNgayDongHP
            // 
            this.dateEditNgayDongHP.EditValue = null;
            this.dateEditNgayDongHP.Location = new System.Drawing.Point(127, 41);
            this.dateEditNgayDongHP.Name = "dateEditNgayDongHP";
            this.dateEditNgayDongHP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayDongHP.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayDongHP.Size = new System.Drawing.Size(125, 22);
            this.dateEditNgayDongHP.TabIndex = 0;
            // 
            // gcChiTietHp
            // 
            this.gcChiTietHp.DataSource = this.bdsCHITIETHP;
            this.gcChiTietHp.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcChiTietHp.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcChiTietHp.Location = new System.Drawing.Point(2, 28);
            this.gcChiTietHp.MainView = this.gvChiTietHp;
            this.gcChiTietHp.Margin = new System.Windows.Forms.Padding(4);
            this.gcChiTietHp.Name = "gcChiTietHp";
            this.gcChiTietHp.Size = new System.Drawing.Size(595, 116);
            this.gcChiTietHp.TabIndex = 1;
            this.gcChiTietHp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChiTietHp});
            // 
            // bdsCHITIETHP
            // 
            this.bdsCHITIETHP.DataMember = "Sp_Chi_Tiet_Dong_HP";
            this.bdsCHITIETHP.DataSource = this.dS;
            // 
            // gvChiTietHp
            // 
            this.gvChiTietHp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNGAYDONG,
            this.colSOTIENDONG});
            this.gvChiTietHp.DetailHeight = 437;
            this.gvChiTietHp.GridControl = this.gcChiTietHp;
            this.gvChiTietHp.Name = "gvChiTietHp";
            this.gvChiTietHp.OptionsBehavior.ReadOnly = true;
            this.gvChiTietHp.OptionsView.ShowGroupPanel = false;
            // 
            // colNGAYDONG
            // 
            this.colNGAYDONG.FieldName = "NGAYDONG";
            this.colNGAYDONG.MinWidth = 31;
            this.colNGAYDONG.Name = "colNGAYDONG";
            this.colNGAYDONG.OptionsColumn.ReadOnly = true;
            this.colNGAYDONG.Visible = true;
            this.colNGAYDONG.VisibleIndex = 0;
            this.colNGAYDONG.Width = 117;
            // 
            // colSOTIENDONG
            // 
            this.colSOTIENDONG.DisplayFormat.FormatString = "#,###";
            this.colSOTIENDONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSOTIENDONG.FieldName = "SOTIENDONG";
            this.colSOTIENDONG.MinWidth = 31;
            this.colSOTIENDONG.Name = "colSOTIENDONG";
            this.colSOTIENDONG.OptionsColumn.ReadOnly = true;
            this.colSOTIENDONG.Visible = true;
            this.colSOTIENDONG.VisibleIndex = 1;
            this.colSOTIENDONG.Width = 117;
            // 
            // panelThongTinHP
            // 
            this.panelThongTinHP.Controls.Add(this.cmbNienKhoa);
            this.panelThongTinHP.Controls.Add(hOCPHILabel);
            this.panelThongTinHP.Controls.Add(this.spinEditHocPhi);
            this.panelThongTinHP.Controls.Add(nIENKHOALabel);
            this.panelThongTinHP.Controls.Add(hOCKYLabel);
            this.panelThongTinHP.Controls.Add(this.spinEditHocKy);
            this.panelThongTinHP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongTinHP.Location = new System.Drawing.Point(2, 28);
            this.panelThongTinHP.Name = "panelThongTinHP";
            this.panelThongTinHP.Size = new System.Drawing.Size(599, 105);
            this.panelThongTinHP.TabIndex = 1;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHOCPHI, "NIENKHOA", true));
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024"});
            this.cmbNienKhoa.Location = new System.Drawing.Point(124, 8);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(125, 24);
            this.cmbNienKhoa.TabIndex = 6;
            // 
            // bdsHOCPHI
            // 
            this.bdsHOCPHI.DataMember = "SP_Thong_tin_dong_HP_sinh_vien1";
            this.bdsHOCPHI.DataSource = this.dS;
            // 
            // spinEditHocPhi
            // 
            this.spinEditHocPhi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHOCPHI, "HOCPHI", true));
            this.spinEditHocPhi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditHocPhi.Location = new System.Drawing.Point(124, 50);
            this.spinEditHocPhi.MenuManager = this.barManagerSinhVien;
            this.spinEditHocPhi.Name = "spinEditHocPhi";
            this.spinEditHocPhi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditHocPhi.Size = new System.Drawing.Size(125, 24);
            this.spinEditHocPhi.TabIndex = 5;
            // 
            // spinEditHocKy
            // 
            this.spinEditHocKy.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHOCPHI, "HOCKY", true));
            this.spinEditHocKy.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditHocKy.Location = new System.Drawing.Point(349, 8);
            this.spinEditHocKy.MenuManager = this.barManagerSinhVien;
            this.spinEditHocKy.Name = "spinEditHocKy";
            this.spinEditHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditHocKy.Properties.MaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.spinEditHocKy.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditHocKy.Size = new System.Drawing.Size(125, 24);
            this.spinEditHocKy.TabIndex = 1;
            this.spinEditHocKy.EditValueChanged += new System.EventHandler(this.hOCKYSpinEdit_EditValueChanged);
            // 
            // HOCPHITableAdapter
            // 
            this.HOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // gcHocPhi
            // 
            this.gcHocPhi.DataSource = this.bdsHOCPHI;
            this.gcHocPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHocPhi.Location = new System.Drawing.Point(603, 116);
            this.gcHocPhi.MainView = this.gvHocPhi;
            this.gcHocPhi.MenuManager = this.barManagerSinhVien;
            this.gcHocPhi.Name = "gcHocPhi";
            this.gcHocPhi.Size = new System.Drawing.Size(782, 551);
            this.gcHocPhi.TabIndex = 21;
            this.gcHocPhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHocPhi});
            this.gcHocPhi.Click += new System.EventHandler(this.sP_Thong_tin_dong_HP_sinh_vien1GridControl_Click);
            // 
            // gvHocPhi
            // 
            this.gvHocPhi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colSOTIENDADONG,
            this.colSOTIENCANDONG});
            this.gvHocPhi.GridControl = this.gcHocPhi;
            this.gvHocPhi.Name = "gvHocPhi";
            this.gvHocPhi.OptionsBehavior.ReadOnly = true;
            this.gvHocPhi.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvHocPhi_FocusedRowChanged);
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 25;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            this.colNIENKHOA.Width = 94;
            // 
            // colHOCKY
            // 
            this.colHOCKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 25;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            this.colHOCKY.Width = 94;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.DisplayFormat.FormatString = "###,#";
            this.colHOCPHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 25;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            this.colHOCPHI.Width = 94;
            // 
            // colSOTIENDADONG
            // 
            this.colSOTIENDADONG.DisplayFormat.FormatString = "###,#";
            this.colSOTIENDADONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIENDADONG.FieldName = "SOTIENDADONG";
            this.colSOTIENDADONG.MinWidth = 25;
            this.colSOTIENDADONG.Name = "colSOTIENDADONG";
            this.colSOTIENDADONG.Visible = true;
            this.colSOTIENDADONG.VisibleIndex = 3;
            this.colSOTIENDADONG.Width = 94;
            // 
            // colSOTIENCANDONG
            // 
            this.colSOTIENCANDONG.DisplayFormat.FormatString = "###,#";
            this.colSOTIENCANDONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIENCANDONG.FieldName = "SOTIENCANDONG";
            this.colSOTIENCANDONG.MinWidth = 25;
            this.colSOTIENCANDONG.Name = "colSOTIENCANDONG";
            this.colSOTIENCANDONG.Visible = true;
            this.colSOTIENCANDONG.VisibleIndex = 4;
            this.colSOTIENCANDONG.Width = 94;
            // 
            // CHITETHPTableAdapter
            // 
            this.CHITETHPTableAdapter.ClearBeforeFill = true;
            // 
            // frmHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 667);
            this.Controls.Add(this.gcHocPhi);
            this.Controls.Add(this.grcThongTinHP);
            this.Controls.Add(this.grcThongTinSV);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmHocPhi";
            this.Text = "frmHocPhi";
            this.Load += new System.EventHandler(this.frmHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcThongTinSV)).EndInit();
            this.grcThongTinSV.ResumeLayout(false);
            this.grcThongTinSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSinhVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcThongTinHP)).EndInit();
            this.grcThongTinHP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcChiTietHP)).EndInit();
            this.grcChiTietHP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcDongHP)).EndInit();
            this.grcDongHP.ResumeLayout(false);
            this.grcDongHP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditTienDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayDongHP.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayDongHP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCHITIETHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietHp)).EndInit();
            this.panelThongTinHP.ResumeLayout(false);
            this.panelThongTinHP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOCPHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditHocPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerSinhVien;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barBtnThem;
        private DevExpress.XtraBars.BarButtonItem barBtnXoa;
        private DevExpress.XtraBars.BarButtonItem barBtnSua;
        private DevExpress.XtraBars.BarButtonItem barBtnUndo;
        private DevExpress.XtraBars.BarButtonItem barBtnGhi;
        private DevExpress.XtraBars.BarButtonItem barBtnHuy;
        private DevExpress.XtraBars.BarButtonItem barBtnLamMoi;
        private DevExpress.XtraBars.BarButtonItem barBtnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsSINHVIEN;
        private DSTableAdapters.GET_SINHVIENTableAdapter SINHVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl grcThongTinHP;
        private DevExpress.XtraEditors.GroupControl grcChiTietHP;
        private DevExpress.XtraEditors.GroupControl grcDongHP;
        private DevExpress.XtraEditors.SimpleButton btnNopHP;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateEditNgayDongHP;
        private DevExpress.XtraGrid.GridControl gcChiTietHp;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChiTietHp;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDONG;
        private System.Windows.Forms.Panel panelThongTinHP;
        private DevExpress.XtraEditors.GroupControl grcThongTinSV;
        private DevExpress.XtraEditors.LookUpEdit cmbSinhVien;
        private System.Windows.Forms.TextBox txtLop;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtHoten;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bdsHOCPHI;
        private DSTableAdapters.SP_Thong_tin_dong_HP_sinh_vien1TableAdapter HOCPHITableAdapter;
        private DevExpress.XtraGrid.GridControl gcHocPhi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHocPhi;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDADONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENCANDONG;
        private System.Windows.Forms.BindingSource bdsCHITIETHP;
        private DSTableAdapters.Sp_Chi_Tiet_Dong_HPTableAdapter CHITETHPTableAdapter;
        private DevExpress.XtraEditors.SpinEdit spinEditHocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private DevExpress.XtraEditors.SpinEdit spinEditHocPhi;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SpinEdit spinEditTienDong;
    }
}