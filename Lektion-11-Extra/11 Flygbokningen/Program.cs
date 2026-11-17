
class FlightBooking
{
    private int maxSeats;
    private List<string> passengerNames;
    public FlightBooking(int maxSeats)
    {
        this.maxSeats = maxSeats;
        this.passengerNames = new List<string>();
    }
    public void BookSeat(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Passagerarnamn får inte vara tomt.");
            Console.ResetColor();
            return;
        }
        if (passengerNames.Contains(name))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Passagerare {name} är redan bokad.");
            Console.ResetColor();
            return;
        }

        if (passengerNames.Count < maxSeats)
        {
            passengerNames.Add(name);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Bokning bekräftad för {name}. Totalt antal bokade platser: {passengerNames.Count}/{maxSeats}");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Tyvärr, inga lediga platser kvar för {name}. Totalt antal bokade platser: {passengerNames.Count}/{maxSeats}");
            Console.ResetColor();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("11 Flygbokningen");
        Console.Title = "11 Flygbokningen";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        FlightBooking flightBooking = new FlightBooking(4);
        flightBooking.BookSeat("Alice");
        flightBooking.BookSeat("Bob");
        flightBooking.BookSeat("");
        flightBooking.BookSeat("David");
        flightBooking.BookSeat("Eve");
        flightBooking.BookSeat("Alice");
        flightBooking.BookSeat("Frank");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}