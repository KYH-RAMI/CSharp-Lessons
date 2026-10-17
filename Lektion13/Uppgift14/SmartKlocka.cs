
using Lektion13.Uppgift11;

namespace Lektion13.Uppgift14
{
    internal class SmartKlocka : ILaddbar, IGps
    {
        public void Ladda()
        {
            Console.WriteLine("Laddar SmartKlocka");
        }
        public void HämtaPosition()
        {
            Console.WriteLine("Hämtar position från SmartKlocka");
        }
    }
}
