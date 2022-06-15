using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_6
{
    class Catalog
    {
        public string numeleClasei;
        public Elev[] elevi;

        public Catalog(string numeleClasei, Elev[] elevi)
        {
            this.numeleClasei = numeleClasei;
            this.elevi = elevi;
        }

        public void Tiparteste()
        {
            Console.WriteLine($"Clasa: {numeleClasei}");

            foreach(Elev elev in elevi)
            {
                Console.WriteLine($"{elev.nume} {elev.prenume}");
            }
        }

        public Premiant GetPremiantul()
        {
            double mediaMaxima = 0;

            Premiant premiant = new Premiant();

            foreach(Elev elev in elevi)
            {
                elev.Media();
                if(elev.Media() > mediaMaxima)
                {
                    mediaMaxima = elev.Media();
                    premiant.nume = elev.nume;
                    premiant.prenmume = elev.prenume;
                    premiant.media = mediaMaxima;
                }
            }

            return premiant;
        }
    }
}
