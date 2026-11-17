namespace Lektion14.Uppgift01
{
    internal class Hund : Djur
    {
        public override void GörLjud()
        {
            Console.WriteLine("Hunden skäller");
        }
        public void ViftaPåSvansen()
        {
            Console.WriteLine("Hunden viftar på svansen");
        }
    }
}
