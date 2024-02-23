namespace DoAn
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btbDangXuat = new System.Windows.Forms.Button();
            this.panelChitiet = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnLuuFile = new System.Windows.Forms.Button();
            this.btnLopHoc = new System.Windows.Forms.Button();
            this.btnMonHoc = new System.Windows.Forms.Button();
            this.btnGiangVien = new System.Windows.Forms.Button();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panelChitiet.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btbDangXuat);
            this.panel1.Controls.Add(this.panelChitiet);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnChiTiet);
            this.panel1.Controls.Add(this.btnLuuFile);
            this.panel1.Controls.Add(this.btnLopHoc);
            this.panel1.Controls.Add(this.btnMonHoc);
            this.panel1.Controls.Add(this.btnGiangVien);
            this.panel1.Controls.Add(this.btnSinhVien);
            this.panel1.Controls.Add(this.btnTrangChu);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 667);
            this.panel1.TabIndex = 0;
            // 
            // btbDangXuat
            // 
            this.btbDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btbDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbDangXuat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btbDangXuat.Image")));
            this.btbDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbDangXuat.Location = new System.Drawing.Point(12, 585);
            this.btbDangXuat.Name = "btbDangXuat";
            this.btbDangXuat.Size = new System.Drawing.Size(222, 36);
            this.btbDangXuat.TabIndex = 46;
            this.btbDangXuat.Text = "&Đăng xuất";
            this.btbDangXuat.UseVisualStyleBackColor = true;
            this.btbDangXuat.Click += new System.EventHandler(this.btbDangXuat_Click);
            // 
            // panelChitiet
            // 
            this.panelChitiet.Controls.Add(this.btnXem);
            this.panelChitiet.Controls.Add(this.btnChon);
            this.panelChitiet.Location = new System.Drawing.Point(12, 303);
            this.panelChitiet.Name = "panelChitiet";
            this.panelChitiet.Size = new System.Drawing.Size(220, 75);
            this.panelChitiet.TabIndex = 37;
            // 
            // btnXem
            // 
            this.btnXem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXem.Image = global::DoAn.Properties.Resources.icons8_show_property_20;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(0, 36);
            this.btnXem.Name = "btnXem";
            this.btnXem.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnXem.Size = new System.Drawing.Size(220, 36);
            this.btnXem.TabIndex = 41;
            this.btnXem.Text = "X&em lớp học";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnChon
            // 
            this.btnChon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChon.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.Image")));
            this.btnChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChon.Location = new System.Drawing.Point(0, 0);
            this.btnChon.Name = "btnChon";
            this.btnChon.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnChon.Size = new System.Drawing.Size(220, 36);
            this.btnChon.TabIndex = 38;
            this.btnChon.Text = "Tìm &sinh viên";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::DoAn.Properties.Resources.icons8_emergency_exit_30;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(12, 627);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(222, 36);
            this.btnThoat.TabIndex = 47;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 36);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "MENU";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChiTiet.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.Image = global::DoAn.Properties.Resources.icons8_more_details_30;
            this.btnChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiTiet.Location = new System.Drawing.Point(10, 270);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(222, 36);
            this.btnChiTiet.TabIndex = 37;
            this.btnChiTiet.Text = "&Chi tiết lớp học";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnLuuFile
            // 
            this.btnLuuFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuuFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuFile.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuFile.Image = global::DoAn.Properties.Resources.icons8_save_30;
            this.btnLuuFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuFile.Location = new System.Drawing.Point(12, 543);
            this.btnLuuFile.Name = "btnLuuFile";
            this.btnLuuFile.Size = new System.Drawing.Size(222, 36);
            this.btnLuuFile.TabIndex = 45;
            this.btnLuuFile.Text = "Lưu &File";
            this.btnLuuFile.UseVisualStyleBackColor = true;
            this.btnLuuFile.Click += new System.EventHandler(this.btnLuuFile_Click);
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopHoc.Image = global::DoAn.Properties.Resources.icons8_classroom_30;
            this.btnLopHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLopHoc.Location = new System.Drawing.Point(12, 228);
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.Size = new System.Drawing.Size(222, 36);
            this.btnLopHoc.TabIndex = 30;
            this.btnLopHoc.Text = "&Lớp học";
            this.btnLopHoc.UseVisualStyleBackColor = true;
            this.btnLopHoc.Click += new System.EventHandler(this.btnLopHoc_Click);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonHoc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonHoc.Image = global::DoAn.Properties.Resources.icons8_subjects_30;
            this.btnMonHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonHoc.Location = new System.Drawing.Point(10, 186);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Size = new System.Drawing.Size(222, 36);
            this.btnMonHoc.TabIndex = 20;
            this.btnMonHoc.Text = "&Môn học";
            this.btnMonHoc.UseVisualStyleBackColor = true;
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiangVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiangVien.Image = global::DoAn.Properties.Resources.icons8_teachers_30;
            this.btnGiangVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiangVien.Location = new System.Drawing.Point(12, 144);
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.Size = new System.Drawing.Size(222, 36);
            this.btnGiangVien.TabIndex = 12;
            this.btnGiangVien.Text = "&Giảng viên";
            this.btnGiangVien.UseVisualStyleBackColor = true;
            this.btnGiangVien.Click += new System.EventHandler(this.btnGiangVien_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinhVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhVien.Image = global::DoAn.Properties.Resources.icons8_person_student_30;
            this.btnSinhVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinhVien.Location = new System.Drawing.Point(10, 102);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(222, 36);
            this.btnSinhVien.TabIndex = 1;
            this.btnSinhVien.Text = "S&inh viên";
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangChu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTrangChu.Image = global::DoAn.Properties.Resources.icons8_home_page_30;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(10, 60);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(222, 36);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "Trang c&hủ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(251, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1153, 614);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1145, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trang chủ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1416, 677);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1434, 724);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panelChitiet.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLopHoc;
        private System.Windows.Forms.Button btnMonHoc;
        private System.Windows.Forms.Button btnGiangVien;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnLuuFile;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panelChitiet;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btbDangXuat;
    }
}

