using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDay5
{
    class BinarySubtraction
    {
        static void Main(string[] args)
        {
            string bin1, bin2;
            int sub;
            Console.Write("Enter binary numbers to be subtracted : ");
            bin1 = Console.ReadLine();
            bin2 = Console.ReadLine();

            int b1 = Convert.ToInt32(bin1, 2);
            int b2 = Convert.ToInt32(bin2, 2);

            sub = b1 - b2;
            Console.WriteLine("binary subtraction result is :{0} ", sub);
        }
            //if (BinToDec(bin1) > BinToDec(bin2))
            //{
            //    sub = BinToDec(bin1) - BinToDec(bin2);
            //    Console.WriteLine(sub);
            //    Console.Write(BinToDec(bin1));
            //}
            //else
            //{
            //    sub = BinToDec(bin2) - BinToDec(bin1);
            //    Console.WriteLine(sub);
            //}
        //static int BinToDec(int num)
        //{
        //    int res = 1;
        //    int div = 10;
        //    while (div < 100000000)
        //    {
        //        if (num % div >= (div) / 10)
        //        {
        //            res *= 2;
        //        }
        //        div *= 10;
        //    }
        //    return res;
        //}
        //static int DecToBin(int decNum)
        //{
        //    int[] arr = new int[10];
        //    for(int i = 0; i < arr.Length; i++)
        //    {
        //        while (decNum > 0)
        //        {
        //            arr[i] = decNum % 2;
        //            decNum /= 2;
        //        }
        //    }
        //    int bin = 0;
        //    for(int j = arr.Length; j > 0; j--)
        //    {
        //        if (arr[j] == 1)
        //        {
        //            bin *= 2;
        //        }
        //    }
        //    return bin;
        //}
    }
}
