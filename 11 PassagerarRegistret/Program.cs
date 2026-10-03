
class PassagerarManifest
{
    private readonly List<string> _passagerare = [];
    private const int MaxPassagerare = 12;
    public IReadOnlyList<string> Passagerare => _passagerare.AsReadOnly();
    public void RegistreraGrupp(List<string> namnLista)
    {
        if (namnLista == null || namnLista.Count == 0)
        {
            throw new ArgumentException("Namnlistan kan inte vara null eller tom.", nameof(namnLista));
        }
        if (_passagerare.Count + namnLista.Count > MaxPassagerare)
        {
            throw new InvalidOperationException("Tillägget av gruppen överstiger maxgränsen på 12 passagerare.");
        }
        // Validera hela gruppen innan någon läggs till
        foreach (var namn in namnLista)
        {
            if (string.IsNullOrWhiteSpace(namn))
            {
                throw new ArgumentException("Alla namn i listan måste vara giltiga och inte tomma.", nameof(namnLista));
            }
        }
        // Om valideringen lyckas, lägg till hela gruppen
        _passagerare.AddRange(namnLista);
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("11 PassagerarRegistret");
        Console.Title = "11 PassagerarRegistret";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        PassagerarManifest manifest = new PassagerarManifest();

        manifest.RegistreraGrupp(
        [
            "Anna", "Erik", "Sara", "Johan", "Lisa",
            "Oskar", "Maria", "David", "Emma", "Lars"
        ]);

        Console.WriteLine($"Antal ombord: {manifest.Passagerare.Count}");

        try
        {
            manifest.RegistreraGrupp(["Kalle", "Stina", "Per"]);
        }
        catch (InvalidOperationException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Fel: {ex.Message}");
            Console.ResetColor();
        }

        Console.WriteLine($"Antal efter misslyckat försök: {manifest.Passagerare.Count}");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}