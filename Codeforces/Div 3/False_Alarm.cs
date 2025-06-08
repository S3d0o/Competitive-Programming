using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    internal class FileName
    {
        static void Main()
        {
            int t =int.Parse(Console.ReadLine());
            List<string> output = new List<string>();
            while(t-->0)
            {
                string[] nx = Console.ReadLine().Split();
                int numdoors=int.Parse(nx[0]);
                int secbutton=int.Parse(nx[1]);
                int check=secbutton;

                List<int> doors = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                bool conditionMet = false;
                bool finalresult = true ;
                for (int i =0; i<numdoors ;i++)
                {
                    if ((doors[i]== 1 ||conditionMet)&&check>0)
                    {
                        check--;
                        conditionMet = true;
                    }
                   
                    else if (doors[i] == 1 && check == 0)
                    {
                        // Hit a closed door, button already used up
                        finalresult = false;
                        output.Add("No");
                        break;
                    }
                }
                if (finalresult)
                {
                    output.Add("Yes");
                }


            }
            foreach (string x in output)
            {
                Console.WriteLine(x);
            }
        }
    }
}
