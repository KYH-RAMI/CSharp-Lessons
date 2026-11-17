
class Hero
{
    public int HP;
    public int XP;
    public Hero(int hp, int xp)
    {
        this.HP = hp;
        this.XP = xp;
    }
    public void TakeDamage(int damage)
    {
        if (damage <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Skadan måste vara större än 0.");
            Console.ResetColor();
            return;
        }
        
            this.HP -= damage;

        if (this.HP <= 0)
        {
            this.HP = 0;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Game Over! Karaktären dog! \n");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Karaktären tog {damage} skada. Nuvarande HP: {this.HP} \n");
            Console.ResetColor();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("08 Rollspelskaraktären");
        Console.Title = "08 Rollspelskaraktären";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Hero hero = new Hero(100, 0);
        Random random = new Random();

        while (hero.HP > 0)
        {
            Console.WriteLine($"Nuvarande HP: {hero.HP} \n");
            Console.WriteLine("Tryck på en tangent för nästa attack... \n");
            Console.ReadKey(true);

            int damage = random.Next(1, 31);

            hero.TakeDamage(damage);

            Console.WriteLine();
        }

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}