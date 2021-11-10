using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            var numbers = new[] { 34, 17, 99, 24, 12, 61 };
            var index = Array.IndexOf(numbers, 9);


            Console.WriteLine("Length: " + numbers.Length);

            Console.WriteLine("Index of 99: " + index);

            Array.Clear(numbers, 3, 2);
            Console.WriteLine("Effect of Clear(): ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            var another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy(): ");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            Array.Sort(another);
            Console.WriteLine("Effect of Sort(): ");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse: ");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            // Lists
            var nums = new List<int>() { 1, 2, 3, 4 };
            nums.Add(1);
            nums.AddRange(numbers);

            foreach (var n in nums)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\nIndex of 1: " + nums.IndexOf(1));
            Console.WriteLine("Last index of 1: " + nums.LastIndexOf(1));
            Console.WriteLine("Count: " + nums.Count);

            nums.Remove(1);
            
            foreach (var n in nums)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            for (var i = 0; i < nums.Count; i++)
            {
                if (nums[i] == 1)
                {
                    nums.Remove(nums[i]);
                }
            }
            foreach (var n in nums)
            {
                Console.WriteLine(n);
            }

            nums.Clear();
            Console.WriteLine("Count after Clear(): " + nums.Count);
        }
    }
}
