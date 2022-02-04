using System;

namespace Lesson3_Task2
{
    class L3Task2
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter <= 100; counter++)
            {
                Console.Write($" {counter}");
            }

            for (int counter = 99; counter > 0; counter--)
            {
                Console.Write($" {counter}");
            }
        }
    }
}
