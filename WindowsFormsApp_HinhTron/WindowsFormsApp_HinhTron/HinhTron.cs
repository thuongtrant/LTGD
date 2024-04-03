using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_HinhTron
{
    internal class HinhTron
    {
        private Diem tam;
        private double banKinh;
        public HinhTron(Diem tam, double banKinh)
        {
            this.tam = tam;
            this.banKinh = banKinh;
        }
        public double BanKinh
        {
            get { return banKinh; } set { banKinh = value;}
        }
        public Diem Tam { get { return tam; } set {  tam = value; } }
        public double tinhDienTich()
        {
            return this.BanKinh * this.BanKinh * Math.PI;
        }
        public double tinhChuVi()
        {
            return this.BanKinh * 2 * Math.PI;
        }
    }
}
