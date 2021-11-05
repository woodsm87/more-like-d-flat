using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
    // Random generation
        // random string creation (obfuscation applicable?)
            var random = new Random();

            for (var i = 0; i < 10; i++)
            {
                Console.Write((char)('a' + random.Next(0, 26)));
            }
            Console.WriteLine(); // terminates line writing

        // random array
            const int pwLength = 10;
            var buffer = new char[pwLength];
            var randArray = new Random();

            for (var i = 0; i < pwLength; i++)
            {
                buffer[i] = (char)('a' + randArray.Next(0, 26));
            }

            //var pw = String.Join("", buffer);
            var pw = new string(buffer);

            Console.WriteLine(pw); // terminates line writing

    // For loop
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

    // For Each loop
            var name = "John Smith";

            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

    // While loop
            var j = 0;
            while (j <= 10)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue; // returns to start of loop
                }

                break;
            }
        }
    }
}
