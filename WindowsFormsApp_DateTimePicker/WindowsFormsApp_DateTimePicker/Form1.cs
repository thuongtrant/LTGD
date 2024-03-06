using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtpThongTin_ValueChanged(object sender, EventArgs e)
        {
            string ngay, thang, nam;
            ngay = dtpThongTin.Value.Day.ToString();
            thang = dtpThongTin.Value.Month.ToString();
            nam = dtpThongTin.Value.Year.ToString();
            txtNTN.Text = ngay + "/" + thang + "/" + nam;
            txtNgay.Text = ngay;
            txtThang.Text = thang;
            txtNam.Text = nam;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpThongTin_ValueChanged(sender, e);
        }
        int soNgayTrongThang(int month, int year)
        {
            int soNgay = 0;
            switch (month)
            {
                case 4: case 6: case 9: case 11: soNgay = 30; break;
                case 2:
                    if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                    {
                        soNgay = 29;
                    }
                    else
                        soNgay = 29; break;
                default: 
                     soNgay = 31;
                     break;
            }
            return soNgay;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try { 
                int d = int.Parse(txtNgay.Text);
                int m = int.Parse(txtThang.Text);
                int y = int.Parse(txtNam.Text);
                if (!(y >= 1900 && y <= 2100) || !(m >= 1 && m <= 12) || !(d >= 1 && d <= soNgayTrongThang(
                    m, y)))
                    throw new Exception("Giá trị không hợp lệ");
                txtNTN.Text = d.ToString() + "/" + m.ToString() + "/" + y.ToString();
                DateTime t = new DateTime(y, m, d);
                dtpThongTin.Value = t; 
            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }
                
        }
    }
}
