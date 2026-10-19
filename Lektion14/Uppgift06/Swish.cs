
namespace Lektion14.Uppgift06
{
    internal class Swish : Betalning
    {
        public override void ProcessaBetalning()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[SWISH] {Belopp:C2} | Betalning behandlas...");
            Console.ResetColor();
        }
    }
}
