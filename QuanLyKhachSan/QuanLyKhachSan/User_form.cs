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
    public partial class User_form : Form
    {
        public User_form()
        {
            InitializeComponent();
        }

        //Mã hóa SHA512
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

        //

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        QuanLyKSDataContext db = new QuanLyKSDataContext();
        private void User_form_Load(object sender, EventArgs e)
        {

        }
        public NHANVIEN nv = new NHANVIEN();  
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            nv = (from NHANVIEN in db.NHANVIENs
                       where NHANVIEN.TAIKHOAN == txtMANV_user.Text.Trim()
                       && NHANVIEN.MATKHAU == EncodeSHA1(txtMatKhau.Text)
                       select NHANVIEN
                          ).SingleOrDefault();
            if (nv == null)
            {
                MessageBox.Show("Sai mật khẫu hoặc tài khoản !","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nv = new NHANVIEN();
            }
            else
            {
                this.Close();
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            DMK_form dmk = new DMK_form();
            dmk.ShowDialog();
        }
    }
}
