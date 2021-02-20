/*7-нұсқа
   Бөлшек сан класын сипаттаңыз. Сан бүтін және бөлшек бөліктерін беретін екі бүтін сандық өріс арқылы беріледі. Келесі әдістерді жүзеге асырыңыз: 
       1.	класс өрістерін инициалдайтын конструкторлар құру;
       2.	екі бөлшек санды азайту нәтижесін бөлшек сан ретінде қайтару.*/

using System;

namespace foo
{
    class Student
    {
        public int id;
        public string FIO;
        public string pan_aty;
        public int kredyt_sany;
        public int RK1;
        public int MT;
        public int RK2;
        public int E;

        public Student(int id, string FIO, string pan_aty, int kredyt_sany)
        {
            this.id = id;
            this.FIO = FIO;
            this.pan_aty = pan_aty;
            this.kredyt_sany = kredyt_sany;
        }


        public void Shygaru()
        {
            Console.WriteLine($"Id nomer : {id}\tFIO : {FIO}\nPan aty: {pan_aty}\tKredyt sany: {kredyt_sany}");
        }


        public double GPA1()
        {
                int res1 = (int)((RK1 + MT + RK2) * 0.2) + (int)(E * 0.4);
                if (res1 < 25) { return 0.0; }
                else if (res1 > 24 && res1 < 50) { return 0.5; }
                else if (res1 > 49 && res1 < 55) { return 1.0; }
                else if (res1 > 54 && res1 < 60) { return 1.33; }
                else if (res1 > 59 && res1 < 65) { return 1.67; }
                else if (res1 > 64 && res1 < 70) { return 2.0; }
                else if (res1 > 69 && res1 < 76) { return 2.33; }
                else if (res1 > 75 && res1 < 80) { return 2.67; }
                else if (res1 > 79 && res1 < 85) { return 3.0; }
                else if (res1 > 84 && res1 < 90) { return 3.33; }
                else if (res1 > 89 && res1 < 95) { return 3.67; }
                else { return 4.0; }


            
        }
        public double GPA2()
        {
            int res1 = (int)((RK1 + MT + RK2) * 0.2) + (int)(E * 0.4);
            if (res1 < 25) { return 0.0; }
            else if (res1 > 24 && res1 < 50) { return 0.5; }
            else if (res1 > 49 && res1 < 55) { return 1.0; }
            else if (res1 > 54 && res1 < 60) { return 1.33; }
            else if (res1 > 59 && res1 < 65) { return 1.67; }
            else if (res1 > 64 && res1 < 70) { return 2.0; }
            else if (res1 > 69 && res1 < 76) { return 2.33; }
            else if (res1 > 75 && res1 < 80) { return 2.67; }
            else if (res1 > 79 && res1 < 85) { return 3.0; }
            else if (res1 > 84 && res1 < 90) { return 3.33; }
            else if (res1 > 89 && res1 < 95) { return 3.67; }
            else { return 4.0; }



        }

        public void Salystyru(double GPA1, double GPA2,Student obj)
        {
            Console.WriteLine("_________________________________________");
            Console.WriteLine($"ID: {id} , FIO: {FIO} , GPA={GPA1}\nID: {obj.id} , FIO: {obj.FIO} , GPA={GPA2}");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("GPA SALYSTYRU NATYZHESI ");

            if (GPA1 > GPA2)
            {
                Console.WriteLine($"ID: {id} , FIO: {FIO} --> GPA={GPA1} ulken !");
            }
            else if (GPA1 == GPA2)
            {
                Console.WriteLine("GPA natyzheleri TEN");
            }
            else
            {
                Console.WriteLine($"ID: {obj.id} , FIO: {obj.FIO} --> GPA={GPA2} ulken !");
            }
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student(5, "Sadylla Bekarys", "OOP", 3);
            Student stu2 = new Student(7, "Boribek Meiirzhan", "OOP", 3);
            stu1.Shygaru();
            Console.Write("RK1: ");
            stu1.RK1 = int.Parse(Console.ReadLine());
            Console.Write("MT: ");
            stu1.MT = int.Parse(Console.ReadLine());
            Console.Write("RK2: ");
            stu1.RK2 = int.Parse(Console.ReadLine());
            Console.Write("Exam : ");
            stu1.E = int.Parse(Console.ReadLine());
            Syzyk();
            stu2.Shygaru();
            Console.Write("RK1: ");
            stu2.RK1 = int.Parse(Console.ReadLine());
            Console.Write("MT: ");
            stu2.MT = int.Parse(Console.ReadLine());
            Console.Write("RK2: ");
            stu2.RK2 = int.Parse(Console.ReadLine());
            Console.Write("Exam : ");
            stu2.E = int.Parse(Console.ReadLine());

            double gpa1=stu1.GPA1();
            double gpa2=stu2.GPA2();
            stu1.Salystyru(gpa1, gpa2, stu2);

        }

        static void Syzyk()
        {
            Console.WriteLine("---------------------------------------");
        }
    }
}
