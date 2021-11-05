using System;
using System.Linq;

namespace LoopExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
             *      Display the count on the console
             * 2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
             *      Calculate the sum of all the previously entered numbers and display it on the console.
             * 3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
             *      For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
             * 4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
             *      If the user guesses the number, display “You won"; otherwise, display “You lost". 
             *      (To make sure the program is behaving correctly, you can display the secret number on the console first.)
             * 5- Write a program and ask the user to enter a series of numbers separated by comma. 
             *      Find the maximum of the numbers and display it on the console. 
             *      For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
             */

    // 1)
            Console.WriteLine("Give me a number to work with:");
            var divider = Convert.ToInt32(Console.ReadLine());
            var counter = 0;
            for (var i = 1; i < divider; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("Count of numbers from 1-{0} cleanly divisible by 3: {1}\n", divider, counter);

    // 2)
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number, or 'ok' to complete the set:");
                var inner = Console.ReadLine();
                
                if (inner != "ok")
                {
                    sum += Convert.ToInt32(inner);
                    continue;
                }

                else
                {
                    break;
                }
            }
            Console.WriteLine("Sum of your numbers is: {0}\n", sum);

    // 3)
            Console.WriteLine("Enter a number:");
            var input = Convert.ToInt32(Console.ReadLine());
            double factorial = input;
            var decrement = input;

            while (decrement > 1)
            {
                decrement--;
                factorial *= decrement;
            }
            Console.WriteLine("{0}! = {1}\n", input, factorial);

    // 4)
            Console.WriteLine("I've picked a number between 1-20.\nYou have four guesses to get it!");
            var rando = new Random().Next(1, 20);

            //Console.WriteLine(rando);
            for (var i = 4; i > 0; i--)
            {
                var inRandom = Convert.ToInt32(Console.ReadLine());
                if (inRandom == rando)
                {
                    Console.WriteLine("You got me this time!\n");
                    break;
                }

                if (i == 1)
                {
                    Console.WriteLine("You didn't pick {0}! I win!\n", rando);
                    break;
                }

                if (i == 2)
                {
                    Console.WriteLine("Nope! {0} more guess....", i - 1);
                }

                else
                {
                    Console.WriteLine("Nope! {0} more guesses....", i - 1);
                }
            }

    // 5)
            Console.WriteLine("Enter a series of numbers, separated by a ','.");
            var series = Console.ReadLine().Split(',');
            var top = Convert.ToInt32(series[0]);

            foreach (var number in series)
            {
                var item = Convert.ToInt32(number);
                if (item > top)
                {
                    top = item;
                }
            }
            Console.WriteLine("The highest you entered was: {0}\n", top);
        }
    }
}
