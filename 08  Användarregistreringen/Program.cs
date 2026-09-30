/*
 * 8. Användarregistreringen (Konstruktorn)
Kravspecifikation:
. Skapa en klass Anvandare med egenskaperna Anvandarnamn och Losenord.

*/

class Användare
{
    public string Användarnamn { get; set; }
    public string Lösenord { get; set; }

    public Användare(string användarnamn, string lösenord)
    {
        Användarnamn = användarnamn;
        Lösenord = lösenord;
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("08 Användarregistreringen");
        Console.Title = "08 Användarregistreringen";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        //användare 1
        Användare användare1 = new Användare("admin", "1234");
        Console.WriteLine($"Användarnamn: {användare1.Användarnamn}");
        Console.WriteLine($"Lösenord: {användare1.Lösenord}");
        Console.WriteLine("\n");

        //Användare 2
        Användare användare2 = new Användare("Rami", "12345");
        Console.WriteLine($"Användarnamn: {användare2.Användarnamn}");
        Console.WriteLine($"Lösenord: {användare2.Lösenord}");
        Console.WriteLine("\n");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}