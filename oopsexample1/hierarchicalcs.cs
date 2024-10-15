using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsexample1
{
    class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("vehicle is driving");
        }
    }
    class Car: Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("car is driving");
        }
    }
    class Bike:Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("bike is driving");
        }
    }
    internal class hierarchical
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Drive();
            Bike bike = new Bike();
            bike.Drive();
        }
    }
}
