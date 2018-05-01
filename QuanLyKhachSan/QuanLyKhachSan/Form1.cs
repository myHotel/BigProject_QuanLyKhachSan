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
    
    public partial class Form1 : Form
    {
        QuanLyKSDataContext db = new QuanLyKSDataContext();
        public Form1()
        {
            InitializeComponent();
        }
        public static NHANVIEN nv = new NHANVIEN();
        public Form1(NHANVIEN _nv)
        {
            InitializeComponent();
            nv = _nv;
            chkPhanQuyen();
        }

        public static string manv;
        private void chkPhanQuyen()
        {

            if(nv.PHANQUYEN == null)
            {
                btnInDS_bar.Enabled = false;
                btnDatPhong.Enabled = false;
                btnKhachHang.Enabled = false;
                btnTTTK.Enabled = false;
                btnNhanVien.Enabled = false;
                btnTKDT_bar.Enabled = false;
                btnDangNhap.Text = "Đăng nhập";
            }
            else if (nv.PHANQUYEN == false)
            {
                btnInDS_bar.Enabled = false;
                btnDatPhong.Enabled = true;
                btnKhachHang.Enabled = true;
                btnTTTK.Enabled = true;
                btnNhanVien.Enabled = false;
                btnTKDT_bar.Enabled = false;
                btnDangNhap.Text = "Đăng xuất";
            }
            else
            {
                btnDatPhong.Enabled = true;
                btnInDS_bar.Enabled = true;
                btnDatPhong.Enabled = true;
                btnKhachHang.Enabled = true;
                btnTTTK.Enabled = true;
                btnNhanVien.Enabled = true;
                btnTKDT_bar.Enabled = true;
                btnDangNhap.Text = "Đăng xuất";
            }

                lblMessage.Text = "";
                lblMaND.Text = nv.MANV;
                manv = lblMaND.Text;
                lblTenND.Text = nv.HOTEN;
                if (nv.PHANQUYEN == true)
                    lblChucvu.Text = "Quản lý";
                else lblChucvu.Text = "Nhân viên";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnDatPhong.Enabled = false;
            btnInDS_bar.Enabled = false;
            btnDatPhong.Enabled = false;
            btnKhachHang.Enabled = false;
            btnTTTK.Enabled = false;
            btnNhanVien.Enabled = false;
            btnTKDT_bar.Enabled = false;
            lblMaND.Text = "Mã người dùng";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (btnDangNhap.Text == "Đăng xuất")
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn " + btnDangNhap.Text + " không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    User_form f = new User_form();
                    f.ShowDialog();
                    nv = f.nv;
                    chkPhanQuyen();
                }
            }
            else{
                User_form f = new User_form();
                f.ShowDialog();
                nv = f.nv;
                chkPhanQuyen();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnDMKbar_Click(object sender, EventArgs e)
        {
            DMK_form dmk = new DMK_form();
            dmk.ShowDialog();
        }

        private void btnTTTK_Click(object sender, EventArgs e)
        {
            TKNV_form f = new TKNV_form();
            f.ShowDialog();
  
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            info_form f = new info_form();
            f.ShowDialog();
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            info_form f = new info_form();
            f.ShowDialog();
        }

        private void listOption_ItemClick(object sender, EventArgs e)
        {

        }

        private void btnDatPhong_Click_1(object sender, EventArgs e)
        {
            DatPhong_form f = new DatPhong_form();
            f.ShowDialog();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            ThanhToan_form f = new ThanhToan_form();
            f.ShowDialog();
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            LichSu_form f = new LichSu_form();
            f.ShowDialog();
        }
    }
}
