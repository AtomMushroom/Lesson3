using System;

namespace Lesson_3Task3
{
    class L3Task4
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int counter = 0; counter <= 9; counter++)
            {
                int number = Int32.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("Сумма чисел: " + sum);
        }
    }
}
