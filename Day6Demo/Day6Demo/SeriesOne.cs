using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Demo
{
    class SeriesOne
    {
        static void Main(string[] args)
        {
            int n = 2;
            int len;
            Console.WriteLine("Enter length of sequence : ");
            len = Convert.ToInt32(Console.ReadLine());

            Console.Write(n);
            for(int i = 1; i < len; i++)
            {
                n = n * i + (i * i);
                Console.Write("," + n);
            }
            Console.WriteLine();
        }
    }
}
