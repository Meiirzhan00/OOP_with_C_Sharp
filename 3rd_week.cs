using System;

namespace foo
{

    //// 3nd week
    ////*7-нұсқа
    /* Бөлшек сан класын сипаттаңыз. Сан бүтін және бөлшек бөліктерін беретін екі бүтін сандық өріс арқылы беріледі. Келесі әдістерді жүзеге асырыңыз:
            1.	класс өрістерін жабық түрде жариялап, оларға қатынасуға мүмкіндік беретін қасиеттерді құру.*/

    class Bolshek_san
    {
        private int butin_san;
        private int boletin_san;
        public int butin_san_clon
        {
            get { return butin_san; }
            set { butin_san = value; }
        }
        public int boletin_san_clon
        {
            get { return boletin_san; }
            set { boletin_san = value; }
        }
        public void Shygaru()
        {
            float r = (float)butin_san / boletin_san;
            int butin_bolik = (int)r;
            float bolshek_bolik = r - butin_bolik; ;
            Console.WriteLine($"Bolshektin alymy : {butin_san}\nBolshektin bolimi : {boletin_san}");
            Console.WriteLine($"{butin_san}/{boletin_san} = {r} \n\tButin bolik mani: {butin_bolik} \n\tBolshek bolik mani: {bolshek_bolik}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bolshek_san obj = new Bolshek_san();
            Console.Write("Butin sandy engiz : ");
            obj.butin_san_clon = int.Parse(Console.ReadLine());
            Console.Write("Boletin sandy engiz : ");
            obj.boletin_san_clon = int.Parse(Console.ReadLine());
            Syzyk();
            obj.Shygaru();
        }
        static void Syzyk()
        {
            Console.WriteLine("-----------------------------");
        }
    }
}
