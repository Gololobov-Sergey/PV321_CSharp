using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV321_CSharp
{
    partial class Point
    {
        public double X;
        public double Y;

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Print()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }


        public static Point operator ++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }

        public static Point operator -(Point p)
        {
            return new Point(-p.X, -p.Y);
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Point operator *(Point p1, int n)
        {
            return new Point(p1.X * n, p1.Y * n);
        }

        public static Point operator *(int n, Point p1)
        {
            return new Point(p1.X * n, p1.Y * n);
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return p1.X != p2.X || p1.Y != p2.Y;
        }

        public static bool operator >(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X, 2) + Math.Pow(p1.Y, 2)) >
                Math.Sqrt(Math.Pow(p2.X, 2) + Math.Pow(p2.Y, 2));
        }

        public static bool operator <(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X, 2) + Math.Pow(p1.Y, 2)) <
                Math.Sqrt(Math.Pow(p2.X, 2) + Math.Pow(p2.Y, 2));
        }


        public static bool operator true(Point p)
        {
            return p.X != 0 || p.Y != 0 ? true : false;
        }

        public static bool operator false(Point p)
        {
            return p.X == 0 && p.Y == 0 ? true : false;
        }

        public static Point operator &(Point p1, Point p2)
        {
            return new Point();
        }

        public static Point operator |(Point p1, Point p2)
        {
            return new Point();
        }
    }


    struct SPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
