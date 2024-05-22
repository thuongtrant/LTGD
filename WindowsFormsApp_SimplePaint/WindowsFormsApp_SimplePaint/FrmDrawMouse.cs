﻿using System;
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
    public partial class FrmDrawMouse : Form
    {
        Color color;
        int pentWidt; // Độ dày nét vẽ
        Point pOld; // ĐIểm lưu vị trí điểm nhấn chuột
        Bitmap bmp; // Vẽ trên bitmap này sau đó mới vẽ trên form
        public FrmDrawMouse()
        {
            InitializeComponent();
        }

        private void FrmDrawMouse_Load(object sender, EventArgs e)
        {
            color = Color.Red;
            pentWidt = 1;
            // bmp có kích thước = bằng kích thước màn hình
            bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        }

        private void FrmDrawMouse_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void FrmDrawMouse_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Pen pen = new Pen(color, pentWidt);
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                Graphics g = Graphics.FromImage(bmp);
                g.DrawLine(pen, pOld, e.Location);
                pOld = e.Location;
                Invalidate();
            }
        }

        private void FrmDrawMouse_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);

        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.R: color = Color.Red; break;
                case Keys.G: color = Color.Green; break;
                case Keys.B: color = Color.Blue ; break;
                case Keys.Up:pentWidt++;break;
                case Keys.Down:pentWidt--;break;
            }
            return true;
        }
    }
}
