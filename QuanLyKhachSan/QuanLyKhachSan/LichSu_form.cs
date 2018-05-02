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
    public partial class LichSu_form : Form
    {
        public LichSu_form()
        {
            InitializeComponent();
        }

        QuanLyKSDataContext db = new QuanLyKSDataContext();

        private void loadDSLichSu()
        {
            dgvLichSu.DataSource = db.DATPHONGs.Select(p => new
            {
                p.PHONG.TENPHONG,
                p.KHACHHANG.TENKH,
                p.NHANVIEN.HOTEN,
                p.NGAYNHAN,
                p.NGAYTRA,
                p.TRANGTHAI
            });
        }

        private void LichSu_form_Load(object sender, EventArgs e)
        {
            cboNgay.SelectedIndex = 1;
            loadDSLichSu();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(cboNgay.SelectedItem.ToString() == "Ngày nhận")
            {
                dgvLichSu.DataSource = db.DATPHONGs.Where(p => p.NGAYNHAN.Value.Date == dtpNgay.Value.Date).Select(p => new
                {
                    p.PHONG.TENPHONG,
                    p.KHACHHANG.TENKH,
                    p.NHANVIEN.HOTEN,
                    p.NGAYNHAN,
                    p.NGAYTRA,
                    p.TRANGTHAI
                });
            }
            else
            {
                dgvLichSu.DataSource = db.DATPHONGs.Where(p => p.NGAYTRA.Value.Date == dtpNgay.Value.Date).Select(p => new
                {
                    p.PHONG.TENPHONG,
                    p.KHACHHANG.TENKH,
                    p.NHANVIEN.HOTEN,
                    p.NGAYNHAN,
                    p.NGAYTRA,
                    p.TRANGTHAI
                });
            }
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            loadDSLichSu();
        }
    }
}
