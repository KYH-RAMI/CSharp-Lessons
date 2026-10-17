
using Lektion13.Uppgift11;

namespace Lektion13.Uppgift15
{
    internal class Robot : Maskin, ILaddbar
    {
       public void Ladda()
        {
            Console.WriteLine("Roboton laddas...");
        }

    }
}
