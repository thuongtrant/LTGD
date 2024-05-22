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
    public partial class FrmDrawText : Form
    {
        public FrmDrawText()
        {
            InitializeComponent();
        }

        private void FrmDrawText_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            string chuoi = "Hello";

            Font f = new Font("Arial", 36 ,FontStyle.Bold);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Far;
            g.DrawString(chuoi,f,Brushes .Green, ClientRectangle,stringFormat);


            TextureBrush tbr = new TextureBrush(Image.FromFile(Application.StartupPath + @"\1.png"));
            stringFormat.Alignment=StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Far;
            g.DrawString(chuoi, f, tbr, ClientRectangle, stringFormat);

            HatchBrush hbr = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.Orange, Color.Yellow);
            stringFormat.LineAlignment = StringAlignment.Near; 
            stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            g.DrawString(chuoi, f,hbr, ClientRectangle, stringFormat);

            LinearGradientBrush lbr = new LinearGradientBrush(new Rectangle(50, 50, 10, 10), Color.Blue, Color.White, 45);
            stringFormat.Alignment = StringAlignment.Far;
            stringFormat.LineAlignment = StringAlignment.Far;
            g.DrawString(chuoi, f, lbr, ClientRectangle, stringFormat);
        }

        private void FrmDrawText_SizeChanged(object sender, EventArgs e)
        {
            Invalidate(); // Gọi hàm Paint
        }
    }
}
