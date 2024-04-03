using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_TinhPhanSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            lblDau.Text = btnCong.Text;
            PhanSo ps1, ps2;
            try
            {
                ps1 = new PhanSo(int.Parse(txtTu1.Text), int.Parse(txtMau1.Text));
                ps2 = new PhanSo(int.Parse(txtTu2.Text), int.Parse(txtMau2.Text));
                PhanSo kq = ps1.tong(ps2);
                txtTuKQ.Text = kq.TuSo.ToString();
                txtMauKQ.Text = kq.MauSo.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            lblDau.Text = btnTru.Text;
            PhanSo ps1, ps2;
            try
            {
                ps1 = new PhanSo(int.Parse(txtTu1.Text), int.Parse(txtMau1.Text));
                ps2 = new PhanSo(int.Parse(txtTu2.Text), int.Parse(txtMau2.Text));
                PhanSo kq = ps1.tru(ps2);
                txtTuKQ.Text = kq.TuSo.ToString();
                txtMauKQ.Text = kq.MauSo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            lblDau.Text = btnNhan.Text;
            PhanSo ps1, ps2;
            try
            {
                ps1 = new PhanSo(int.Parse(txtTu1.Text), int.Parse(txtMau1.Text));
                ps2 = new PhanSo(int.Parse(txtTu2.Text), int.Parse(txtMau2.Text));
                PhanSo kq = ps1.nhan(ps2);
                txtTuKQ.Text = kq.TuSo.ToString();
                txtMauKQ.Text = kq.MauSo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {

        }
    }
}
