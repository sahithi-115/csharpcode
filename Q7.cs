using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_precedence
{
    /*bool a = true, b = false;
    bool result = a && (5 + 2 * 3 > 10) || !b;
    t && (5+2*3>10)|| !f;
    t && (5+6>10) || !f;
    t && (11> 10) || !f;
    t && t || t;
    t|| t;
    true
      */
    internal class Q7
    {
        static void Main(string[] args)
        {
            bool a = true, b = false;
            bool result = a && (5 + 2 * 3 > 10) || !b;
            Console.WriteLine(result);
        }
    }
}
