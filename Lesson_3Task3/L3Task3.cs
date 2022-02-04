using System;

namespace Lesson_3Task3
{
    class L3Task3
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            for (int counter = 0; counter <= 9; counter++)
            {
                int number = Int32.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    a++;
                }
                else
                {
                    b++;
                }
            }
            Console.WriteLine("Четных: " + a);
            Console.WriteLine("Нечетных: " + b);
        }
    }
}
