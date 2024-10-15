using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_precedence
{
    /*int a = 7, b = 2;
     int result = a << b | a >> b;
    7<<2 | 7>> 2;
    7<< 2 means it shift to left then the value is 001
    7>> 2 it shift to right and the value is 11100
    after doing or operators of 00001 and 11100 is 11101
    when it convert to base 10 then its value id 29
     */
    internal class Q9
    {
        static void Main(string[] args)
        {
            int a = 7, b = 2;
            int result = a << b | a >> b;

            Console.WriteLine(result);
        }
    }
}
