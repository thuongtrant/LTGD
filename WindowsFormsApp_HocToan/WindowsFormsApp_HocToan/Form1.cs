using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_HocToan
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        string[] toanTu = { "+", "-", "x", "/" };
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            double kq = 0;
            switch(index)
            {
                case 0:
                    kq = int.Parse(lbl1.Text) + int.Parse(lbl2.Text); break;
                case 1:
                    kq = int.Parse(lbl1.Text) - int.Parse(lbl2.Text); break;
                case 2:
                    kq = int.Parse(lbl1.Text) * int.Parse(lbl2.Text); break;
                case 3:
                    kq = int.Parse(lbl1.Text) / int.Parse(lbl2.Text); break;
            }
            try { 
                int user = int.Parse(txtDoan.Text);
                if (user == kq)
                {
                    lblKQ.Text = "Chính xác!";
                }
                else
                    lblKQ.Text = "Sai!";
            }catch(FormatException) {
                MessageBox.Show("Bạn phải nhập kết quả dự đoán là số!", "Thông báo", MessageBoxButtons.OK);

            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            int so1, so2;
            do {
                so1 = rnd.Next(10);
                so2 = rnd.Next(10);
                index = rnd.Next(4);
            } while(index == 3 && so2 == 0);
            lbl1.Text = so1.ToString();
            lbl2.Text = so2.ToString();
            lblToanTu.Text = toanTu[index];
            lblKQ.Text = "";
            txtDoan.Text = "";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDoan.Text += bt.Text;
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            if (txtDoan.Text != "")
                return;
            txtDoan.Text = "-";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtDoan.Text == "") return;
            txtDoan.Text = txtDoan.Text.Substring(0,txtDoan.Text.Length-1);
        }
    }
}
