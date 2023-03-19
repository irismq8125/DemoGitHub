using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nhap vao so nguyen a
            Console.Write("Nhap vao so nguyen a = ");
            int a = int.Parse(Console.ReadLine());
            //nhap vao so nguyen b
            Console.Write("Nhap vao so nguyen b = ");
            int b = int.Parse(Console.ReadLine());

            float c = (a * 1.0f) / b;

            //hien thi ket qua
            Console.WriteLine("<-------------------->");
            Console.WriteLine("So nguyen a vua nhap la: a = {0}",a);
            Console.WriteLine("So nguyen b vua nhap la: b = {0}",b);

            Console.WriteLine("Thuong cua a va b = {0}", c);
            Console.WriteLine("<-------------------->");
            Console.WriteLine("Bam phim bat ky de ket thuc!");
            Console.ReadKey();
        }
    }
}
