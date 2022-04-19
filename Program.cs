using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4355
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan(9865666, "Dominic", 5000000);
            Karyawan karyawan2 = new Karyawan(2244352, "Hannams", 7000000);


            
            Console.WriteLine(" NO   NIK / NAMA\t\t   Gaji Bulanan\t  ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" 1.  {0} {1} \t\t  {2}\t ", karyawan1.NIK, karyawan1.Nama, karyawan1.Gaji);
            Console.WriteLine(" 2.  {0} {1} \t\t  {2}\t ", karyawan2.NIK, karyawan2.Nama, karyawan2.Gaji);

            Console.WriteLine("\n\nAsikkkkk dpt kenaikan gaji nih!!!\n");

            Console.WriteLine(" NO   NIK / NAMA\t\t   Gaji Bulanan\t  ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" 1.  {0} {1} \t\t  {2}\t ", karyawan1.NIK, karyawan1.Nama, karyawan1.NaikGaji);
            Console.WriteLine(" 2.  {0} {1} \t\t  {2}\t ", karyawan2.NIK, karyawan2.Nama, karyawan2.NaikGaji);


            Console.ReadKey();
        }
    }
}
