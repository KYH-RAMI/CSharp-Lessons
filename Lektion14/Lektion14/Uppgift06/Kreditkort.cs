
namespace Lektion14.Uppgift06
{
    internal class Kreditkort : Betalning
    {
        public override void ProcessaBetalning()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[KREDITKORT] {Belopp:C2} | Betalning behandlas...");
            Console.ResetColor();
        }
    }
}
