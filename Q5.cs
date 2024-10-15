using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_precedence
{
    /*int a = 5 ,b = 10 , c= 20;
     * int result = (a+(b*c)) - (c/a)) % (b+=5);
     * (5+(10*20))-(20/5))% (b = 10+5);
     * (5+200-4)%(15);
     * 201 % 15 ;
     * 6
     */
    internal class Q5
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10, c = 20;
            int result = (a + (b * c) - (c / a)) % (b += 5);
            Console.WriteLine(result);
        }
    }
}
