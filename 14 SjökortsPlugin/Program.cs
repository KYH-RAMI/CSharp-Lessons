
abstract class SjökortsPlugin
{
    public abstract string Namn { get; }

    public abstract void ExekveraRuttBeräkning();
}

// två konkreta plug-in-klasser som ärver från SjökortsPlugin
class MinstaBränsleRutt : SjökortsPlugin
{
    public override string Namn => "Minsta bränslerutt";

    public override void ExekveraRuttBeräkning()
        => Console.WriteLine("Beräknar rutten med lägsta möjliga bränsleförbrukning.");
}

class SäkrastVäderRutt : SjökortsPlugin
{
    public override string Namn => "Säkrast väderrutt";

    public override void ExekveraRuttBeräkning()
        => Console.WriteLine("Beräknar rutten utifrån säkrast möjliga väderförhållanden.");
}

//plug-in-hanterare som kan ladda och köra dessa moduler utan att känna till deras konkreta typer i förväg
class PluginHanterare
{
    private readonly List<SjökortsPlugin> _plugins = [];

    public void Registrera(SjökortsPlugin plugin)
        => _plugins.Add(plugin);

    public void KörAlla()
    {
        foreach (SjökortsPlugin plugin in _plugins)
        {
            Console.WriteLine($"[{plugin.Namn}]");
            plugin.ExekveraRuttBeräkning();
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("14 - SjökortsPlugin");
        Console.Title = "14 - SjökortsPlugin";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        PluginHanterare hanterare = new PluginHanterare();

        hanterare.Registrera(new MinstaBränsleRutt());
        hanterare.Registrera(new SäkrastVäderRutt());

        hanterare.KörAlla();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}