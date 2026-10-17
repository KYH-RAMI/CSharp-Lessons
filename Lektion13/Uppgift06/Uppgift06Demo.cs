
namespace Lektion13.Uppgift06
{
    internal class Uppgift06Demo
    {

        public static void Kör()
        {
            Console.WriteLine("=== Uppgift 6: Inkapsling med validering ===");
            Console.WriteLine();
            AnvändarProfil användare = new AnvändarProfil();
            användare.Lösenord = "123";
            Console.WriteLine();
            användare.Lösenord = "<>d!!";
            Console.WriteLine();
            användare.Lösenord = "123456";
            Console.WriteLine($"Lösenordet ändrat! {användare.Lösenord} ");
        }
    }
}
