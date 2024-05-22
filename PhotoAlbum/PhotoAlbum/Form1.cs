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

namespace PhotoAlbum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTree();
        }
        private void InitTree()
        {
            string[] drives = Directory.GetLogicalDrives();
            TreeNode node = null;  
            foreach (string drive in drives)
            {
                node = new TreeNode(drive);
                treeFolder.Nodes.Add(node);
                node.Nodes.Add("Temp");
            }
        }

        private void treeFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            node.ImageIndex = 1;
            try
            {
                foreach (string dir in Directory.GetDirectories(node.FullPath))
                {
                    TreeNode n = node.Nodes.Add(Path.GetFileName(dir));
                    n.Nodes.Add("Temp");
                }
            }
            catch { }
        }

        private void treeFolder_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }

        private void treeFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                picView.Image = null;
                string[] arrFiles = Directory.GetFiles(e.Node.FullPath);
                pnThum.Controls.Clear();
                foreach (string file in arrFiles)
                {
                    if(file.ToLower().EndsWith(".jpg") ||
                        file.ToLower().EndsWith(".gif") ||
                        file.ToLower().EndsWith(".png") ||
                        file.ToLower().EndsWith(".bmp") ||
                        file.ToLower().EndsWith(".jpeg"))
                    {
                        PictureBox pic = new PictureBox();
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Image = Image.FromFile(file);
                        pic.Height = pnThum.Height - 10;
                        pic.Width = pnThum.Height * 5 / 4;
                        //pic.Cursor = Cursor;
                        pnThum.Controls.Add(pic);
                        pic.Click += new EventHandler(pictureBox_Click);
                    }    
                }
            }catch { }
        }
        private void pictureBox_Click(object sender, EventArgs e) {
            PictureBox pic = (PictureBox)sender;
            picView.Image = pic.Image;
                
        }
    }
}
