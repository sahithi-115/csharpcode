//Create a base class called animal and a derived class called dog . demonstrate how to cast a dog object to an animal type and then back to a dog

using System;
namespace ConsoleApp2

{
    class Animal
    {
        public virtual void sound()
        {
            Console.WriteLine("animal makes sound");
        }
    }
    class Dog:Animal
    {
        public override void sound()
        {
            Console.WriteLine("Dog is barking");
        }
        public void Fetch()
        {
            Console.WriteLine("The dog fetches a ball.");
        }
    }


    internal class Castingclass
    {
        static void Main(string[] args)
        {
            Dog d;
            d = new Dog();
            d.Fetch();
            d.sound();
            Animal a = new Dog();
            a.sound();

            if (a is Dog)
            {
                Dog myDogAgain = (Dog)a; 
                myDogAgain.Fetch();
            }
            else
            {
                Console.WriteLine("Animal a is not in Dog");
            }
        }
    }
}
