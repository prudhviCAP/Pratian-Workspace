
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Demo
{
    class FirstLetterWord
    {
        static void Main(string[] args)
        {
            string sentence;
            Console.Write(" enter sentence : ");
            sentence = Console.ReadLine();

            Console.WriteLine("First letters of every word in sentence is : ");
            Console.Write(sentence[0]);

            for(int i = 0; i < sentence.Length; i++)
            {
                if(sentence[i]==' ')
                {
                    Console.Write(" " + sentence[i + 1]);
                }
            }
        }
    }
}
