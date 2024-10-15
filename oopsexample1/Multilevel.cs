using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsexample1
{
    class Livingbeing
    {
        public void Exist()
        {
            Console.WriteLine("living being exists");
        }
    }
    class Plant:Livingbeing
    {
        public void grow()
        {
            Console.WriteLine("plant grows");
        }
    }
    class Flower: Plant 
    { 
        public void Bloom()
        {
            Console.WriteLine("flower bloom");
        }
    }

    internal class Multilevel
    {
        static void Main(string[] args)
        {
            Flower flower = new Flower();
            flower.grow();
            flower.Bloom();
            flower.Exist();
        }
    }
}
