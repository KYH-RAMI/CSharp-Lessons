
namespace Lektion14.Uppgift13
{
    internal class Rapport
    {
        public string Titel { get; }
        public string Innehåll { get; }

        public Rapport(string titel, string innehåll)
        {
            this.Titel = titel;
            this.Innehåll = innehåll;
        }
    }
}
