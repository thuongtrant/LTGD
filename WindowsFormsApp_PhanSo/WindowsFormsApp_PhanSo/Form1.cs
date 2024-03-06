using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_PhanSo
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            PhanSo a, b, kq;
            a = new PhanSo();
            kq = new PhanSo();
            try {
                a.tuSO = int.Parse(txtTu1.Text);
                a.mauSo = int.Parse(txtMau1.Text);
                b = new PhanSo(int.Parse(txtTu2.Text),int.Parse(txtMau2.Text)) ;
                
                kq = a.tong(b) ;
                txtTu.Text = kq.tuSO.ToString() ;
                txtMau.Text = kq.mauSo.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            finally
            {
                txtMau.Clear();
                txtTu.Clear();
                txtTu1 .Clear();    
                txtTu2 .Clear();
                txtMau1 .Clear();
                txtMau2 .Clear();

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMau1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
    public class PhanSo
    {
        private int tu, mau;
        public PhanSo()
        {
            tu = 0;
            mau = 1;
        }
        public PhanSo(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public int tuSO
        {
            get { return tu; }
            set { tu = value; }
        }
        public int mauSo
        {
            get { return mau; }
            set { mau = value; }
        }
        public PhanSo tong(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tu = tu * p.mau + mau * p.tu;
            kq.mau = mau * p.mau;
            return kq;
        }
    }
}
