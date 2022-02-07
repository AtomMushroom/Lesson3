using System;

namespace Lesson_3Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            for (int x = 2; x<=8; x++)
            {
                for (int y = 2; y<=5; y++)
                {
                    result = Math.Pow(x, y);
                    Console.WriteLine(x + " " + y + " " + result);
                }
            }
        }
    }
}
