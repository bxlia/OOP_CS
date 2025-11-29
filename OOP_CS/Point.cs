using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CS
{
    internal class Point
    {
        double x;
        double y;

        public double GetX()
        {
            return x;
        }

        public double GetY()
        {
            return y;
        }

        public void SetX(double x)
        {
            this.x = x;
        }

        public void SetY(double y)
        {
            this.y = y;
        }

        public double X
        { get { return x; } set { x = value; } }

        public double Y
        { get { return y; } set { y = value; } }

        public void Print()
        {
            Console.WriteLine($"X = {x}\tY = {y}");
        }

        public double Distance(Point otherPoint)
        {
            double deltaX = x - otherPoint.x;
            double deltaY = y - otherPoint.y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point();
            A.X = 22;
            A.Y = 33;
            A.Print();

            Point B = new Point();
            B.X = 25;
            B.Y = 30;
            B.Print();

            double distance = A.Distance(B);
            Console.WriteLine($"Расстояние между точками A и B: {distance:F2}");

            double distance2 = B.Distance(A);
            Console.WriteLine($"Расстояние между точками B и A: {distance2:F2}");
        }
    }
}