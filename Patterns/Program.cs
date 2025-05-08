// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Globalization;

class Patterns
{
    static void Main(string[] arg)
    {
        //---- Full Pyramid
        int n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            // For space
            for (int col = 0; col < n - row - 1; col++)
            {
                System.Console.Write(" ");
            }
            // For star
            for (int col = 0; col < row + 1; col++)
            {
                System.Console.Write(" *  ");
            }
            System.Console.WriteLine();
        }

        //----- Inverted Pyramid
        n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            // For space
            for (int col = 0; col < row; col++)
            {
                System.Console.Write(" ");
            }
            // For star
            for (int col = 0; col < n - row; col++)
            {
                System.Console.Write(" * ");
            }
            System.Console.WriteLine();
        }

        //------ Diamond Pattern
        n = int.Parse(Console.ReadLine());
        int half = n / 2;

        for (int row = 0; row < half; row++)
        {
            // For space
            for (int col = 0; col < half - row - 1; col++)
            {
                System.Console.Write(" ");
            }
            // For star
            for (int col = 0; col < row + 1; col++)
            {
                System.Console.Write(" *  ");
            }
            System.Console.WriteLine();
        }

        for (int row = 0; row < half; row++)
        {
            // For space
            for (int col = 0; col < row; col++)
            {
                System.Console.Write(" ");
            }
            // For star
            for (int col = 0; col < half - row; col++)
            {
                System.Console.Write(" *  ");
            }
            System.Console.WriteLine();
        }

        //----- Hollow Pyramid
        n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            // For space
            for (int col = 0; col < n - row - 1; col++)
            {
                System.Console.Write(" ");
            }
            // For star
            for (int col = 0; col < row + 1; col++)
            {
                if (col == 0 || col == row)
                {
                    System.Console.Write(" *  ");
                }
                else
                {
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine();
        }

        //---- Inverted Hollow Pyramid
        n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            // For space
            for (int col = 0; col < row; col++)
            {
                System.Console.Write(" ");
            }
            // For star
            int totalColumn = n - row;
            for (int col = 0; col < totalColumn; col++)
            {
                if (col == 0 || col == totalColumn - 1)
                {
                    System.Console.Write(" * ");
                }
                else
                {
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine();
        }

        //--- Box Pattern
        n = 4;
        for (int row = 0; row < n; row++)
        {
            // Inverted Pyramid 1
            for (int col = 0; col < n - row; col++)
            {
                System.Console.Write(" * ");
            }
            // Full Pyramid
            for (int col = 0; col < (2 * row + 1); col++)
            {
                System.Console.Write(" ");
            }
            // Inverted Pyramid 2
            for (int col = 0; col < n - row; col++)
            {
                System.Console.Write(" * ");
            }
            System.Console.WriteLine();
        }

        for (int row = 0; row < n; row++)
        {
            // Inverted
            for (int col = 0; col < (row + 1); col++)
            {
                System.Console.Write(" * ");
            }
            for (int col = 0; col < (2 * n - 2 * row - 1); col++)
            {
                System.Console.Write(" ");
            }
            // Inverted Pyramid 2
            for (int col = 0; col < row + 1; col++)
            {
                System.Console.Write(" * ");
            }
            System.Console.WriteLine();
        }

        //--- Fancy Pattern
        n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < 2 * row + 1; col++)
            {
                if (col % 2 == 1)
                {
                    System.Console.Write(" * ");
                }
                else
                {
                    System.Console.Write(row + 1);
                }
            }
            System.Console.WriteLine();
        }

        //--- Inverted Half Pyramid
        n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n - row; col++)
            {
                if (row == 0 || row == n - 1)
                {
                    System.Console.Write(" * ");
                }
                else
                {
                    if (col == 0 || col == n - row - 1)
                    {
                        System.Console.Write(" * ");
                    }
                    else
                    {
                        System.Console.Write(" ");
                    }
                }
            }
            System.Console.WriteLine();
        }

        //-- Inverted Number Pyramid
        n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n - row; col++)
            {
                if (col == 0)
                {
                    System.Console.Write(" 1 ");
                }
                else
                {
                    if (col == n - col - 1)
                    {
                        System.Console.Write(row + 1);
                    }
                    else
                    {
                        System.Console.Write(" ");
                    }
                }
            }
            System.Console.WriteLine();
        }

        //--- Printed Numeric Pattern
        n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < row + 1; col++)
            {
                System.Console.Write(col + 1);
            }
            System.Console.WriteLine();
        }

        //-- Alphabet Pattern
        n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            char ch = 'A';
            for (int col = 0; col < row + 1; col++)
            {
                ch = (char)(col + 1 + 'A' - 1);
                System.Console.Write(ch);
            }
            for (char alphabet = ch; alphabet > 'A';)
            {
                alphabet = (char)(alphabet - 1);
                System.Console.Write(alphabet);
            }
            System.Console.WriteLine();
        }
    }
}