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
    public partial class DMK_form : Form
    {
        public DMK_form()
        {
            InitializeComponent();
        }


        QuanLyKSDataContext db = new QuanLyKSDataContext();

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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            NHANVIEN nv = db.NHANVIENs.SingleOrDefault(p => p.TAIKHOAN == txtTK.Text);
            if(nv == null)
            {
                MessageBox.Show("Tên người dùng bạn vừa hập không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                if (EncodeSHA1(txtMKC.Text).ToUpper() != nv.MATKHAU.Trim())
                {
                    MessageBox.Show("Mật khẩu cũ không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(EncodeSHA1(txtMKM.Text).ToUpper() != EncodeSHA1(txtNLMKM.Text).ToUpper())
                    MessageBox.Show("Mật khẩu mới nhập lại không trùng khớp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    nv.MATKHAU = EncodeSHA1(txtMKM.Text).ToUpper();
                    db.SubmitChanges();
                    MessageBox.Show("Lưu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DMK_form_Load(object sender, EventArgs e)
        {

        }
    }
}
