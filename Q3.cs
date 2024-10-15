using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_precedence
{
    /*int result =8/3 & 1^6;
     * 8/1^6;
     * 8/7;
     * 15
     */
    internal class Q3
    {
        static void Main(string[] args)
        {
            int result = 8 / 3 & 1 ^ 6;
            Console.WriteLine(result);
        }
    }
}
