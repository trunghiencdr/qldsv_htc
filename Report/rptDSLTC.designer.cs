
namespace QLDSV.Report
{
    partial class rptDSLTC
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
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNienkhoa = new System.Windows.Forms.ComboBox();
            this.cmbHocki = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(205, 60);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(142, 21);
            this.cmbKhoa.TabIndex = 0;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            this.cmbKhoa.Click += new System.EventHandler(this.cmbKhoa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(118, 63);
            this.lblTenKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(37, 13);
            this.lblTenKhoa.TabIndex = 4;
            this.lblTenKhoa.Text = "KHOA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Niên khóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Học kì";
            // 
            // cmbNienkhoa
            // 
            this.cmbNienkhoa.FormattingEnabled = true;
            this.cmbNienkhoa.Location = new System.Drawing.Point(205, 110);
            this.cmbNienkhoa.Name = "cmbNienkhoa";
            this.cmbNienkhoa.Size = new System.Drawing.Size(142, 21);
            this.cmbNienkhoa.TabIndex = 8;
            this.cmbNienkhoa.SelectedIndexChanged += new System.EventHandler(this.cmbNienkhoa_SelectedIndexChanged);
            // 
            // cmbHocki
            // 
            this.cmbHocki.FormattingEnabled = true;
            this.cmbHocki.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHocki.Location = new System.Drawing.Point(205, 156);
            this.cmbHocki.Name = "cmbHocki";
            this.cmbHocki.Size = new System.Drawing.Size(142, 21);
            this.cmbHocki.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rptDSLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbHocki);
            this.Controls.Add(this.cmbNienkhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTenKhoa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbKhoa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "rptDSLTC";
            this.Text = "rptDSLTC";
            this.Load += new System.EventHandler(this.rptDSLTC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNienkhoa;
        private System.Windows.Forms.ComboBox cmbHocki;
        private System.Windows.Forms.Button button2;
    }
}