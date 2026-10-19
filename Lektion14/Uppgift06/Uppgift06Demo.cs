
namespace Lektion14.Uppgift06
{
    internal class Uppgift06Demo
    {
        public static void Kör()
        {
            Console.WriteLine("=== Uppgift 6: Verklig hierarki – Betalsystem ===");
            Console.WriteLine();
            Betalning kreditkort = new Kreditkort { Belopp = 500m };
            Betalning swish = new Swish { Belopp = 250m };

            kreditkort.ProcessaBetalning();
            swish.ProcessaBetalning();
            // new Kreditkort { Belopp = 500m }.ProcessaBetalning();  //Object Initializer
        }
    }
}
