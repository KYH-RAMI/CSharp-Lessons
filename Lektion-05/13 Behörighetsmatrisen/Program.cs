Console.WriteLine("13 Behörighetsmatrisen");
Console.WriteLine("======================");
Console.WriteLine("Användarroller: None=0, Read=1, Write=2, Execute=4");

var userRoles = UserRoles.Read | UserRoles.Write;

if (userRoles.HasFlag(UserRoles.Read) && userRoles.HasFlag(UserRoles.Write))
{
    Console.WriteLine("Användaren har BÅDE Read och Write-rättigheter.");
}
else
{
    Console.WriteLine("Användaren har INTE BÅDE Read och Write-rättigheter.");
}

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();


[Flags]
enum UserRoles
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4
}
