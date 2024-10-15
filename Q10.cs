using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_precedence
{
    /*
     * int a = 8, b = 12;
int result = a > b ? a++ * 2 : --b * 3;
    8>12? a++ *2: --b*3
    f: --b*3
    11*3
    33
     */
    internal class Q10
    {
        static void Main(string[] args)
        {
            int a = 8, b = 12;
            int result = a > b ? a++ * 2 : --b * 3;
            Console.WriteLine(result);
        }
    }
}
