

namespace Lektion14.Uppgift05
{
    internal class Skrivare
    {
        public void SkrivUt(string text)
        {
            Console.WriteLine($"SkrivUt(string): {text}");
        }

        public void SkrivUt(int tal)
        {
            Console.WriteLine($"SkrivUt(int): {tal}");
        }
    }
}
