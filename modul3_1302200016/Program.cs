using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302200016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demo kode buah
            KodeBuah_1 buah = KodeBuah_1.GetKodeBuah("C000");
            Console.WriteLine(buah.GetBuah() + " dengan kode " + buah.GetKode());

            Console.WriteLine(" ");

        }
    }
}
