     /* 7-нұсқа
        Pair класын құрыңыз, өрістері: екі бүтін сандық өріс. Сандарды көбейту әдісін құрыңыз. 
        Туынды Тікбұрышты класын анықтаңыз, өрістері катеттері. Үшбұрыштың гипотенузасы мен ауданын табу әдістерін құрыңыз. */

using System;

namespace OOP2
{
    class Pair
    {
        public static int x, y;
        public Pair()
        {

            x = 7;
            y = 9;

        }
        public void Kobeytu()
        {
            int z = x * y;
            Console.WriteLine($"{x} * {y} = {z}");
        }
    }

    class Tikburysh : Pair
    {
        public static double a, b;

        new public void Kobeytu()
        {
            base.Kobeytu();
        }
        static Tikburysh()
        {
            Console.WriteLine("Tikburyshty ushburysh katetteri: ");
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());

        }
        public double Gypotenuza()
        {
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return c;
        }

        public double Audan()
        {
            double s = (a * b) / 2;
            return s;
        }
    }

    class Program
    {
       
        static void Main(string[] args)
        {
            Pair p = new Pair();
            Console.WriteLine("Kobeytu natezhyesi: ");
            p.Kobeytu();

            Syzyk();

            Tikburysh t = new Tikburysh();
            Syzyk();

            double result = t.Gypotenuza();
            Console.WriteLine($"Gypotenuzasy : c = {result}");

            Syzyk();

            double S = t.Audan();
            Console.WriteLine($"Audany : ({Tikburysh.a}*{Tikburysh.b})/2 = {S}");



        }
        static void Syzyk()
        {
           for (int i = 0; i < 22; i++)
             {
                 Console.Write('-');
             }
             Console.WriteLine();
        }
    }
    
}
