using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Matt";
            var isWorking = true;

            const float Pi = 3.14f;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("Byte:{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Float:{0} {1}", float.MinValue, float.MaxValue);

        }
    }
}
