using System;
using System.Collections.Generic;
using System.Linq;

namespace cherry_bomb
{
    internal class FileName
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<int> output = new List<int>();

            while (t-- > 0)
            {
                string[] fline = Console.ReadLine().Split(" ");
                int size = int.Parse(fline[0]);
                int maxv = int.Parse(fline[1]);

                List<int> A = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                List<int> B = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

                if (B.All(x => x == -1))
                {
                    int maxX = A.Min() + maxv;
                    int minX = A.Max();
                    int count = Math.Max(0, maxX - minX + 1);
                    output.Add(count);
                }
                else
                {
                    bool equal = true;
                    int complementary = -1;

                    // Set complementary using the first valid pair
                    for (int i = 0; i < size; i++)
                    {
                        if (B[i] != -1)
                        {
                            complementary = A[i] + B[i];
                            break;
                        }
                    }

                    // Check if all defined pairs sum up to the same complementary
                    for (int i = 0; i < size; i++)
                    {
                        if (B[i] != -1 && A[i] + B[i] != complementary)
                        {
                            equal = false;
                            break;
                        }
                    }

                    // Now check if we can assign values to -1s to satisfy the same complementary
                    if (equal)
                    {
                        for (int i = 0; i < size; i++)
                        {
                            if (B[i] == -1)
                            {
                                int requiredB = complementary - A[i];
                                if (requiredB < 0 || requiredB > maxv)
                                {
                                    equal = false;
                                    break;
                                }
                            }
                        }
                    }

                    output.Add(equal ? 1 : 0);
                }
            }

            foreach (var item in output)
                Console.WriteLine(item);
        }
    }
}
