using System;

namespace basic_shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Rectangle
    {
        int height;
        int width;

        static void createRectangles()
        {
            Rectangle rectangle1 = new Rectangle();
            Rectangle rectangle2 = new Rectangle();
            Rectangle rectangle3 = new Rectangle();

            rectangle1.height = 25;
            rectangle1.width = 34;

            rectangle2.height = 5;
            rectangle2.width = 10;

            rectangle3.height = 30;
            rectangle3.width = 15;
        }
    }
}
