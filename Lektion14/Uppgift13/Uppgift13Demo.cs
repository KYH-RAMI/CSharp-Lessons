
namespace Lektion14.Uppgift13
{
    internal class Uppgift13Demo
    {
        public static void Kör()
        {
            Console.WriteLine("=== Uppgift 13: Stark sammanhållning – High Cohesion ===");
            Console.WriteLine();
            Rapport rapport = new Rapport("C# utbildning", "Claes Engelin var läraren ;)");

            Console.WriteLine($"Titel: {rapport.Titel}");
            Console.WriteLine();
            Console.WriteLine($"Innehåll: {rapport.Innehåll}");
            Console.WriteLine();
            Console.WriteLine("SRP: En klass ska ha ett tydligt ansvarsområde.");
            Console.WriteLine("Rapport lagrar data, medan demon hanterar utskriften.");
        }
    }
}