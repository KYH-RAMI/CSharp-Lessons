
class Logger
{
    public enum Severity
    {
        Info,
        Warning,
        Error
    }
    private readonly string[] _messages;
    private int _currentIndex;
    private int _messageCount;
    public Logger()
    {
        _messages = new string[5];
        _currentIndex = 0;
        _messageCount = 0;
    }
    public void Log(string message, Severity severity)
    {
        if (string.IsNullOrWhiteSpace(message))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Loggmeddelandet får inte vara tomt.");
            Console.ResetColor();
            return;
        }
        string logMessage = $"[{severity}] {message}";
        _messages[_currentIndex] = logMessage;
        if(_messageCount < _messages.Length)
        {
            _messageCount++;
        }

        _currentIndex = (_currentIndex + 1) % _messages.Length;

        Console.ForegroundColor = severity switch
        {
            Severity.Info => ConsoleColor.White,
            Severity.Warning => ConsoleColor.Yellow,
            Severity.Error => ConsoleColor.Red,
            _ => ConsoleColor.White
        };
        Console.WriteLine(logMessage);
        Console.WriteLine();
        Console.ResetColor();
    }

    public void ShowLog()
    {
        Console.WriteLine("\nSenaste loggmeddelanden:");

        int startIndex;

        if (_messageCount < _messages.Length)
        {
            startIndex = 0;
        }
        else
        {
            startIndex = _currentIndex;
        }

        for (int i = 0; i < _messageCount; i++)
        {
            int index = (startIndex + i) % _messages.Length;
            Console.WriteLine(_messages[index]);
        }

    }
    public void Info(string message) => Log(message, Severity.Info);
    public void Warning(string message) => Log(message, Severity.Warning);
    public void Error(string message) => Log(message, Severity.Error);
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("15 Loggningssystemet");
        Console.Title = "15 Loggningssystemet";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Logger logger = new Logger();
        logger.Info("Logg 1");
        logger.Warning("Logg 2");
        logger.Error("Logg 3");
        logger.Info("Logg 4");
        logger.Warning("Logg 5");
        logger.Error("Logg 6");
        logger.Info("Logg 7");

        logger.ShowLog();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}