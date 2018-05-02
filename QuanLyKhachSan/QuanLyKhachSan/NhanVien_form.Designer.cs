namespace WindowsFormsApp1
{
    partial class NhanVien_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNhanVien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
<<<<<<< HEAD
            this.btnChonQuyen = new DevComponents.DotNetBar.ButtonX();
            this.rdbThongThuong = new System.Windows.Forms.RadioButton();
            this.rdbNhanVien = new System.Windows.Forms.RadioButton();
            this.rdbQuanLy = new System.Windows.Forms.RadioButton();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnXemChiTiet = new DevComponents.DotNetBar.ButtonX();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
=======
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            this.txtSDT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCMND = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtHoTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaNV = new DevComponents.DotNetBar.Controls.TextBoxX();
<<<<<<< HEAD
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
=======
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
<<<<<<< HEAD
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
=======
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.ribbonClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HOTEN,
            this.CMND,
            this.NGAYSINH,
            this.DIACHI,
            this.GIOITINH,
            this.SDT});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
<<<<<<< HEAD
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvNhanVien.Location = new System.Drawing.Point(461, 75);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanVien.Size = new System.Drawing.Size(766, 465);
=======
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvNhanVien.Location = new System.Drawing.Point(406, 60);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(821, 443);
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            this.dgvNhanVien.TabIndex = 1;
            this.dgvNhanVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_RowEnter);
            // 
            // MANV
            // 
            this.MANV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã NV";
            this.MANV.Name = "MANV";
<<<<<<< HEAD
            this.MANV.ReadOnly = true;
=======
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // HOTEN
            // 
            this.HOTEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ tên";
            this.HOTEN.Name = "HOTEN";
<<<<<<< HEAD
            this.HOTEN.ReadOnly = true;
=======
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // CMND
            // 
            this.CMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
<<<<<<< HEAD
            this.CMND.ReadOnly = true;
=======
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
<<<<<<< HEAD
            this.NGAYSINH.ReadOnly = true;
=======
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // DIACHI
            // 
            this.DIACHI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
<<<<<<< HEAD
            this.DIACHI.ReadOnly = true;
=======
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // GIOITINH
            // 
            this.GIOITINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
<<<<<<< HEAD
            this.GIOITINH.ReadOnly = true;
=======
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
<<<<<<< HEAD
            this.SDT.ReadOnly = true;
=======
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.groupPanel1.Controls.Add(this.btnChonQuyen);
            this.groupPanel1.Controls.Add(this.rdbThongThuong);
            this.groupPanel1.Controls.Add(this.rdbNhanVien);
            this.groupPanel1.Controls.Add(this.rdbQuanLy);
            this.groupPanel1.Controls.Add(this.ribbonClientPanel1);
            this.groupPanel1.Controls.Add(this.cboGioiTinh);
            this.groupPanel1.Controls.Add(this.dtpNgaySinh);
            this.groupPanel1.Controls.Add(this.txtMatKhau);
            this.groupPanel1.Controls.Add(this.txtSDT);
            this.groupPanel1.Controls.Add(this.txtDiaChi);
            this.groupPanel1.Controls.Add(this.txtCMND);
            this.groupPanel1.Controls.Add(this.txtHoTen);
            this.groupPanel1.Controls.Add(this.txtMaNV);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(1, 75);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(454, 465);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "Thông tin nhân viên";
            // 
<<<<<<< HEAD
            // btnChonQuyen
            // 
            this.btnChonQuyen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChonQuyen.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnChonQuyen.Location = new System.Drawing.Point(9, 397);
            this.btnChonQuyen.Name = "btnChonQuyen";
            this.btnChonQuyen.Size = new System.Drawing.Size(107, 28);
            this.btnChonQuyen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChonQuyen.TabIndex = 12;
            this.btnChonQuyen.Text = "Chọn quyền";
            this.btnChonQuyen.Click += new System.EventHandler(this.btnChonQuyen_Click);
            // 
            // rdbThongThuong
            // 
            this.rdbThongThuong.AutoSize = true;
            this.rdbThongThuong.ForeColor = System.Drawing.Color.Blue;
            this.rdbThongThuong.Location = new System.Drawing.Point(313, 357);
            this.rdbThongThuong.Name = "rdbThongThuong";
            this.rdbThongThuong.Size = new System.Drawing.Size(138, 25);
            this.rdbThongThuong.TabIndex = 11;
            this.rdbThongThuong.Text = "Thông thường";
            this.rdbThongThuong.UseVisualStyleBackColor = true;
            // 
            // rdbNhanVien
            // 
            this.rdbNhanVien.AutoSize = true;
            this.rdbNhanVien.ForeColor = System.Drawing.Color.Olive;
            this.rdbNhanVien.Location = new System.Drawing.Point(204, 357);
            this.rdbNhanVien.Name = "rdbNhanVien";
            this.rdbNhanVien.Size = new System.Drawing.Size(105, 25);
            this.rdbNhanVien.TabIndex = 11;
            this.rdbNhanVien.Text = "Nhân viên";
            this.rdbNhanVien.UseVisualStyleBackColor = true;
            // 
            // rdbQuanLy
            // 
            this.rdbQuanLy.AutoSize = true;
            this.rdbQuanLy.Checked = true;
            this.rdbQuanLy.ForeColor = System.Drawing.Color.Red;
            this.rdbQuanLy.Location = new System.Drawing.Point(110, 357);
            this.rdbQuanLy.Name = "rdbQuanLy";
            this.rdbQuanLy.Size = new System.Drawing.Size(87, 25);
            this.rdbQuanLy.TabIndex = 11;
            this.rdbQuanLy.TabStop = true;
            this.rdbQuanLy.Text = "Quản lý";
            this.rdbQuanLy.UseVisualStyleBackColor = true;
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.ribbonClientPanel1.Controls.Add(this.btnXoa);
            this.ribbonClientPanel1.Controls.Add(this.btnThem);
            this.ribbonClientPanel1.Controls.Add(this.btnXemChiTiet);
            this.ribbonClientPanel1.Location = new System.Drawing.Point(315, 32);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(117, 229);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonClientPanel1.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnXoa.Location = new System.Drawing.Point(14, 153);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 65);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnThem.Location = new System.Drawing.Point(14, 83);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 65);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXemChiTiet.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnXemChiTiet.Location = new System.Drawing.Point(14, 12);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(89, 65);
            this.btnXemChiTiet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXemChiTiet.TabIndex = 10;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(91, 267);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(341, 29);
            this.cboGioiTinh.TabIndex = 9;
            // 
            // dtpNgaySinh
            // 
            // 
            // 
            // 
            this.dtpNgaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgaySinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpNgaySinh.ButtonDropDown.Visible = true;
            this.dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
            this.dtpNgaySinh.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtpNgaySinh.IsPopupCalendarOpen = false;
            this.dtpNgaySinh.Location = new System.Drawing.Point(93, 175);
=======
            // cboGioiTinh
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(91, 267);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(290, 23);
            this.cboGioiTinh.TabIndex = 9;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
<<<<<<< HEAD
            this.dtpNgaySinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgaySinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpNgaySinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpNgaySinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpNgaySinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgaySinh.MonthCalendar.TodayButtonVisible = true;
            this.dtpNgaySinh.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(216, 29);
            this.dtpNgaySinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpNgaySinh.TabIndex = 8;
=======
            this.dtpNgaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgaySinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpNgaySinh.ButtonDropDown.Visible = true;
            this.dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
            this.dtpNgaySinh.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtpNgaySinh.IsPopupCalendarOpen = false;
            this.dtpNgaySinh.Location = new System.Drawing.Point(91, 175);
            // 
            // 
            // 
            this.dtpNgaySinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpNgaySinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgaySinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpNgaySinh.MonthCalendar.ClearButtonVisible = true;
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // txtMatKhau
            // 
<<<<<<< HEAD
            this.txtMatKhau.BackColor = System.Drawing.Color.White;
            // 
=======
            // 
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpNgaySinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // 
            this.txtMatKhau.Border.Class = "TextBoxBorder";
            this.txtMatKhau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.Location = new System.Drawing.Point(249, 397);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(196, 29);
            this.txtMatKhau.TabIndex = 7;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
<<<<<<< HEAD
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
=======
            this.dtpNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpNgaySinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgaySinh.MonthCalendar.TodayButtonVisible = true;
            this.dtpNgaySinh.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(290, 21);
            this.dtpNgaySinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpNgaySinh.TabIndex = 8;
            // 
            // txtSDT
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // 
            // 
            this.txtSDT.Border.Class = "TextBoxBorder";
            this.txtSDT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.Location = new System.Drawing.Point(89, 315);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(343, 29);
            this.txtSDT.TabIndex = 7;
            // 
<<<<<<< HEAD
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(93, 221);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(216, 29);
=======
            this.txtSDT.Border.Class = "TextBoxBorder";
            this.txtSDT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSDT.Location = new System.Drawing.Point(93, 315);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(290, 21);
            this.txtSDT.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChi.Location = new System.Drawing.Point(93, 221);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(290, 21);
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtCMND
            // 
<<<<<<< HEAD
            this.txtCMND.BackColor = System.Drawing.Color.White;
=======
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // 
            // 
            this.txtCMND.Border.Class = "TextBoxBorder";
            this.txtCMND.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
<<<<<<< HEAD
            this.txtCMND.ForeColor = System.Drawing.Color.Black;
            this.txtCMND.Location = new System.Drawing.Point(93, 129);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(216, 29);
=======
            this.txtCMND.Location = new System.Drawing.Point(93, 129);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(290, 21);
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            this.txtCMND.TabIndex = 7;
            // 
            // txtHoTen
            // 
<<<<<<< HEAD
            this.txtHoTen.BackColor = System.Drawing.Color.White;
=======
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // 
            // 
            this.txtHoTen.Border.Class = "TextBoxBorder";
            this.txtHoTen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
<<<<<<< HEAD
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(93, 83);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(216, 29);
=======
            this.txtHoTen.Location = new System.Drawing.Point(93, 83);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(290, 21);
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            this.txtHoTen.TabIndex = 7;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMaNV.Border.Class = "TextBoxBorder";
            this.txtMaNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNV.ForeColor = System.Drawing.Color.Black;
            this.txtMaNV.Location = new System.Drawing.Point(93, 32);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(216, 29);
            this.txtMaNV.TabIndex = 7;
            // 
<<<<<<< HEAD
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(135, 397);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(96, 28);
            this.labelX9.TabIndex = 6;
            this.labelX9.Text = "Mật khẩu";
            // 
            // labelX1
=======
            // labelX8
            // 
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(9, 315);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 6;
            this.labelX8.Text = "SĐT";
            // 
<<<<<<< HEAD
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(9, 357);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(95, 25);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Phân quyền";
            // 
            // labelX8
=======
            // labelX7
            // 
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(9, 268);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 5;
            this.labelX7.Text = "Giới tính";
            // 
<<<<<<< HEAD
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(9, 315);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 29);
            this.labelX8.TabIndex = 6;
            this.labelX8.Text = "SĐT";
            // 
            // labelX7
=======
            // labelX6
            // 
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(9, 221);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 4;
            this.labelX6.Text = "Địa chỉ";
            // 
<<<<<<< HEAD
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(9, 268);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 28);
            this.labelX7.TabIndex = 5;
            this.labelX7.Text = "Giới tính";
            // 
            // labelX6
=======
            // labelX5
            // 
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(9, 174);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 3;
            this.labelX5.Text = "Ngày sinh";
            // 
<<<<<<< HEAD
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(9, 221);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 29);
            this.labelX6.TabIndex = 4;
            this.labelX6.Text = "Địa chỉ";
=======
            // labelX4
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // labelX5
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(9, 127);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "CMND";
            // 
<<<<<<< HEAD
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(9, 174);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 30);
            this.labelX5.TabIndex = 3;
            this.labelX5.Text = "Ngày sinh";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(9, 127);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 31);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "CMND";
=======
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(9, 80);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Họ tên";
            // 
            // labelX2
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // labelX3
            // 
            // 
            // 
<<<<<<< HEAD
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(9, 80);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 32);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Họ tên";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(9, 33);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 28);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Mã NV";
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.Location = new System.Drawing.Point(12, -1);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(395, 70);
            this.reflectionLabel1.TabIndex = 3;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Nhân viên </i><font color=\"#B02B2C\"> GONGCHA Hotel</font></" +
    "font></b>";
=======
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(9, 33);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Mã NV";
>>>>>>> b846cfbb9e24ef2224c682d050ca506d89d82104
            // 
            // NhanVien_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 540);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.dgvNhanVien);
            this.Name = "NhanVien_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhanVien_form";
            this.Load += new System.EventHandler(this.NhanVien_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ribbonClientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvNhanVien;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCMND;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoTen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNV;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private DevComponents.DotNetBar.ButtonX btnXemChiTiet;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpNgaySinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSDT;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatKhau;
        private DevComponents.DotNetBar.LabelX labelX9;
        private System.Windows.Forms.RadioButton rdbNhanVien;
        private System.Windows.Forms.RadioButton rdbQuanLy;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.RadioButton rdbThongThuong;
        private DevComponents.DotNetBar.ButtonX btnChonQuyen;
    }
}