using System;

namespace LoopChallenge
{
    class Program
    {
        static void Main(string[] args)

        {
            var count = 0;
            while (count < 5) { 
                Console.WriteLine("This is start of loop no. " + (count + 1)+ "\n");
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine(i);

                }
                for (int i = 10; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
                count++;
                Console.WriteLine("\n");
            }
        }
    }
}
