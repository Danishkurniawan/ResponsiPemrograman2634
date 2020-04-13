using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2634
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("1.", "190110021", "Danish", 2200000);
            Karyawan karyawan2 = new Karyawan("2.", "190112311", "Alex", 2600000);
            Console.WriteLine("No NIK/Nama               Gaji Bulanan");
            Console.WriteLine("--------------------------------------");
            karyawan1.DataKaryawan();
            karyawan2.DataKaryawan();
            Console.WriteLine();
            Console.WriteLine("Asyiiiiik kenaikan gaji 10 % Nichh");
            Console.WriteLine();
            karyawan1.NaikGaji();
            karyawan2.NaikGaji();

            Console.ReadKey();
        }
    }
}
