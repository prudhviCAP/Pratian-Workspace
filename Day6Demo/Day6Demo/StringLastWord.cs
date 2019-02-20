using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Demo
{
    class StringLastWord
    {
        static void Main(string[] args)
        {
            //string sentence;
            //Console.Write("enter string to find last word ");
            //sentence = Console.ReadLine();

            //string[] lastWord=new string[sentence.Length];
            //for(int i = 0; i < sentence.Length; i++)
            //{
            //    lastWord[i] = Convert.ToString(sentence.Split(' '));
            //}
            //Console.WriteLine(lastWord[lastWord.Length - 1]);

            string sentence;
            Console.Write("enter string to find last word ");
            sentence = Console.ReadLine();

            string lastWord = sentence.Substring(sentence.LastIndexOf(" ")+1);
            Console.WriteLine("last word of sentence {0} is    {1}", sentence, lastWord);
        }
    }
}
