using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_SimplePaint
{
    public partial class FrmDrawImage : Form
    {
        public FrmDrawImage()
        {
            InitializeComponent();
        }

        private void FrmDrawImage_Paint(object sender, PaintEventArgs e)
        {
            //string pathImage = Application.StartupPath + @"\1.png";
            //Image img = Image.FromFile(pathImage);
            //Rectangle rec = new Rectangle(20, 20, 500, 400);
            //e.Graphics.DrawImage(img, rec);

            Rectangle rc1 = new Rectangle(0,0,ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rc2 = new Rectangle(0,ClientRectangle.Height / 2, ClientRectangle.Width / 2,ClientRectangle.Height / 2);
            Rectangle rc3 = new Rectangle(ClientRectangle.Width / 2, 0, ClientRectangle.Width / 2, ClientRectangle.Height );

            DrawImage(rc1, e.Graphics);
            DrawText(rc2, e.Graphics);
            DrawPolygon(rc3 , e.Graphics);
        }
        private void DrawImage(Rectangle rc, Graphics g)
        {
            Image img = Image.FromFile(Application.StartupPath + @"\1.png");
            g.DrawImage(img, rc);

            // Vẽ chữ
            Font f = new Font("Arial", 36, FontStyle.Bold);
            SolidBrush br = new SolidBrush(Color.FromArgb(100, 255, 255, 0));
            StringFormat fm = new StringFormat();
            fm.Alignment = StringAlignment.Far;
            g.DrawString("Anita", f, br, rc, fm);
        }
        private void DrawText(Rectangle rc, Graphics g)
        {
            LinearGradientBrush br = new LinearGradientBrush(rc, Color.Black, Color.White, 45);
            g.FillRectangle(br, rc);
            LinearGradientBrush lbr = new LinearGradientBrush(new Rectangle(0, 0, 40, 40),Color.Red, Color.Yellow, LinearGradientMode.BackwardDiagonal);
            StringFormat fm = new StringFormat();
            fm.Alignment = StringAlignment.Center;
            fm.LineAlignment = StringAlignment.Center;
            Font f = new Font("Arial", 48, FontStyle.Bold| FontStyle.Italic);
            g.DrawString("Hello", f,lbr, rc, fm);
        }
        private void DrawPolygon(Rectangle rc, Graphics g)
        {
            Point[] arrp = {new Point(rc.Left,rc.Height/4),
            new Point(rc.Left + rc.Width/2,0)
            ,new Point(rc.Left + rc.Width,rc.Height/4)
            ,new Point(rc.Left + rc.Width/2 , rc.Height)};
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(arrp);
            PathGradientBrush br = new PathGradientBrush(path);
            br.CenterColor = Color.White;
            Color[] arrC = { Color.Red, Color.Yellow, Color.Cyan };
            br.SurroundColors = arrC;
            g.FillPolygon(br, arrp);
        }

        private void FrmDrawImage_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
