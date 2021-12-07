
namespace QLDSV.Report
{
    partial class xrp_DIEMTONGKET
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xrp_DIEMTONGKET));
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(167.5F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(32.5F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField crossTabColumnField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition crossTabRowDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.crossTabGeneralStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabDataStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabHeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabTotalStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblKhoa = new DevExpress.XtraReports.UI.XRLabel();
            this.lblLopKhoaHoc = new DevExpress.XtraReports.UI.XRLabel();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.crossTab1 = new DevExpress.XtraReports.UI.XRCrossTab();
            this.xrCrossTabCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell6 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell7 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell8 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell9 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.TitleStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            ((System.ComponentModel.ISupportInitialize)(this.crossTab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "QLDSV.Properties.Settings.QLDSVConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_BC_DIEMTONGKET";
            queryParameter1.Name = "@MALOP";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "D15CQCP01";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "SP_BC_DIEMTONGKET";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // crossTabGeneralStyle
            // 
            this.crossTabGeneralStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.crossTabGeneralStyle.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabGeneralStyle.BorderWidth = 1F;
            this.crossTabGeneralStyle.Font = new System.Drawing.Font("Arial", 9.75F);
            this.crossTabGeneralStyle.Name = "crossTabGeneralStyle";
            this.crossTabGeneralStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // crossTabDataStyle
            // 
            this.crossTabDataStyle.Name = "crossTabDataStyle";
            this.crossTabDataStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabHeaderStyle
            // 
            this.crossTabHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.crossTabHeaderStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.crossTabHeaderStyle.Name = "crossTabHeaderStyle";
            this.crossTabHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabTotalStyle
            // 
            this.crossTabTotalStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.crossTabTotalStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.crossTabTotalStyle.Name = "crossTabTotalStyle";
            this.crossTabTotalStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblKhoa,
            this.lblLopKhoaHoc,
            this.label1});
            this.ReportHeader.HeightF = 210.013F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblKhoa
            // 
            this.lblKhoa.Font = new System.Drawing.Font("Arial", 11F);
            this.lblKhoa.LocationFloat = new DevExpress.Utils.PointFloat(152.5F, 125.8333F);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.SizeF = new System.Drawing.SizeF(596.2656F, 30.01302F);
            this.lblKhoa.StyleName = "TitleStyle";
            this.lblKhoa.StylePriority.UseFont = false;
            this.lblKhoa.StylePriority.UseTextAlignment = false;
            this.lblKhoa.Text = "BẢNG ĐIỂM TỔNG KẾT CUỐI KHÓA";
            this.lblKhoa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblLopKhoaHoc
            // 
            this.lblLopKhoaHoc.Font = new System.Drawing.Font("Arial", 11F);
            this.lblLopKhoaHoc.LocationFloat = new DevExpress.Utils.PointFloat(152.5F, 95.82031F);
            this.lblLopKhoaHoc.Name = "lblLopKhoaHoc";
            this.lblLopKhoaHoc.SizeF = new System.Drawing.SizeF(596.2656F, 30.01302F);
            this.lblLopKhoaHoc.StyleName = "TitleStyle";
            this.lblLopKhoaHoc.StylePriority.UseFont = false;
            this.lblLopKhoaHoc.StylePriority.UseTextAlignment = false;
            this.lblLopKhoaHoc.Text = "BẢNG ĐIỂM TỔNG KẾT CUỐI KHÓA";
            this.lblLopKhoaHoc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(152.5F, 37.48698F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(596.2656F, 30.01302F);
            this.label1.StyleName = "TitleStyle";
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.Text = "BẢNG ĐIỂM TỔNG KẾT CUỐI KHÓA";
            this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.crossTab1});
            this.Detail.HeightF = 175F;
            this.Detail.Name = "Detail";
            // 
            // crossTab1
            // 
            this.crossTab1.Cells.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCrossTabCell2,
            this.xrCrossTabCell3,
            this.xrCrossTabCell4,
            this.xrCrossTabCell5,
            this.xrCrossTabCell6,
            this.xrCrossTabCell7,
            this.xrCrossTabCell8,
            this.xrCrossTabCell9,
            this.crossTabHeaderCell1});
            crossTabColumnDefinition1.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow;
            crossTabColumnDefinition2.Visible = false;
            this.crossTab1.ColumnDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition[] {
            crossTabColumnDefinition1,
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(100.8334F),
            crossTabColumnDefinition2});
            crossTabColumnField1.FieldName = "MAMH";
            crossTabColumnField1.SortOrder = DevExpress.XtraReports.UI.XRColumnSortOrder.None;
            this.crossTab1.ColumnFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField[] {
            crossTabColumnField1});
            this.crossTab1.DataAreaStyleName = "crossTabDataStyle";
            crossTabDataField1.FieldName = "DIEM";
            crossTabDataField1.SummaryType = DevExpress.XtraReports.UI.CrossTab.SummaryType.Max;
            this.crossTab1.DataFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField[] {
            crossTabDataField1});
            this.crossTab1.DataMember = "SP_BC_DIEMTONGKET";
            this.crossTab1.DataSource = this.sqlDataSource1;
            this.crossTab1.GeneralStyleName = "crossTabGeneralStyle";
            this.crossTab1.HeaderAreaStyleName = "crossTabHeaderStyle";
            this.crossTab1.LayoutOptions.CornerHeaderDisplayMode = DevExpress.XtraReports.UI.CrossTab.CornerHeaderDisplayMode.ColumnFieldNames;
            this.crossTab1.LocationFloat = new DevExpress.Utils.PointFloat(21.66667F, 0F);
            this.crossTab1.Name = "crossTab1";
            crossTabRowDefinition1.Visible = false;
            this.crossTab1.RowDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(116.6667F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(33.33332F),
            crossTabRowDefinition1});
            crossTabRowField1.FieldName = "TTSV";
            this.crossTab1.RowFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField[] {
            crossTabRowField1});
            this.crossTab1.SizeF = new System.Drawing.SizeF(300.8334F, 175F);
            this.crossTab1.TotalAreaStyleName = "crossTabTotalStyle";
            // 
            // xrCrossTabCell2
            // 
            this.xrCrossTabCell2.ColumnIndex = 1;
            this.xrCrossTabCell2.Name = "xrCrossTabCell2";
            this.xrCrossTabCell2.NullValueText = "Chưa đăng ký";
            this.xrCrossTabCell2.RowIndex = 1;
            this.xrCrossTabCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrCrossTabCell3
            // 
            this.xrCrossTabCell3.ColumnIndex = 1;
            this.xrCrossTabCell3.Name = "xrCrossTabCell3";
            this.xrCrossTabCell3.RowIndex = 0;
            this.xrCrossTabCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrCrossTabCell4
            // 
            this.xrCrossTabCell4.ColumnIndex = 2;
            this.xrCrossTabCell4.Name = "xrCrossTabCell4";
            this.xrCrossTabCell4.RowIndex = 0;
            this.xrCrossTabCell4.Text = "Grand Total";
            // 
            // xrCrossTabCell5
            // 
            this.xrCrossTabCell5.ColumnIndex = 2;
            this.xrCrossTabCell5.Name = "xrCrossTabCell5";
            this.xrCrossTabCell5.RowIndex = 1;
            // 
            // xrCrossTabCell6
            // 
            this.xrCrossTabCell6.ColumnIndex = 0;
            this.xrCrossTabCell6.Name = "xrCrossTabCell6";
            this.xrCrossTabCell6.RowIndex = 1;
            // 
            // xrCrossTabCell7
            // 
            this.xrCrossTabCell7.ColumnIndex = 0;
            this.xrCrossTabCell7.Name = "xrCrossTabCell7";
            this.xrCrossTabCell7.RowIndex = 2;
            this.xrCrossTabCell7.Text = "";
            // 
            // xrCrossTabCell8
            // 
            this.xrCrossTabCell8.ColumnIndex = 1;
            this.xrCrossTabCell8.Name = "xrCrossTabCell8";
            this.xrCrossTabCell8.RowIndex = 2;
            // 
            // xrCrossTabCell9
            // 
            this.xrCrossTabCell9.ColumnIndex = 2;
            this.xrCrossTabCell9.Name = "xrCrossTabCell9";
            this.xrCrossTabCell9.RowIndex = 2;
            // 
            // crossTabHeaderCell1
            // 
            this.crossTabHeaderCell1.ColumnIndex = 0;
            this.crossTabHeaderCell1.Name = "crossTabHeaderCell1";
            this.crossTabHeaderCell1.RowIndex = 0;
            this.crossTabHeaderCell1.Text = "MÃ SINH VIÊN-HỌ TÊN";
            this.crossTabHeaderCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // TitleStyle
            // 
            this.TitleStyle.Font = new System.Drawing.Font("Arial", 18F);
            this.TitleStyle.Name = "TitleStyle";
            this.TitleStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.PageFooter.Name = "PageFooter";
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(10F, 0F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(315F, 23F);
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(575F, 0F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(315F, 23F);
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // xrp_DIEMTONGKET
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.ReportHeader,
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart;
            this.Landscape = true;
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.ScriptsSource = "\r\nprivate void xrCrossTabCell4_BeforePrint(object sender, DevExpress.XtraReports." +
    "UI.CrossTab.CrossTabCellPrintEventArgs e) {\r\n\r\n}\r\n";
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.TitleStyle,
            this.crossTabGeneralStyle,
            this.crossTabHeaderStyle,
            this.crossTabDataStyle,
            this.crossTabTotalStyle});
            this.Version = "19.2";
            this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            ((System.ComponentModel.ISupportInitialize)(this.crossTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabGeneralStyle;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabDataStyle;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabHeaderStyle;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabTotalStyle;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRCrossTab crossTab1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell3;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell5;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell6;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell7;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell8;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell9;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRControlStyle TitleStyle;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell1;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        public DevExpress.XtraReports.UI.XRLabel lblKhoa;
        public DevExpress.XtraReports.UI.XRLabel lblLopKhoaHoc;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        public DevExpress.XtraReports.UI.XRLabel label1;
    }
}
