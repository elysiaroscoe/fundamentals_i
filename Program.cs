using System;

namespace Fundamentals_I
{
    class Program
    {
        // Problem 1
        // static void Main(string[] args)
        // {
        //     int i = 1;
        //     while (i <= 255)
        //     {
        //         Console.WriteLine(i);
        //         i++;
        //     }
        // }

        // static void Main(string[] args)
        // {
        //     for (int i = 1; i <= 255; i++)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }



        //Problem 2
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 100)
            {
                if (i%3==0 && i%5==0)
                {
                    i++;
                }
                else if (i%3==0 || i%5==0)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
        }

    }
}