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
    public partial class FormDangNhapcs : Form
    {
        string ht;
        public FormDangNhapcs()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ht = txtTenDn.Text;
            string mk = txtMatKhau.Text;
            if(ht != "" && mk == "admin")
            {
                this.Hide();
                Form f = new Form1(ht);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nhập lại thông tin đăng nhập!", "Thông báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
