using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St._Chroma
{
    internal class FileName
    {
        static void Main()
        {
            int test = int.Parse(Console.ReadLine());
            List<string> listout = new List<string>();
            for (int i = 0; i < test; i++)//test cases 
            {
                List<string> input = Console.ReadLine().Split(" ").ToList();
                List<int> output = new List<int>();
                int n = int.Parse(input[0]);
                int x = int.Parse(input[1]);//should be last element 
                for (int k = (n - 1); k >= 0; k--)
                {
                    output.Add(k);
                }
                output.Sort();
                if (output.Contains(x))
                {
                    if (x != output[n - 1])
                    {
                        output.Remove(x);
                        output.Add(x);//make x the last element
                    }
                }
                
                    string joinedstring = string.Join(" ", output);
                listout.Add(joinedstring);
            }
            foreach (string v in listout)
            {
                Console.WriteLine(v);
            }
        }
    }
}
