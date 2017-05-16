using System;

namespace Pascals_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height in rows");
            string input = Console.ReadLine();
            int to = Convert.ToInt16(input);
            int spaces = to / 5 * 2 + 1;
            for (int i = 0; i < to; i++)
            {
                Console.Write(new String(' ', (spaces + 1) / 2 * ((to - 1) - i)));
                int l = 1;
                for (int j = 0; j<=i; j++)
                {
                    Console.Write(l);
                    Console.Write(new string(' ',spaces + 1 - l.ToString().Length));
                    l = l * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}