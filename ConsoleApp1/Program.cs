using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {  
            //Find the sum of the even numbers
            int[] inputIntegers = new int[6];
            int sumNumbers = 0;


            for (int i = 0; i < inputIntegers.Length; i++)
            {
                Console.WriteLine("Input 6 integers:" +  (i + 1));
                inputIntegers[i] = int.Parse(Console.ReadLine());
                if (inputIntegers[i] % 2 == 0)
                {
                    sumNumbers += inputIntegers[i];
                }
            }
            Console.WriteLine("Sum of even numbers is:" + sumNumbers);
            Console.ReadLine();
        }
    }
}

