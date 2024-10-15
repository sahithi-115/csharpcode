namespace oopsexample1
{
    class Animal
    {
        public virtual void Makesound()
        {
            Console.WriteLine("Animal makes a Sound");
        }
    }
    class Dog : Animal
    {
        public override void Makesound()
        {
            Console.WriteLine("Dog barkes");
        }
    }

    internal class Program1
    {
        static void Main(string[] args)
        {
            Animal a= new Animal();
            //Animal a = new Dog();
            a.Makesound();
        }
    }
}
