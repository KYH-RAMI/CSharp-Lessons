using Lektion13.Uppgift11;

namespace Lektion13.Uppgift12
{
    internal class Uppgift12Demo
    {

        public static void Kör()
        {
            Console.WriteLine("=== Uppgift 12: Implementera ett gränssnitt ===");
            Console.WriteLine();

            Mobiltelefon telefon = new Mobiltelefon();
            telefon.Ladda();
            Console.WriteLine($"Objekttyp: {telefon.GetType().Name}");
            Console.WriteLine($"Gränssnitt: {nameof(ILaddbar)}");
            ILaddbar laddbarEnhet = telefon;
            laddbarEnhet.Ladda();
            Console.WriteLine($"Samma objekt: {ReferenceEquals(telefon, laddbarEnhet)}");
        }
    }
}
