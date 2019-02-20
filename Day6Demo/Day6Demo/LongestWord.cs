using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Demo
{
    class LongestWord
    {
        static void Main(string[] args)
        {
            string sentence;
            Console.WriteLine(" enter string : ");
            sentence = Console.ReadLine();

            Console.WriteLine("Reverse of string  is : ");
            Console.WriteLine(WordReverse(sentence));
            //for(int i = 0; i < sentence.Length; i++)
            //{
            //}
        }
        static String[] WordReverse(String str)
        {
            int i = str.Length - 1;
            int start, end = i + 1;
            String result = "";
            string[] words = new string[10];
            int j = 0;
            while (i >= 0)
            {
                if (str[i] == ' ')
                {
                    start = i + 1;
                    while (start != end)
                        result += str[start++];

                    words[j] = result;
                    j++;

                    result += ' ';

                    end = i;
                }
                i--;
            }

            start = 0;
            while (start != end)
                result += str[start++];

            //  return result;
            return words;
        }
    }
}
