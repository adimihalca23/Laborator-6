using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_6
{
    class Dulap
    {
        public int lungime;
        public int latime;
        public int inaltime;

        public Dulap(int lungime, int latime, int inaltime)
        {
            this.lungime = lungime;
            this.latime = latime;
            this.inaltime = inaltime;
        }

        public int CalculVolum()
        {
            if (lungime <= 0 || latime <= 0 || inaltime <= 0)
            {
                return 0;
            }

            return lungime * latime * inaltime;
        }

        public void Tipareste(int volum)
        {
            Console.WriteLine($"Volumul dulapului este {volum}.");
        }

    }
}
