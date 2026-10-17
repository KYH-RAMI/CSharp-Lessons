
namespace Lektion13.Uppgift04
{
    internal class Sparkonto : Konto
    {
        public Sparkonto(int kontonummer) : base(kontonummer)
        {
            KontoNummer = kontonummer;
        }

        public void VisaKontonummer()
        {
            Console.WriteLine($"Kontonummer: {KontoNummer}");
        }
    }
}
