using System;

namespace OOP2
{
    class OiynTasy
    {
        public int k1;
        public int k2;
        public delegate void Natizhe(string message);
        public event Natizhe okyga;
        public OiynTasy()
        {

            Console.Write("Birinshi tastan tusken san: ");
            k1=int.Parse(Console.ReadLine());
            Console.Write("Ekinshi tastan tusken san: ");
            k2=int.Parse(Console.ReadLine());
        }
        public void Laktyru()
        {
            if (k1+k2>8 && k1<=6 && k1<=6)
            {
                okyga?.Invoke($"1-shi tastagy san : {k1}, 2-shi tastagy san : {k2}");
            }
            else if (k1+k2==8 && k1<=6 && k1<=6)
            {
                okyga?.Invoke("Laktyrylgan tastar sany 8-ge ten !");
            }
            else if (k1+k2>8 && k1<=6 && k1<=6)
            {
                okyga?.Invoke("Laktyrylgan tastar sany 8-den kem !");
            }
            else 
            {
                okyga?.Invoke($"k1 n|e k2 mani 6-dan ulken. ");
            }
        }
    }

    class OiynTasyK
    {
        public delegate void Natizhe(string message);
        public event Natizhe okyga;
        public void Kezdeysok()
        {
            Random rnd = new Random();
            int i1=rnd.Next(1, 6);
            int i2=rnd.Next(1, 6);
            if (i1+i2>8)
            {
                okyga?.Invoke($"1-shi tastagy san : {i1}, 2-shi tastagy san : {i2}");
            }
            else if (i1+i2==8)
            {
                okyga?.Invoke("Laktyrylgan tastar sany 8-ge ten !");
            }
            else 
            {
                okyga?.Invoke("Laktyrylgan tastar sany 8-den kem !");
            }
        }
    }
    class MainClass 
    {
        public static void Main (string[] args) 
        {
            // Random rnd = new Random();
            // for(int i =1; i<2;i++)
            // {
            //     Console.WriteLine("Бросок № {0}, выпали числа {1} и {2}", i, rnd.Next(1, 6), rnd.Next(1, 6));
            // }
            Console.WriteLine("Tasty laktyrudy tanda: \n1) Kolmen engizu.\n2) Kezdeysok tandau.\n");
            int tanda=int.Parse(Console.ReadLine());
            switch(tanda)
            {
                case 1 : 
                    OiynTasy p=new OiynTasy();
                    p.okyga+=DisplayMessage;
                    p.Laktyru();
                break;

                case 2 :
                    OiynTasyK p2=new OiynTasyK();
                    p2.okyga+=DisplayMessage;
                    p2.Kezdeysok();
                break;
            }
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
