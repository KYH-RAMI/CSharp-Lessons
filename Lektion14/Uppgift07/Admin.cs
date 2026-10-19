
namespace Lektion14.Uppgift07
{
    internal class Admin : Användare
    {
        public override void VisaInformation()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ADMIN] Namn: {Namn}");
            Console.ResetColor();
        }
        public void NollställSystem()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ADMIN] Systemet har återställts.");
            Console.ResetColor();
        }
    }
}
