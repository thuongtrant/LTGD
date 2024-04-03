using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_HinhTron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            Diem diem = new Diem(double.Parse(txtXtam.Text), double.Parse(txtYtam.Text));

            HinhTron tron = new HinhTron(diem,double.Parse(txtBK.Text));
            double BK = double.Parse(txtBK.Text);
             
            if (rdDienTich.Checked)
            {
                txtKetQua.Text = tron.tinhDienTich().ToString();
            }else if (rdChuVi.Checked)
            {
                txtKetQua.Text = tron.tinhChuVi().ToString();
            }
            else if (rdKiemTra.Checked) { 

            }
        }
    }
}
