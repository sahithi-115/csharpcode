using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_precedence
{
    /*int result = 25 / 5 * 2 % 3;
    5*2 % 3;
    10%3
    1
     */
    internal class Q6
    {
        static void Main(string[] args)
        {
            int result = 25 / 5 * 2 % 3;

            Console.WriteLine(result);
        }
    }
}
