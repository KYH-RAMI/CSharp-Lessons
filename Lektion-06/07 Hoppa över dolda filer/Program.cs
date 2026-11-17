Console.WriteLine("07 Hoppa över dolda filer");
Console.WriteLine("======================");
Console.WriteLine("\n\n");

string[] files = 
{ 
    ".config", 
    "index.html", 
    ".git", 
    "styles.css" 
};

foreach (string file in files)
{
    if(file.StartsWith("."))
    {
        continue;
    }
    Console.WriteLine(file);
}

Console.WriteLine("\n\n");
Console.WriteLine("============================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();