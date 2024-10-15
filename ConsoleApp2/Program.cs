namespace ConsoleApp2
{
    class Car
    {
        public string make;
        public string model;
        public int year;

        public void Displaymethod()
        {
            Console.WriteLine("the model of the car is {0} it year of relese is {1}",model,year);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.make = "Toyota";
            c.model = "F-Series";
            c.year = 2018;
            c.Displaymethod();

            Car c2 = new Car();
            c2.make = "Ford";
            c2.model = "Civic";
            c2.year = 2017;
            c2.Displaymethod();

             
        }
    }
}
