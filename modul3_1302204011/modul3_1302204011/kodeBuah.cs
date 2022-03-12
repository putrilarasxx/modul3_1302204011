using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204011
{
    public class kodeBuah
    {
		public enum namaBuah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka }
		public kodeBuah()
        {
        }
        public int getKodeBuah(namaBuah inputBuah)
        {
            int[] arrayBuah = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int indexBuah = (int)inputBuah;
            return arrayBuah[indexBuah];
        }
	}
}

