namespace DoAn
{
    partial class FormMonHoc
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
            this.dgvMH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.nudSoTietLT = new System.Windows.Forms.NumericUpDown();
            this.nudSoTietTH = new System.Windows.Forms.NumericUpDown();
            this.nudSoTC = new System.Windows.Forms.NumericUpDown();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.lblSoTietLT = new System.Windows.Forms.Label();
            this.lblSoTietTH = new System.Windows.Forms.Label();
            this.lblSoTC = new System.Windows.Forms.Label();
            this.lblTenMH = new System.Windows.Forms.Label();
            this.lblMaMH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMH)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTietLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTietTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMH
            // 
            this.dgvMH.AllowUserToAddRows = false;
            this.dgvMH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvMH.Location = new System.Drawing.Point(12, 215);
            this.dgvMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMH.MultiSelect = false;
            this.dgvMH.Name = "dgvMH";
            this.dgvMH.ReadOnly = true;
            this.dgvMH.RowHeadersWidth = 51;
            this.dgvMH.RowTemplate.Height = 29;
            this.dgvMH.Size = new System.Drawing.Size(835, 249);
            this.dgvMH.TabIndex = 29;
            this.dgvMH.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMH_RowEnter);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaMH";
            this.Column1.HeaderText = "Mã môn học";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenMH";
            this.Column2.HeaderText = "Tên môn học";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "SoTC";
            this.Column3.HeaderText = "Số tín chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "SoTietTH";
            this.Column4.HeaderText = "Sô tiết thực hành";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "SoTietLT";
            this.Column5.HeaderText = "Số tiết lý thuyết";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "MÔN HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 28);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.nudSoTietLT);
            this.panel2.Controls.Add(this.nudSoTietTH);
            this.panel2.Controls.Add(this.nudSoTC);
            this.panel2.Controls.Add(this.txtTenMH);
            this.panel2.Controls.Add(this.txtMaMH);
            this.panel2.Controls.Add(this.lblSoTietLT);
            this.panel2.Controls.Add(this.lblSoTietTH);
            this.panel2.Controls.Add(this.lblSoTC);
            this.panel2.Controls.Add(this.lblTenMH);
            this.panel2.Controls.Add(this.lblMaMH);
            this.panel2.Location = new System.Drawing.Point(12, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 164);
            this.panel2.TabIndex = 28;
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Red;
            this.btnSua.Image = global::DoAn.Properties.Resources.icons8_programmer_fixing_issues_20;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(704, 112);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 30);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Image = global::DoAn.Properties.Resources.icons8_remove_20;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(704, 68);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 30);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Image = global::DoAn.Properties.Resources.icons8_add_new_20;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(704, 25);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 30);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // nudSoTietLT
            // 
            this.nudSoTietLT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudSoTietLT.Location = new System.Drawing.Point(491, 66);
            this.nudSoTietLT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSoTietLT.Name = "nudSoTietLT";
            this.nudSoTietLT.Size = new System.Drawing.Size(162, 22);
            this.nudSoTietLT.TabIndex = 25;
            // 
            // nudSoTietTH
            // 
            this.nudSoTietTH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudSoTietTH.Location = new System.Drawing.Point(491, 24);
            this.nudSoTietTH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSoTietTH.Name = "nudSoTietTH";
            this.nudSoTietTH.Size = new System.Drawing.Size(162, 22);
            this.nudSoTietTH.TabIndex = 24;
            // 
            // nudSoTC
            // 
            this.nudSoTC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudSoTC.Location = new System.Drawing.Point(133, 119);
            this.nudSoTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSoTC.Name = "nudSoTC";
            this.nudSoTC.Size = new System.Drawing.Size(178, 22);
            this.nudSoTC.TabIndex = 23;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMH.Location = new System.Drawing.Point(133, 68);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(178, 22);
            this.txtTenMH.TabIndex = 22;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaMH.Location = new System.Drawing.Point(133, 25);
            this.txtMaMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaMH.MaxLength = 7;
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(178, 22);
            this.txtMaMH.TabIndex = 21;
            this.txtMaMH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaMH_KeyPress);
            // 
            // lblSoTietLT
            // 
            this.lblSoTietLT.AutoSize = true;
            this.lblSoTietLT.BackColor = System.Drawing.SystemColors.Control;
            this.lblSoTietLT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTietLT.ForeColor = System.Drawing.Color.Blue;
            this.lblSoTietLT.Location = new System.Drawing.Point(358, 72);
            this.lblSoTietLT.Name = "lblSoTietLT";
            this.lblSoTietLT.Size = new System.Drawing.Size(115, 17);
            this.lblSoTietLT.TabIndex = 27;
            this.lblSoTietLT.Text = "Số tiết lý thuyết:";
            // 
            // lblSoTietTH
            // 
            this.lblSoTietTH.AutoSize = true;
            this.lblSoTietTH.BackColor = System.Drawing.SystemColors.Control;
            this.lblSoTietTH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTietTH.ForeColor = System.Drawing.Color.Blue;
            this.lblSoTietTH.Location = new System.Drawing.Point(349, 30);
            this.lblSoTietTH.Name = "lblSoTietTH";
            this.lblSoTietTH.Size = new System.Drawing.Size(123, 17);
            this.lblSoTietTH.TabIndex = 28;
            this.lblSoTietTH.Text = "Số tiết thực hành:";
            // 
            // lblSoTC
            // 
            this.lblSoTC.AutoSize = true;
            this.lblSoTC.BackColor = System.Drawing.SystemColors.Control;
            this.lblSoTC.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTC.ForeColor = System.Drawing.Color.Blue;
            this.lblSoTC.Location = new System.Drawing.Point(10, 119);
            this.lblSoTC.Name = "lblSoTC";
            this.lblSoTC.Size = new System.Drawing.Size(73, 17);
            this.lblSoTC.TabIndex = 29;
            this.lblSoTC.Text = "Số tín chỉ:";
            // 
            // lblTenMH
            // 
            this.lblTenMH.AutoSize = true;
            this.lblTenMH.BackColor = System.Drawing.SystemColors.Control;
            this.lblTenMH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMH.ForeColor = System.Drawing.Color.Blue;
            this.lblTenMH.Location = new System.Drawing.Point(10, 69);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(98, 17);
            this.lblTenMH.TabIndex = 30;
            this.lblTenMH.Text = "Tên môn học:";
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaMH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMH.ForeColor = System.Drawing.Color.Blue;
            this.lblMaMH.Location = new System.Drawing.Point(10, 25);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(94, 17);
            this.lblMaMH.TabIndex = 31;
            this.lblMaMH.Text = "Mã môn học:";
            // 
            // FormMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(859, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMH);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMonHoc";
            this.Load += new System.EventHandler(this.FormMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTietLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTietTH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudSoTietLT;
        private System.Windows.Forms.NumericUpDown nudSoTietTH;
        private System.Windows.Forms.NumericUpDown nudSoTC;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label lblSoTietLT;
        private System.Windows.Forms.Label lblSoTietTH;
        private System.Windows.Forms.Label lblSoTC;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}