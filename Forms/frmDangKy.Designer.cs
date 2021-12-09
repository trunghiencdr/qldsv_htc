namespace QLDSV.Forms
{
    partial class frmDangKy
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessageError = new System.Windows.Forms.Label();
            this.lblErrorRoles = new System.Windows.Forms.Label();
            this.lblError_MaGV = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Label();
            this.lblError_RePassword = new System.Windows.Forms.Label();
            this.lblError_Password = new System.Windows.Forms.Label();
            this.lblErorr_LoginName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ckboxShow = new System.Windows.Forms.CheckBox();
            this.radioButtonPKT = new System.Windows.Forms.RadioButton();
            this.radioButtonKhoa = new System.Windows.Forms.RadioButton();
            this.radioButtonPGV = new System.Windows.Forms.RadioButton();
            this.radioGroupRoles = new DevExpress.XtraEditors.RadioGroup();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lookUpEditMaGV = new DevExpress.XtraEditors.LookUpEdit();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.btnCreateLogin = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bdsGIANGVIEN = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.GIANGVIENTableAdapter = new QLDSV.DSTableAdapters.GIANGVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupRoles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGIANGVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1534, 728);
            this.panelControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lblMessageError);
            this.panel1.Controls.Add(this.lblErrorRoles);
            this.panel1.Controls.Add(this.lblError_MaGV);
            this.panel1.Controls.Add(this.lblAlert);
            this.panel1.Controls.Add(this.lblError_RePassword);
            this.panel1.Controls.Add(this.lblError_Password);
            this.panel1.Controls.Add(this.lblErorr_LoginName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ckboxShow);
            this.panel1.Controls.Add(this.radioButtonPKT);
            this.panel1.Controls.Add(this.radioButtonKhoa);
            this.panel1.Controls.Add(this.radioButtonPGV);
            this.panel1.Controls.Add(this.radioGroupRoles);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lookUpEditMaGV);
            this.panel1.Controls.Add(this.txtRePassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtLoginName);
            this.panel1.Controls.Add(this.btnCreateLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1530, 724);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblMessageError
            // 
            this.lblMessageError.BackColor = System.Drawing.Color.Salmon;
            this.lblMessageError.ForeColor = System.Drawing.Color.Transparent;
            this.lblMessageError.Location = new System.Drawing.Point(188, 124);
            this.lblMessageError.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMessageError.Name = "lblMessageError";
            this.lblMessageError.Size = new System.Drawing.Size(726, 40);
            this.lblMessageError.TabIndex = 25;
            this.lblMessageError.Text = "Error Text";
            this.lblMessageError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessageError.Visible = false;
            // 
            // lblErrorRoles
            // 
            this.lblErrorRoles.Image = global::QLDSV.Properties.Resources.error_24px;
            this.lblErrorRoles.Location = new System.Drawing.Point(816, 357);
            this.lblErrorRoles.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblErrorRoles.Name = "lblErrorRoles";
            this.lblErrorRoles.Size = new System.Drawing.Size(49, 42);
            this.lblErrorRoles.TabIndex = 23;
            this.lblErrorRoles.Visible = false;
            // 
            // lblError_MaGV
            // 
            this.lblError_MaGV.Image = global::QLDSV.Properties.Resources.error_24px;
            this.lblError_MaGV.Location = new System.Drawing.Point(816, 315);
            this.lblError_MaGV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblError_MaGV.Name = "lblError_MaGV";
            this.lblError_MaGV.Size = new System.Drawing.Size(49, 32);
            this.lblError_MaGV.TabIndex = 22;
            this.lblError_MaGV.Visible = false;
            this.lblError_MaGV.Click += new System.EventHandler(this.lblError_MaGV_Click);
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.Red;
            this.lblAlert.Location = new System.Drawing.Point(390, 288);
            this.lblAlert.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(181, 17);
            this.lblAlert.TabIndex = 21;
            this.lblAlert.Text = "Mật khẩu không trùng khớp";
            this.lblAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlert.Visible = false;
            // 
            // lblError_RePassword
            // 
            this.lblError_RePassword.Image = global::QLDSV.Properties.Resources.error_24px;
            this.lblError_RePassword.Location = new System.Drawing.Point(815, 246);
            this.lblError_RePassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblError_RePassword.Name = "lblError_RePassword";
            this.lblError_RePassword.Size = new System.Drawing.Size(50, 27);
            this.lblError_RePassword.TabIndex = 20;
            this.lblError_RePassword.Visible = false;
            // 
            // lblError_Password
            // 
            this.lblError_Password.Image = global::QLDSV.Properties.Resources.error_24px;
            this.lblError_Password.Location = new System.Drawing.Point(814, 209);
            this.lblError_Password.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblError_Password.Name = "lblError_Password";
            this.lblError_Password.Size = new System.Drawing.Size(50, 27);
            this.lblError_Password.TabIndex = 19;
            this.lblError_Password.Visible = false;
            // 
            // lblErorr_LoginName
            // 
            this.lblErorr_LoginName.Image = global::QLDSV.Properties.Resources.error_24px;
            this.lblErorr_LoginName.Location = new System.Drawing.Point(815, 164);
            this.lblErorr_LoginName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblErorr_LoginName.Name = "lblErorr_LoginName";
            this.lblErorr_LoginName.Size = new System.Drawing.Size(50, 35);
            this.lblErorr_LoginName.TabIndex = 18;
            this.toolTip1.SetToolTip(this.lblErorr_LoginName, "Tên đăng nhập bị đã có sẵn");
            this.lblErorr_LoginName.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Navy;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(479, 45);
            this.label7.TabIndex = 17;
            this.label7.Text = "TẠO TÀI KHOẢN";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckboxShow
            // 
            this.ckboxShow.AutoSize = true;
            this.ckboxShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxShow.Location = new System.Drawing.Point(887, 253);
            this.ckboxShow.Margin = new System.Windows.Forms.Padding(5);
            this.ckboxShow.Name = "ckboxShow";
            this.ckboxShow.Size = new System.Drawing.Size(68, 22);
            this.ckboxShow.TabIndex = 16;
            this.ckboxShow.Text = "Show";
            this.ckboxShow.UseVisualStyleBackColor = true;
            this.ckboxShow.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButtonPKT
            // 
            this.radioButtonPKT.AutoSize = true;
            this.radioButtonPKT.Location = new System.Drawing.Point(726, 372);
            this.radioButtonPKT.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonPKT.Name = "radioButtonPKT";
            this.radioButtonPKT.Size = new System.Drawing.Size(56, 21);
            this.radioButtonPKT.TabIndex = 15;
            this.radioButtonPKT.TabStop = true;
            this.radioButtonPKT.Text = "PKT";
            this.radioButtonPKT.UseVisualStyleBackColor = true;
            // 
            // radioButtonKhoa
            // 
            this.radioButtonKhoa.AutoSize = true;
            this.radioButtonKhoa.Location = new System.Drawing.Point(568, 372);
            this.radioButtonKhoa.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonKhoa.Name = "radioButtonKhoa";
            this.radioButtonKhoa.Size = new System.Drawing.Size(68, 21);
            this.radioButtonKhoa.TabIndex = 14;
            this.radioButtonKhoa.TabStop = true;
            this.radioButtonKhoa.Text = "KHOA";
            this.radioButtonKhoa.UseVisualStyleBackColor = true;
            // 
            // radioButtonPGV
            // 
            this.radioButtonPGV.AutoSize = true;
            this.radioButtonPGV.Location = new System.Drawing.Point(433, 372);
            this.radioButtonPGV.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonPGV.Name = "radioButtonPGV";
            this.radioButtonPGV.Size = new System.Drawing.Size(58, 21);
            this.radioButtonPGV.TabIndex = 13;
            this.radioButtonPGV.TabStop = true;
            this.radioButtonPGV.Text = "PGV";
            this.radioButtonPGV.UseVisualStyleBackColor = true;
            // 
            // radioGroupRoles
            // 
            this.radioGroupRoles.Location = new System.Drawing.Point(391, 357);
            this.radioGroupRoles.Margin = new System.Windows.Forms.Padding(5);
            this.radioGroupRoles.Name = "radioGroupRoles";
            this.radioGroupRoles.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupRoles.Size = new System.Drawing.Size(414, 62);
            this.radioGroupRoles.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 369);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Khoa/Phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 327);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Chọn mã giảng viên:";
            // 
            // lookUpEditMaGV
            // 
            this.lookUpEditMaGV.Location = new System.Drawing.Point(393, 321);
            this.lookUpEditMaGV.Margin = new System.Windows.Forms.Padding(5);
            this.lookUpEditMaGV.Name = "lookUpEditMaGV";
            this.lookUpEditMaGV.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditMaGV.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditMaGV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMaGV.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAGV", "MAGV", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEditMaGV.Properties.DataSource = this.bdsGIANGVIEN;
            this.lookUpEditMaGV.Properties.DisplayMember = "MAGV";
            this.lookUpEditMaGV.Properties.NullText = "";
            this.lookUpEditMaGV.Properties.ValueMember = "MAGV";
            this.lookUpEditMaGV.Size = new System.Drawing.Size(412, 26);
            this.lookUpEditMaGV.TabIndex = 9;
            // 
            // txtRePassword
            // 
            this.txtRePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePassword.Location = new System.Drawing.Point(393, 246);
            this.txtRePassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(413, 27);
            this.txtRePassword.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhập lại mật khẩu:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(392, 209);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(413, 27);
            this.txtPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu:";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(623, 438);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 45);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtLoginName
            // 
            this.txtLoginName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginName.Location = new System.Drawing.Point(392, 172);
            this.txtLoginName.Margin = new System.Windows.Forms.Padding(5);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(413, 27);
            this.txtLoginName.TabIndex = 2;
            // 
            // btnCreateLogin
            // 
            this.btnCreateLogin.Appearance.BackColor = System.Drawing.Color.Navy;
            this.btnCreateLogin.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateLogin.Appearance.Options.UseBackColor = true;
            this.btnCreateLogin.Appearance.Options.UseFont = true;
            this.btnCreateLogin.Location = new System.Drawing.Point(361, 438);
            this.btnCreateLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreateLogin.Name = "btnCreateLogin";
            this.btnCreateLogin.Size = new System.Drawing.Size(235, 45);
            this.btnCreateLogin.TabIndex = 0;
            this.btnCreateLogin.Text = "Tạo tài khoản";
            this.btnCreateLogin.Click += new System.EventHandler(this.btnCreateLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bdsGIANGVIEN
            // 
            this.bdsGIANGVIEN.DataMember = "GIANGVIEN";
            this.bdsGIANGVIEN.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GIANGVIENTableAdapter
            // 
            this.GIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 666);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmDangKy";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupRoles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGIANGVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCreateLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditMaGV;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsGIANGVIEN;
        private DSTableAdapters.GIANGVIENTableAdapter GIANGVIENTableAdapter;
        private System.Windows.Forms.RadioButton radioButtonPKT;
        private System.Windows.Forms.RadioButton radioButtonKhoa;
        private System.Windows.Forms.RadioButton radioButtonPGV;
        private DevExpress.XtraEditors.RadioGroup radioGroupRoles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckboxShow;
        private System.Windows.Forms.Label lblErorr_LoginName;
        private System.Windows.Forms.Label lblError_RePassword;
        private System.Windows.Forms.Label lblError_Password;
        private System.Windows.Forms.Label lblErrorRoles;
        private System.Windows.Forms.Label lblError_MaGV;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblMessageError;
    }
}