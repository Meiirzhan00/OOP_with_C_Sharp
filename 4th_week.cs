    /*7-нұсқа
    Бөлшек сан класын сипаттаңыз. Сан бүтін және бөлшек бөліктерін беретін екі бүтін сандық өріс арқылы беріледі. Келесі әдістерді жүзеге асырыңыз: 
        1.	класс өрістерін инициалдайтын конструкторлар құру;
        2.	екі бөлшек санды азайту нәтижесін бөлшек сан ретінде қайтару.*/

using System;

{
    class Bolshek_san
    {
        public int butin_san;
        public int boletin_san;

        public Bolshek_san(int butin_san, int boletin_san)
        {
            this.butin_san = butin_san;
            this.boletin_san = boletin_san;
        }

        public void Shygaru()
        {
            float r = (float)butin_san / boletin_san;
            int butin_bolik = (int)r;
            float bolshek_bolik = r - butin_bolik; ;
            Console.WriteLine($"Bolshektin alymy : {butin_san}\nBolshektin bolimi : {boletin_san}");
            Console.WriteLine($"{butin_san}/{boletin_san} = {r} \n\tButin bolik mani: {butin_bolik} \n\tBolshek bolik mani: {bolshek_bolik}");
        }

        public void Azaytu(Bolshek_san obj2)
        {
            float foo1 = (float)butin_san / boletin_san;
            float foo2 = (float)obj2.butin_san / obj2.boletin_san;
            float res = foo1 - foo2;
            Console.WriteLine($"{foo1}-{foo2} = {res}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bolshek_san obj1 = new Bolshek_san(11, 3);
            Bolshek_san obj2 = new Bolshek_san(17, 6);

            Console.WriteLine("1-shi object mani: ");
            obj1.Shygaru();
            Syzyk();
            Console.WriteLine("2-shi object mani: ");
            obj2.Shygaru();
            Syzyk();
            obj1.Azaytu(obj2);
        }

        static void Syzyk()
        {
            Console.WriteLine("---------------------------------------");
        }
    }
}
