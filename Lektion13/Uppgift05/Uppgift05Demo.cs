
namespace Lektion13.Uppgift05
{
    internal class Uppgift05Demo
    {

        public static void Kör()
        {
            SystemModul systemModul = new SystemModul();
            Console.WriteLine("=== Uppgift 5: Internal ===");
            Console.WriteLine();
            Console.WriteLine("SystemModul har instansierats!");
            Console.WriteLine($"Objekttyp: {systemModul.GetType().Name}");
            Console.WriteLine();
            Console.WriteLine("Klassen är deklarerad som internal.");
            Console.WriteLine("Den är normalt endast tillgänglig inom samma assembly.");
            Console.WriteLine("Andra assemblies kan inte använda klassen direkt.");
        }
    }
}
