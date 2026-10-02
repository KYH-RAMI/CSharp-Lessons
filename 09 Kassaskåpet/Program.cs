
class Safe
{
    private string _password;
    private bool _isLocked;
    public Safe(string password)
    {
        _password = password;
        _isLocked = true; // Kassaskåpet är låst som standard
    }
    public void Unlock(string password)
    {
        if (!_isLocked)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Kassaskåpet är redan upplåst.");
            Console.ResetColor();
            return;
        }

        if (password == _password)
        {
            _isLocked = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kassaskåpet är nu upplåst.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fel lösenord! Kassaskåpet förblir låst.");
        }

        Console.ResetColor();
    }
    public void Lock()
    {
        _isLocked = true;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Kassaskåpet är nu låst.");
        Console.ResetColor();
    }
    public bool IsLocked() => _isLocked;
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("09 Kassaskåpet");
        Console.Title = "09 Kassaskåpet";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Safe safe = new Safe("1234");

        safe.Unlock("0000");
        safe.Unlock("1234");
        safe.Unlock("5555");
        safe.Lock();
        safe.Unlock("1234");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}