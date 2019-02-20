using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDay5
{
    class VowelCount
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Enter string : ");
            str = Console.ReadLine();

            char[] ch = str.ToCharArray();
            int vowelCount = 0;
            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'a' || ch[i] == 'A' || ch[i] == 'e' || ch[i] == 'E' || ch[i] == 'i' || ch[i] == 'I' || ch[i] == 'o' || ch[i] == 'O' || ch[i] == 'u' || ch[i] == 'U')
                {
                    vowelCount++;
                }
            }
            Console.WriteLine("num of vowels in {0} is {1}", str, vowelCount);
        }
    }
}
