using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_GameXucXac
{
    public partial class Form1 : Form
    {
        string path;
        int nChoose;
        int nCount, nWin, nLose;

        private void Form1_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\HinhXucXac\";
            Init();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            nChoose = int.Parse(button.Text);
            picChoose.Image = Image.FromFile(path + "dic" + nChoose.ToString() + ".gif");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int res = r.Next(1, 7);
            string kq;
            nCount++;
            picResult.Image = Image.FromFile(path + "dic" + res.ToString() + ".gif");
            if (res == nChoose)
            {
                nWin++;
                kq = "Thắng";
            }
            else { 
                nLose++;
                kq = "Thua";
            }
            lblCount.Text = nCount.ToString();
            lblWin.Text = nWin.ToString() + string.Format("{0: 0.00}%", (nWin * 100) / nCount);
            lblLose.Text = nLose.ToString() + string.Format("{0: 0.00}%", (nLose * 100) / nCount);

            listResult.Items.Add(string.Format("{0}. {1} (Đoán {2} ra {3}).", nCount, kq, nChoose,res));

        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Init()
        {
            listResult.Items.Clear();
            lblLose.Text = lblCount.Text = lblWin.Text = " ";
            nChoose = 1;
            picChoose.Image = Image.FromFile(path + "dic1.gif");
            nCount = nWin = nLose = 0;
            picChoose.Image = null;
        }
      
    }
}
