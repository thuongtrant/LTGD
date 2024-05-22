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

namespace WindowsFormsApp_EmployeeManage
{
    public partial class Form1 : Form
    {
        Employee[] ds = new Employee[100];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

      
        private void themNV(Employee nv) { 
            ListViewItem item = new ListViewItem(nv.Name);
            item.SubItems.Add(nv.Age.ToString());
            item.SubItems.Add(nv.Address);
            lvDS.Items.Add(item);

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string ten = txtName.Text;
            int tuoi = int.Parse(txtAge.Text);
            string diachi = txtAddress.Text;
            ds[i] = new Employee(ten, tuoi, diachi);
            themNV(ds[i]);
            i++;
            txtName.Clear();
            txtAge.Clear();
            txtAddress.Clear();
            txtName.Focus();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Empl file (*.empl) | *.empl";
            DialogResult re = new DialogResult();
            re = save.ShowDialog();
            if(re == DialogResult.OK)
            {
                string path = save.FileName;
                StreamWriter writer = new StreamWriter(@path);
                for(int j = 0; j < i;j++)
                {
                    string s = ds[j].Name + '#' + ds[j].Age.ToString() + '#' + ds[j].Address;
                    writer.WriteLine(s);
                }
                writer.Close();
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvDS.Items.Clear();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Empl file (*.empl) | *.empl";
            DialogResult re = new DialogResult();
            re = open.ShowDialog();
            if(re == DialogResult.OK)
            {
                string path = open.FileName;
                StreamReader reader = new StreamReader(@path);
                string text;
                if(File.Exists(@path))
                {
                    string[] kq = File.ReadAllLines(@path);
                    for (int i = 0; i < kq.Length; i++)
                    {
                        text = reader.ReadLine();
                        string[] value = text.Split(new char[] {'#'});
                        ListViewItem item = new ListViewItem(value[0]);
                        item.SubItems.Add(value[1]);
                        item.SubItems.Add(value[2]);    
                        lvDS.Items.Add(item);
                    }

                    reader.Close();
                }
                
            }
        }
    }
}
