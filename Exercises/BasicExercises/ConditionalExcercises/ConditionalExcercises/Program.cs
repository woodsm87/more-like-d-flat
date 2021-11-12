using System;

namespace ConditionalExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1- Write a program and ask the user to enter a number. The number should be between 1 to 10. 
             *      If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". 
             *      (This logic is used a lot in applications where values entered into input boxes need to be validated.)
             * 2- Write a program which takes two numbers from the console and displays the maximum of the two.
             * 3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
             * 4- Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc 
             *      and focus purely on the logic. Write a program that asks the user to enter the speed limit. 
             *      Once set, the program asks for the speed of a car. 
             *          If the user enters a value less than the speed limit, program should display Ok on the console. 
             *          If the value is above the speed limit, the program should calculate the number of demerit points. 
             *      For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
             *          If the number of demerit points is above 12, the program should display License Suspended.
             */
            var exercise = 0;
            do
            {
                Console.WriteLine("Please select an exercise 1-4:");
                exercise = Convert.ToInt32(Console.ReadLine());

                switch (exercise)
                {
                    case 1:
                        Console.WriteLine("You have chosen exercise 1: Validity test.\nPlease enter a number to test:");
                        var input = Convert.ToInt32(Console.ReadLine());
                        Validity(input);
                        exercise = 0;
                        break;

                    case 2:
                        Console.WriteLine("You have chosen exercise 2: Max value test.\nPlease enter 2 numbers to test:");
                        var numA = Convert.ToInt32(Console.ReadLine());
                        var numB = Convert.ToInt32(Console.ReadLine());
                        Topper(numA, numB);
                        exercise = 0;
                        break;

                    case 3:
                        Console.WriteLine("You have chosen exercise 3: Image orientation test.\nPlease enter height and width to test:");
                        Console.WriteLine("Height: ");
                        var height = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Width: ");
                        var width = Convert.ToInt32(Console.ReadLine());
                        Image(height, width);
                        exercise = 0;
                        break;

                    case 4:
                        Console.WriteLine("You have chosen exercise 4: Speed limit test.\nPlease enter speed limit and current speed to test:");
                        Console.WriteLine("Limit: ");
                        var limit = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Speed: ");
                        var speed = Convert.ToInt32(Console.ReadLine());
                        Speed(limit, speed);
                        exercise = 0;
                        break;

                    default:
                        Console.WriteLine("Bad input error.....");
                        break;
                }
            } while (exercise == 0);

        }

        public static void Validity(int inputNum)
        {
            if (inputNum < 10 && inputNum > 0)
            {
                Console.WriteLine("Valid entry.");
            }
            else
            {
                Console.WriteLine("Invalid entry.");
            }
        }

        public static void Topper(int numA, int numB)
        {
            Console.WriteLine(Math.Max(numA, numB));
        }

        public static void Image( int height, int width)
        {
            if (height > width)
            {
                Console.WriteLine("The image is in portrait orientation.");
            }
            if (height == width)
            {
                Console.WriteLine("This image is square.");
            }
            else
            {
                Console.WriteLine("The image is in landscape orientation.");
            }
        }

        public static void Speed(int limit, int velocity)
        {
            if (velocity < limit)
            {
                Console.WriteLine("This speed is acceptable, though slow.");
            }

            if (velocity == limit)
            {
                Console.WriteLine("You're so careful, good job.");
            }

            else
            {
                var demerits = (velocity - limit) / 5;
                if (demerits > 12)
                {
                    Console.WriteLine("You have exceeded the limit of demerits on your license,\nit is now suspended.");
                }

                else
                {
                    Console.WriteLine("You have earned {0} demerits on your license. Mind you don't exceed 12!", demerits);
                }
            }
        }
    }
}
