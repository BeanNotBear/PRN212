using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnclassSlot1
{
    internal class student
    {
        private String mssv;
        private String name;
        private double hs1;
        private double hs2;
        private double tbkt;
        private double diemThi;
        private double diemtbmh;

        public student()
        {
        }

        public student(string mssv, string name, double hs1, double hs2, double tbkt, double diemThi, double diemtbmh)
        {
            this.mssv = mssv;
            this.name = name;
            this.hs1 = hs1;
            this.hs2 = hs2;
            this.tbkt = tbkt;
            this.diemThi = diemThi;
            this.diemtbmh = diemtbmh;
        }

        public string Mssv { get => mssv; set => mssv = value; }
        public string Name { get => name; set => name = value; }
        public double Hs1 { get => hs1; set => hs1 = value; }
        public double Hs2 { get => hs2; set => hs2 = value; }
        public double Tbkt { get => tbkt; set => tbkt = value; }
        public double DiemThi { get => diemThi; set => diemThi = value; }
        public double Diemtbmh { get => diemtbmh; set => diemtbmh = value; }
    }
}
