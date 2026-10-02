
class BankAccount
{
    private string _accountNumber;
    private decimal _balance;
    public BankAccount(string accountNumber, decimal initialBalance)
    {
        this._accountNumber = accountNumber;
        
        if(initialBalance < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Startsaldot kan inte vara negativt. Saldo sätts till 0.");
            Console.ResetColor();
            this._balance = 0m;
        }
        else
        {
            this._balance = initialBalance;
        }
    }
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Insättningsbeloppet måste vara positivt.");
            Console.ResetColor();
            return;
        }
        _balance += amount;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Insättning: {amount:C}. Nytt saldo: {_balance:C}");
        Console.ResetColor();
    }
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Uttagsbeloppet måste vara positivt.");
            Console.ResetColor();
            return;
        }
        if (amount > this._balance)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Otillräckligt saldo för uttag.");
            Console.ResetColor();
            return;
        }
        this._balance -= amount;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Uttag: {amount:C}. Nytt saldo: {this._balance:C}");
        Console.ResetColor();
    }
    public string GetAccountNumber() => this._accountNumber;
    public decimal GetBalance() => this._balance;
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("06 Bankkontot");
        Console.Title = "06 Bankkontot";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        BankAccount account = new BankAccount("123456789", -1000m);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Kontonummer: {account.GetAccountNumber()}");
        Console.WriteLine($"Aktuellt saldo: {account.GetBalance():C}");
        Console.ResetColor();
        account.Deposit(500m);
        account.Withdraw(200m);
        account.Withdraw(1500m);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Aktuellt saldo: {account.GetBalance():C}");
        Console.ResetColor();  



        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}