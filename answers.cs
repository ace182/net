using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge C# Junior Developer\n");
            Console.WriteLine("Select an option:\n");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            int number = Program.Multiples(3, 5, 10);
            Console.WriteLine(number);
            Program.PowerNumber(5);
        }

        // Multiples
        static int Multiples(int x, int y, int n)
        {
            int acum = 0;
            for (int i = 1; i < n; i++)
            {
                if (i % x == 0 || i % y == 0)
                {
                    acum += i;
                }
            }
            return acum;
        }

        // Power number
        static void PowerNumber(int n)
        {
            for (int i = 0; i < Math.Pow(10, n); i++)
            {
                int[] numbers = GetDigits(i);
                int acum = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    acum += (int)Math.Pow(numbers[j], n);
                }
                if (acum == i && acum != 0)
                {
                    Console.WriteLine(acum);
                }
            }
            return;
        }

        static int[] GetDigits(int number)
        {
            string text = number.ToString(); //Set to TextBox text
            int[] numbers = new int[text.Length]; //Create array of ints
            for (int i = 0; i < text.Length; i++)
            {
                //Parse each character to an integer
                numbers[i] = Int32.Parse(text[i].ToString());
            }
            return numbers;
        }

        // Matrix
        static void matrix(int n)
        {
            int[][] = 
        }
    }
}