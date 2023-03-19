using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGitHub
{
    struct ThongTinHocSinh
    {
        public string hoTen { get; set; }
        public string khoa { get; set; }

        public ThongTinHocSinh(string ten, string khoa)
        {
            this.hoTen = ten;
            this.khoa = khoa;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            ThongTinHocSinh hs = new ThongTinHocSinh();

            hs.hoTen = "Nguyen van a";
            hs.khoa = "toan";

            ThongTinHocSinh hs2 = new ThongTinHocSinh("Nguyen van B","toan");

            Console.WriteLine("Ten hoc sinh la {0}", hs.hoTen);
            Console.WriteLine("Ten hoc sinh 2 la {0}", hs2.hoTen);


            //nhap vao so nguyen a
            //Console.Write("Nhap vao so nguyen a = ");
            //int a = int.Parse(Console.ReadLine());
            ////nhap vao so nguyen b
            //Console.Write("Nhap vao so nguyen b = ");
            //int b = int.Parse(Console.ReadLine());

            //float c = (a * 1.0f) / b;

            //if(a >= b)
            //{
            //    Console.WriteLine("Gia tri cua a lon hon gia tri cua b");
            //}
            //else
            //{
            //    Console.WriteLine("Gia tri cua a nho hon gia tri cua b");
            //}

            int a = 10;
            --a;


            //hien thi ket qua
            //Console.WriteLine("<-------------------->");
            //Console.WriteLine("So nguyen a vua nhap la: a = {0}", a);
            //Console.WriteLine("So nguyen b vua nhap la: b = {0}", b);

            //Console.WriteLine("Thuong cua a va b = {0}", c);
            //Console.WriteLine("<-------------------->");
            //Console.WriteLine("Bam phim bat ky de ket thuc!");
            Console.ReadKey();
        }
    }
}
