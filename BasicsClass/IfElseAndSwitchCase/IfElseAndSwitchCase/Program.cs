using System;

namespace IfElseAndSwitchCase
{
    partial class Program
    {
        static void Main(string[] args)
        {
    // If/Else
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning!");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }

            bool isGoldCustomer = true;
        // simple conditionals can be done in instantion
            //float price;
            //if (isGoldCustomer)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.95f;
            //}

            //                              if true : else
            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);

    // Switch/Case

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's sweater weather!");
                    break;

                case Season.Summer:
                    Console.WriteLine("Swimsuit season!");
                    break;

        // multiple cases with same return
                case Season.Spring:
                case Season.Winter:
                    Console.WriteLine("There's a sale!");
                    break;

                default:
                    Console.WriteLine("wat.");
                    break;
            };

        }
    }
}
