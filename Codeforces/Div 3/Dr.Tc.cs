using System;
using System.Collections.Generic;
using System.Linq;

namespace Dr.Tc
{
    internal class FileName
    {
        static void Main()
        {
            int test = int.Parse(Console.ReadLine());
            List<int> countsof1s = new List<int>();

            for (int i = 0; i < test; i++)
            {
                int length = int.Parse(Console.ReadLine());
                string binary = Console.ReadLine();

                int count = 0;

                for (int j = 0; j < length; j++)
                {
                    // Copy original string to char array
                    char[] flipped = binary.ToCharArray();

                    // Flip the j-th bit
                    flipped[j] = flipped[j] == '0' ? '1' : '0';

                    // Count number of '1's in this flipped row
                    count += flipped.Count(c => c == '1');
                }

                countsof1s.Add(count);
            }

            foreach (int s in countsof1s)
            {
                Console.WriteLine(s);
            }
        }
    }
}
