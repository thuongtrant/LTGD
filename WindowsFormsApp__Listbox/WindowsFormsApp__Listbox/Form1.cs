using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp__Listbox
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ht = txtNhap.Text;
            if (ht != "")
            {
                lbKQ.Items.Add(ht);
                count++;
                lblSoLuong.Text = "Tổng số lượng: " + count.ToString();
            }
            else
                MessageBox.Show("Vui lòng nhập thông tin! ", "Thông báo", MessageBoxButtons.OK);
            
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtNhap.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //int index = lbKQ.SelectedIndex;
            //lbKQ.Items.RemoveAt(index);
            for (int i = lbKQ.SelectedItems.Count - 1; i >= 0; i--)
            {
                lbKQ.Items.Remove(lbKQ.SelectedItems[i]);
            }
            count = lbKQ.Items.Count;
            lblSoLuong.Text = "Tổng số lương: " + count.ToString();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string gt = "Tên đang được chọn la: " + lbKQ.SelectedItem.ToString();
            MessageBox.Show(gt, "Hiển thị");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSoLuong.Text = "Tổng số lương: 0";
        }

        private void lbKQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "";
            foreach (int i in lbKQ.SelectedIndices)
                s += i.ToString() + ", ";
            if(s != "")
            {
                s = s.Substring(0, s.Length - 2);
            }
            lblIndex.Text = "Đang chọn phần tử: " + s;

        }
    }
}
