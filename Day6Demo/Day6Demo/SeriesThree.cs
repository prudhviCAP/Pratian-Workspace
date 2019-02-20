using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Demo
{
    class SeriesThree
    {
        static void Main(string[] args)
        {
            double n = 4;
            double mul = 0.5;

            int len;
            Console.WriteLine("Enter length of sequence : ");
            len = Convert.ToInt32(Console.ReadLine());

            Console.Write(n);
            for(int i = 1; i < len; i++)
            {
                n *= mul;
                mul++;
                Console.Write("," + n);
            }
        }
    }
}
