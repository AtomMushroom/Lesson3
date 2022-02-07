using System;

namespace Lesson_3Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            for (int x = 30; x <=33; x++)
            {
                for (int y = 1; y <= 5; y++)
                {
                    result = x - y;
                    Console.WriteLine(x + " " + y + " " + result);
                }
            }
        }
    }
}
