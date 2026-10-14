using System;

namespace Generisk_par_behållare
{
    class Par<T, U>
    {
        public T Forsta
        {
            get; set;
        }
        public U Andra
        {
            get; set;
        }

        public Par(T forsta, U andra)
        {
            Forsta = forsta;
            Andra = andra;
        }

        // Snygg utskrift
        public override string ToString()
            => $"({Forsta}, {Andra})";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine();
            Console.Title = "Generisk par-behållare";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            // ---------- 1. string + int ----------
            var p1 = new Par<string, int>("Ålder", 30);
            Console.WriteLine($"p1: {p1}");
            Console.WriteLine($"    Första = {p1.Forsta}");
            Console.WriteLine($"    Andra  = {p1.Andra}");

            // ---------- 2. int + string (omvänd ordning) ----------
            var p2 = new Par<int, string>(1, "Ett");
            Console.WriteLine($"\np2: {p2}");

            // ---------- 3. string + double ----------
            var p3 = new Par<string, double>("Pi", 3.14159);
            Console.WriteLine($"\np3: {p3}");

            // ---------- 4. Två egna typer ----------
            var p4 = new Par<Person, Adress>(
                new Person("Alice"),
                new Adress("Storgatan 1", "Stockholm"));
            Console.WriteLine($"\np4: {p4}");

            // ---------- 5. Ändra värden via properties ----------
            p1.Andra = 31;
            Console.WriteLine($"\np1 efter ändring: {p1}");

            #region footer
            Console.WriteLine("\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }
    }

    // Hjälpklasser för demonstration
    public class Person
    {
        public string Namn
        {
            get;
        }
        public Person(string namn) => Namn = namn;
        public override string ToString() => Namn;
    }

    public class Adress
    {
        public string Gata
        {
            get;
        }
        public string Stad
        {
            get;
        }
        public Adress(string gata, string stad)
        {
            Gata = gata;
            Stad = stad;
        }
        public override string ToString() => $"{Gata}, {Stad}";
    }
}