using System;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BigInteger numberOne = 1;
            BigInteger numberTwo = 1;
            BigInteger result;
            int counter = 1;

            Console.WriteLine(numberOne + " (" + counter + ".sayı)");
            for (int i = 0; i < 999; i++)
            {
                counter++;
                result = numberOne + numberTwo;
                Console.WriteLine(result + " (" + counter + ".sayı)");
                numberOne = numberTwo;
                numberTwo = result;
            }

            


        }
    }
}
