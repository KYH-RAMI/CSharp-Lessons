
class TrafficLight
{
    public enum LightState
    {
        Red,
        RedYellow,
        Green,
        Yellow
    }
    private LightState _currentState;
    public TrafficLight()
    {
        _currentState = LightState.Red; // Startar med rött ljus
    }
    public void NextState()
    {
        switch (_currentState)
        {
            case LightState.Red:
                _currentState = LightState.RedYellow;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ljus ändrat till: Rött + gult");
                break;

            case LightState.RedYellow:
                _currentState = LightState.Green;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ljus ändrat till: Grönt");
                break;

            case LightState.Green:
                _currentState = LightState.Yellow;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ljus ändrat till: Gult");
                break;

            case LightState.Yellow:
                _currentState = LightState.Red;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ljus ändrat till: Rött");
                break;
        }
        Console.ResetColor();
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("14 Trafikljussimulatorn");
        Console.Title = "14 Trafikljussimulatorn";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        TrafficLight trafficLight = new TrafficLight();

        bool running = true;

        while (running)
        {
            Console.WriteLine("Tryck på en tangent för nästa ljus, eller ESC för att avsluta.");

            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Escape)
            {
                running = false;
            }
            else
            {
                trafficLight.NextState();
            }

            Console.WriteLine();
        }


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}