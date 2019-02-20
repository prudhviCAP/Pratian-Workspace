using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDay5
{
    class Series
    {
        static void Main(string[] args)
        {
            int n = 2;

            int seqLen;
            Console.Write("Enter length of sequnece : ");
            seqLen = Convert.ToInt32(Console.ReadLine());
            Console.Write(n );
            for (int i = 1; i < seqLen; i++)
            {
                if (i % 2 != 0)
                {
                    n = n * 2 + 1;
                    Console.Write("," + n);
                }
                else
                {
                    n = n * 2 - 1;
                    Console.Write("," + n);
                }
            }
            Console.WriteLine();
        }
    }
}
