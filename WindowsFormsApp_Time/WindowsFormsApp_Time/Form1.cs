using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Time
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            ThoiGian t = new ThoiGian(int.Parse(txtGio.Text), int.Parse(txtPhut.Text), int.Parse(txtGiay.Text));
            lblKQ.Text = t.HienThiThoiGian();
        }
    }
    struct ThoiGian
    {
        int gio, phut, giay;
        public ThoiGian(int g, int p, int s)
        {
            this.gio = g;
            this.phut = p;
            this.giay = s;
        }

        public int Gio
        {
            get { return gio; }
            set { gio = value; }
        }
        public int Phut
        {
            get { return phut; }
            set { phut = value; }
        }
        public int Giay
        {
            get { return giay; }
            set { giay = value; }
        }
        public string HienThiThoiGian()
        {
            Chuanhoa();
            return String.Format("{0:0} : {1:00}: {2:00}", gio, phut, giay);
        }
        public void Chuanhoa()
        {
            int t = giay / 60;
            giay = giay >= 60 ? giay % 60 : giay;
            phut += t;
            t =phut / 60;
            phut = phut >= 60 ? phut % 60 : phut;
            gio += t;
            gio = gio >= 24 ? gio % 24 : gio;

        }
    }
}
