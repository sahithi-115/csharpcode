
// this is static type case1

namespace Staticanddynamic
{
    class Parent
    {
        public void show()
        {
            //Console.WriteLine("this is parent method");
        }
    }
    class Child : Parent 
    {
        public new void show()
        {
            //Console.WriteLine("this is child method");
        }
    }
    class Polymorphism
    {
        static void Main(string[] args)
        {
            Parent p = new Child();
            p.show();
        }
    }
}
