using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_6
{
    class Elev
    {
        public string nume;
        public string prenume;
        public int[] note;

        public Elev(string nume, string prenume)
        {
            this.nume = nume;
            this.prenume = prenume;
        }

        public int Media()
        {
            int suma = 0;

            foreach(int nota in note)
            {
                suma += nota;
            }

            return suma / note.Length;
        }

        public void Tipareste()
        {
            Console.WriteLine($"Nume: {nume}, Prenume: {prenume}");
            foreach(int nota in note)
            {
                Console.Write($"{nota}, ");
            }
        }
    }
}
