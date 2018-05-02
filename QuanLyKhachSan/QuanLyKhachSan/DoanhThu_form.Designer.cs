namespace QuanLyKhachSan
{
    partial class DoanhThu_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.btnThongKeALL = new DevComponents.DotNetBar.ButtonX();
            this.lblUser = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnDong = new DevComponents.DotNetBar.ButtonX();
            this.btnThongKe = new DevComponents.DotNetBar.ButtonX();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dgvDanhSach = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lblTongThu = new DevComponents.DotNetBar.LabelX();
            this.label = new DevComponents.DotNetBar.LabelX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.ribbonClientPanel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Location = new System.Drawing.Point(0, -1);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(382, 103);
            this.reflectionLabel1.TabIndex = 0;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Thống kê doanh thu</i><font color=\"#B02B2C\"> GONGCHA Hotel<" +
    "/font></font></b>";
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.btnThongKeALL);
            this.ribbonClientPanel1.Controls.Add(this.lblUser);
            this.ribbonClientPanel1.Controls.Add(this.labelX3);
            this.ribbonClientPanel1.Controls.Add(this.btnDong);
            this.ribbonClientPanel1.Controls.Add(this.btnThongKe);
            this.ribbonClientPanel1.Controls.Add(this.dtp2);
            this.ribbonClientPanel1.Controls.Add(this.dtp1);
            this.ribbonClientPanel1.Controls.Add(this.dtpDenNgay);
            this.ribbonClientPanel1.Controls.Add(this.labelX1);
            this.ribbonClientPanel1.Location = new System.Drawing.Point(388, -1);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(555, 103);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.ribbonClientPanel1.Style.BackColorGradientAngle = 90;
            this.ribbonClientPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.ribbonClientPanel1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Tile;
            this.ribbonClientPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonClientPanel1.Style.BorderBottomWidth = 1;
            this.ribbonClientPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.ribbonClientPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonClientPanel1.Style.BorderLeftWidth = 1;
            this.ribbonClientPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonClientPanel1.Style.BorderRightWidth = 1;
            this.ribbonClientPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonClientPanel1.Style.BorderTopWidth = 1;
            this.ribbonClientPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonClientPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribbonClientPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseDown.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.ribbonClientPanel1.StyleMouseDown.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.ribbonClientPanel1.StyleMouseDown.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
            this.ribbonClientPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonClientPanel1.StyleMouseDown.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseOver.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground2;
            this.ribbonClientPanel1.StyleMouseOver.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground;
            this.ribbonClientPanel1.StyleMouseOver.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
            this.ribbonClientPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonClientPanel1.StyleMouseOver.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
            this.ribbonClientPanel1.TabIndex = 1;
            // 
            // btnThongKeALL
            // 
            this.btnThongKeALL.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThongKeALL.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThongKeALL.Location = new System.Drawing.Point(407, 51);
            this.btnThongKeALL.Name = "btnThongKeALL";
            this.btnThongKeALL.Size = new System.Drawing.Size(137, 41);
            this.btnThongKeALL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThongKeALL.TabIndex = 4;
            this.btnThongKeALL.Text = "Thống kê tất cả";
            this.btnThongKeALL.Click += new System.EventHandler(this.btnThongKeALL_Click);
            // 
            // lblUser
            // 
            // 
            // 
            // 
            this.lblUser.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUser.ForeColor = System.Drawing.Color.Red;
            this.lblUser.Location = new System.Drawing.Point(96, 58);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(75, 33);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "user";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(15, 58);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 33);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Tài khoản ";
            // 
            // btnDong
            // 
            this.btnDong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDong.Location = new System.Drawing.Point(177, 50);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(87, 42);
            this.btnDong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThongKe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThongKe.Location = new System.Drawing.Point(270, 50);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(123, 42);
            this.btnThongKe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "dd/MM/yyyy";
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(407, 16);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(137, 29);
            this.dtp2.TabIndex = 1;
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "dd/MM/yyyy";
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(96, 15);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(162, 29);
            this.dtp1.TabIndex = 1;
            // 
            // dtpDenNgay
            // 
            // 
            // 
            // 
            this.dtpDenNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDenNgay.Location = new System.Drawing.Point(305, 15);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(75, 28);
            this.dtpDenNgay.TabIndex = 0;
            this.dtpDenNgay.Text = "đến ngày";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(15, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(60, 28);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Từ ngày";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dgvDanhSach);
            this.panelEx1.Location = new System.Drawing.Point(0, 108);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(943, 352);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            this.panelEx1.Text = "panelEx1";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.MAPHONG,
            this.NGAYNHAN,
            this.NGAYTRA,
            this.GIATIEN});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSach.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.EnableHeadersVisualStyles = false;
            this.dgvDanhSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDanhSach.Size = new System.Drawing.Size(943, 352);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // MAKH
            // 
            this.MAKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã khách hàng";
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            this.MAKH.Width = 139;
            // 
            // TENKH
            // 
            this.TENKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.FillWeight = 60.69903F;
            this.TENKH.HeaderText = "Tên khách hàng";
            this.TENKH.Name = "TENKH";
            this.TENKH.ReadOnly = true;
            // 
            // MAPHONG
            // 
            this.MAPHONG.DataPropertyName = "MAPHONG";
            this.MAPHONG.HeaderText = "Mã phòng";
            this.MAPHONG.Name = "MAPHONG";
            this.MAPHONG.ReadOnly = true;
            // 
            // NGAYNHAN
            // 
            this.NGAYNHAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYNHAN.DataPropertyName = "NGAYNHAN";
            this.NGAYNHAN.HeaderText = "Ngày nhận";
            this.NGAYNHAN.Name = "NGAYNHAN";
            this.NGAYNHAN.ReadOnly = true;
            // 
            // NGAYTRA
            // 
            this.NGAYTRA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYTRA.DataPropertyName = "NGAYTRA";
            this.NGAYTRA.HeaderText = "Ngày trả";
            this.NGAYTRA.Name = "NGAYTRA";
            this.NGAYTRA.ReadOnly = true;
            // 
            // GIATIEN
            // 
            this.GIATIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIATIEN.DataPropertyName = "TONGTIEN";
            this.GIATIEN.HeaderText = "Giá tiền";
            this.GIATIEN.Name = "GIATIEN";
            this.GIATIEN.ReadOnly = true;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Blue;
            this.labelX5.Location = new System.Drawing.Point(365, 466);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(151, 37);
            this.labelX5.TabIndex = 3;
            this.labelX5.Text = "Tổng doanh thu :";
            // 
            // lblTongThu
            // 
            // 
            // 
            // 
            this.lblTongThu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTongThu.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongThu.ForeColor = System.Drawing.Color.Red;
            this.lblTongThu.Location = new System.Drawing.Point(522, 473);
            this.lblTongThu.Name = "lblTongThu";
            this.lblTongThu.Size = new System.Drawing.Size(124, 23);
            this.lblTongThu.TabIndex = 3;
            this.lblTongThu.Text = "vnd";
            // 
            // label
            // 
            // 
            // 
            // 
            this.label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Blue;
            this.label.Location = new System.Drawing.Point(13, 466);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(268, 37);
            this.label.TabIndex = 4;
            this.label.Text = "Tổng số hóa đơn đặt phòng :\r\n";
            // 
            // lblCount
            // 
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Red;
            this.lblCount.Location = new System.Drawing.Point(287, 473);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(48, 23);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "count";
            // 
            // DoanhThu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblTongThu);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.ribbonClientPanel1);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DoanhThu_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoanhThu_form";
            this.Load += new System.EventHandler(this.DoanhThu_form_Load);
            this.ribbonClientPanel1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private DevComponents.DotNetBar.LabelX lblUser;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnDong;
        private DevComponents.DotNetBar.ButtonX btnThongKe;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private DevComponents.DotNetBar.LabelX dtpDenNgay;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDanhSach;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX lblTongThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATIEN;
        private DevComponents.DotNetBar.ButtonX btnThongKeALL;
        private DevComponents.DotNetBar.LabelX label;
        private DevComponents.DotNetBar.LabelX lblCount;
    }
}