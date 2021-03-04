using System;

namespace OOP6
{
    class Circle
    {
        int r;
        public Circle(int x)
        {
            r = x;
        }

        public static bool operator < (Circle op1, Circle op2)
        {
            double s1 = Math.PI * Math.Pow(op1.r, 2);
            double s2 = Math.PI * Math.Pow(op2.r, 2);

            if (s1 < s2) { return true; }
            else { return false; }
        }

        public static bool operator >(Circle op1, Circle op2)
        {
            double s1 = Math.PI * Math.Pow(op1.r, 2);
            double s2 = Math.PI * Math.Pow(op2.r, 2);

            if (s1 > s2) { return true; }
            else { return false; }
        }

        public void Shygaru()
        {
            Console.WriteLine(r);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle s1 = new Circle(7);
            Circle s2 = new Circle(11);
            Console.Write($"s1 obj radius : ");
            s1.Shygaru();
            Console.Write($"s2 obj radius : ");
            s2.Shygaru();

            if (s1 > s2) { Console.WriteLine("s1 shenber audany s2-den ulken !"); }
            else if (s1 < s2) { Console.WriteLine("s2 shenber audany s1-den ulken !"); }
            else { Console.WriteLine("s1 zhane s2 ozara ten !"); }
        }
    }
}
