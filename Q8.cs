using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_precedence
{
    /*int a = 5;
int b = (a += 10) - (a -= 2) * (a *= 3);
(a= 5+10) - (a-=2) * (a *=3);
   15 -(a = 15-2) * (a*=3)
    15 - 13 * (a=13*3)
    15 - 13 * 39
    15-507
    -492
     */
    internal class Q8
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = (a += 10) - (a -= 2) * (a *= 3);
            Console.WriteLine(b);
            Console.WriteLine(a);
        }
    }
}
