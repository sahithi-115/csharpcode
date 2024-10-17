using System.Security.Cryptography.X509Certificates;

namespace Stringdatatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "2000";
            //int n = s1;
            int n = int .Parse(s1); 
            Console.WriteLine(n);

            char c = s1[0]; //char.Parse(s1);

            string name = "sahithi";
            bool success = int .TryParse(name,out n);
            Console.WriteLine(success + " " + n);

        }
    }
}
