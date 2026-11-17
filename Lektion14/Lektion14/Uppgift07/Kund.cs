
namespace Lektion14.Uppgift07
{
    internal class Kund : Användare
    {
        public override void VisaInformation()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[KUND] Namn: {Namn}");
            Console.ResetColor();
        }
    }
}
