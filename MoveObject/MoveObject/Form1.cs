using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveObject
{
    public partial class Form1 : Form
    {
        int count = 0;
        Point pOld; // Biến lưu vị trí nhấn chuột    
        Random r = new Random();
        string[] arrFiles;
        int imgWidth = 90;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Dùng chuột hoặc các phím mũi tên di chuyển hình vào trong panel bên phải";
            arrFiles = Directory.GetFiles(Application.StartupPath + @"\Images");
            AddNewPicture();
        }
        private void AddNewPicture()
        {
            count++;
            string file = arrFiles[r.Next(arrFiles.Length)];
            Image img = Image.FromFile(file);
            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = count.ToString();
            pictureBox.Image = img;
            pictureBox.Location = new Point(0,0);
            pictureBox.Width = pictureBox.Height = imgWidth;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //Cài sự kiện nhấn chuột;
            pictureBox.MouseDown += Pic_MouseDown;
            pictureBox.MouseMove += Pic_MouseMove;
            pictureBox.MouseUp += Pic_MouseUp;
            this.Controls.Add(pictureBox);
            // Sắp xếp lại pnBound
            this.Controls.SetChildIndex(pnBound,this.Controls.Count-1); 

        }
        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }
        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)//giữ chuột trái di chuyển
            {
                PictureBox pic = (PictureBox)sender;
                int dx = e.X - pOld.X;
                int dy = e.Y - pOld.Y;
                pic.Left += dx;
                pic.Top += dy;

            }    
        }
        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (pnBound.Bounds.Contains(pic.Bounds))
            {
                pnBound.Controls.Add(pic);
                AddNewPicture();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Control[] arrControl = this.Controls.Find(count.ToString(),false);
            PictureBox picBox = (PictureBox)arrControl[0];
            switch(e.KeyCode)
            {
                case Keys.Left:
                    if((picBox.Left - 5) > 0)
                        picBox.Left-= 5;
                        break;
                    
                case Keys.Right:
                    if((picBox.Right+5) < ClientRectangle.Width)
                        picBox.Left+=5;
                    break;
                case Keys.Up:
                    if((picBox.Top-5) > 0) 
                        picBox.Top-=5;
                    break;
                case Keys.Down:
                    if((picBox.Bottom+5) < ClientRectangle.Height)
                        picBox.Top+=5;
                    break;

                    if (pnBound.Bounds.Contains(picBox.Bounds))
                    {
                        pnBound.Controls.Add(picBox);
                        AddNewPicture() ;
                    }
            }
        }

        private void pnBound_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void pnBound_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                pnBound.Left += (e.X - pOld.X);
                pnBound.Top += (e.Y - pOld.Y);
            }
        }
    }

}
