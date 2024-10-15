using System;
using System.Runtime.InteropServices.Marshalling;

namespace Chatgptdemotest1
{
    abstract class Shape 
    {
        public int Dic;

        public Shape()
        {

        }
        public Shape(int dic)
        {
            this.Dic = dic;
        }
        public abstract double CalculateArea();
        
    }
    class Square : Shape 
    {
        public int side;
        Square()
        {

        }
        public Square(int side)
        {
            this.side = side;
        }

        // Overriding CalculateArea for Square
        public override double CalculateArea()
        {
            return side * side;
        }
    }
    class Rectangle : Shape
    {
        public int l;
        public int h;
        public Rectangle()
        {
        }
        public Rectangle(int l, int h)
        {
            this.l = l;
            this.h = h;
        }
        public override double CalculateArea()
        {
            return l * h;
        }
    }

class Program2
    {
    public static void Main(string[] args)
        {
            Shape s;
            if (args[0] == "S")
            {
                s = new Square(5);
            }
            else
            {
                s = new Rectangle(5, 7);
            }
            Console.WriteLine(s.CalculateArea());
        }
    }
}
