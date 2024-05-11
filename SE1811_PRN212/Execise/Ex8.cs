using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise
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

    internal class Ex8
    {

        static void Main(string[] args)
        {
            List<student> list = new List<student>();
            list.Add(new student("HS001", "Nguyen Ngoc Anh", 8 ,8, 8.0, 8, 8.0));
            list.Add(new student("HS002", "Dang Ba Nam", 8, 9, 8.7, 8, 8.5));
            list.Add(new student("HS003", "Nguyen Ngoc Anh", 7, 6, 6.3, 9, 7.2));
            list.Add(new student("HS004", "Le Duc Tu", 7, 7, 7.0, 8, 7.3));
            list.Add(new student("HS005", "Mac Van Vien", 9, 7, 8.0, 8, 8.0));
            list.Add(new student("HS006", "Vu Dinh Toan", 9, 10, 9.7, 10, 9.8));
            list.Add(new student("HS007", "Ngo Dinh Tung ", 8,9, 8.7, 8, 8.5 ));
            list.Add(new student("HS008", "Do Huu Nam", 7, 7, 7.0, 9, 7.7));
            Console.WriteLine($"|{"STT",3}|{"Ma hoc sinh",15}|{"Ho va ten",18}|{@"Diem he so", 17}|{"Diem TBKT",15}|{"Diem thi",15}|{"Diem TBMH",10}|");
            for (int i = 0; i < list.Count;  i++)
            {
                Console.WriteLine($"|{i,3}|{list[i].Mssv,15}|{list[i].Name,18}|{list[i].Hs1,8}|{list[i].Hs2,8}|{list[i].Tbkt,15}|{list[i].DiemThi,15}|{list[i].Diemtbmh, 10}|");
            }
        }
    }
}
