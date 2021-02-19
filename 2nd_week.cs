/*7-нұсқа
    /* Бөлшек сан класын сипаттаңыз.Сан бүтін және бөлшек бөліктерін беретін екі бүтін сандық өріс арқылы беріледі.Келесі әдістерді жүзеге асырыңыз:
        1.	берілген бөлшек санды бүтін санға көбейту;
        2.	объектіні әдеттегі бөлшек сан түрінде экранға шығару; */

using System;

{
    class Bolshek_san
    {
        public int butin_san;
        public int boletin_san;
        public void Kobeytu()
        {
            float rem = (float)butin_san / boletin_san;
            float k = rem * butin_san;
            Console.WriteLine($"Kobeytu natyzhesi :\n{rem}*{butin_san} = {k}");
        }
        public void Shygaru()
        {
            float b = (float)butin_san / boletin_san;
            Console.WriteLine($"{butin_san}/{boletin_san} = {b}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bolshek_san obj = new Bolshek_san();
            Console.Write("Butin sandy engiz : ");
            obj.butin_san = int.Parse(Console.ReadLine());
            Console.Write("Boletin sandy engiz : ");
            obj.boletin_san = int.Parse(Console.ReadLine());
            obj.Kobeytu();
            Syzyk();
            Console.WriteLine("Bolshek san turinde : ");
            obj.Shygaru();
        }
        static void Syzyk()
        {
            Console.WriteLine("-----------------------------");
        }
    }
}
