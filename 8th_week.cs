/*Тапсырма: 7-дәріс материалдарын қайта қарастырып, 
     * 2-7 лабораториялық жұмыстарда берілген әдістердің 
     * жұмысына қажетті өрнектерді кеңейтуші әдіс ретінде жүзеге асырыңыз. */


using System;

namespace OOP2
{
        public static class Bolshek_san
        {
            public static void Kobeytu(this int san, int butin_san, int boletin_san)
            {
                float rem = (float)butin_san / boletin_san;
                float k = rem * butin_san;
                Console.WriteLine($"Kobeytu natyzhesi :\n{rem}*{san} = {k}");
            }
            public static void Shygaru(int butin_san, int boletin_san)
            {
                float b = (float)butin_san / boletin_san;
                Console.WriteLine($"{butin_san}/{boletin_san} = {b}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                int san = 80;
                int butin_san = 17;
                int boletin_san = 2;

                san.Kobeytu(butin_san,boletin_san);
                Syzyk();
                Console.WriteLine("Bolshek san turinde : ");

                Bolshek_san.Shygaru(butin_san,boletin_san);
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

