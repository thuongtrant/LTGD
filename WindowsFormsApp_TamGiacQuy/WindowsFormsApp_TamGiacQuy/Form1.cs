//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace WindowsFormsApp_TamGiacQuy
//{
//    public partial class Form1 : Form
//    {
//        private TamGiac tamGiac;

//        public Form1()
//        {
//            InitializeComponent();
//        }
//        private void btnKiemTra_Click(object sender, EventArgs e)
//        {
//            // Lấy tọa độ của 3 điểm của tam giác từ TextBoxes
//            double x1 = double.Parse(txtX1.Text);
//            double y1 = double.Parse(txtY1.Text);
//            double x2 = double.Parse(txtX2.Text);
//            double y2 = double.Parse(txtY2.Text);
//            double x3 = double.Parse(txtX3.Text);
//            double y3 = double.Parse(txtY3.Text);

//            // Khởi tạo một đối tượng tam giác
//            tamGiac = new TamGiac(new Diem(x1, y1), new Diem(x2, y2), new Diem(x3, y3));

//            // Lấy tọa độ của điểm cần kiểm tra từ TextBox
//            double xDiem = double.Parse(txtXDiem.Text);
//            double yDiem = double.Parse(txtYDiem.Text);
//            Diem diem = new Diem(xDiem, yDiem);

//            // Kiểm tra xem điểm có nằm trong tam giác hay không
//            bool ketQua = tamGiac.KiemTraDiemTrongTamGiac(diem);

//            // Hiển thị kết quả
//            if (ketQua)
//            {
//                lblKetQua.Text = "Điểm nằm trong tam giác.";
//                lblKetQua.ForeColor = Color.Green;
//            }
//            else
//            {
//                lblKetQua.Text = "Điểm không nằm trong tam giác.";
//                lblKetQua.ForeColor = Color.Red;
//            }
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {

//        }
//    }
//    class Diem
//        {
//            private int x;
//            private int y;
//            public int X
//            {
//                get { return x; }
//                set { x = value; }
//            }
//            public int Y
//            {
//               get { return y; }
//               set { y = value; }
//            }

//        public Diem(int h, int t)
//            {
//                x = h;
//                y = t;
//            }
//        }

//        // Định nghĩa lớp TamGiac
//        public class TamGiac
//        {
//            private Diem diem1, diem2, diem3;

//            public TamGiac(Diem d1, Diem d2, Diem d3)
//            {
//                diem1 = d1;
//                diem2 = d2;
//                diem3 = d3;
//            }
            
//            // Kiểm tra xem một điểm có nằm trong tam giác hay không
//            public bool KiemTraDiemTrongTamGiac(Diem diem)
//            {
//                double ABC = DienTichTamGiac(diem1, diem2, diem3);
//                double ABP = DienTichTamGiac(diem1, diem2, diem);
//                double ACP = DienTichTamGiac(diem1, diem3, diem);
//                double BCP = DienTichTamGiac(diem2, diem3, diem);

//                return (ABP + ACP + BCP == ABC);
//            }

//            // Tính diện tích của một tam giác bằng phương pháp diện tích Heron
//            private double DienTichTamGiac(Diem a, Diem b, Diem c)
//            {
//                double ab = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
//                double bc = Math.Sqrt(Math.Pow(c.X - b.X, 2) + Math.Pow(c.Y - b.Y, 2));
//                double ac = Math.Sqrt(Math.Pow(c.X - a.X, 2) + Math.Pow(c.Y - a.Y, 2));
//                double p = (ab + bc + ac) / 2;
//                return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
//            }
//        }
//    }

