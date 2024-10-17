using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringdatatype
{
    internal class sampleprogram2
    {
        static void Main(string[] args)
        {
            char c;
            Console.Write("enter the letter" );
            string s = Console .ReadLine();
            c = char.Parse(s);
            Console.WriteLine( "The letter is :"+c );
            int n = c;
            Console.WriteLine(n);


            Console.Write("enter a number");
            string s1 = Console.ReadLine();
            int n1 = int.Parse(s1);
            char c1 = (char)n1;
            Console.WriteLine(c1);
        }
    }
}
