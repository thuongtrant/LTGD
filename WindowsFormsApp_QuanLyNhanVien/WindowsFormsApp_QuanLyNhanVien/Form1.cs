using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_QuanLyNhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string text) : this()
        {
            txtDangNhap.Text = text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtHoTen.Text);
            item.SubItems.Add(dtNgaySinh.Text);
            item.SubItems.Add(rdNam.Checked ? "Nam" : "Nữ");
            item.ImageIndex = rdNam.Checked ? 1 : 0;
            lvDS.Items.Add(item);
            txtHoTen.Text = "";
            txtHoTen.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvDS.Columns.Add("Học tên", 130);
            lvDS.Columns.Add("Ngày sinh", 140);
            lvDS.Columns.Add("Giới tính", 110);
            this.Opacity = 1.0;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
                Application.Exit();
            else
                this.Opacity -= 0.1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvDS.SelectedItems)
                lvDS.Items.Remove(item);
        }

        private void btnDongUD_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
