
using Tamagotchi;

namespace Tamagotchi
{
    public class Husdjur
    {
        private int _hunger = 50;
        private int _trötthet = 50;

        private int Hunger
        {
            get => _hunger;
            // set => _hunger = value < 0 ? 0 : value > 100 ? 100 : value; C# har tydligen bättre sätt att göra detta
            set => _hunger = Math.Clamp(value, 0, 100);
        }

        private int Trötthet
        {
            get => _trötthet;
            //set => _trötthet = value < 0 ? 0 : value > 100 ? 100 : value; // samma här den tyckte inte om detta...
            set => _trötthet = Math.Clamp(value, 0, 100);
        }

        public void Mata()
        {
            Hunger -= 10;
            Trötthet += 10;
            Console.WriteLine("Du matade husdjuret.");
        }

        public void Spela()
        {
            Hunger += 10;
            Trötthet += 10;
            Console.WriteLine("Du spelade med husdjuret.");
        }

        public void Sova()
        {
            Hunger += 10;
            Trötthet -= 10;
            Console.WriteLine("Husdjuret sov.");
        }

        public void KontrolleraMående()
        {
            Console.WriteLine("Husdjurets status:");
            Console.WriteLine($"Hunger: {Hunger}");
            Console.WriteLine($"Trötthet: {Trötthet}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("11 Tamagotchi");
            Console.Title = "11 Tamagotchi";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            Husdjur husdjur = new Husdjur();
            husdjur.KontrolleraMående();
            husdjur.Mata();
            husdjur.KontrolleraMående();
            husdjur.Spela();
            husdjur.KontrolleraMående();
            husdjur.Sova();
            husdjur.KontrolleraMående();


            #region footer
            Console.WriteLine("\n\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }

    }
}