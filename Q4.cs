using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_precedence
{
    /*bool result = (true || false) && (false | true) & false ^ true;
     * true && true & false^ true ;
     * true && false ^ true
     * true && true
     * true
     */
    internal class Q4
    {
        static void Main(string[] args)
        {
            bool result = (true || false) && (false | true) & false ^ true;
            Console.WriteLine(result);
        }
    }
}
