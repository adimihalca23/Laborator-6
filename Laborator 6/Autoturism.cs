using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_6
{
    class Autoturism
    {
        public string marca;
        public string numarDeInmatriculare;
        public int capacitateCilindrica;

        public Autoturism(string marca, string numarDeInmatriculare, int capacitateCilindrica)
        {
            this.marca = marca;
            this.numarDeInmatriculare = numarDeInmatriculare;
            this.capacitateCilindrica = capacitateCilindrica;
        }

        public void Tipareste()
        {
            Console.WriteLine($"Autoturismul este marca {marca} cu numarul de inmatriculare {numarDeInmatriculare} " +
                $"avand capacitatea cilindrica de {capacitateCilindrica}.");
        }
    }
}
