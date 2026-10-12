
namespace Utmaning_Smart_Hem
{
    public enum LampStatus
    {
        Av,
        Lag,
        Medium,
        Max
    }

    public class SmartLampa
    {
        public LampStatus Status { get; private set; } = LampStatus.Av;

        private int _antalTimmarTand;

        public int AntalTimmarTand
        {
            get => _antalTimmarTand;
        }

        public void Klick()
        {
            switch (Status)
            {
                case LampStatus.Av:
                    Status = LampStatus.Lag;
                    break;

                case LampStatus.Lag:
                    Status = LampStatus.Medium;
                    break;

                case LampStatus.Medium:
                    Status = LampStatus.Max;
                    break;

                case LampStatus.Max:
                    Status = LampStatus.Av;
                    break;
            }

            if (Status != LampStatus.Av)
            {
                _antalTimmarTand++;
            }

            Console.WriteLine($"Lampans status: {Status}");
            Console.WriteLine($"Antal timmar tänd: {_antalTimmarTand}");
        }
    }

internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("");
            Console.Title = "";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            SmartLampa lampa = new SmartLampa();

            Console.WriteLine($"Startstatus: {lampa.Status}");

            lampa.Klick();
            lampa.Klick();
            lampa.Klick();
            lampa.Klick();
            lampa.Klick();

            #region footer
            Console.WriteLine("\n\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }

    }
}
