using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_QuaySo
{
    public partial class Form1 : Form
    {
        string path;

        public Form1()
        {
            InitializeComponent();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
             int so1, so2, so3;
            Random r = new Random();
            so1 = r.Next(1,7);
            so2 = r.Next(1,7);
            so3 = r.Next(1,7);
            picSo1.Image = Image.FromFile(path + "dic" + so1.ToString() + ".gif");
            picSo2.Image = Image.FromFile(path + "dic" + so2.ToString() + ".gif");
            picSo3.Image = Image.FromFile(path + "dic" + so3.ToString() + ".gif");
            lblResult.Text = (so1 + so2 + so3).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\Hinhxucxac\";

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
