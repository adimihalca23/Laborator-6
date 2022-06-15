using System;

namespace Laborator_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex3();
        }

        static void Ex1()
        {
            Dulap dulap = new Dulap(-4, 15, 8);

            if (dulap.CalculVolum() == 0)
            {
                throw new Exception("Parametru mai mic decat 0.");
            }
            else
            {
                dulap.Tipareste(dulap.CalculVolum());
            }
        }

        static void Ex2()
        {
            Autoturism autoturism1 = new Autoturism("Tesla", "SM 23 ADY", 2500);
            Autoturism autoturism2 = new Autoturism("Dacia", "SM 15 ADY", 2000);

            autoturism1.Tipareste();
            autoturism2.Tipareste();
        }

        static void Ex3()
        {
            Elev elev1 = new Elev("Michael", "Jordan");
            elev1.note = new int[] { 7, 8, 9 };
            Elev elev2 = new Elev("Kobe", "Bryant");
            elev2.note = new int[] { 6, 10, 8 };
            Elev elev3 = new Elev("Derrick", "Rose");
            elev3.note = new int[] { 5, 4, 9 };

            Elev[] elevi = new Elev[] {elev1, elev2, elev3};

            Catalog catalog = new Catalog("Bio-Chimie", elevi);

            catalog.Tiparteste();

            Console.WriteLine($"Elevul cu cea mai mare medie este: {catalog.GetPremiantul().nume} {catalog.GetPremiantul().prenmume} " +
                $"cu media {catalog.GetPremiantul().media}");
        }
    }
}
