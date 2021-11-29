
namespace QLDSV.Report
{
    partial class fmpt_BC_DKLTC
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
            this.panelPD = new System.Windows.Forms.Panel();
            this.cmbGiangVien = new System.Windows.Forms.ComboBox();
            this.cmbGiangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.cmbMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNhom = new System.Windows.Forms.ComboBox();
            this.button_THOAT = new System.Windows.Forms.Button();
            this.button_IN = new System.Windows.Forms.Button();
            this.labelMaSV = new System.Windows.Forms.Label();
            this.label_TenLop = new System.Windows.Forms.Label();
            this.label_Khoa = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbMonHocTableAdapter = new QLDSV.DSTableAdapters.cmbMonHocTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.cmbGiangVienTableAdapter = new QLDSV.DSTableAdapters.cmbGiangVienTableAdapter();
            this.panelPD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGiangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPD
            // 
            this.panelPD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelPD.Controls.Add(this.cmbGiangVien);
            this.panelPD.Controls.Add(this.cmbMonHoc);
            this.panelPD.Controls.Add(this.label3);
            this.panelPD.Controls.Add(this.cmbNienKhoa);
            this.panelPD.Controls.Add(this.label1);
            this.panelPD.Controls.Add(this.cmbHocKy);
            this.panelPD.Controls.Add(this.label2);
            this.panelPD.Controls.Add(this.cmbNhom);
            this.panelPD.Controls.Add(this.button_THOAT);
            this.panelPD.Controls.Add(this.button_IN);
            this.panelPD.Controls.Add(this.labelMaSV);
            this.panelPD.Controls.Add(this.label_TenLop);
            this.panelPD.Controls.Add(this.label_Khoa);
            this.panelPD.Controls.Add(this.cmbKhoa);
            this.panelPD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPD.Location = new System.Drawing.Point(0, 0);
            this.panelPD.Margin = new System.Windows.Forms.Padding(4);
            this.panelPD.Name = "panelPD";
            this.panelPD.Size = new System.Drawing.Size(1059, 465);
            this.panelPD.TabIndex = 1;
            // 
            // cmbGiangVien
            // 
            this.cmbGiangVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cmbGiangVienBindingSource, "TENGV", true));
            this.cmbGiangVien.DataSource = this.cmbGiangVienBindingSource;
            this.cmbGiangVien.DisplayMember = "TENGV";
            this.cmbGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGiangVien.FormattingEnabled = true;
            this.cmbGiangVien.Location = new System.Drawing.Point(261, 242);
            this.cmbGiangVien.Name = "cmbGiangVien";
            this.cmbGiangVien.Size = new System.Drawing.Size(313, 24);
            this.cmbGiangVien.TabIndex = 25;
            this.cmbGiangVien.ValueMember = "MAGV";
            this.cmbGiangVien.SelectedIndexChanged += new System.EventHandler(this.cmbGiangVien_SelectedIndexChanged);
            // 
            // cmbGiangVienBindingSource
            // 
            this.cmbGiangVienBindingSource.DataMember = "cmbGiangVien";
            this.cmbGiangVienBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cmbMonHocBindingSource, "TENMH", true));
            this.cmbMonHoc.DataSource = this.cmbMonHocBindingSource;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(261, 192);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(313, 24);
            this.cmbMonHoc.TabIndex = 24;
            this.cmbMonHoc.ValueMember = "MAMH";
            this.cmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.tENMHComboBox_SelectedIndexChanged);
            // 
            // cmbMonHocBindingSource
            // 
            this.cmbMonHocBindingSource.DataMember = "cmbMonHoc";
            this.cmbMonHocBindingSource.DataSource = this.dS;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "GIẢNG VIÊN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Items.AddRange(new object[] {
            "2015-2016",
            "2016-2017",
            "2017-2018",
            "2018-2019",
            "2019-2020",
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024",
            "2024-2025",
            "2025-2026",
            "2026-2027"});
            this.cmbNienKhoa.Location = new System.Drawing.Point(261, 145);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(313, 24);
            this.cmbNienKhoa.TabIndex = 21;
            this.cmbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbNienKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "MÔN HỌC";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DisplayMember = "TENLOP";
            this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocKy.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHocKy.Location = new System.Drawing.Point(723, 144);
            this.cmbHocKy.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(174, 27);
            this.cmbHocKy.TabIndex = 16;
            this.cmbHocKy.ValueMember = "MALOP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "NHÓM";
            // 
            // cmbNhom
            // 
            this.cmbNhom.DisplayMember = "TENLOP";
            this.cmbNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhom.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhom.FormattingEnabled = true;
            this.cmbNhom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbNhom.Location = new System.Drawing.Point(723, 238);
            this.cmbNhom.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNhom.Name = "cmbNhom";
            this.cmbNhom.Size = new System.Drawing.Size(174, 27);
            this.cmbNhom.TabIndex = 14;
            this.cmbNhom.ValueMember = "MALOP";
            // 
            // button_THOAT
            // 
            this.button_THOAT.BackColor = System.Drawing.Color.LightCoral;
            this.button_THOAT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_THOAT.Location = new System.Drawing.Point(709, 368);
            this.button_THOAT.Margin = new System.Windows.Forms.Padding(4);
            this.button_THOAT.Name = "button_THOAT";
            this.button_THOAT.Size = new System.Drawing.Size(100, 52);
            this.button_THOAT.TabIndex = 7;
            this.button_THOAT.Text = "THOÁT";
            this.button_THOAT.UseVisualStyleBackColor = false;
            this.button_THOAT.Click += new System.EventHandler(this.button_THOAT_Click);
            // 
            // button_IN
            // 
            this.button_IN.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_IN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_IN.Location = new System.Drawing.Point(564, 368);
            this.button_IN.Margin = new System.Windows.Forms.Padding(4);
            this.button_IN.Name = "button_IN";
            this.button_IN.Size = new System.Drawing.Size(100, 52);
            this.button_IN.TabIndex = 6;
            this.button_IN.Text = "IN";
            this.button_IN.UseVisualStyleBackColor = false;
            this.button_IN.Click += new System.EventHandler(this.button_IN_Click);
            // 
            // labelMaSV
            // 
            this.labelMaSV.AutoSize = true;
            this.labelMaSV.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaSV.Location = new System.Drawing.Point(639, 144);
            this.labelMaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaSV.Name = "labelMaSV";
            this.labelMaSV.Size = new System.Drawing.Size(76, 23);
            this.labelMaSV.TabIndex = 5;
            this.labelMaSV.Text = "HỌC KỲ";
            this.labelMaSV.Click += new System.EventHandler(this.labelMaSV_Click);
            // 
            // label_TenLop
            // 
            this.label_TenLop.AutoSize = true;
            this.label_TenLop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenLop.Location = new System.Drawing.Point(133, 143);
            this.label_TenLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TenLop.Name = "label_TenLop";
            this.label_TenLop.Size = new System.Drawing.Size(109, 23);
            this.label_TenLop.TabIndex = 3;
            this.label_TenLop.Text = "NIÊN KHÓA";
            this.label_TenLop.Click += new System.EventHandler(this.label_TenLop_Click);
            // 
            // label_Khoa
            // 
            this.label_Khoa.AutoSize = true;
            this.label_Khoa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Khoa.Location = new System.Drawing.Point(302, 32);
            this.label_Khoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Khoa.Name = "label_Khoa";
            this.label_Khoa.Size = new System.Drawing.Size(54, 23);
            this.label_Khoa.TabIndex = 2;
            this.label_Khoa.Text = "KHOA";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(381, 28);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(469, 27);
            this.cmbKhoa.TabIndex = 0;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbMonHocTableAdapter
            // 
            this.cmbMonHocTableAdapter.ClearBeforeFill = true;
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
            // cmbGiangVienTableAdapter
            // 
            this.cmbGiangVienTableAdapter.ClearBeforeFill = true;
            // 
            // fmpt_BC_DKLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 465);
            this.Controls.Add(this.panelPD);
            this.Name = "fmpt_BC_DKLTC";
            this.Text = "fmpt_BC_DKLTC";
            this.Load += new System.EventHandler(this.fmpt_BC_DKLTC_Load);
            this.panelPD.ResumeLayout(false);
            this.panelPD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGiangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPD;
        private System.Windows.Forms.Button button_THOAT;
        private System.Windows.Forms.Button button_IN;
        private System.Windows.Forms.Label labelMaSV;
        private System.Windows.Forms.Label label_TenLop;
        private System.Windows.Forms.Label label_Khoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNhom;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.BindingSource cmbMonHocBindingSource;
        private DS dS;
        private DSTableAdapters.cmbMonHocTableAdapter cmbMonHocTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.BindingSource cmbGiangVienBindingSource;
        private DSTableAdapters.cmbGiangVienTableAdapter cmbGiangVienTableAdapter;
        private System.Windows.Forms.ComboBox cmbGiangVien;
    }
}