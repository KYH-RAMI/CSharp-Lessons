
namespace Lektion13.Uppgift03
{
    internal class Uppgift03Demo
    {
        public static void Kör()
        {

            VD vd = new VD("Rami", "DevSecOps", "Microsoft");
            Console.WriteLine("=== Uppgift 3: VD ===");
            Console.WriteLine();
            Console.WriteLine($" VD: {vd.Namn} Arbetar på avdelning: {vd.Avdelning} och är VD för  {vd.Företag}");
        }
    }
}
