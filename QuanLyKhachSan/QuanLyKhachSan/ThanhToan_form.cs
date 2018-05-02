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
    public partial class ThanhToan_form : Form
    {
        public ThanhToan_form()
        {
            InitializeComponent();
        }
        QuanLyKSDataContext db = new QuanLyKSDataContext();
        private void ThanhToan_form_Load(object sender, EventArgs e)
        {
            cboMaPhong.DataSource = db.PHONGs;
            cboMaPhong.DisplayMember = "MAPHONG";
            cboMaPhong.ValueMember = "MAPHONG";
            txtMAKH.Enabled = false;
            txtTENKH.Enabled = false;
            dtpNGAYNHAN.Enabled = false;
            txtGiaTien.Enabled = false;
            LoadDSPHONG();
        }

        private void LoadDSPHONG()
        {
            dgvDSPHONG.DataSource = db.DATPHONGs.Where(p => p.TRANGTHAI == "Chưa thanh toán").Select(p=> new
            {
                p.MAPHONG,
                p.MAKH,
                p.KHACHHANG.TENKH,
                p.NGAYNHAN,
                p.PHONG.GIAPHONG,
                p.TRANGTHAI
            });
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            dgvDSPHONG.DataSource = db.DATPHONGs.Where(p => p.MAPHONG == cboMaPhong.Text).Select(p => new 
            {
                p.MAPHONG,
                p.MAKH,
                p.KHACHHANG.TENKH,
                p.NGAYNHAN,
                p.PHONG.GIAPHONG,
                p.TRANGTHAI
            });
            if (cboMaPhong.Text == "")
            {
                LoadDSPHONG();
            }
        }
        long thanhTien  = 0;
        private void dgvDSPHONG_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr = dgvDSPHONG.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                cboMaPhong.Text = dr.Cells[0].Value.ToString();
                txtMAKH.Text = dr.Cells[1].Value.ToString();
                txtTENKH.Text = dr.Cells[2].Value.ToString();
                dtpNGAYNHAN.Value = DateTime.Parse(dr.Cells[3].Value.ToString());
                txtGiaTien.Text = dr.Cells[4].Value.ToString();
                //tính ra ngày và giờ
                TimeSpan c = DateTime.Now.Subtract(dtpNGAYNHAN.Value);
                int songay = c.Days;
                int songio = c.Hours;
                txtSoNgay.Text = songay.ToString();
                txtSoGio.Text = songio.ToString();
                PHONG ph = new PHONG();
                ph = db.PHONGs.SingleOrDefault(p => p.MAPHONG == cboMaPhong.Text);
                //cách tính thành tiền
                thanhTien = c.Days * ph.GIAPHONG + c.Hours * (ph.GIAPHONG / 8);
                lblTongCong.Text = thanhTien.ToString();

            }
           
        }

        private void btnTHANHTOAN_Click(object sender, EventArgs e)
        {
            DATPHONG thanhtoan = db.DATPHONGs.SingleOrDefault(p => p.MAKH == txtMAKH.Text);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thanh toán cho khách hàng " + thanhtoan.MAKH, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thanhtoan != null && dr == DialogResult.OK)
            {
                //chỉnh lại từ dtpNgayGio.Value thành DateTime.Now
                thanhtoan.NGAYTRA = DateTime.Now;
                thanhtoan.TRANGTHAI = "Đã thanh toán";
                thanhtoan.TONGTIEN = long.Parse(lblTongCong.Text);
                PHONG ph = db.PHONGs.SingleOrDefault(p => p.MAPHONG == cboMaPhong.Text.Trim());
                ph.TRANGTHAI = "Còn trống";
                db.SubmitChanges();
                LoadDSPHONG();
                MessageBox.Show("Bạn đã thanh toán thành công mã phòng " + thanhtoan.MAPHONG + " của khách hàng " + thanhtoan.MAKH + " vào lúc " + DateTime.Now + " .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);    
            }
            
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadDSPHONG();
        }


    }
}
