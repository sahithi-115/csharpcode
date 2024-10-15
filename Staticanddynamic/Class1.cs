// dynamic case 2
using System;

namespace Staticanddynamic
{
    class Parent1
    {
        public virtual void show()
        {
            //Console.WriteLine("this is parent method");
        }
    }
    class Child1 : Parent1
    {
        public new void show()
        {
            //Console.WriteLine("this is child method");
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            Parent p = new Child();
            p.show();
        }
    }
}
