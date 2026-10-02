
class Hotellrum
{
    public int RumNummer { get; set; }
    public string GastNamn { get; set; }
    public bool IsOckuperat { get; set; }
    public Hotellrum(int rumNummer)
    {
        RumNummer = rumNummer;
        GastNamn = "";
        IsOckuperat = false;
    }

    public void CheckIn(string namn)
    {
        GastNamn = namn;
        IsOckuperat = true;
    }
    public void CheckOut()
    {
        GastNamn = "";
        IsOckuperat = false;
    }
    public void Print()
    {
        Console.WriteLine($"Rum {RumNummer}: {GastNamn} - {(IsOckuperat ? "Ockuperat" : "Ledigt")}");
    }


}
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("11 Logg och hanteringssystem");
        Console.Title = "11 Logg och hanteringssystem";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        List<Hotellrum> rumLista = new List<Hotellrum>
        {
            new Hotellrum(1),
            new Hotellrum(2),
            new Hotellrum(3)
        };
        Console.WriteLine("Välkommen till Ramis hotell!");
        Console.WriteLine();

        bool running = true;

        while (running)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("1. Visa status för alla rum ");
            Console.WriteLine("2. Checka in en gäst ");
            Console.WriteLine("3. Checka ut en gäst ");
            Console.WriteLine("4. Avsluta programmet ");
            Console.WriteLine();
            Console.Write("Välj ett alternativ: ");
            Console.WriteLine();
            Console.ResetColor();


            if (!int.TryParse(Console.ReadLine(), out int val))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du måste ange ett nummer! ");
                Console.ResetColor();
                continue;
            }

            switch (val)
            {
                case 1:
                    {
                        foreach (Hotellrum hotellrum in rumLista)
                        {
                            Console.WriteLine();
                            Console.WriteLine("=========================");
                            hotellrum.Print();
                            Console.WriteLine("=========================");
                            Console.WriteLine();
                        }
                        break;
                    }

                case 2:
                    {
                        Console.Write("Ange rumsnummer: ");

                        if (!int.TryParse(Console.ReadLine(), out int rumNummer))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Du måste ange ett giltigt rumsnummer!");
                            Console.ResetColor();
                            continue;
                        }
                        Hotellrum? valtsRum =
                            rumLista.FirstOrDefault(r => r.RumNummer == rumNummer);
                        
                        if(valtsRum != null)
                        {
                            if (valtsRum.IsOckuperat)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine();
                                Console.WriteLine($"Rum {valtsRum.RumNummer} är redan ockuperat av {valtsRum.GastNamn}. ");
                                Console.WriteLine();
                                Console.ResetColor();
                                break;
                            }
                            else
                            {


                                Console.WriteLine("Ange gästnamn: ");
                                string Namn = Console.ReadLine() ?? "";
                                
                                if(string.IsNullOrWhiteSpace(Namn))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Gästnamn kan inte vara tomt. ");
                                    Console.ResetColor();
                                    break;
                                }
                                valtsRum.CheckIn(Namn);
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"Rum {valtsRum.RumNummer} är nu ockuperat av {valtsRum.GastNamn}. ");
                                Console.WriteLine();
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine();
                            Console.WriteLine("Rummet finns inte. ");
                            Console.WriteLine();
                            Console.ResetColor();
                        }
                        break;

                    }

                case 3:
                    Console.Write("Ange rumsnummer: ");

                    if (!int.TryParse(Console.ReadLine(), out int rumsNummer))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Du måste ange ett giltigt rumsnummer!");
                        Console.ResetColor();
                        continue;
                    }

                    Hotellrum? valtRum =
                        rumLista.FirstOrDefault(r => r.RumNummer == rumsNummer);

                    if (valtRum != null)
                    {
                        if (valtRum.IsOckuperat)
                        {
                            valtRum.CheckOut();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Rum {valtRum.RumNummer} är nu utcheckat. ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine();
                            Console.WriteLine($"Rum {valtRum.RumNummer} är redan ledigt. ");
                            Console.WriteLine();
                            Console.ResetColor();
                        }
                        
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("Rummet finns inte.");
                        Console.WriteLine();
                        Console.ResetColor();
                    }

                    break;

                case 4:
                    running = false;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ogiltigt val. Försök igen!");
                    Console.ResetColor();
                    break;
            }
        }

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}
