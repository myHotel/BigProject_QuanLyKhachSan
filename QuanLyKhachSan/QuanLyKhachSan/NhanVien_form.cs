using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NhanVien_form : Form
    {
        public NhanVien_form()
        {
            InitializeComponent();
        }
        QuanLyKSDataContext db = new QuanLyKSDataContext();
        private void NhanVien_form_Load(object sender, EventArgs e)
        {
            LoadDSNhanVien();
        }
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
        }
    }
}
