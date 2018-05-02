﻿using System;
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
    public partial class DatPhong_form :Form
    {
        public DatPhong_form()
        {
            InitializeComponent();
        }
        QuanLyKSDataContext db = new QuanLyKSDataContext();
        private void DatPhong_form_Load(object sender, EventArgs e)
        {
            cboLoaiPhong.SelectedIndex=5;

            cboTenPhong.DataSource = db.PHONGs;
            cboTenPhong.DisplayMember = "TENPHONG";
            cboTenPhong.ValueMember = "MAPHONG";
            //không cho chỉnh mã phòng, giá tiền
            txtMAPHONG.Enabled = false;
            txtGiaTien.Enabled = false;

            LOADDSPhong();
        }

        private void LOADDSPhong()
        {
            dgvDSPhong.DataSource = db.PHONGs.OrderBy(p => p.MAPHONG).Select(p => new
            {
                p.MAPHONG,
                p.TENPHONG,
                p.LOAIPHONG,
                p.GIAPHONG,
                p.TRANGTHAI
            });
        }

        private void dgvDSPhong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr = dgvDSPhong.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                txtMAPHONG.Text = dr.Cells[0].Value.ToString();
                cboTenPhong.Text = dr.Cells[1].Value.ToString();
                cboLoaiPhong.Text = dr.Cells[2].Value.ToString();
                txtGiaTien.Text = dr.Cells[3].Value.ToString();
                PHONG ph = db.PHONGs.SingleOrDefault(p => p.MAPHONG == txtMAPHONG.Text);
                if (ph.TRANGTHAI == "Đã thuê")
                {
                    cboTRANGTHAI.ForeColor = Color.Red;
                    cboTRANGTHAI.Text = dr.Cells[4].Value.ToString();
                }
                else if (ph.TRANGTHAI == "Còn trống")
                {
                    cboTRANGTHAI.ForeColor = Color.Blue;
                    cboTRANGTHAI.Text = dr.Cells[4].Value.ToString();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //chỉnh lại nút tìm kiếm theo cboTenPhong thay vì txtMaPhong
            dgvDSPhong.DataSource = db.PHONGs.Where(p => p.MAPHONG == cboTenPhong.SelectedValue.ToString()).Select(p=> new
            {
                p.MAPHONG,
                p.TENPHONG,
                p.LOAIPHONG,
                p.GIAPHONG,
                p.TRANGTHAI
            });
        }

        private void loadTimKiem()
        {
            //nếu cbo Loại phòng là "Tất cả" thì show ra hết
            if(cboLoaiPhong.SelectedItem.ToString() == "Tất cả")
            {
                dgvDSPhong.DataSource = db.PHONGs.Select(p => new
                {
                    p.MAPHONG,
                    p.TENPHONG,
                    p.LOAIPHONG,
                    p.GIAPHONG,
                    p.TRANGTHAI
                });
            }
            //còn không thì show theo loại phòng
            else
            {
                dgvDSPhong.DataSource = db.PHONGs.Where(p => p.LOAIPHONG == cboLoaiPhong.SelectedItem.ToString()).Select(p => new
                {
                    p.MAPHONG,
                    p.TENPHONG,
                    p.LOAIPHONG,
                    p.GIAPHONG,
                    p.TRANGTHAI
                });
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            loadTimKiem();
        }
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = new KHACHHANG
            {
                MAKH = txtMAKH.Text,
                TENKH = txtTENKH.Text,
                CMND = txtCMND.Text,
                SDT = txtSDT.Text
            };
            DATPHONG qlp = new DATPHONG
            {
                MANV = Form1.nv.MANV,
                MAPHONG = txtMAPHONG.Text,
                MAKH = txtMAKH.Text,
                //chỉnh khúc này từ dtpNgayNhan thành DateTime.Now và xóa luôn dtpNgayNhan
                NGAYNHAN = DateTime.Now,    
                NGAYTRA = null,
                TRANGTHAI = "Chưa thanh toán"
            };
            PHONG ph = db.PHONGs.SingleOrDefault(p=>p.MAPHONG == txtMAPHONG.Text);
            if(ph.TRANGTHAI == "Đã thuê")
            {
                MessageBox.Show("Phòng " + txtMAPHONG.Text + " hiện đang được thuê không thể đặt phòng. Xin kiểm tra lại.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if(txtMAKH.Text == "" || txtTENKH.Text == "" || txtCMND.Text == "" || db.KHACHHANGs.Where(p=>p.MAKH == kh.MAKH).SingleOrDefault()!=null)
                {
                    MessageBox.Show("Một số thông tin nhập còn thiếu hoặc Mã khách hàng bị trùng. Xin kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ph.TRANGTHAI = "Đã thuê";
                    db.DATPHONGs.InsertOnSubmit(qlp);
                    db.KHACHHANGs.InsertOnSubmit(kh);
                    db.SubmitChanges();
                    LOADDSPhong();
                    MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LOADDSPhong();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

      

      
    }
}
