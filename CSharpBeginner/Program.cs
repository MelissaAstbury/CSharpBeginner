﻿using System;

namespace CSharpBeginner
{
    class Program
    {
        static void Main(string[] args)
        {

            // if statements (branches)
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



            // while loop
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"The counter is {counter}");
                counter++;
            }



            // for loops
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"The index is {index}");
            }



            // combine the branches and loops

            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
