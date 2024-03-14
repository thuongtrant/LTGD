using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_XuLyChuoi
{

    public partial class Form1 : Form
    {
        private string originalString;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThayThe_Click(object sender, EventArgs e)
        {
            txtS1.Text = txtS1.Text.Replace(txtS2.Text, txtS3.Text);
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            txtS1.Text = txtS1.Text.Insert(int.Parse(txtVtChen.Text),txtS2.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtS1.Text = txtS1.Text.Remove(txtS1.Text.IndexOf(txtS2.Text), txtS2.TextLength);
        }

        private void btnChuanHoa_Click(object sender, EventArgs e)
        {
            string[] subName = txtS1.Text.Split(' ', '\n', '\t');


            for (int i = 0; i < subName.Length; i++)
            {
                string firstChar = subName[i].Substring(0, 1);
                string otherChar = subName[i].Substring(1);
                subName[i] = firstChar.ToUpper() + otherChar.ToLower();
                txtS1.Text += subName[i] + " ";
                string result = String.Join(" ", subName);
                txtS1.Text = result;
            }
            
        }

        private void btnDao_Click(object sender, EventArgs e)
        {
            string[] subName = txtS1.Text.Split(' ', '\n', '\t');
            Array.Reverse(subName);
            string result = String.Join(" ", subName);
            txtS1.Text = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalString = "tran thuong";
            txtS1.Text = originalString;
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            txtS1.Text = originalString;
        }

        private void btnLayChuoiCon_Click(object sender, EventArgs e)
        {
            int dau = int.Parse(txtVtTu.Text);
            int cuoi = int.Parse(txtSoKiTu.Text);
            string result = txtS1.Text.Substring(dau, cuoi);
            txtS1.Text = result;
        }
    }
}
