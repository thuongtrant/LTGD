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

namespace WindowsFormsApp_PhotoAlbum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void InitTree() // load toan bo o dia len treeview
        {
            string[] drives = Environment.GetLogicalDrives();
            foreach (string drive in drives)
            {
                DriveInfo d = new DriveInfo(drive);
                string name = drive.Substring(0, 1) + ":\\";
                TreeNode node = new TreeNode(name,0,0);
                if (d.IsReady == true)
                    node.Nodes.Add("...");
                node.Tag = drive;
                treeFolder.Nodes.Add(node);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTree();
        }

        private void treeFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if(e.Node.Nodes.Count > 0) {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    e.Node.Nodes.Clear();
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());
                    foreach (string dir in dirs)
                    {
                        DirectoryInfo dirInfo = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(dirInfo.Name);
                        try
                        {
                            node.Tag = dir;
                            if (dirInfo.GetDirectories().Count() > 0)
                                node.Nodes.Add(null, "...");
                        }
                        catch (UnauthorizedAccessException)
                        {
                            node.SelectedImageIndex = 0;
                        } catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error!");
                        }
                        finally
                        {
                            e.Node.Nodes.Add(node);
                        }
                    }
                }
            }
        }

        private void treeFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pnThum.Controls.Clear();
            picView.Image = null;
            string path = e.Node.FullPath;
            string[] files = Directory.GetFiles(path);
            foreach (string file in files) {
                string f = file.ToLower();
                if (f.EndsWith(".jpg") || f.EndsWith(".jpeg") || f.EndsWith(".png") || f.EndsWith(".gif") || f.EndsWith(".bmp") )
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(file);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Size = new Size(50, 50);
                    pic.Click += new EventHandler(pic_Click);
                    pnThum.Controls.Add(pic);
                }
            }
        }
        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox p =(PictureBox)sender;
            picView.Image = p.Image;
            picView.SizeMode = PictureBoxSizeMode.StretchImage;
        }


    }
}
