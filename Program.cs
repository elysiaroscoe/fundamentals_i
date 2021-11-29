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
        // static void Main(string[] args)
        // {
        //     int i = 1;
        //     while (i <= 100)
        //     {
        //         if (i%3==0 && i%5==0)
        //         {
        //             i++;
        //         }
        //         else if (i%3==0 || i%5==0)
        //         {
        //             Console.WriteLine(i);
        //             i++;
        //         }
        //         else
        //         {
        //             i++;
        //         }
        //     }
        // }

        // static void Main(string[] args)
        // {
        //     for (int i = 1; i <= 100; i++)
        //     {
        //         if (i%3==0 && i%5==0)
        //         {
        //             continue;
        //         }
        //         else if (i%3==0 || i%5==0)
        //         {
        //             Console.WriteLine(i);
        //         }
        //     }
        // }


        //Problem 3
        // static void Main(string[] args)
        // {
        //     int i = 1;
        //     while (i <= 100)
        //     {
        //         if (i%3==0 && i%5==0)
        //         {
        //             Console.WriteLine("FizzBuzz");
        //             i++;
        //         }
        //         else if (i%3==0)
        //         {
        //             Console.WriteLine("Fizz");
        //             i++;
        //         }
        //         else if (i%5==0)
        //         {
        //             Console.WriteLine("Buzz");
        //             i++;
        //         }
        //         else
        //         {
        //             i++;
        //         }
        //     }
        // }

        // static void Main(string[] args)
        // {
        //     for (int i = 1; i <= 100; i++)
        //     {
        //         if (i%3==0 && i%5==0)
        //         {
        //             Console.WriteLine("FizzBuzz");
        //         }
        //         else if (i%3==0)
        //         {
        //             Console.WriteLine("Fizz");
        //         }
        //         else if (i%5==0)
        //         {
        //             Console.WriteLine("Buzz");
        //         }
        //     }
        // }


    }
}

//Coding Dojo answers rely heavily on bool-is that important?
//ex: 

    // bool byThree = (value % 3 == 0);
    // bool byFive =  (value % 5 == 0);
    // bool byThreeAndFive = (value % 3 == 0 && value % 5 == 0);
