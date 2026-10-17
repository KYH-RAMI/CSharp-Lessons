namespace Lektion13.Uppgift04
{
    internal class Uppgift04Demo
    {
        public static void Kör()
        {
            
            Sparkonto sparkonto = new Sparkonto(123456789);
            Console.WriteLine("=== Uppgift 4: Sparkonto ===");
            Console.WriteLine();
            sparkonto.VisaKontonummer(); // Visar kontonumret p.g.a funktionen/metoden är public
            // Console.WriteLine(sparkonto.KontoNummer); // 'Konto.KontoNummer' is inaccessible due to its protection level
        }
    }
}
