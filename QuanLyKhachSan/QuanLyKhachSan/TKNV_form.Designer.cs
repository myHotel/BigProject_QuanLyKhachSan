namespace QuanLyKhachSan
{
    partial class TKNV_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TKNV_form));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboGioiTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbnam = new DevComponents.Editors.ComboItem();
            this.cbnu = new DevComponents.Editors.ComboItem();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.labelX21 = new DevComponents.DotNetBar.LabelX();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.labelX19 = new DevComponents.DotNetBar.LabelX();
            this.labelX18 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lblChucVu = new DevComponents.DotNetBar.LabelX();
            this.txtTNV = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnChinhSuaTT = new DevComponents.DotNetBar.ButtonX();
            this.btnLuuTT = new DevComponents.DotNetBar.ButtonX();
            this.lblManv = new DevComponents.DotNetBar.LabelX();
            this.lblTaiKhoan = new DevComponents.DotNetBar.LabelX();
            this.lblMatKhau = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Red;
            this.labelX1.Location = new System.Drawing.Point(192, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(229, 41);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Thông tin tài khoản nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMatKhau);
            this.groupBox1.Controls.Add(this.lblTaiKhoan);
            this.groupBox1.Controls.Add(this.lblManv);
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.labelX21);
            this.groupBox1.Controls.Add(this.labelX20);
            this.groupBox1.Controls.Add(this.labelX19);
            this.groupBox1.Controls.Add(this.labelX18);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX12);
            this.groupBox1.Controls.Add(this.labelX10);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.lblChucVu);
            this.groupBox1.Controls.Add(this.txtTNV);
            this.groupBox1.Controls.Add(this.txtDC);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Location = new System.Drawing.Point(1, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 314);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DisplayMember = "Text";
            this.cboGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.ItemHeight = 14;
            this.cboGioiTinh.Items.AddRange(new object[] {
            this.cbnam,
            this.cbnu});
            this.cboGioiTinh.Location = new System.Drawing.Point(138, 163);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(128, 20);
            this.cboGioiTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboGioiTinh.TabIndex = 63;
            // 
            // cbnam
            // 
            this.cbnam.Text = "Nam";
            // 
            // cbnu
            // 
            this.cbnu.Text = "Nữ";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "\'Ngày \'dd - \'Tháng\' MM - \'Năm\'  yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(138, 135);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(233, 20);
            this.dtpNgaySinh.TabIndex = 62;
            // 
            // labelX21
            // 
            // 
            // 
            // 
            this.labelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX21.Location = new System.Drawing.Point(39, 16);
            this.labelX21.Name = "labelX21";
            this.labelX21.Size = new System.Drawing.Size(92, 21);
            this.labelX21.TabIndex = 43;
            this.labelX21.Text = "Mã nhân viên";
            // 
            // labelX20
            // 
            // 
            // 
            // 
            this.labelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX20.Location = new System.Drawing.Point(39, 43);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(92, 22);
            this.labelX20.TabIndex = 51;
            this.labelX20.Text = "Tên nhân viên";
            // 
            // labelX19
            // 
            // 
            // 
            // 
            this.labelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX19.Location = new System.Drawing.Point(39, 71);
            this.labelX19.Name = "labelX19";
            this.labelX19.Size = new System.Drawing.Size(92, 23);
            this.labelX19.TabIndex = 50;
            this.labelX19.Text = "Tài khoản";
            // 
            // labelX18
            // 
            // 
            // 
            // 
            this.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX18.Location = new System.Drawing.Point(39, 103);
            this.labelX18.Name = "labelX18";
            this.labelX18.Size = new System.Drawing.Size(92, 23);
            this.labelX18.TabIndex = 49;
            this.labelX18.Text = "Mật khẩu";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(39, 133);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(92, 23);
            this.labelX5.TabIndex = 48;
            this.labelX5.Text = "Ngày sinh";
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(39, 162);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(92, 23);
            this.labelX12.TabIndex = 47;
            this.labelX12.Text = "Giới tính";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(39, 193);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(92, 23);
            this.labelX10.TabIndex = 46;
            this.labelX10.Text = "Địa chỉ";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(39, 222);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(92, 23);
            this.labelX8.TabIndex = 45;
            this.labelX8.Text = "Số điện thoại";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(39, 254);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(92, 20);
            this.labelX6.TabIndex = 44;
            this.labelX6.Text = "CMND";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(39, 280);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(92, 19);
            this.labelX3.TabIndex = 52;
            this.labelX3.Text = "Chức vụ";
            // 
            // lblChucVu
            // 
            // 
            // 
            // 
            this.lblChucVu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.ForeColor = System.Drawing.Color.Green;
            this.lblChucVu.Location = new System.Drawing.Point(137, 282);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(420, 19);
            this.lblChucVu.TabIndex = 53;
            this.lblChucVu.Text = "...";
            // 
            // txtTNV
            // 
            this.txtTNV.Location = new System.Drawing.Point(137, 45);
            this.txtTNV.Multiline = true;
            this.txtTNV.Name = "txtTNV";
            this.txtTNV.ReadOnly = true;
            this.txtTNV.Size = new System.Drawing.Size(420, 21);
            this.txtTNV.TabIndex = 55;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(137, 195);
            this.txtDC.Multiline = true;
            this.txtDC.Name = "txtDC";
            this.txtDC.ReadOnly = true;
            this.txtDC.Size = new System.Drawing.Size(420, 21);
            this.txtDC.TabIndex = 59;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(137, 224);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(420, 21);
            this.txtSDT.TabIndex = 60;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(137, 256);
            this.txtCMND.Multiline = true;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.ReadOnly = true;
            this.txtCMND.Size = new System.Drawing.Size(420, 20);
            this.txtCMND.TabIndex = 61;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(94, 379);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(133, 41);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "Trở về";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnChinhSuaTT
            // 
            this.btnChinhSuaTT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChinhSuaTT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChinhSuaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSuaTT.Location = new System.Drawing.Point(378, 379);
            this.btnChinhSuaTT.Name = "btnChinhSuaTT";
            this.btnChinhSuaTT.Size = new System.Drawing.Size(125, 40);
            this.btnChinhSuaTT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChinhSuaTT.TabIndex = 4;
            this.btnChinhSuaTT.Text = "Chỉnh sửa thông tin";
            this.btnChinhSuaTT.Click += new System.EventHandler(this.btnChinhSuaTT_Click);
            // 
            // btnLuuTT
            // 
            this.btnLuuTT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuTT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuuTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTT.Location = new System.Drawing.Point(233, 379);
            this.btnLuuTT.Name = "btnLuuTT";
            this.btnLuuTT.Size = new System.Drawing.Size(139, 40);
            this.btnLuuTT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuuTT.TabIndex = 5;
            this.btnLuuTT.Text = "Lưu";
            this.btnLuuTT.Click += new System.EventHandler(this.btnLuuTT_Click);
            // 
            // lblManv
            // 
            // 
            // 
            // 
            this.lblManv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblManv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManv.ForeColor = System.Drawing.Color.Red;
            this.lblManv.Location = new System.Drawing.Point(137, 16);
            this.lblManv.Name = "lblManv";
            this.lblManv.Size = new System.Drawing.Size(190, 23);
            this.lblManv.TabIndex = 64;
            this.lblManv.Text = "...";
            // 
            // lblTaiKhoan
            // 
            // 
            // 
            // 
            this.lblTaiKhoan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Location = new System.Drawing.Point(138, 73);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(419, 23);
            this.lblTaiKhoan.TabIndex = 65;
            this.lblTaiKhoan.Text = "...";
            // 
            // lblMatKhau
            // 
            // 
            // 
            // 
            this.lblMatKhau.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(138, 103);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(419, 23);
            this.lblMatKhau.TabIndex = 66;
            this.lblMatKhau.Text = "...";
            // 
            // TKNV_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(596, 423);
            this.Controls.Add(this.btnLuuTT);
            this.Controls.Add(this.btnChinhSuaTT);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TKNV_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.TKNV_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btnChinhSuaTT;
        private DevComponents.DotNetBar.ButtonX btnLuuTT;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private DevComponents.DotNetBar.LabelX labelX21;
        private DevComponents.DotNetBar.LabelX labelX20;
        private DevComponents.DotNetBar.LabelX labelX19;
        private DevComponents.DotNetBar.LabelX labelX18;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lblChucVu;
        private System.Windows.Forms.TextBox txtTNV;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboGioiTinh;
        private DevComponents.Editors.ComboItem cbnam;
        private DevComponents.Editors.ComboItem cbnu;
        private DevComponents.DotNetBar.LabelX lblManv;
        private DevComponents.DotNetBar.LabelX lblMatKhau;
        private DevComponents.DotNetBar.LabelX lblTaiKhoan;
    }
}