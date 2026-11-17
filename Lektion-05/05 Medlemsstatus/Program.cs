Console.WriteLine("05 Medlemsstatus");
        Console.WriteLine("======================");
        Console.Write("Mata in din medlemsnivå (1-3): ");

        string? msg = Console.ReadLine();

        if (int.TryParse(msg, out int medlemsnivå))
        {
            switch (medlemsnivå)
            {
                case 1:
                    Console.WriteLine("nBasic - 99 kr");
                    break;
                case 2:
                    Console.WriteLine("\nStandard - 149 kr");
                    break;
                case 3:
                    Console.WriteLine("\nPremium - 199 kr");
                    break;
               
                default:
                    Console.WriteLine("\nFelaktig inmatning.");
                    break;
            }
        }

        Console.WriteLine("======================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();