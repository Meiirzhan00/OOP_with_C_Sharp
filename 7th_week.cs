/*7-нұсқа
Бөлшек сан класын сипаттаңыз. Сан бүтін және бөлшек бөліктерін беретін екі бүтін сандық өріс арқылы беріледі. 
Келесі операторларды асыра жүктеңіз: 
    1.	екі бөлшек санның қосындысын есептеу үшін (+) операторын асыра жүктеңіз;
    2.	бөлшек сан объектісінің ақиқат/жалған болуын тексеру үшін true/false операторларын асыра жүктеңіз, 
        бөлімі нөлге тең болатын объект жалған болады деп тұжырымдаңыз. */


using System;
using System.Collections.Generic;

namespace foo
{
    class Bolshek_san
    {
        int butin_san;
        int boletin_san;
        float bsan;
        public Bolshek_san(int butin_san, int boletin_san)
        {

            this.butin_san = butin_san;
            this.boletin_san = boletin_san;
            bsan = (float)butin_san / boletin_san;

        }

        public Bolshek_san()
        {
        }

        public void Shygaru()
        {
            float r = (float)butin_san / boletin_san;
            Console.WriteLine($"{butin_san}/{boletin_san} = {r} ");
        }


        public static Bolshek_san operator +(Bolshek_san ob1, Bolshek_san ob2)
        {
            Bolshek_san natizhe = new Bolshek_san();

            natizhe.bsan = ob1.bsan + ob2.bsan;
            return natizhe;
        }

        public void Kosu()
        {

            Console.WriteLine($"Kosu natizhesi: {bsan}");

        }

        public static bool operator true(Bolshek_san ob1)
        {

            if (ob1.boletin_san == 0 ) return true;
            else return false;
        }

        public static bool operator false(Bolshek_san ob2)
        {

            if (ob2.boletin_san != 0)  return true; 
            else return false;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Bolshek_san obj1 = new Bolshek_san(17,7);
            Bolshek_san obj2 = new Bolshek_san(29,11);
            Bolshek_san obj3;

            Console.WriteLine("1-shi object mani: ");
            obj1.Shygaru();
            Syzyk();
            Console.WriteLine("2-shi object mani: ");
            obj2.Shygaru();
            Syzyk();

            obj3 = obj1 + obj2;
            Console.Write("obj3 = obj1 + obj2  ");
            obj3.Kosu();

            if (obj1)
            {
                Console.WriteLine("\nobj1 bolimi nolge ten !");
            }
            else Console.WriteLine("\nobj1 bolimi nolge ten emes !");

            if (obj2)
            {
                Console.WriteLine($"\nobj2 bolimi nolge ten !");
            }
            else Console.WriteLine("\nobj2 bolimi nolge ten emes !");

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
