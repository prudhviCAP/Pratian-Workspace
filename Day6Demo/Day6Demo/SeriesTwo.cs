using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Demo
{
    class SeriesTwo
    {
        static void Main(string[] args)
        {
            int initial = 8;

            int len;
            Console.WriteLine("Enter length of sequence : ");
            len = Convert.ToInt32(Console.ReadLine());

            Console.Write(initial);
            for(int i = 1; i < len; i++)
            {
                initial = initial * 3 - 5;
                Console.Write("," + initial);
            }
        }
    }
}
