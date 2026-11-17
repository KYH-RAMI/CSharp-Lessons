
Console.WriteLine("01 Välkomstsnurran");
Console.WriteLine("======================");

bool continueSpinning = true;
while (continueSpinning)
{
    Console.WriteLine("Vill du fortsätta köra programmet? Skriv då 'ja' eller 'j'");
    string userInput = Console.ReadLine().ToLower();

    if (userInput == "ja" || userInput == "j")
    {
        Console.WriteLine("Snurrar vidare...");
    }
    else
    {
        continueSpinning = false;
        Console.WriteLine("Hej då!");
    }
    
}

Console.WriteLine("============================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();