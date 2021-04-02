
using OOP2;
using System;

namespace OOP2
{
    abstract class Phygura
    {
 
        public abstract void Audan();

        public abstract void Perymetr();

    }

    class Shenber : Phygura
    {
        double r;
        public Shenber()
        {
            Console.WriteLine("Shenber radiusyn engiz : r = ");
            r = Convert.ToDouble(Console.ReadLine());
        }
        public override void Audan()
        {
            double S = Math.PI * Math.Pow(r, 2);

            Console.WriteLine($"Shenber audany : S = {S}");
        }

    
        public override void Perymetr()
        {
            double P = 2 * Math.PI * r;

            Console.WriteLine($"Shenber perymetri : P = {P}");
        }
    }


    class Trapesia : Phygura
    {
        double a, b, c, d, h;

        public Trapesia(double a, double b, double c, double d,double h)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.h = h;
        }
        public override void Audan()
        {
            double S = ((a + b) / 2) * h;

            Console.WriteLine($"Trapesia audany : S = {S}");
        }

        public override void Perymetr()
        {
            double P = a + b + c + d;

            Console.WriteLine($"Trapesia perymetri : P = {P}");
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Shenber s = new Shenber();

            s.Audan();

            s.Perymetr();

            Line();

            Trapesia t = new Trapesia(4,7,2,6,9);

            t.Audan();

            t.Perymetr();
        }
        static void Line()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
        }
    }

}

