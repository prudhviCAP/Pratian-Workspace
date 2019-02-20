using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDay5
{
    class HCF
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int hcf = 1;
            Console.Write("Enter numbers to find hcf ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            int x = num1;
            int y = num2;

            if (num2 > num1)
            {
                int i = 2;
                while (i <= num1)
                {
                    if (num1 % i == 0 && num2 % i == 0)
                    {
                        hcf = i;
                    }
                    i++;
                }
            }
            else if (num1 > num2)
            {
                int i = 2;
                while (i <= num2)
                {
                    if (num1 % i == 0 && num2 % i == 0)
                    {
                        hcf = i;
                    }
                    i++;
                }
            }
            else
                hcf = num1;

            Console.WriteLine("HCF of {0},{1} is {2}", x, y, hcf);
        }
    }
}
