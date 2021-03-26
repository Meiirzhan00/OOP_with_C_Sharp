/* 12-нұсқа
        Pair класын құрыңыз, өрістері: екі бүтін сан. Өрістердің мәндерін өзгерту және сандардың көбейтіндісін табу әдістерін құрыңыз. 
        Туынды Тіктөртбұрыш класын құрыңыз, өрістері: қабырғаларының ұзындықтары. Тіктөртбұрыштың периметрі мен ауданын есептеу әдістерін құрыңыз.
 */

using System;

namespace OOP2
{
    class Pair
    {
        public static int x, y;
        public Pair()
        {

            x = 10;
            y = 13;

        }

        public void Ozgertu()
        {
            Console.Write("Zhana x manin engiz: x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zhana y manin engiz: y = ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"x = {x} \t y = {y}");
        }
        public void Kobeytu()
        {
            int z = x * y;
            Console.WriteLine($"{x} * {y} = {z}");
        }

    }

    class Tiktortburysh : Pair
    {
        public static double a, b;

        new public void Kobeytu()
        {
            base.Kobeytu();
        }
        static Tiktortburysh()
        {
            Console.WriteLine("Tiktortburysh 2 kabyrgasy : ");
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());

        }
        public double Perymetr()
        {
            double c = (a + b)*2;
            return c;
        }

        public double Audan()
        {
            double s = a * b ;
            return s;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Pair p = new Pair();

            Console.WriteLine("x zhane y manin ozgertkin kelse {1} - di bas, ozgertkin kelmese {2} - ni bas : ");
            int tanda = Convert.ToInt32(Console.ReadLine());

            switch (tanda)
            {
                case 1: 
                    p.Ozgertu();

                    Syzyk();

                    Console.WriteLine("Kobeytu natezhyesi: ");
                    p.Kobeytu() ; 
                    
                    break;

                case 2:

                    Console.WriteLine("Kobeytu natezhyesi: ");
                    p.Kobeytu();

                    break;
            }

            Syzyk();

            Tiktortburysh t = new Tiktortburysh();
            Syzyk();

            double result = t.Perymetr();
            Console.WriteLine($"Perymetr mani : c = {result}");

            Syzyk();

            double S = t.Audan();
            Console.WriteLine($"Audany : {Tiktortburysh.a}*{Tiktortburysh.b} = {S}");



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
