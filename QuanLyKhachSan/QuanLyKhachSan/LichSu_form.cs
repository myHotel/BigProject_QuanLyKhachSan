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
            dgvLichSu.DataSource = db.LICHSU_VIEWs.Select(p => new
            {
                p.TENPHONG,
                p.TENKH,
                p.HOTEN,
                p.NGAYNHAN,
                p.NGAYTRA,
                p.TRANGTHAI
            });
        }

        private void LichSu_form_Load(object sender, EventArgs e)
        {
            loadDSLichSu();
        }
    }
}
