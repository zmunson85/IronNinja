using System;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            SpiceHound sh = new SpiceHound();
            SweetTooth swt = new SweetTooth();

            while (!sh.IsFull)
                sh.Consume(buffet.Serve());

            while (!swt.IsFull)
                swt.Consume(buffet.Serve());

            Ninja winner;
            string title;
            if (sh.FoodHistory.Count > swt.FoodHistory.Count)
            {
                winner = sh;
                title = "Spice Hound";

            }
            else
            {
                winner = swt;
                title = "Sweet Tooth";

            }

            Console.WriteLine($"{title} wins after finishing, {winner.FoodHistory.Count} items!");

        }
    }
}
