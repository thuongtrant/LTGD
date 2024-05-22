using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class FormQLNhanVien : Form
    {
        public static string Tendangnhap = "";
        public bool bClose;

        public FormQLNhanVien()
        {
            FormDangNhap f = new FormDangNhap();
            f.ShowDialog();
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "") return;
            ListViewItem item = new ListViewItem(txtHoTen.Text);
            item.SubItems.Add(dtNgaySinh.Text);
            item.SubItems.Add(rdNam.Checked ? "Nam" : "Nữ");
            item.ImageIndex = rdNam.Checked ? 1 : 0;
            listViewNV.Items.Add(item);
            txtHoTen.Text = "";
            txtHoTen.Focus();
        }

        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            lblTenDN.Text = Tendangnhap;
            bClose = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listViewNV.SelectedItems)
                listViewNV.Items.Remove(item);
        }

        private void FormQLNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!bClose)
                e.Cancel = true;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.3;
            if(this.Opacity <= 0)
                bClose = true;
                Application.Exit();
        }
    }
}
