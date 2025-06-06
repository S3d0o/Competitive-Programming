using System;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < test; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int l = int.Parse(input[0]);
                int r = int.Parse(input[1]);
                int d = int.Parse(input[2]);
                int u = int.Parse(input[3]);

                // The square condition: All four sides must be equal.
                if (l == r && r == d && d == u)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
