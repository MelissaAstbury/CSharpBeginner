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





            // Finding the Index
            var certainName = names.IndexOf("Mike");
            if (certainName == -1)
            {
                Console.WriteLine($"When an item is not found the index is {certainName}");
            }
            else
            {
                Console.WriteLine($"The name {names[certainName]} is at index {certainName}");
            }



            // Fibonacci sequence

            var fibonacciNumbers = new List<int> { 1, 1 };

            // This will grab the last one currently in the sequence
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            // This will grab the second the last in the sequence
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            // Add them together and add this to the original sequence
            fibonacciNumbers.Add(previous + previous2);

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);




            // Challenge - Get the first 20 in sequence
            var fibonacciNumbers2 = new List<int> { 1, 1 };

            while (fibonacciNumbers2.Count < 20)
            {
                // This will grab the last one currently in the sequence
                var previous3 = fibonacciNumbers2[fibonacciNumbers2.Count - 1];
                // This will grab the second the last in the sequence
                var previous4 = fibonacciNumbers2[fibonacciNumbers2.Count - 2];

                // Add them together and add this to the original sequence
                fibonacciNumbers2.Add(previous3 + previous4);
            }

                foreach (var i in fibonacciNumbers2)
                Console.WriteLine(i);

        }
    }
}
