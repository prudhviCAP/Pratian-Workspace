using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDay5
{
    class VowelCountRecursive
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Enter string to count vowel : ");
            str = Console.ReadLine();
            int count = 0;

            char[] ch = str.ToCharArray();
            for(int i = 0; i < ch.Length; i++)
            {
                if (isVowel(ch[i]))
                {
                    count++;
                }
            }
            Console.WriteLine("number of vowels in string is {0}", count);
        }
        public static bool isVowel(char c)
        {
            if (c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' || c == 'I' || c == 'o' || c == 'O' || c == 'u' || c == 'U')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
