
namespace Lektion14.Uppgift07
{
    internal class Användare
    {
        public string Namn { get; set; } = string.Empty;
        public virtual void VisaInformation()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[ANVÄNDARE] Namn: {Namn}");
            Console.ResetColor();
        }
    }
}
