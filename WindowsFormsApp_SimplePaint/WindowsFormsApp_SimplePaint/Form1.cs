using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_SimplePaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawByMouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDrawMouse f = new FrmDrawMouse();
            f.MdiParent = this;
            f.Show();
        }

        private void drawTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDrawText f = new FrmDrawText();
            f.MdiParent = this;
            f.Show();
        }

        private void drawImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDrawImage f = new FrmDrawImage();
            f.MdiParent = this;
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Do you sure want to exit?", "Message", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                Application.Exit(); 
            }
        }
    }
}
