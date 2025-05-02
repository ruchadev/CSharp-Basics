// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Globalization;
using System.IO.Pipelines;

class Loops
{
    static void Main(string[] arg)
    {
        // ------for loop--------
        for (int i = 10; i <= 12; i++)
        {
            System.Console.WriteLine("Monika oh my darling");
        }

        for (int even = 2; even < 10; even += 2)
        {
            System.Console.WriteLine(even);
        }

        for (int countdown = 10; countdown > 0; countdown--)
        {
            System.Console.WriteLine(countdown);
        }

        int counter;
        for (counter = 0; counter <= 5; counter++)
        {
            System.Console.WriteLine("A");
        }
        Console.ReadLine();

        // ------NestedLoop--------
        for (int outer = 0; outer < 3; outer++)
        {
            System.Console.WriteLine($"outer loop : {outer}");
            for (int inner = 0; inner < 3; inner++)
            {
                System.Console.WriteLine($"inner loop: {inner}");
            }
        }

        // --------for loop without defining and initializing the condition under for loop
        int infiniteCounter = 1;
        for (; ; )
        {
            if (infiniteCounter <= 5)
            {
                System.Console.WriteLine($"VALUE OF I: {infiniteCounter}");
                Console.WriteLine("Rucha");
                infiniteCounter++;
            }
        }

        // --print 11 times your name
        for (int nameCounter = 0; nameCounter <= 11; nameCounter++)
        {
            System.Console.WriteLine("Rucha");
        }

        // -------Print 19 table
        for (int multiplier = 1; multiplier <= 10; multiplier++)
        {
            int result = 19 * multiplier;
            System.Console.WriteLine($"19 table :{result}");
        }

        // ------1 to 100 odd numbers print
        for (int number = 1; number <= 100; number++)
        {
            if (number % 2 != 0)
            {
                System.Console.WriteLine($"number is odd: {number}");
            }
        }

        // ------Pattern printing - square
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                Console.Write("*");
            }
            System.Console.WriteLine();
        }

        // ------Rectangle pattern printing
        for (int rectRow = 0; rectRow < 3; rectRow++)
        {
            for (int rectCol = 0; rectCol < 5; rectCol++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // ----Hollow rectangle
        for (int hollowRow = 0; hollowRow < 5; hollowRow++)
        {
            for (int hollowCol = 0; hollowCol < 5; hollowCol++)
            {
                if (hollowRow == 0 || hollowRow == 4 || hollowCol == 0 || hollowCol == 4)
                {
                    System.Console.Write("*");
                }
                else
                {
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine();
        }

        // -------Half pyramid
        int pyramidHeight = int.Parse(Console.ReadLine());
        for (int pyramidRow = 0; pyramidRow < pyramidHeight; pyramidRow++)
        {
            for (int pyramidCol = 0; pyramidCol < pyramidRow + 1; pyramidCol++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }

        // ----Inverted half pyramid
        int invertedHeight = int.Parse(Console.ReadLine());
        for (int invertedRow = 0; invertedRow < invertedHeight; invertedRow++)
        {
            for (int invertedCol = 0; invertedCol < invertedHeight - invertedRow; invertedCol++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }

        // -----Numeric pyramid
        int numericHeight = int.Parse(Console.ReadLine());
        for (int numericRow = 0; numericRow < numericHeight; numericRow++)
        {
            for (int numericCol = 0; numericCol < numericRow + 1; numericCol++)
            {
                System.Console.Write(numericCol + 1);
            }
            System.Console.WriteLine();
        }

        // ----Inverted numeric pyramid
        int invertedNumericHeight = int.Parse(Console.ReadLine());
        for (int invertedNumericRow = 0; invertedNumericRow < invertedNumericHeight; invertedNumericRow++)
        {
            for (int invertedNumericCol = 0; invertedNumericCol < invertedNumericHeight - invertedNumericRow; invertedNumericCol++)
            {
                System.Console.Write(invertedNumericCol + 1);
            }
            System.Console.WriteLine();
        }
    }
}