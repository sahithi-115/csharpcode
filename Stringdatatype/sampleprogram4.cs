using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringdatatype
{
    internal class sampleprogram4
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();  
            string s = "";
            for (int i = 0; i < 200000; i++)
            {
                s += "A";
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);

            // string builder 
            sw = System.Diagnostics.Stopwatch.StartNew();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < 200000; i++)
            {
                sb.Append("A");
                //Console.WriteLine($"{sb.Capacity} {sb.Length}");
            }
            s= sb.ToString();
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
    }
}
