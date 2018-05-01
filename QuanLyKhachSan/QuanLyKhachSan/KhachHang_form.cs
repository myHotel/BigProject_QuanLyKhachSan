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
    public partial class KhachHang_form : Form
    {
        public KhachHang_form()
        {
            InitializeComponent();
        }
        QuanLyKSDataContext db = new QuanLyKSDataContext();
        private void KhachHang_form_Load(object sender, EventArgs e)
        {
            LoadDSKhachHang();
        }
        private void LoadDSKhachHang()
        {
            dgvKhachHang.DataSource = db.DATPHONGs.Select(p => new
            {
                p.KHACHHANG.TENKH,
                p.PHONG.TENPHONG,
                p.KHACHHANG.CMND,
                p.KHACHHANG.SDT,
                p.NGAYNHAN,
                p.NGAYTRA,
                p.TRANGTHAI
            });
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = db.DATPHONGs.Where(p => p.KHACHHANG.TENKH.Contains(txtTENKH.Text)).Select(p=>new {
                p.KHACHHANG.TENKH,
                p.PHONG.TENPHONG,
                p.KHACHHANG.CMND,
                p.KHACHHANG.SDT,
                p.NGAYNHAN,
                p.NGAYTRA,
                p.TRANGTHAI
            });
            
        }
    }
}
