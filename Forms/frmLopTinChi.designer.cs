
namespace QLDSV.Forms
{
    partial class frmLopTinChi
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
            System.Windows.Forms.Label mALTCLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label sOSVTOITHIEULabel;
            System.Windows.Forms.Label hUYLOPLabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLopTinChi));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.dS = new QLDSV.DS();
            this.LOPTINCHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTINCHITableAdapter = new QLDSV.DSTableAdapters.LOPTINCHITableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.lOPTINCHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVTOITHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHUYLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DANGKYTableAdapter = new QLDSV.DSTableAdapters.DANGKYTableAdapter();
            this.grbLTC = new System.Windows.Forms.GroupBox();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.hUYLOPCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.txtSOSV = new DevExpress.XtraEditors.SpinEdit();
            this.cmbMAGV = new System.Windows.Forms.ComboBox();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNHOM = new DevExpress.XtraEditors.SpinEdit();
            this.cmbMAMH = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtHOCKI = new DevExpress.XtraEditors.SpinEdit();
            this.txtNIENKHOA = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLTC = new DevExpress.XtraEditors.SpinEdit();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gIANGVIENTableAdapter = new QLDSV.DSTableAdapters.GIANGVIENTableAdapter();
            this.gIANGVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.mONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            mALTCLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            sOSVTOITHIEULabel = new System.Windows.Forms.Label();
            hUYLOPLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerSinhVien)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOPTINCHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DANGKYBindingSource)).BeginInit();
            this.grbLTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hUYLOPCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNHOM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOCKI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNIENKHOA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // mALTCLabel
            // 
            mALTCLabel.AutoSize = true;
            mALTCLabel.Location = new System.Drawing.Point(5, 38);
            mALTCLabel.Name = "mALTCLabel";
            mALTCLabel.Size = new System.Drawing.Size(57, 17);
            mALTCLabel.TabIndex = 0;
            mALTCLabel.Text = "Mã LTC";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(5, 67);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(80, 17);
            nIENKHOALabel.TabIndex = 2;
            nIENKHOALabel.Text = "Niên khóa :";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(5, 97);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(59, 17);
            hOCKYLabel.TabIndex = 4;
            hOCKYLabel.Text = "Học kỳ :";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(8, 126);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(60, 17);
            mAMHLabel.TabIndex = 8;
            mAMHLabel.Text = "Mã MH :";
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Location = new System.Drawing.Point(290, 38);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(53, 17);
            nHOMLabel.TabIndex = 10;
            nHOMLabel.Text = "Nhóm :";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(290, 67);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(59, 17);
            mAGVLabel.TabIndex = 12;
            mAGVLabel.Text = "Mã GV :";
            // 
            // sOSVTOITHIEULabel
            // 
            sOSVTOITHIEULabel.AutoSize = true;
            sOSVTOITHIEULabel.Location = new System.Drawing.Point(290, 125);
            sOSVTOITHIEULabel.Name = "sOSVTOITHIEULabel";
            sOSVTOITHIEULabel.Size = new System.Drawing.Size(109, 17);
            sOSVTOITHIEULabel.TabIndex = 14;
            sOSVTOITHIEULabel.Text = "Số SV tối thiểu :";
            // 
            // hUYLOPLabel
            // 
            hUYLOPLabel.AutoSize = true;
            hUYLOPLabel.Location = new System.Drawing.Point(290, 169);
            hUYLOPLabel.Name = "hUYLOPLabel";
            hUYLOPLabel.Size = new System.Drawing.Size(64, 17);
            hUYLOPLabel.TabIndex = 16;
            hUYLOPLabel.Text = "Hủy lớp :";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(290, 99);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(70, 17);
            mAKHOALabel.TabIndex = 17;
            mAKHOALabel.Text = "Mã khoa :";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1384, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 775);
            this.barDockControlBottom.Manager = this.barManagerSinhVien;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1384, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManagerSinhVien;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 745);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1384, 30);
            this.barDockControlRight.Manager = this.barManagerSinhVien;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 745);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTenKhoa);
            this.panel1.Controls.Add(this.cmbKhoa);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 45);
            this.panel1.TabIndex = 4;
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(569, 18);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(47, 17);
            this.lblTenKhoa.TabIndex = 1;
            this.lblTenKhoa.Text = "KHOA";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(665, 15);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(228, 24);
            this.cmbKhoa.TabIndex = 0;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            this.cmbKhoa.Click += new System.EventHandler(this.cmbKhoa_Click);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LOPTINCHIBindingSource
            // 
            this.LOPTINCHIBindingSource.DataMember = "LOPTINCHI";
            this.LOPTINCHIBindingSource.DataSource = this.dS;
            // 
            // LOPTINCHITableAdapter
            // 
            this.LOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.LOPTINCHITableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTINCHIGridControl
            // 
            this.lOPTINCHIGridControl.DataSource = this.LOPTINCHIBindingSource;
            this.lOPTINCHIGridControl.Location = new System.Drawing.Point(0, 89);
            this.lOPTINCHIGridControl.MainView = this.gridView1;
            this.lOPTINCHIGridControl.MenuManager = this.barManagerSinhVien;
            this.lOPTINCHIGridControl.Name = "lOPTINCHIGridControl";
            this.lOPTINCHIGridControl.Size = new System.Drawing.Size(1364, 178);
            this.lOPTINCHIGridControl.TabIndex = 6;
            this.lOPTINCHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colNIENKHOA,
            this.colHOCKY,
            this.colMAMH,
            this.colNHOM,
            this.colMAGV,
            this.colMAKHOA,
            this.colSOSVTOITHIEU,
            this.colHUYLOP});
            this.gridView1.GridControl = this.lOPTINCHIGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMALTC
            // 
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.MinWidth = 25;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 94;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 25;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 1;
            this.colNIENKHOA.Width = 94;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 25;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 2;
            this.colHOCKY.Width = 94;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 3;
            this.colMAMH.Width = 94;
            // 
            // colNHOM
            // 
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 25;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 4;
            this.colNHOM.Width = 94;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 5;
            this.colMAGV.Width = 94;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 25;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 6;
            this.colMAKHOA.Width = 94;
            // 
            // colSOSVTOITHIEU
            // 
            this.colSOSVTOITHIEU.FieldName = "SOSVTOITHIEU";
            this.colSOSVTOITHIEU.MinWidth = 25;
            this.colSOSVTOITHIEU.Name = "colSOSVTOITHIEU";
            this.colSOSVTOITHIEU.Visible = true;
            this.colSOSVTOITHIEU.VisibleIndex = 7;
            this.colSOSVTOITHIEU.Width = 94;
            // 
            // colHUYLOP
            // 
            this.colHUYLOP.FieldName = "HUYLOP";
            this.colHUYLOP.MinWidth = 25;
            this.colHUYLOP.Name = "colHUYLOP";
            this.colHUYLOP.Visible = true;
            this.colHUYLOP.VisibleIndex = 8;
            this.colHUYLOP.Width = 94;
            // 
            // DANGKYBindingSource
            // 
            this.DANGKYBindingSource.DataMember = "FK_DANGKY_LOPTINCHI";
            this.DANGKYBindingSource.DataSource = this.LOPTINCHIBindingSource;
            // 
            // DANGKYTableAdapter
            // 
            this.DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // grbLTC
            // 
            this.grbLTC.Controls.Add(mAKHOALabel);
            this.grbLTC.Controls.Add(this.txtMaKhoa);
            this.grbLTC.Controls.Add(hUYLOPLabel);
            this.grbLTC.Controls.Add(this.hUYLOPCheckEdit);
            this.grbLTC.Controls.Add(sOSVTOITHIEULabel);
            this.grbLTC.Controls.Add(this.txtSOSV);
            this.grbLTC.Controls.Add(mAGVLabel);
            this.grbLTC.Controls.Add(this.cmbMAGV);
            this.grbLTC.Controls.Add(nHOMLabel);
            this.grbLTC.Controls.Add(this.txtNHOM);
            this.grbLTC.Controls.Add(mAMHLabel);
            this.grbLTC.Controls.Add(this.cmbMAMH);
            this.grbLTC.Controls.Add(hOCKYLabel);
            this.grbLTC.Controls.Add(this.txtHOCKI);
            this.grbLTC.Controls.Add(nIENKHOALabel);
            this.grbLTC.Controls.Add(this.txtNIENKHOA);
            this.grbLTC.Controls.Add(mALTCLabel);
            this.grbLTC.Controls.Add(this.txtMaLTC);
            this.grbLTC.Location = new System.Drawing.Point(0, 273);
            this.grbLTC.Name = "grbLTC";
            this.grbLTC.Size = new System.Drawing.Size(539, 331);
            this.grbLTC.TabIndex = 11;
            this.grbLTC.TabStop = false;
            this.grbLTC.Text = "Thông tin lớp tín chỉ";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.LOPTINCHIBindingSource, "MAKHOA", true));
            this.txtMaKhoa.Enabled = false;
            this.txtMaKhoa.Location = new System.Drawing.Point(410, 94);
            this.txtMaKhoa.MenuManager = this.barManagerSinhVien;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(125, 22);
            this.txtMaKhoa.TabIndex = 18;
            // 
            // hUYLOPCheckEdit
            // 
            this.hUYLOPCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.LOPTINCHIBindingSource, "HUYLOP", true));
            this.hUYLOPCheckEdit.EditValue = true;
            this.hUYLOPCheckEdit.Location = new System.Drawing.Point(410, 165);
            this.hUYLOPCheckEdit.MenuManager = this.barManagerSinhVien;
            this.hUYLOPCheckEdit.Name = "hUYLOPCheckEdit";
            this.hUYLOPCheckEdit.Properties.Caption = "Lop bi huy";
            this.hUYLOPCheckEdit.Size = new System.Drawing.Size(94, 24);
            this.hUYLOPCheckEdit.TabIndex = 17;
            // 
            // txtSOSV
            // 
            this.txtSOSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.LOPTINCHIBindingSource, "SOSVTOITHIEU", true));
            this.txtSOSV.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSOSV.Location = new System.Drawing.Point(410, 122);
            this.txtSOSV.MenuManager = this.barManagerSinhVien;
            this.txtSOSV.Name = "txtSOSV";
            this.txtSOSV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSOSV.Size = new System.Drawing.Size(125, 24);
            this.txtSOSV.TabIndex = 15;
            // 
            // cmbMAGV
            // 
            this.cmbMAGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LOPTINCHIBindingSource, "MAGV", true));
            this.cmbMAGV.DataSource = this.gIANGVIENBindingSource;
            this.cmbMAGV.DisplayMember = "MAGV";
            this.cmbMAGV.FormattingEnabled = true;
            this.cmbMAGV.Location = new System.Drawing.Point(410, 64);
            this.cmbMAGV.Name = "cmbMAGV";
            this.cmbMAGV.Size = new System.Drawing.Size(125, 24);
            this.cmbMAGV.TabIndex = 13;
            this.cmbMAGV.ValueMember = "MAGV";
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.dS;
            // 
            // txtNHOM
            // 
            this.txtNHOM.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.LOPTINCHIBindingSource, "NHOM", true));
            this.txtNHOM.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNHOM.Location = new System.Drawing.Point(410, 34);
            this.txtNHOM.MenuManager = this.barManagerSinhVien;
            this.txtNHOM.Name = "txtNHOM";
            this.txtNHOM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNHOM.Size = new System.Drawing.Size(125, 24);
            this.txtNHOM.TabIndex = 11;
            // 
            // cmbMAMH
            // 
            this.cmbMAMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LOPTINCHIBindingSource, "MAMH", true));
            this.cmbMAMH.DataSource = this.mONHOCBindingSource;
            this.cmbMAMH.DisplayMember = "MAMH";
            this.cmbMAMH.FormattingEnabled = true;
            this.cmbMAMH.Location = new System.Drawing.Point(93, 125);
            this.cmbMAMH.Name = "cmbMAMH";
            this.cmbMAMH.Size = new System.Drawing.Size(125, 24);
            this.cmbMAMH.TabIndex = 9;
            this.cmbMAMH.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // txtHOCKI
            // 
            this.txtHOCKI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.LOPTINCHIBindingSource, "HOCKY", true));
            this.txtHOCKI.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtHOCKI.Location = new System.Drawing.Point(93, 95);
            this.txtHOCKI.MenuManager = this.barManagerSinhVien;
            this.txtHOCKI.Name = "txtHOCKI";
            this.txtHOCKI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHOCKI.Size = new System.Drawing.Size(125, 24);
            this.txtHOCKI.TabIndex = 5;
            // 
            // txtNIENKHOA
            // 
            this.txtNIENKHOA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.LOPTINCHIBindingSource, "NIENKHOA", true));
            this.txtNIENKHOA.Location = new System.Drawing.Point(93, 67);
            this.txtNIENKHOA.MenuManager = this.barManagerSinhVien;
            this.txtNIENKHOA.Name = "txtNIENKHOA";
            this.txtNIENKHOA.Size = new System.Drawing.Size(125, 22);
            this.txtNIENKHOA.TabIndex = 3;
            // 
            // txtMaLTC
            // 
            this.txtMaLTC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.LOPTINCHIBindingSource, "MALTC", true));
            this.txtMaLTC.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMaLTC.Location = new System.Drawing.Point(93, 37);
            this.txtMaLTC.MenuManager = this.barManagerSinhVien;
            this.txtMaLTC.Name = "txtMaLTC";
            this.txtMaLTC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMaLTC.Size = new System.Drawing.Size(125, 24);
            this.txtMaLTC.TabIndex = 1;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // gIANGVIENGridControl
            // 
            this.gIANGVIENGridControl.DataSource = this.gIANGVIENBindingSource;
            this.gIANGVIENGridControl.Location = new System.Drawing.Point(545, 273);
            this.gIANGVIENGridControl.MainView = this.gridView2;
            this.gIANGVIENGridControl.MenuManager = this.barManagerSinhVien;
            this.gIANGVIENGridControl.Name = "gIANGVIENGridControl";
            this.gIANGVIENGridControl.Size = new System.Drawing.Size(422, 220);
            this.gIANGVIENGridControl.TabIndex = 15;
            this.gIANGVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV1,
            this.colMAKHOA1,
            this.colHO,
            this.colTEN});
            this.gridView2.GridControl = this.gIANGVIENGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            // 
            // colMAGV1
            // 
            this.colMAGV1.FieldName = "MAGV";
            this.colMAGV1.MinWidth = 25;
            this.colMAGV1.Name = "colMAGV1";
            this.colMAGV1.Visible = true;
            this.colMAGV1.VisibleIndex = 0;
            this.colMAGV1.Width = 94;
            // 
            // colMAKHOA1
            // 
            this.colMAKHOA1.FieldName = "MAKHOA";
            this.colMAKHOA1.MinWidth = 25;
            this.colMAKHOA1.Name = "colMAKHOA1";
            this.colMAKHOA1.Visible = true;
            this.colMAKHOA1.VisibleIndex = 1;
            this.colMAKHOA1.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 2;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 3;
            this.colTEN.Width = 94;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCGridControl
            // 
            this.mONHOCGridControl.DataSource = this.mONHOCBindingSource;
            this.mONHOCGridControl.Location = new System.Drawing.Point(973, 273);
            this.mONHOCGridControl.MainView = this.gridView3;
            this.mONHOCGridControl.MenuManager = this.barManagerSinhVien;
            this.mONHOCGridControl.Name = "mONHOCGridControl";
            this.mONHOCGridControl.Size = new System.Drawing.Size(391, 220);
            this.mONHOCGridControl.TabIndex = 15;
            this.mONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH1,
            this.colTENMH});
            this.gridView3.GridControl = this.mONHOCGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsBehavior.ReadOnly = true;
            // 
            // colMAMH1
            // 
            this.colMAMH1.FieldName = "MAMH";
            this.colMAMH1.MinWidth = 25;
            this.colMAMH1.Name = "colMAMH1";
            this.colMAMH1.Visible = true;
            this.colMAMH1.VisibleIndex = 0;
            this.colMAMH1.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 94;
            // 
            // frmLopTinChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 775);
            this.Controls.Add(this.mONHOCGridControl);
            this.Controls.Add(this.gIANGVIENGridControl);
            this.Controls.Add(this.grbLTC);
            this.Controls.Add(this.lOPTINCHIGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmLopTinChi";
            this.Text = "frmLopTinChi";
            this.Load += new System.EventHandler(this.frmLopTinChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerSinhVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOPTINCHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DANGKYBindingSource)).EndInit();
            this.grbLTC.ResumeLayout(false);
            this.grbLTC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hUYLOPCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNHOM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOCKI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNIENKHOA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.BindingSource LOPTINCHIBindingSource;
        private DS dS;
        private DSTableAdapters.LOPTINCHITableAdapter LOPTINCHITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOPTINCHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTOITHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colHUYLOP;
        private System.Windows.Forms.BindingSource DANGKYBindingSource;
        private DSTableAdapters.DANGKYTableAdapter DANGKYTableAdapter;
        private System.Windows.Forms.GroupBox grbLTC;
        private DevExpress.XtraEditors.CheckEdit hUYLOPCheckEdit;
        private DevExpress.XtraEditors.SpinEdit txtSOSV;
        private System.Windows.Forms.ComboBox cmbMAGV;
        private DevExpress.XtraEditors.SpinEdit txtNHOM;
        private System.Windows.Forms.ComboBox cmbMAMH;
        private DevExpress.XtraEditors.SpinEdit txtHOCKI;
        private DevExpress.XtraEditors.TextEdit txtNIENKHOA;
        private DevExpress.XtraEditors.SpinEdit txtMaLTC;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private DSTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private DevExpress.XtraGrid.GridControl gIANGVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DevExpress.XtraGrid.GridControl mONHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA1;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
    }
}