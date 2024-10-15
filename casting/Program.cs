//write a program that demonstrates implicait and explicit casting between different numeric types such as int , double and float
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicait casting of int 
            int n = 10;
            double d = n;
            float f = n;
            //implicait with float 
            float f1 = 20.3f;
            double d1 = f1;
            //explicit casting of int 
            double d2 = 456.3;
            int i = (int)d2;
            int i1 = (int)f1;

            //explicit casting to float 

           f = (float)d2;

        }
    }
}
