using System;

namespace currency
{
    class Program
    {
        static void Main(string[] args)
        {
            string dollars_input;
            double dollars;

            string exchange_input;
            double exchange;

            double converted;

            Console.WriteLine("How many dollars do have?");
            dollars_input = Console.ReadLine();

            while (!double.TryParse(dollars_input, out dollars))
            {
                Console.WriteLine("PLease enter a valid amount! How many dollars do have?");
                dollars_input = Console.ReadLine();
            }

            dollars = double.Parse(dollars_input);
            

            Console.WriteLine("Whats the sterling -> dollar Exchange rate?");
            exchange_input = Console.ReadLine();
            while (!double.TryParse(exchange_input, out exchange))
            {
                Console.WriteLine("Please eneter a valid exchange rate! What's the sterling -> dollar Exchange rate?");
                exchange_input = Console.ReadLine();
            }

            exchange = double.Parse(exchange_input);
            converted = dollars * exchange;
            
            Console.WriteLine($"{dollars:$0.00} is {converted:C2} in sterling");

        }
    }
}
