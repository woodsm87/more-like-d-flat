using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
    // DateTime
            var dt = new DateTime(2021, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yy-MMM-dd"));

    // TimeSpan
            var timespan = new TimeSpan(1, 2, 3);
            var timespan1 = new TimeSpan(1, 0, 0);
            var timespan2 = TimeSpan.FromHours(1);

            var duration = today - yesterday;
            Console.WriteLine("Duration: " + duration);

        // Properties
            Console.WriteLine("Minutes: " + timespan.Minutes); //provides minutes of timespan
            Console.WriteLine("Total Minutes: " + timespan.TotalMinutes); //converts total timespan (1 hr, 2 min, 3 sec) to minutes

            Console.WriteLine("Add example: " + timespan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract example: " + timespan.Subtract(TimeSpan.FromMinutes(2)));

            Console.WriteLine("ToString" + timespan.ToString());
            Console.WriteLine("Pares: " + TimeSpan.Parse("01:15:20"));
        }
    }
}
