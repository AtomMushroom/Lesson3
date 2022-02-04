using System;

namespace Lesson_3Task3
{
    class L3Task4
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int counter = 0; counter <= 20; counter++)
            {
                if (counter % 2 != 0)
                {
                    sum += counter;
                    Console.WriteLine(counter);
                }
            }
            Console.WriteLine("Сумма чисел последовательности: " + sum);
        }
    }
}
