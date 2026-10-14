using System;

// Kort variant – importerar undernamnrymden
using Geometri.Forminfo;

namespace Geometri.Forminfo
{
    // Klass som ligger i undernamnrymden Geometri.Forminfo
    public class Rektangel
    {
        public double Bredd
        {
            get; set;
        }
        public double Höjd
        {
            get; set;
        }

        public Rektangel(double bredd, double höjd)
        {
            Bredd = bredd;
            Höjd = höjd;
        }

        public double Area() => Bredd * Höjd;

        public override string ToString()
            => $"Rektangel {Bredd} x {Höjd}, area = {Area()}";
    }
}

namespace Namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("04 Namespaces");
            Console.Title = "04 Namespaces";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            // ---------- 1. Kort namn (via using Geometri.Forminfo) ----------
            var r1 = new Rektangel(3, 4);
            Console.WriteLine($"Kort namn:         {r1}");

            // ---------- 2. Fullständigt kvalificerat namn ----------
            var r2 = new Geometri.Forminfo.Rektangel(5, 6);
            Console.WriteLine($"Fullt kvalificerat: {r2}");

            // ---------- 3. Alias (using X = ...) ----------
            // (läggs högst upp i filen: using Form = Geometri.Forminfo.Rektangel;)
            // var r3 = new Form(2, 2);

            #region footer
            Console.WriteLine("\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }
    }
}