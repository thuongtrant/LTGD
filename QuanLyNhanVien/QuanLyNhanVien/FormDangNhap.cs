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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDn_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "" || txtMK.Text != "admin")
                Application.Exit();
            else
                FormQLNhanVien.Tendangnhap = txtTenDN.Text;
                this.Close();
        }

        private void btnThuLai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(FormQLNhanVien.Tendangnhap == "")
                Application.Exit();
        }
    }
}
