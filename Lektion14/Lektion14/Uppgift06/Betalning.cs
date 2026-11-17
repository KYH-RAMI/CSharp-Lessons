
namespace Lektion14.Uppgift06
{
    internal class Betalning
    {
        public decimal Belopp { get; set; }
        public virtual void ProcessaBetalning()
        {
            Console.WriteLine($"{Belopp} behandlas...");
        }
    }
}
