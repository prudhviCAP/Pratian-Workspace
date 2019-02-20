using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDay5
{
    class LCM
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int lcm = 1;
            Console.Write("Enter numbers to find lcm : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            int x = num1;
            int y = num2;

            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
            }

            lcm = (x * y) / num1;
            Console.WriteLine(" lcm of {0} and {1} : {2}", x, y, lcm);
        }
    }
}
