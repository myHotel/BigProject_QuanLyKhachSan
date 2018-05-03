using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace QuanLyKhachSan
{
    public partial class NhanVien_form : Form
    {
        public NhanVien_form()
        {
            InitializeComponent();
        }
        QuanLyKSDataContext db = new QuanLyKSDataContext();

        private string EncodeSHA1(string pass)
        {

            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);

            bs = sha1.ComputeHash(bs);

            System.Text.StringBuilder s = new System.Text.StringBuilder();

            foreach (byte b in bs)
            {

                s.Append(b.ToString("x1").ToLower());

            }

            pass = s.ToString();

            return pass;

        }

        private void NhanVien_form_Load(object sender, EventArgs e)
        {
            LoadDSNhanVien();
        }

        public static NHANVIEN nv = new NHANVIEN(); 
        private void LoadDSNhanVien()
        {
            dgvNhanVien.DataSource = db.NHANVIENs.OrderBy(p => p.MANV).Select(p => new {
                p.MANV,
                p.HOTEN,
                p.CMND,
                p.NGAYSINH,
                p.DIACHI,
                p.GIOITINH,
                p.SDT,
            });
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = new DataGridViewRow();
            dgvr = dgvNhanVien.Rows[e.RowIndex];
            if(e.RowIndex >= 0)
            {
                txtMaNV.Text = dgvr.Cells[0].Value.ToString();
                txtHoTen.Text = dgvr.Cells[1].Value.ToString();
                txtCMND.Text = dgvr.Cells[2].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(dgvr.Cells[3].Value.ToString());
                txtDiaChi.Text = dgvr.Cells[4].Value.ToString();
                cboGioiTinh.Text = dgvr.Cells[5].Value.ToString();
                txtSDT.Text = dgvr.Cells[6].Value.ToString();
            }
            nv = db.NHANVIENs.SingleOrDefault(p => p.MANV == txtMaNV.Text.Trim());
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            TKNV_form f = new TKNV_form();
            f.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN
            { 
                MANV = txtMaNV.Text,
                HOTEN = txtHoTen.Text,
                GIOITINH = cboGioiTinh.Text,
                NGAYSINH = dtpNgaySinh.Value,
                CMND = txtCMND.Text,
                DIACHI = txtDiaChi.Text,
                SDT = txtSDT.Text,
            };
            //bỏ rdbQuanLy
            if (!rdbThongThuong.Checked)
            {
                    nv.TAIKHOAN = txtMaNV.Text;
                    nv.MATKHAU = EncodeSHA1(txtMatKhau.Text.Trim());
                    nv.PHANQUYEN = false;
             }
             else 
             {
                    nv.TAIKHOAN = null;
                    nv.MATKHAU = null;
             }
            

            if (db.NHANVIENs.Where(p => p.MANV == txtMaNV.Text).SingleOrDefault() != null)
            {
                MessageBox.Show("Tài khoản bạn nhập bị trùng vui lòng kiểm tra lại !.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtMaNV.Text.Trim() == "" || txtHoTen.Text.Trim() == "" || txtCMND.Text.Trim() == "" || txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Một số thông tin còn thiếu!.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!rdbThongThuong.Checked && txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu với phân quyền trên !.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                db.NHANVIENs.InsertOnSubmit(nv);
                db.SubmitChanges();
                MessageBox.Show("Tạo nhân viên thành công!.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSNhanVien();
            }
        }

        private void btnChonQuyen_Click(object sender, EventArgs e)
        {
            if (!rdbThongThuong.Checked)
                txtMatKhau.Enabled = true;
            else
                txtMatKhau.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = db.NHANVIENs.SingleOrDefault(p => p.MANV == txtMaNV.Text);
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa nhân viên "+ nv.MANV + " !.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(nv!=null && dr == DialogResult.OK)
            {
                db.NHANVIENs.DeleteOnSubmit(nv);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công!.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSNhanVien();
            }
        }

        
    }
}
