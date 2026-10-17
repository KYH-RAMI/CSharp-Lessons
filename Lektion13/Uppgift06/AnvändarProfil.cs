
namespace Lektion13.Uppgift06
{
    internal class AnvändarProfil
    {
        private const string Felmeddelande = "Lösenordet måste vara minst 6 tecken långt";
        private string? _lösenord;
        public string? Lösenord
        {
            get
            {
                return _lösenord;
            }
            set
            {
                if (value?.Length >= 6)
                {
                    _lösenord = value;
                }
                else
                {
                    Console.WriteLine(Felmeddelande);
                }
            }
        }
    }
}
