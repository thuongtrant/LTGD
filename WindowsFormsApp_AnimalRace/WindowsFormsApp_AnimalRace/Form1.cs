using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_AnimalRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if(picLionRun.Right == 0 || picDogRun.Right == 0 || picBirdRun.Right == 0)
            {
                timer1.Enabled = false;
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int rdLion = picLionRun.Left + rd.Next(5, 20);
            int rdDog = picDogRun.Left+ rd.Next(5, 20);
            int rdBird = picBirdRun.Left + rd.Next(5, 20);
            picLionRun.Left = rdLion;
            picDogRun.Left = rdDog;
            picBirdRun.Left = rdBird;
        }

    }
}
