
class AudioPlayer
{
    public enum PlayerState
    {
        Playing,
        Paused,
        Stopped
    }
    public PlayerState State { get; private set; }
    public AudioPlayer()
    {
        State = PlayerState.Stopped;
    }
    public void Play()
    {
        if (State == PlayerState.Playing)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ogiltig övergång: Spelaren är redan i 'Playing' tillstånd.");
            Console.ResetColor();
        }
        else
        {
            State = PlayerState.Playing;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Spelaren är nu i 'Playing' tillstånd.");
            Console.ResetColor();
        }
    }
    public void Pause()
    {
        if (State == PlayerState.Paused)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ogiltig övergång: Spelaren är redan i 'Paused' tillstånd.");
            Console.ResetColor();
        }
        else if (State == PlayerState.Stopped)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ogiltig övergång: Kan inte pausa när spelaren är i 'Stopped' tillstånd.");
            Console.ResetColor();
        }
        else
        {
            State = PlayerState.Paused;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Spelaren är nu i 'Paused' tillstånd.");
            Console.ResetColor();
        }
    }
    public void Stop()
    {
        if (State == PlayerState.Stopped)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ogiltig övergång: Spelaren är redan i 'Stopped' tillstånd.");
            Console.ResetColor();
        }
        else
        {
            State = PlayerState.Stopped;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Spelaren är nu i 'Stopped' tillstånd.");
            Console.ResetColor();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("12 Musikspelaren");
        Console.Title = "12 Musikspelaren";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        AudioPlayer player = new AudioPlayer();

        player.Pause(); // fel - Stopped
        player.Play();  // Playing
        player.Play();  // fel - redan Playing
        player.Pause(); // Paused
        player.Pause(); // fel - redan Paused
        player.Play();  // Playing igen
        player.Stop();  // Stopped
        player.Stop();  // fel - redan Stopped

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}