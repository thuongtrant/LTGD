using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_DiChuyenAnh
{
    public partial class Form1 : Form
    {
        string path;
        Random r = new Random();
        Point d;
        PictureBox Hinh;

        public Form1()
        {
            InitializeComponent();
        }
        public void AddNewPicture()
        {
            Hinh = new PictureBox();
            int so = r.Next(1, 6);
            Hinh.Image = Image.FromFile(path + so.ToString() + ".png");
            Hinh.Location = new Point(30, 40);
            Hinh.Size = new Size(70, 70);
            Hinh.SizeMode = PictureBoxSizeMode.StretchImage;
            Hinh.MouseDown += new MouseEventHandler(Hinh_MouseDown);
            Hinh.MouseMove += new MouseEventHandler(Hinh_MouseMove);
            Hinh.MouseUp += new MouseEventHandler(Hinh_MouseUp);
            Controls.Add(Hinh);
        }
        private void Hinh_MouseDown(object sender, MouseEventArgs e)
        {
            d = e.Location;
        }
        private void Hinh_MouseMove(object sender, MouseEventArgs e)
        {
            int dx = e.X - d.X;
            int dy = e.Y - d.Y;
            Hinh.Left += dx;
            Hinh.Top += dy;
        }
        private void Hinh_MouseUp(object sender, MouseEventArgs e)
        {
            if (pnBound.Bounds.Contains(Hinh.Bounds))
            {
                PictureBox a = (PictureBox)sender;
                pnBound.Controls.Add(a);
                AddNewPicture();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\Images\";
            AddNewPicture();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    d = Hinh.Location;
                    Hinh.Left -= 5;
                    Hinh.Top += 0;
                    break;
                case Keys.Up:
                    d = Hinh.Location;
                    Hinh.Left += 0;
                    Hinh.Top -= 5;
                    break;
                case Keys.Down:
                    d = Hinh.Location;
                    Hinh.Left += 0;
                    Hinh.Top += 5;
                    break;
                case Keys.Right:
                    d = Hinh.Location;
                    Hinh.Left += 5;
                    Hinh.Top += 0;
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
