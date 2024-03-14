using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_SapXepMang
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int[] toantu = { 1, 2, 3, 4,5 ,6,7,8,9,10
        ,11 ,12,13,14,15,16,17,18,19,20};
        int vitri = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoPhanTu.Text);
        }
    
    }
}
