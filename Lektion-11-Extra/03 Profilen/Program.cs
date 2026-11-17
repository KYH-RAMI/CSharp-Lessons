/*
 * Uppgift 3 (Grön): Profilen
Skapa en klass UserProfile med falten 'Username', 'Email' och 'StatusText'. Implementera en metod
UpdateStatus(string newStatus) som uppdaterar texten och skriver ut loggen.
*/

class UserProfile
{
    public string Username;
    public string Email;
    public string StatusText;
    public UserProfile(string username, string email)
    {
        this.Username = username;
        this.Email = email;
        this.StatusText = "Ingen status uppdaterad än.";
    }
    public void UpdateStatus(string newStatus)
    {
        this.StatusText = newStatus;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"{Username}: {StatusText} \n");
        Console.ResetColor();
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("03 Profilen");
        Console.Title = "03 Profilen";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion
        Console.WriteLine("Logg: ");
        UserProfile user1 = new UserProfile("Rami", "rami@rami.se");
        user1.UpdateStatus("Har precis uppdaterat sin status!");
        user1.UpdateStatus("Har precis uppdaterat sin status igen!");

        UserProfile user2 = new UserProfile("Kalle", "kalle@kalle.se");
        user2.UpdateStatus("Har precis uppdaterat sin status!");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}