using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_precedence
{
    /*int x = 7;
     * inty = x++ *2 + --x/3 - ++x;
     * 7*2 + -- 8 /3 - ++8;
     * 14 +7/3 - ++7;
     *14 +2 - 8;
     *16 - 8
     *8
     */
    internal class Q2
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = x++ * 2 + --x / 3 - ++x;
            Console.WriteLine(y);

        }
    }
}
