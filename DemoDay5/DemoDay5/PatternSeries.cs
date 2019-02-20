using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDay5
{
    class PatternSeries
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter sequence number ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < 2 * n ; i++)
            {
                if (i <= 7)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for(int j = 1; j < 2 * n - i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
