using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    public enum ShippingMethod
        //default values are index and should be overwritten
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * C# uses instantiator 'new' to allocate memory for a class
             * 
             * 'struct' is a special object, used as a low-memory, simple class
             * 'enum' commonly used where there are a number of related constants
             * 
             * @ is used to read verbatim string (i.e. r'\\network\fully\qualified\domain')
             * 
             * structures are Value Types, i.e. int, char, bool
             *      allocated on stack automatically
             *      immediately removed from stack when falls out of scope
             * 
             * classes are Reference Types, i.e. string, array, custom
             *      allocated on heap manually
             *      remains on heap until garbage collected by CLR
             */

    // Classes
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";

            var jack = new Person
            {
                FirstName = "Jack",
                LastName = "Smith"
            };
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

    // Arrays

            var numbers = new int[3] { 1, 2, 3 };
            //numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);


    // Strings
            var firstName = "Matt";
            var lastName = "Woods";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Jack", "John", "Mary" };
            var formattedNames = string.Join(", ", names);

            Console.WriteLine(fullName);
            Console.WriteLine(myFullName);
            Console.WriteLine(formattedNames);

            var text = "Hi John\nLook into the following paths\nc:\\folder\\file\nc:\\folder2\\file";
            var textVerbatim = @"Hi John
Look into the following paths
c:\folder\file
c:\folder2\file";

            Console.WriteLine(text);
            Console.WriteLine(textVerbatim);

    // Enums
            var method = ShippingMethod.Express;

            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString()); //Console.WriteLine converts all to string in print

        // Parsing string to enum
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);

    // Reference Types vs Value Types
        // Simple

            var a = 10; // value type
            var b = a; // copy of value stored in new memory address
            b++;
            Console.WriteLine(string.Format("a: {0}\nb: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 }; // reference type
            var array2 = array1; // copy of memory address assigned to new var
            array2[0] = 0;

            Console.WriteLine(string.Join(", ", array1));
            Console.WriteLine(string.Join(", ", array2));

        // Advanced
            var numeral = 1; // value type
            Increment(numeral); // copy of value is sent to Increment, not object
            Console.WriteLine(numeral);

            var person = new Person() // reference type
            {
                FirstName = "Matt",
                LastName = "Woods",
                Age = 33
            };

            MakeOld(person); // copy of memory location sent to MakeOld, affects object

            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10; // copy of value is incremented by 10, then destroyed on scope exit
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
