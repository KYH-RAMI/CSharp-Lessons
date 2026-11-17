const string username = "admin";
const string password = "password";
Console.WriteLine("03 Inloggningsvalidering");
Console.WriteLine("======================");
Console.Write("Användarnamn: ");
string user = Console.ReadLine();
Console.Write("Lösenord: ");
string pass = Console.ReadLine();

if (user == username && pass == password) { 
    Console.WriteLine("True!");
}
else
{
    Console.WriteLine("False!"); 
}
Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey(); 