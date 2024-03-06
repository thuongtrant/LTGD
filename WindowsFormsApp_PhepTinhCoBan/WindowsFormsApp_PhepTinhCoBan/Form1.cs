using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_PhepTinhCoBan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            txtKQ.Text = String.Format("{0}", a + b);
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            txtKQ.Text = String.Format("{0}", a - b);
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            txtKQ.Text = String.Format("{0}", a * b);
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            if (b != 0)
            {
                txtKQ.Text = String.Format("{0:0.00}", a / b);
            }
            else
                MessageBox.Show("Số chia phải khác 0", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
