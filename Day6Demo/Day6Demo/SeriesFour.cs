using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Demo
{
    class SeriesFour
    {
        static void Main(string[] args)
        {
            int n = 6;

            int len;
            Console.WriteLine("Enter length of sequence : ");
            len = Convert.ToInt32(Console.ReadLine());

            Console.Write(n);

            for(int i = 2; i <= len; i++)
            {
                if (i % 2 == 0)
                {
                    n = n * i + (i + 1);
                    Console.Write("," + n);
                }
                else
                {
                    n = n * i - (i + 1);
                    Console.Write("," + n);
                }
            }


        }
    }
}
