using System;

namespace cSharpInheritence
{
    class ObjectWeWillMessAroundWithTodayInTheClass
    {
        public void theWidth(int myWidth)    // function/method - myWidth is a parameter
        {
            width = myWidth;
        }
        public void theHeight(int myHeight)  // function/method - myHeight is a parameter
        {
            height = myHeight;
        }

        protected int width;
        protected int height;
    }

    class Square : ObjectWeWillMessAroundWithTodayInTheClass   // : creates a sub-class
    {
        public int area() {
            return (width * height);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // creating an ew instance of square: mySquare
            Square mySquare = new Square();
            mySquare.theHeight(10);  // passing parameter through
            mySquare.theWidth(10);   // passing parameter through
            Console.WriteLine("My square has a value of: {0}", mySquare.area());
            Console.ReadKey();
        }
    }
}
