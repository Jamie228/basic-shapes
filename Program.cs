using System;

namespace basic_shapes
{
    class Program
    {
        static void Main(string[] args)
        {
         Rectangle rectangle1 = new Rectangle(34, 25);
         Rectangle rectangle2 = new Rectangle(10, 5);
         Rectangle rectangle3 = new Rectangle(15, 30);

         Console.WriteLine("RECTANGLE 1 AREA: {0}", rectangle1.GetArea());
         Console.WriteLine("RECTANGLE 2 AREA: {0}", rectangle2.GetArea());
         Console.WriteLine("RECTANGLE 3 AREA: {0}", rectangle3.GetArea());
         
        }
    }

    class Rectangle
    {
        private int height;
        private int width;

        public Rectangle(int width, int height)
        {
            this.width=width;
            this.height=height;
        }

        public int GetArea()
        {
            return this.width*this.height;
        }
    }
}
