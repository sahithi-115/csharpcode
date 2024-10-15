// dynamic case 3
using System;

namespace Staticanddynamic
{
    class Parent2
    {
        public virtual void show()
        {
            Console.WriteLine("this is parent method");
        }
    }
    class Child2 : Parent2
    {
        public override void show()
        {
            Console.WriteLine("this is child method");
        }
    }
    class Class2
    {
        static void Main(string[] args)
        {
            Parent p = new Child();
            p.show();
        }
    }
}


