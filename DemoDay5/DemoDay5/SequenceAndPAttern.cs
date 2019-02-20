using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDay5
{
    class SequenceAndPAttern
    {
        static void Main(string[] args)
        {
            int len;
            Console.Write("Enter number of elements to be generated in sequence : ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[len];

            arr[0] = 2;
            for(int i = 1; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    arr[i] = arr[i - 1] * 2 + 1;
                }
                else
                {
                    arr[i] = arr[i - 1] * 2 - 1;
                }
            }

            int n = MinFact(len);
            
        }
        static int Fact(int m)
        {
            int res;
            res = Fact(m-1) * m;
            return res;
        }
        static int MinFact(int length)
        {
            int rowNum;
            int i = 1;
            while (i < 10)
            {
                if (Fact(i) >= length)
                {
                    rowNum = i;
                    return rowNum;
                }
                else
                {
                    i++;
                }
            }
            return 0;
        }
    }
}
