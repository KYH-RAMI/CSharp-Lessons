
class MovieTicket
{
    public string MovieTitle;
    public decimal Price;
    public bool IsUsed { get; private set; }
    public MovieTicket(string movieTitle, decimal price)
    {
        this.MovieTitle = movieTitle;
        this.Price = price;
        this.IsUsed = false;
    }
    public void UseTicket()
    {
        if (IsUsed)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Biljetten för {MovieTitle} ({Price:C}) har redan använts. \n");
            Console.ResetColor();
        }
        else
        {
            IsUsed = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Biljetten för {MovieTitle} ({Price:C}) har nu använts. \n");
            Console.ResetColor();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("04 Biljetten");
        Console.Title = "04 Biljetten";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        MovieTicket ticket1 = new MovieTicket("Interstellar", 149.90m);
        ticket1.UseTicket(); // Första användningen
        ticket1.UseTicket(); // Andra användningen, ska visa att biljetten redan är använd
        MovieTicket ticket2 = new MovieTicket("Inception", 129.90m);
        ticket2.UseTicket(); // Första användningen
        ticket2.UseTicket(); // Andra användningen, ska visa att biljetten redan är använd  


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}