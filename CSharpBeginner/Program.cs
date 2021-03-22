using System;

namespace CSharpBeginner
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
