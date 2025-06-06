using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace div03
{
    internal class pa
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            List<string> output = new List<string>();
            while(t-->0)
            {
                double year=int.Parse(Console.ReadLine());

                double test=Math.Sqrt(year);

                if (test%1 != 0)
                {
                    output.Add("-1");
                }
                else
                {
                    for(int i=0;i<=test;i++)
                    {
                        double j = test ;
                        if( Math.Pow(i+j,2) == year )
                        {
                            output.Add( i.ToString()+" "+j.ToString()); 
                            break;
                        }
                    }

                }
            }
            foreach(string i in output)
            {
                Console.WriteLine(i);
            }
        }
    }
}
