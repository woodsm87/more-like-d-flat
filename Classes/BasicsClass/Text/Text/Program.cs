using System;
using System.Text;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Like most objects in C#, strings are immutable, so changes such as replace or ToUpper
             * need to be set as new objects
             */
            var fullName = "Matt Woods ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());

            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("Split first name: " + names[0]);
            Console.WriteLine("Split last name: " + names[1]);

            Console.WriteLine("Replacement: " + fullName.Replace("Matt", "Matthew"));

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            var input = "25";
            var age = Convert.ToByte(input); // Since storing an age value will always be less than 255 use byte
            Console.WriteLine(age);

            float price = 12356.23f;
            Console.WriteLine(price.ToString("C"));

            // Summarizing blocks
            var sentence = "This is going to be an indeterminate length text block that is intended to be long.";
            var summary = StringUtility.SummarizeText(sentence, 25);

            Console.WriteLine(summary);

    // String Builder
        /*
         * No searching functions, only manipulation
         * because the manipulations return builder objects, they can be chained as demonstrated below
         */
            var builder = new StringBuilder();
            /*
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);
            Console.WriteLine();

            builder.Replace('-', '*');
            builder.Remove(0, 10); // Performs based on index
            builder.Insert(0, new string('-', 10)); // Performs based on index
            */
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
            //Console.WriteLine(builder);
            //Console.WriteLine();

                .Replace('-', '*')
                .Remove(0, 10) // Performs based on index
                .Insert(0, new string('-', 10)); // Performs based on index
            Console.WriteLine(builder);
            Console.WriteLine();

        }
    }
}
