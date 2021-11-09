﻿using System;

namespace TextExercises
{
    class Program
    {
        static void Main(string[] args)
        {
    /*
    * 1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
    *      Work out if the numbers are consecutive. 
    *      For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: 
    *          "Consecutive"; otherwise, display "Not Consecutive".
    */
            Console.WriteLine("Please enter numbers, separated by a hyphen '-': ");
            var input = Console.ReadLine().Split('-');
            var max = 0;

            foreach (var n in input)
            {
                if (Convert.ToInt32(n) + 1 == max || Convert.ToInt32(n) - 1 == max)
                {
                    max = Convert.ToInt32(n);
                }
                Console.WriteLine("Not Consecutive");
                break;
            }
            Console.WriteLine("Consecutive");
            Console.WriteLine();

    /*
    * 2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
    *      If the user simply presses Enter, without supplying an input, exit immediately; 
    *      otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
    */
            Console.WriteLine("Please enter numbers separated by hyphens '-': ");
            var dupes = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(dupes))
            {
                Console.WriteLine("You forgot to provide numbers");
            }

            var check = dupes.Split('-');
            // parse array for duplicates
            Console.WriteLine("Duplicates");
            Console.WriteLine();

    /*
    * 3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
    *      A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; 
    *      otherwise, display "Invalid Time". 
    *      If the user doesn't provide any values, consider it as invalid time.
    */
            Console.WriteLine("Enter a time in format '19:00': ");
            var timeIn = Console.ReadLine();

            Console.WriteLine("Ok");

            Console.WriteLine("Invalid Time");

            Console.WriteLine();

            /*
             * 4- Write a program and ask the user to enter a few words separated by a space. 
             *      Use the words to create a variable name with PascalCase. 
             *      For example, if the user types: "number of students", display "NumberOfStudents". 
             *      Make sure that the program is not dependent on the input. 
             *      So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
             */
            Console.WriteLine("Enter a few words: ");
            var pascal = Console.ReadLine().Split(' ');

            Console.WriteLine("PascalCaseOfInput");
            Console.WriteLine();

            /*
             * 5- Write a program and ask the user to enter an English word. 
             *      Count the number of vowels (a, e, o, u, i) in the word. 
             *      So, if the user enters "inadequate", the program should display 6 on the console.
             */
            Console.WriteLine("Please enter a word: ");
            var vowels = Console.ReadLine();

            Console.WriteLine("Count of vowels: ");
            Console.WriteLine();
        }
    }
}
