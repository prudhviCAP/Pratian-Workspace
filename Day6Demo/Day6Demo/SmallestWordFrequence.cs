using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Demo
{
    class SmallestWordFrequence
    {
        static void Main(string[] args)
        {
            string sentence;
            Console.WriteLine(" enter string : ");
            sentence = Console.ReadLine();

            char[] charArray = sentence.ToCharArray();

            string[] wordArray = new string[10];

            


            int min = wordArray[0].Length;
            for(int i = 1; i < wordArray.Length; i++)
            {
                if (min > wordArray[i].Length)
                {
                    min = wordArray[i].Length;
                }
            }
            for(int i = 0; i < wordArray.Length; i++)
            {
                Console.WriteLine(wordArray[i]);
            }
            int count = 0;
            for(int l = 0; l < wordArray.Length; l++)
            {
                if (wordArray[l].Length == min)
                {
                    count++;
                }
            }
            Console.WriteLine(min);
            Console.WriteLine("Frequency of smallest word is {0}", count);
        }
    }
}
