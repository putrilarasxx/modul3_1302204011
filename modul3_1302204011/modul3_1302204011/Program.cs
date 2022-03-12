using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204011
{
    public class Program
    {
        static void Main(string[] args)
        {
            kodeBuah objek1 = new kodeBuah();
            kodeBuah.namaBuah inputBuah = kodeBuah.namaBuah.Alpukat;
            Console.WriteLine("Kode buah " + inputBuah + " adalah " + objek1.getKodeBuah(inputBuah));

           
        }
    }
}
