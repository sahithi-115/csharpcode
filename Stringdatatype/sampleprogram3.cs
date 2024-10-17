using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringdatatype
{
    internal class sampleprogram3
    {
        static void Main(string[] args)
        {
            int n = 10;
            int n1 = 50;
            Console.WriteLine("the sum of "+n+"and"+n1+ "is :"+n+n1);

            Console.WriteLine("the sum of " + n + "and" + n1 + "is :" + (n + n1));

            Console.WriteLine("the sum of {0} and {1} is : {2}",n , n1 , n+n1 );

            Console.WriteLine($"the sum of {n} and {n1} is :{n+n1}");

            string a = "the sum of " + n + "and" + n1 + " is :" + (n + n1);

            a= string.Format("the sum of {0} and {1} is : {2}",n , n1 , n + n1);

            a = $"the sum of {n} and {n1} is :{n + n1}";
        }
    }
}
