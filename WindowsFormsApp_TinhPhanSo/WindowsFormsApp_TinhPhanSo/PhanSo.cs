using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_TinhPhanSo
{
    internal class PhanSo
    {
        int tuSo, mauSo;
        public PhanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }
        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }
        public int TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }
        public int MauSo
        {
            get { return mauSo; }
            set { mauSo = value; }
        }
        private void Toigian()
        {
            int uc = Configuration.UCLN(tuSo,mauSo);
            if(uc > 0)
            {
                tuSo /= uc;
                mauSo /= uc;
            }
        }
        public PhanSo tong(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuSo = tuSo * p.mauSo + mauSo * p.tuSo;
            kq.mauSo = mauSo * p.mauSo;
            kq.Toigian();
            return kq;
        }
        public PhanSo tru(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuSo = tuSo * p.mauSo - mauSo * p.tuSo;
            kq.mauSo = mauSo * p.mauSo;
            kq.Toigian();
            return kq;
        }
        public PhanSo nhan(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuSo = tuSo   * p.tuSo;
            kq.mauSo = mauSo * p.mauSo;
            kq.Toigian();
            return kq;
        }
    }
}
