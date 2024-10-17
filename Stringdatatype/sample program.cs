using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringdatatype
{
    internal class sample_program
    {
        static void Main(string[] args)
        {
            int n1 ,n2;

            Console.Write("Enter the number :");
            string s = Console.ReadLine();
            n1 = int.Parse(s);
            Console.Write("Enter the number :");
            s = Console.ReadLine();
            n2 = int.Parse(s);
            int sum = n1+ n2;
            Console.WriteLine("the sum of two number is :"+ sum);

        }
    }
}
