using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDay5
{
    class AsciiOfChar
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write("Enter char to find ASCII :");
            ch = Convert.ToChar(Console.ReadLine());
            int val = Convert.ToInt32(ch);
            Console.WriteLine("ASCII value of {0} is :{1}", ch, val);
        }
    }
}
