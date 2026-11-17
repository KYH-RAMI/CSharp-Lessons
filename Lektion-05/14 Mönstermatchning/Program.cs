Console.WriteLine("14 Mönstermatchning med Switch och Property-matching");
Console.WriteLine("====================");

User user1 = new User("Rami", false);
User user2 = new User("Admin", true);

MatchUser(user1);
MatchUser(user2);

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();

static void MatchUser(User user)
{
    switch (user)
    {
        case { IsAdmin: true }:
            Console.WriteLine($"Användaren {user.Name} är en admin.");
            break;
        case { IsAdmin: false }:
            Console.WriteLine($"Användaren {user.Name} är en vanlig användare.");
            break;
        default:
            Console.WriteLine("Okänd användartyp.");
            break;
    }
}

class User
{
    public string Name { get; set; }
    public bool IsAdmin { get; set; }

    public User(string name, bool isAdmin)
    {
        Name = name;
        IsAdmin = isAdmin;
    }
}

