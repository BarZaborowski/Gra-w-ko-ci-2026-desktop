using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_kosci_2026
{
    internal class Kosc
    {
        public int liczbaInstancji = 0;

        public string[] nazwa = { "kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png" };

        public int liczbaOczu = 0;

        public int id = 0;

        public bool czyDostepna = true;

        public int losowa;

        public void Kosci()
        {
            Random rnd = new Random();
            losowa = rnd.Next(1, 7);
            liczbaOczu = losowa;
            id = losowa;
            czyDostepna = true;
        }

        public void Rzut()
        {
            if (czyDostepna == true)
            {
                Random rnd = new Random();
                losowa = rnd.Next(1, 7);
                liczbaOczu = losowa;
                id = losowa;
                czyDostepna = true;
            }
        }

        public void Blok()
        {
            czyDostepna = false;
        }
    }
}
