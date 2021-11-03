using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(a + b * c);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a != b)); // that's bad
            Console.WriteLine(c > b || c == a);

            /*  
             * Can use in-line multiplication and division ( *= , /= )
             * 
             * ! is used as not ( !a )
             * 
             * In C#, "postfix increment" results in increment after assignment/operation
             *  int a = 1;
             *  int b = a++;
             * 
             *  a = 2, b = 1
             * 
             * "prefix increment" performs increment prior to assignment/operation
             *  int a = 1;
             *  int b = ++a;
             * 
             *  a = 2, b = 2
             */
        }
    }
}
