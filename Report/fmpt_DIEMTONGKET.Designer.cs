
namespace QLDSV.Report
{
    partial class fmpt_DIEMTONGKET
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
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.cmbLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.button_THOAT = new System.Windows.Forms.Button();
            this.button_IN = new System.Windows.Forms.Button();
            this.label_TenLop = new System.Windows.Forms.Label();
            this.label_Khoa = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbLOPTableAdapter = new QLDSV.DSTableAdapters.cmbLOPTableAdapter();
            this.panelPD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPD
            // 
            this.panelPD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelPD.Controls.Add(this.cmbLop);
            this.panelPD.Controls.Add(this.button_THOAT);
            this.panelPD.Controls.Add(this.button_IN);
            this.panelPD.Controls.Add(this.label_TenLop);
            this.panelPD.Controls.Add(this.label_Khoa);
            this.panelPD.Controls.Add(this.cmbKhoa);
            this.panelPD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPD.Location = new System.Drawing.Point(0, 0);
            this.panelPD.Margin = new System.Windows.Forms.Padding(4);
            this.panelPD.Name = "panelPD";
            this.panelPD.Size = new System.Drawing.Size(940, 438);
            this.panelPD.TabIndex = 2;
            // 
            // cmbLop
            // 
            this.cmbLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cmbLOPBindingSource, "TENLOP", true));
            this.cmbLop.DataSource = this.cmbLOPBindingSource;
            this.cmbLop.DisplayMember = "TENLOP";
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(308, 132);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(300, 24);
            this.cmbLop.TabIndex = 8;
            this.cmbLop.ValueMember = "MALOP";
            // 
            // cmbLOPBindingSource
            // 
            this.cmbLOPBindingSource.DataMember = "cmbLOP";
            this.cmbLOPBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_THOAT
            // 
            this.button_THOAT.BackColor = System.Drawing.Color.LightCoral;
            this.button_THOAT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_THOAT.Location = new System.Drawing.Point(690, 222);
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
            this.button_IN.Location = new System.Drawing.Point(567, 222);
            this.button_IN.Margin = new System.Windows.Forms.Padding(4);
            this.button_IN.Name = "button_IN";
            this.button_IN.Size = new System.Drawing.Size(100, 52);
            this.button_IN.TabIndex = 6;
            this.button_IN.Text = "IN";
            this.button_IN.UseVisualStyleBackColor = false;
            this.button_IN.Click += new System.EventHandler(this.button_IN_Click);
            // 
            // label_TenLop
            // 
            this.label_TenLop.AutoSize = true;
            this.label_TenLop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenLop.Location = new System.Drawing.Point(257, 133);
            this.label_TenLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TenLop.Name = "label_TenLop";
            this.label_TenLop.Size = new System.Drawing.Size(43, 23);
            this.label_TenLop.TabIndex = 3;
            this.label_TenLop.Text = "LỚP";
            // 
            // label_Khoa
            // 
            this.label_Khoa.AutoSize = true;
            this.label_Khoa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Khoa.Location = new System.Drawing.Point(246, 32);
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
            this.cmbKhoa.Location = new System.Drawing.Point(308, 28);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(469, 27);
            this.cmbKhoa.TabIndex = 0;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbLOPTableAdapter
            // 
            this.cmbLOPTableAdapter.ClearBeforeFill = true;
            // 
            // fmpt_DIEMTONGKET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 438);
            this.Controls.Add(this.panelPD);
            this.Name = "fmpt_DIEMTONGKET";
            this.Text = "fmpt_DIEMTONGKET";
            this.Load += new System.EventHandler(this.fmpt_DIEMTONGKET_Load);
            this.panelPD.ResumeLayout(false);
            this.panelPD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPD;
        private System.Windows.Forms.Button button_THOAT;
        private System.Windows.Forms.Button button_IN;
        private System.Windows.Forms.Label label_TenLop;
        private System.Windows.Forms.Label label_Khoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource cmbLOPBindingSource;
        private DS dS;
        private DSTableAdapters.cmbLOPTableAdapter cmbLOPTableAdapter;
        private System.Windows.Forms.ComboBox cmbLop;
    }
}