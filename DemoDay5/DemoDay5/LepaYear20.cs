using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDay5
{
    class LepaYear20
    {
        static void Main(string[] args)
        {
            int year = 2019;
            int count = 20;
            int j = 0;
            while (count > 0)
            {
                if(year%400==0 || year%100==0 || year % 4 == 0)
                {
                    j++;
                    count--;
                    Console.WriteLine("leap year {0} is {1}", j, year);
                }
                year++;
            }
            Console.WriteLine();
        }
    }
}
