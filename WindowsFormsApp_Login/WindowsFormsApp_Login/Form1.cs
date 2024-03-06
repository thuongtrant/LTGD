using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = "", pass = "";
            user = txtUser.Text;
            pass = txtPass.Text;
            if(user == ""  || pass == "")
            {
                MessageBox.Show("Bạn phải nhập username và password!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if(pass.Length > 10)
            {
                MessageBox.Show("Password tối đa 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtPass.Clear();
                txtPass.Focus();
                return;
            }
            if (user == "admin" && pass == "123456")
            {
                Form f = new Form2();
                f.ShowDialog();
            }
            else
                MessageBox.Show("Sai username/ password!", "Thông báo", MessageBoxButtons.OK);
                txtPass.Clear() ;
                txtUser.Clear();
        }

        private void btnThuLai_Click(object sender, EventArgs e)
        {
            txtUser.Clear() ;
            txtPass.Clear() ;
            txtUser.Focus();
        }
    }
}
