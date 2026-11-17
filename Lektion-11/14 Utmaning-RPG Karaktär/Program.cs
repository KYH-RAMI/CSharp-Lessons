
using System;

namespace Utmaning
{
    public class Hjaltar
    {
        public string Namn { get; set; }

        public int Halsa { get; set; }
        public int Skada { get; set; }

        public Hjaltar(string namn, int halsa, int skada)
        {
            Namn = namn;
            Halsa = halsa;
            Skada = skada;
        }
        public void Anfall(Hjaltar mal)
        {
            mal.Halsa -= Skada;

            Console.WriteLine($"{Namn} anfaller {mal.Namn}!");
            Console.WriteLine($"{mal.Namn} tar {Skada} skada.");

            if (mal.Halsa <= 0)
            {
                mal.Halsa = 0;
                Console.WriteLine($"{mal.Namn} har svimmat!");
            }
            else
            {
                Console.WriteLine($"{mal.Namn} har {mal.Halsa} hälsa kvar.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("14 Utmaning - RPG Karaktär (Stridssimulator");
            Console.Title = "14 Utmaning - RPG Karaktär (Stridssimulator";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            Hjaltar hjalte1 = new Hjaltar("Rami", 100, 25);
            Hjaltar hjalte2 = new Hjaltar("Stig", 80, 15);

            hjalte1.Anfall(hjalte2);
            hjalte2.Anfall(hjalte1);
            hjalte1.Anfall(hjalte2);
            hjalte1.Anfall(hjalte2);
            hjalte1.Anfall(hjalte2);

            #region footer
            Console.WriteLine("\n\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }

    }
}
