using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_ControlList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gt = "Tên đang được gọi là: " + lbKQ.SelectedItem.ToString();
            MessageBox.Show(gt, "Hiển thị");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ht = txtNhap.Text;
            lbKQ.Items.Add(ht);
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtNhap.Text = "";
        }
    }
}
