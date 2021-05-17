using System;

namespace OOP
{
    public class Shape
    {
        public void ShapeMethod()
        {
            Console.WriteLine("This is a shape");
        }
    }


    public class Rectangle : Shape
    {
        public void RectangleMethod()
        {
            Console.WriteLine("This is a rectangular shape");
        }
    }


    public class Circle : Shape
    {
        public void CircleMethod()
        {
            Console.WriteLine("This is a circular shape");
        }
    }


    public class Square : Rectangle
    {
        public void SquareMethod()
        {
            Console.WriteLine("Square is a rectangle");
        }
    }
}