/* 7-нұсқа
           Түбір абстрактылы базалық класын құрып, оның құрамында түбірлерді есептеп, нәтижені экранға шығару абстрактылы әдістерін анықтаңыз. 
           Бұл кластан туынды Сызықтық және Квадрат кластарын құрып, олардың құрамында сәйкесінше, сызықтық және квадрат теңдеулер түбірлерін табу және 
           экранға шығару әдістерін қайта анықтаңыз. Аталған кластар құрамында қажетті өрістерді және оларды базалық немесе туынды класта анықтаудың 
           дұрыстығы туралы шешімді өзіңіз қабылдаңыз.
 */

using OOP2;
using System;

namespace OOP2
{
    abstract class Tubir
    {
        public double a, b, c;

        public Tubir(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }


        public abstract double Syzykty_tendeu();

        public abstract void Kvadrat_tendeu();

    }

    class Syzykty : Tubir
    {
        double x;

        public Syzykty( double a,double b, double c) : base( a,b,c)
        {

        }
        public void ShygaruSZ()
        {
            Console.WriteLine($"a = {a} , b = {b}\n");
            if (b<0) { Console.WriteLine($"{a}x - {-b} = 0"); }
            else { Console.WriteLine($"{a}x + {b} = 0"); }
        }
        public override double Syzykty_tendeu()
        {

            if (a>0 || b>0 && a<0 || b<0) { return x = -(b / a); }
            else if (a>0 || b<0 && a<0 || b>0) { return x =  b / a; }
            else { return 0 ; }
        }

        public void Sheshimi()
        {
            double result = Syzykty_tendeu();
            Console.WriteLine($"x = {result}");
        }
        public override void Kvadrat_tendeu()
        {
            throw new NotImplementedException();
        }
    }


    class Kvadrat : Tubir
    {
        double x1, x2;

        public Kvadrat(double a, double b, double c) : base(a, b, c) { }

        public void ShygaruKV()
        {
            Console.WriteLine($"a = {a}, b = {b}, c = {c}\n");
            if(a>0 && b>0 && c > 0) { Console.WriteLine($"{a}x^2 + {b}x + {c} = 0"); }
            else if (a>0 && b>0 && c<0) { Console.WriteLine($"{a}x^2 + {b}x - {-c} = 0"); }
            else if (a > 0 && b < 0 && c > 0) { Console.WriteLine($"{a}x^2 - {-b}x + {c} = 0"); }
            else if (a < 0 && b > 0 && c > 0) { Console.WriteLine($"{a}x^2 + {b}x - {-c} = 0"); }
            else { Console.WriteLine($"{a}x - {-b}x - {-c} = 0"); }

        }
        public override void Kvadrat_tendeu()
        {
            double D = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
            if (D>0)
            {
                x1 = (double)(-b - D) / (2 * a);
                x2 = (double)(-b + D) / (2 * a);

                Console.WriteLine($"x1 = {x1} , x2 = {x2}");
            }
            else if (D == 0)
            {
                x1 = x2 = -b / 2 * a;
                Console.WriteLine($"x1 = x2 = {x1}");
            }
            else { Console.WriteLine($"Shehimi zhok, sebebi {D}<0 ."); }
        }

        public override double Syzykty_tendeu()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Syzykty syzyk = new Syzykty(10,-15,5);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Syzykty tendeu sheshimi !");
            Console.ResetColor();
            Line();
            Console.WriteLine($"");

            syzyk.ShygaruSZ();
            Console.WriteLine();
            syzyk.Sheshimi();

            Console.WriteLine();

            Console.WriteLine("=========================");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Kvadrat tendeu sheshimi !");
            Kvadrat kv = new Kvadrat(1,-7,12);
            Console.ResetColor();
            Line();
            Console.WriteLine();

            kv.ShygaruKV();
            Console.WriteLine();
            kv.Kvadrat_tendeu();
            Line();
            Console.ReadKey();
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

