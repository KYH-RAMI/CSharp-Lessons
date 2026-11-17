
namespace Order
{
    public enum OrderStatus
    {
        Skapad,
        Skickad,
        Levererad
    }
    public class Order
    {

        public int OrderNummer { get; set; }
        public OrderStatus Status { get; set; }

        public void UppdateraStatus()
        {
            if (Status == OrderStatus.Skapad)
            {
                Status = OrderStatus.Skickad;
                Console.WriteLine("Status uppdaterad till Skickad");
            }
            else if (Status == OrderStatus.Skickad)
            {
                Status = OrderStatus.Levererad;
                Console.WriteLine("Status uppdaterad till Levererad");
            }
            else
            {
                Console.WriteLine("Status är redan Levererad");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("10 Order");
            Console.Title = "10 Order";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            Order order = new Order();
            order.OrderNummer = 1;
            order.Status = OrderStatus.Skapad;
            Console.WriteLine($"OrderNummer: {order.OrderNummer}, Status: {order.Status}");
            order.UppdateraStatus();
            Console.WriteLine($"OrderNummer: {order.OrderNummer}, Status: {order.Status}");
            order.UppdateraStatus();


            #region footer
            Console.WriteLine("\n\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }

    }
}