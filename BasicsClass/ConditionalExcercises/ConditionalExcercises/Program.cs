using System;

namespace ConditionalExcercises
{
    public enum Exercise
    {
        Valid = 1,
        Max = 2,
        Image = 3,
        Speed = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select an exercise 1-4:");
            var exercise = (Exercise)Convert.ToInt32(Console.ReadLine());

            switch (exercise)
            {
                case Exercise.Valid:
                    Console.WriteLine("You have chosen exercise 1: Validity test.\nPlease enter a number to test:");
                    var input = Convert.ToInt32(Console.ReadLine());
                    Validity(input);
                    break;

                default:
                    Console.WriteLine("Bad input error.....");
                    break;
            }
            


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
    }
}
