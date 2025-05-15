using System;

class Function
{
    static void Main(string[] args)
    {
        PrintLine();
        AddNumbers(50, 100);
        Console.WriteLine("Inside main");
        PrintA();
        Console.WriteLine("Back in main");
        PrintR();
        int sum = AddThreeNumbersReturn(50, 10, 5);
        Console.WriteLine($"Sum of three numbers is: {sum}");
        MessagePrint();
        PrintMaximum(10, 17, 92);
        Counting();
        bool prime = IsPrimeNumber(10);
        Console.WriteLine(prime ? "It's a prime number" : "Not a prime number");
        EvenOrOdd(16);
        FindSumUptoN(10);
        FindEvenNumbersUptoN(10);
        AreaOfCircle(4);
    }

    // Print a line multiple times
    public static void PrintLine()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("This is my first function");
        }
    }

    // Add two numbers
    public static void AddNumbers(int a, int b)
    {
        int result = a + b;
        Console.WriteLine($"Addition of two numbers is: {result}");
    }

    // Function call stack example
    public static void PrintA()
    {
        Console.WriteLine("Inside A");
        Console.WriteLine("Going back to main");
    }

    public static void PrintR()
    {
        Console.WriteLine("Inside R");
        PrintB();
    }

    public static void PrintB()
    {
        Console.WriteLine("Inside B");
        PrintC();
    }

    public static void PrintC()
    {
        Console.WriteLine("Inside C");
    }

    // Print sum of three numbers
    public static void AddThreeNumbers(int x, int y, int z)
    {
        int sum = x + y + z;
        Console.WriteLine($"Sum of three numbers is: {sum}");
    }

    // Return sum of three numbers
    public static int AddThreeNumbersReturn(int x, int y, int z)
    {
        return x + y + z;
    }

    // Print a message
    public static void MessagePrint()
    {
        Console.WriteLine("Message 1");
        return;
    }

    // Find the maximum of three numbers
    public static void PrintMaximum(int num1, int num2, int num3)
    {
        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine($"Maximum is: {num1}");
        }
        else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine($"Maximum is: {num2}");
        }
        else
        {
            Console.WriteLine($"Maximum is: {num3}");
        }
    }

    // Counting from 1 to N
    public static void Counting()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        for (int count = 1; count <= n; count++)
        {
            Console.WriteLine($"Counting: {count}");
        }
    }

    // Check if a number is prime
    public static bool IsPrimeNumber(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    // Check if a number is even or odd
    public static void EvenOrOdd(int num)
    {
        Console.WriteLine(num % 2 == 0 ? "Even number" : "Odd number");
    }

    // Find the sum of all numbers up to N
    public static void FindSumUptoN(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Final sum: {sum}");
    }

    // Find the sum of all even numbers up to N
    public static void FindEvenNumbersUptoN(int x)
    {
        int sum = 0;
        for (int i = 2; i <= x; i += 2)
        {
            sum += i;
        }
        Console.WriteLine($"Final sum of even numbers is: {sum}");
    }

    // Calculate the area of a circle
    public static void AreaOfCircle(int r)
    {
        const double Pi = 3.14;
        double result = Pi * r * r;
        Console.WriteLine($"Area of the circle is: {result}");
    }
    
}