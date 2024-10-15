using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsexample1
{
    interface IFlyable
    {
        void Fly();
    }

    interface IRunnable
    {
        void Run();
    }

    class SuperHero : IFlyable, IRunnable
    {
        public void Fly()
        {
            Console.WriteLine("SuperHero flies");
        }

        public void Run()
        {
            Console.WriteLine("SuperHero runs");
        }
    }

    internal class Multiple
    {
        static void Main(string[] args)
        {
            SuperHero s = new SuperHero();
            s.Fly();
            s.Run();
        }
    }
}
