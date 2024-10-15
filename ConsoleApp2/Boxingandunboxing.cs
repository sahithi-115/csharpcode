using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Boxingandunboxing
    {
        static void Main(string[] args)
        {
            int n;
            object obj;
            int m;
            n = 10;
            obj = n;
            m =(int) obj;
            Console.WriteLine(n);
            Console.WriteLine("obj   "+ obj);
            Console.WriteLine("m   "+ m);
        }
    }
}
