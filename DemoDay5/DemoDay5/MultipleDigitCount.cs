using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDay5
{
    class MultipleDigitCount
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 30, 17, 85, 22, 1, 2000, 250, 800 };
            int count1 = 0, count2 = 0, count3 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] / 10 == 0)
                {
                    count1++;
                }
                else if (arr[i] / 100 == 0)
                {
                    count2++;
                }
                else
                    count3++;
            }
            Console.WriteLine("1 digit numbers are {0} , 2 digit are {1},3 digit are {2}", count1, count2, count3);
        }
    }
}
