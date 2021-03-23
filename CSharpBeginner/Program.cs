using System;
using System.Collections.Generic;

namespace CSharpBeginner
{
    class Program
    {
        static void Main(string[] args)
        {

            // If statements (Branches)
            int a = 5;
            int b = 6;
            int c = 4;
            if (
                (a + b + c > 10)

                &&

                (a == b)

                )
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }


            int d = 5;
            int e = 5;
            int f = 4;
            if (
                (d + e + f < 10)

                ||

                (a == b)

                )
            {
                Console.WriteLine("At leaset one of the answers pass");
            }
            else
            {
                Console.WriteLine("None of the conditions are met");
            }



            // While Loop
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"The counter is {counter}");
                counter++;
            }



            // For Loops
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"The index is {index}");
            }



            // Combine the Branches and Loops

            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"The sum is {sum}");



            // Lists and Collections
            var names = new List<string> { "<name>", "Mel", "Andy" };

            names.Add("Deno");
            names.Add("Mike");
            names.Remove("Mel");

            foreach (var name in names)
            {
                Console.WriteLine($"Hello, {name.ToUpper()}");
            }
            Console.WriteLine(names[1]);
        }
    }
}
