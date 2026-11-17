
class Tamagotchi
{
    public string Name;
    public int Hunger;
    public Tamagotchi(string name)
    {
        Name = name;
        Hunger = 5; // Start hunger level
    }
    public void Feed()
    {
        if (Hunger > 0)
        {
            Hunger--;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Name} har fått mat. Hungernivån är nu {Hunger}.");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{Name} är inte hungrig. ");
            Console.ResetColor();
        }
    }
    public void Play()
    {
        if (Hunger < 10)
        {
            Hunger++;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{Name} spelade och är nu mer hungrig. Hunger nivå är nu {Hunger}. ");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{Name} är för hungrig för att spela. ");
            Console.ResetColor();
        }
    }
    public void PrintStatus()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"{Name}s nuvarande hungernivå är {Hunger}.");
        Console.ResetColor();
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("02 Digitala husdjuret");
        Console.Title = "02 Digitala husdjuret";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Tamagotchi myPet = new Tamagotchi("Tama");
        myPet.Feed();
        myPet.PrintStatus();
        myPet.Play();
        myPet.PrintStatus();
        myPet.Play();
        myPet.PrintStatus();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}