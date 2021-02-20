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

        public Student(int id, string FIO)
        {
            this.id = id;
            this.FIO = FIO;
        }

        public void Shygaru()
        {
            Console.WriteLine($"Id nomer : {id}\tFIO : {FIO}");
        }
    }

    class Pander
    {
        public string pan_aty;
        public int kredyt_sany;
        public int RK1;
        public int MT;
        public int RK2;
        public int E;

        public Pander(string pan_aty, int kredyt_sany)
        {
            this.pan_aty = pan_aty;
            this.kredyt_sany = kredyt_sany;
            Console.Write("RK1: ");
            RK1 = int.Parse(Console.ReadLine());
            Console.Write("MT: ");
            MT = int.Parse(Console.ReadLine());
            Console.Write("RK2: ");
            RK2 = int.Parse(Console.ReadLine());
            Console.Write("Exam : ");
            E = int.Parse(Console.ReadLine());

        }

        public void GPA(Pander obj2)
        {
            int res1 = (int)((RK1 + MT + RK2) * 0.2) + (int)(E * 0.4);
            int res2 = (int)((obj2.RK1 + obj2.MT + obj2.RK2) * 0.2) + (int)(obj2.E * 0.4);
            Console.WriteLine($"GPA = {res1}\t res2 = {res2}");
            double gpa1,gpa2;
            if (res1 < 25) { gpa1 = 0; }
            else if (res1 > 24 && res1 < 50) { gpa1 = 0.5; }
            else if (res1 > 49 && res1 < 55) { gpa1 = 1.0; }
            else if (res1 > 54 && res1 < 60) { gpa1 = 1.33; }
            else if (res1 > 59 && res1 < 65) { gpa1 = 1.67; }
            else if (res1 > 64 && res1 < 70) { gpa1 = 2; }
            else if (res1 > 69 && res1 < 76) { gpa1 = 2.33; }
            else if (res1 > 75 && res1 < 80) { gpa1 = 2.67; }
            else if (res1 > 79 && res1 < 85) { gpa1 = 3; }
            else if (res1 > 84 && res1 < 90) { gpa1 = 3.33; }
            else if (res1 > 89 && res1 < 95) { gpa1 = 3.67; }
            else if (res1>95) { gpa1 = 4; }
            else if (res2 < 25) { gpa2 = 0; }
            else if (res2 > 24 && res2 < 50) { gpa2 = 0.5; }
            else if (res2 > 49 && res2 < 55) { gpa2 = 1.0; }
            else if (res2 > 54 && res2 < 60) { gpa2 = 1.33; }
            else if (res2 > 59 && res2 < 65) { gpa2 = 1.67; }
            else if (res2 > 64 && res2 < 70) { gpa2 = 2; }
            else if (res2 > 69 && res2 < 76) { gpa2 = 2.33; }
            else if (res2 > 75 && res2 < 80) { gpa2 = 2.67; }
            else if (res2 > 79 && res2 < 85) { gpa2 = 3; }
            else if (res2 > 84 && res2 < 90) { gpa2 = 3.33; }
            else if (res2 > 89 && res2 < 95) { gpa2 = 3.67; }
            else if (res2 > 95) { gpa2 = 4; }
            
            if (res1 > res2)
            {

            }


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student(5, "Sadylla Bekarys");
            Student stu2 = new Student(7, "Boribek Meiirzhan");
            stu1.Shygaru();
            Pander obj1 = new Pander("OOP", 3);
            Syzyk();
            stu2.Shygaru();
            Pander obj2 = new Pander("OOP", 3);

            obj1.GPA(obj2);
        }

        static void Syzyk()
        {
            Console.WriteLine("---------------------------------------");
        }
    }
}



_____________________-____________________________________________________________________
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


        public Student() 
        { 

        }

        public void Shygaru()
        {
            Console.WriteLine($"Id nomer : {id}\tFIO : {FIO}\nPan aty: {pan_aty}\tKredyt sany: {kredyt_sany}");
        }


        public void GPA(Student obj2)
        {
            int res1 = (int)((RK1 + MT + RK2) * 0.2) + (int)(E * 0.4);
            int res2 = (int)((obj2.RK1 + obj2.MT + obj2.RK2) * 0.2) + (int)(obj2.E * 0.4);
            Console.WriteLine($"{FIO} ---> res1 = {res1}\n{obj2.FIO} ---> res2 = {res2}");
            double gpa1, gpa2;
            if (res1 < 25) { gpa1 = 0; }
            else if (res1 > 24 && res1 < 50) { gpa1 = 0.5; Console.WriteLine($"{FIO} : GPA={gpa1}"); }
            else if (res1 > 49 && res1 < 55) { gpa1 = 1.0; Console.WriteLine($"{FIO} : GPA={gpa1}"); }
            else if (res1 > 54 && res1 < 60) { gpa1 = 1.33; Console.WriteLine($"{FIO} : GPA={gpa1}"); }
            else if (res1 > 59 && res1 < 65) { gpa1 = 1.67; Console.WriteLine($"{FIO} : GPA={gpa1}"); }
            else if (res1 > 64 && res1 < 70) { gpa1 = 2; Console.WriteLine($"{FIO} : GPA={gpa1}"); }
            else if (res1 > 69 && res1 < 76) { gpa1 = 2.33; Console.WriteLine($"{FIO} : GPA={gpa1}"); }
            else if (res1 > 75 && res1 < 80) { gpa1 = 2.67; Console.WriteLine($"{FIO} : GPA={gpa1}"); }
            else if (res1 > 79 && res1 < 85) { gpa1 = 3; Console.WriteLine($"{FIO} : GPA={gpa1}"); }
            else if (res1 > 84 && res1 < 90) { gpa1 = 3.33; Console.WriteLine($"{FIO} : GPA={gpa1}"); }
            else if (res1 > 89 && res1 < 95) { gpa1 = 3.67; Console.WriteLine($"{FIO} : GPA={gpa1}"); }
            else if (res1 > 95) { gpa1 = 4; Console.WriteLine($"{FIO} : GPA={gpa1}"); }
            else if (res2 < 25) { gpa2 = 0; Console.WriteLine($"{obj2.FIO} : GPA={gpa2}"); }
            else if (res2 > 24 && res2 < 50) { gpa2 = 0.5; Console.WriteLine($"{obj2.FIO} : GPA={gpa2}"); }
            else if (res2 > 49 && res2 < 55) { gpa2 = 1.0; Console.WriteLine($"{obj2.FIO} : GPA={gpa2}"); }
            else if (res2 > 54 && res2 < 60) { gpa2 = 1.33; Console.WriteLine($"{obj2.FIO} : GPA={gpa2}"); }
            else if (res2 > 59 && res2 < 65) { gpa2 = 1.67; Console.WriteLine($"{obj2.FIO} : GPA={gpa2}"); }
            else if (res2 > 64 && res2 < 70) { gpa2 = 2; Console.WriteLine($"{obj2.FIO} : GPA={gpa2}"); }
            else if (res2 > 69 && res2 < 76) { gpa2 = 2.33; Console.WriteLine($"{obj2.FIO} : GPA={gpa2}"); }
            else if (res2 > 75 && res2 < 80) { gpa2 = 2.67; Console.WriteLine($"{obj2.FIO} : GPA={gpa2}"); }
            else if (res2 > 79 && res2 < 85) { gpa2 = 3; Console.WriteLine($"{obj2.FIO} : GPA={gpa2}"); }
            else if (res2 > 84 && res2 < 90) { gpa2 = 3.33; Console.WriteLine($"{obj2.FIO} : GPA={gpa2}"); }
            else if (res2 > 89 && res2 < 95) { gpa2 = 3.67; Console.WriteLine($"{obj2.FIO} : GPA={gpa2}"); }
            else if (res2 > 95) { gpa2 = 4; Console.WriteLine($"{obj2.FIO} : GPA={gpa2}");}

        }

        public void Salystyru()
        {
            
            
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

            stu1.GPA(stu2);
        }

        static void Syzyk()
        {
            Console.WriteLine("---------------------------------------");
        }
    }
}
