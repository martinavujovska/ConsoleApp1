using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Martina", "Jovana", "Bojan", "Irena", "Elena" };
            string[] studentsG2 = { "John", "Bob", "James", "Mark", "Simon" };

            Console.WriteLine("Enter Student Group:");
            int userInput = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < 5; i++)
            {
                if (userInput == 1)
                {
                    Console.WriteLine("The students in G1 are:" + studentsG1[i]);
                }
                else if(userInput == 2)
                {
                    Console.WriteLine("The students in G2 are:" + studentsG2[i]);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
