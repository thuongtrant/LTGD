using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_RandomNumber
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int mark = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuaySo_Click(object sender, EventArgs e)
        {
            int so1, so2, so3;
            so1 = random.Next(1, 7);
            so2 = random.Next(1, 7);
            so3 = random.Next(1, 7);
            lbl1.Text = so1.ToString();
            lbl2.Text = so2.ToString(); 
            lbl3.Text = so3.ToString();

            if(rd3.Checked)
            {
                if(so1 + so2 + so3 <= 10) {
                    mark += 10;
                }else
                    mark -= 10;
            }else
                if (so1 + so2 + so3 > 10)
            {
                mark += 10;
            }
            else
                mark -= 10;
            lblDiem.Text = mark.ToString();
        }
    }
}
