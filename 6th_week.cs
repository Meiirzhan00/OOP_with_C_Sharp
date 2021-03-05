/*7 - нұсқа
Бөлшек сан класын сипаттаңыз. Сан бүтін және бөлшек бөліктерін беретін екі бүтін сандық өріс арқылы беріледі. Келесі әдістерді жүзеге асырыңыз: 
1.класс үшін бос, параметрлі және көшіру конструкторларын құру;
2.бөлшек санды бүтін санға және басқа бөлшек санға қосу әдістерін асыра жүктеу арқылы құрыңыз.*/


using System;
using System.Collections.Generic;
namespace foo
{
    class Bolshek_san 
    {
        public int butin_san;
        public int boletin_san;

        public Bolshek_san()
        {
            butin_san = 17;
            boletin_san = 8;
        }
        public Bolshek_san(int butin_san, int boletin_san)
        {
            this.butin_san = butin_san;
            this.boletin_san = boletin_san;
        }

        public Bolshek_san(Bolshek_san ob)
        {
            this.butin_san = ob.butin_san;
            this.boletin_san = ob.boletin_san;
        }


        public void Kosu()
        {
            float bolshek_san = (float)butin_san / boletin_san;
            float res = butin_san + bolshek_san;
            Console.WriteLine($"Kosu() : {butin_san} + {bolshek_san} = {res}");
        }

        public void Kosu(int b)
        {
            float bolshek_san = (float)butin_san / b;
            float res = butin_san + bolshek_san;
            Console.WriteLine($"Kosu(int) : {butin_san} + {bolshek_san} = {res}");
        }

        public void Kosu(int a, int b)
        {
            float bolshek_san = (float)butin_san / (a+b);
            float res = butin_san + bolshek_san;
            Console.WriteLine($"Kosu(int,int) : {butin_san} + {bolshek_san} = {res}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Bolshek_san obj1 = new Bolshek_san();
            Bolshek_san obj2 = new Bolshek_san(29, 6);
            Bolshek_san obj3 = new Bolshek_san(obj2);


            Syzyk();

            obj1.Kosu();
            Syzyk();
            obj2.Kosu(6);
            Syzyk();
            obj3.Kosu(2, 3);
        }

        static void Syzyk()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.Write("-");
                
            }
            Console.WriteLine();
        }
    }
}
