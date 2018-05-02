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
    public partial class DoanhThu_form : DevComponents.DotNetBar.Office2007Form
    {
        public DoanhThu_form()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        QuanLyKSDataContext db = new QuanLyKSDataContext();
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int ngay1 = dtp1.Value.Day, thang1 = dtp1.Value.Month, nam1 = dtp1.Value.Year;
            int ngay2 = dtp2.Value.Day, thang2 = dtp2.Value.Month, nam2 = dtp2.Value.Year;
            dgvDanhSach.DataSource = db.DATPHONGs.Where(p => p.NGAYNHAN.Value.Day >= ngay1 && p.NGAYNHAN.Value.Day <= ngay2 && p.NGAYNHAN.Value.Month >= thang1 && p.NGAYNHAN.Value.Month <= thang2 && p.NGAYNHAN.Value.Year >= nam1 && p.NGAYNHAN.Value.Year <= nam2).Select(p => new
            {
                p.MAKH,
                p.KHACHHANG.TENKH,
                p.MAPHONG,
                p.NGAYNHAN,
                p.NGAYTRA,
                p.TONGTIEN
            });
            int tien = dgvDanhSach.Rows.Count;
            lblCount.Text = tien.ToString(); 
            long thanhtien = 0;
            for (int i = 0; i < tien - 1; i++)
            {
                thanhtien += long.Parse(dgvDanhSach.Rows[i].Cells[5].Value.ToString());
            }
            lblTongThu.Text = thanhtien.ToString() + " đ";
        }

        private void DoanhThu_form_Load(object sender, EventArgs e)
        {
            lblUser.Text = Form1.nv.MANV;
        }

        private void btnThongKeALL_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = db.DATPHONGs.OrderBy(p=>p.MAKH).Select(p=>new
            {
                p.MAKH,
                p.KHACHHANG.TENKH,
                p.MAPHONG,
                p.NGAYNHAN,
                p.NGAYTRA,
                p.TONGTIEN
            });

            int tien = dgvDanhSach.Rows.Count;
            lblCount.Text = tien.ToString(); 
            long thanhtien = 0;
            for (int i = 0; i < tien - 1; i++)
            {
                thanhtien += long.Parse(dgvDanhSach.Rows[i].Cells[5].Value.ToString());
            }
            lblTongThu.Text = thanhtien.ToString() + " đ";
        }
        
    }
}
