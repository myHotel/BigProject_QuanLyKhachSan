using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class TKNV_form : Form
    {
        public TKNV_form()
        {
            InitializeComponent();
        }

        NHANVIEN nv = new NHANVIEN();

        QuanLyKSDataContext db = new QuanLyKSDataContext();
        private void buttonX1_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        Boolean checkLuu = false;
        private void btnChinhSuaTT_Click(object sender, EventArgs e)
        {
            txtTNV.ReadOnly = false;
            txtDC.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtCMND.ReadOnly = false;
            checkLuu = true;
            btnChinhSuaTT.Enabled = false;
            btnLuuTT.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cboGioiTinh.Enabled = true;
        }
        

        private void TKNV_form_Load(object sender, EventArgs e)
        {

            nv = NhanVien_form.nv;
            lblManv.Text = nv.MANV;
            txtTNV.Text = nv.HOTEN;
            lblTaiKhoan.Text = nv.TAIKHOAN;
            lblMatKhau.Text = nv.MATKHAU;
            dtpNgaySinh.Text = nv.NGAYSINH.ToString();
            cboGioiTinh.Text = nv.GIOITINH;
            txtDC.Text = nv.DIACHI;
            txtSDT.Text = nv.SDT;
            txtCMND.Text = nv.CMND;
            if (nv.PHANQUYEN == true)
                lblChucVu.Text = "Quản lý";
            else lblChucVu.Text = "Nhân viên";
            txtTNV.ReadOnly = true;
            txtDC.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtCMND.ReadOnly = true;
            //bổ sung không cho chỉnh sửa NgaySinh và GioiTinh
            dtpNgaySinh.Enabled = false;
            cboGioiTinh.Enabled = false;
            btnLuuTT.Enabled = false;
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            
            NHANVIEN nv = db.NHANVIENs.SingleOrDefault(p => p.MANV == lblManv.Text);
            if (nv != null) {
                nv.HOTEN = txtTNV.Text;
                nv.GIOITINH = cboGioiTinh.Text;
                nv.NGAYSINH = dtpNgaySinh.Value;
                nv.DIACHI = txtDC.Text;
                nv.CMND = txtCMND.Text;
                nv.SDT = txtSDT.Text;
                db.SubmitChanges();
                MessageBox.Show("Lưu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnChinhSuaTT.Enabled = true;
                btnLuuTT.Enabled = false;
                txtTNV.ReadOnly = true;
                txtDC.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtCMND.ReadOnly = true;
                dtpNgaySinh.Enabled = false;
                cboGioiTinh.Enabled = false;
            }
        }
    }
}
