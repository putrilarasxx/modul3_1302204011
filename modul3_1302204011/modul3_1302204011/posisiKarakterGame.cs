using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204011
{
    public class posisiKarakterGame
    {
        public enum statusKarakter { jongkok, berdiri, tengkurap, terbang }

        public enum aksiKarakter { TombolS, TombolW, TombolX }

        public class Transisi
        {
            public statusKarakter stateAwal;
            public statusKarakter stateAkhir;
            public aksiKarakter trigger;

            public Transisi(statusKarakter awal, statusKarakter akhir, aksiKarakter doing)
            {
                this.stateAwal = awal;
                this.stateAkhir = akhir;
                this.trigger = doing;
            }

            Transisi[] perubahanState = {
                new Transisi(statusKarakter.terbang, statusKarakter.jongkok, aksiKarakter.TombolX),
                new Transisi(statusKarakter.berdiri, statusKarakter.terbang, aksiKarakter.TombolW)
            };

            public statusKarakter stateNow = statusKarakter.berdiri;

            public statusKarakter getStatusAkhir(statusKarakter awal, aksiKarakter doing)
            {
                statusKarakter statusAkhir = awal;

                for (int i = 0; i < perubahanState.Length; i++)
                {
                    statusKarakter statusAwal = perubahanState[i].stateAwal;
                    aksiKarakter triggerState = perubahanState[i].trigger;

                    if (statusAwal == awal && triggerState == doing)
                    {
                        statusAkhir = perubahanState[i].stateAkhir;

                    }
                }
                return statusAkhir;
            }

            public void aksiDoing(aksiKarakter doing)
            {
                statusKarakter stateBerikutnya = getStatusAkhir(stateNow, doing);
                stateNow = stateBerikutnya;

                Console.WriteLine("State saat ini adalah: " + stateNow);

                if (stateNow == statusKarakter.berdiri)
                {
                    Console.WriteLine("Posisi take off");
                }
                else
                {
                    Console.WriteLine("Posisi landing");
                }
            }

        }
        public posisiKarakterGame()
        {
        }
    }
}
