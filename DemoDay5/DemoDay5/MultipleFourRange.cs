using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDay5
{
    class MultipleFourRange
    {
        static void Main(string[] args)
        {
            int low, high;
            Console.Write("Enter range of interval ");
            low = Convert.ToInt32(Console.ReadLine());
            high = Convert.ToInt32(Console.ReadLine());

            int x = low;
            int y = high;

            int sum = 0;

            for(int i = low; i <= high; i++)
            {
                if (i % 4 == 0 && i % 5 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("sum of 4 multiples in range is : {0}", sum);
        }
    }
}
