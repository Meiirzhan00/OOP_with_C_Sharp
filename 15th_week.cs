using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_LAB
{
    class Farm  // Жалпы ферма туралы ақпарат класы
    {
        public int numberFarm;   // Ферма номері
        public string nameFarm;  // Ферма аты
        public string directorFarm;  // Фурма директорының аты-жөні
        public long phoneFarm;  // Ферма номері
        public Farm (int numberFarm, string nameFarm, string directorFarm, long phoneFarm)  // Параметрлі конструктор. Бұл бізге List құру үшін қажет.
        {
            this.numberFarm = numberFarm;
            this.nameFarm = nameFarm;
            this.directorFarm = directorFarm;
            this.phoneFarm = phoneFarm;
        }
        public void ShowFarms()  // Жоғарыдағы параметрлерді. Ферма туралы ақпаратты шығару әдісі.
        {
            Console.WriteLine($"{numberFarm}) {nameFarm} , {directorFarm} , {phoneFarm}.");
        }
    }
    public delegate void Farms();  // Анонимді әдіс құруға қажетті делегат. Фермалар туралы ақпарат шығару үшін.
    public delegate void Money();  // Аукционда ең жоғары бағаға сатылған тері бағасын шығаруға арналған әдіс.
    class Program
    {
        static void Main(string[] args)
        {
            List<Farm> huntFarm = new List<Farm>();  // Ферма туралы ақпаратты жинауға арналған List құрылды.

            huntFarm.Add(new Farm(1, "Sunny Brook Dairy Farm","Magzhan Kayranbay",7024591212));
            huntFarm.Add(new Farm(2, "Turkey Trot Farm", "Akoch Vekchey", 8016549966));
            huntFarm.Add(new Farm(3, "Fox Farmhouse", "Orken Adilbay", 7004887733));
            huntFarm.Add(new Farm(4, "Sunny Brook Dairy Farm", "Nesipbay Nurgaly", 7779105511));

            Console.WriteLine("Auyksonga katysatyn fermalar :\n");
            Farms printFarm = delegate  // Анонимдік әдістің денесі.
            {
                foreach (var count in huntFarm)
                {
                    count.ShowFarms();
                }
            };
            printFarm();  // Анонимдік әдісті шақыру.

            Console.WriteLine("\nAuyksonga koylatyn teri : 'ARYSTAN TERISI'");
            int n = 0;
            Console.Write("\nMumkindikter sanin engiz (n > 4) : ");  // Аукционда берілетін мүмкіндіктер саны. Яғни қанша мүмкіндіктен соң сатып алу тоқтайды.
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)   // int типінен басқа енгізсек қателік шығады. Өткен сабақтармен байланыстырдым.
            {
                Console.WriteLine("Durys emes format.");
            }
            if (n > 0)
            {
                List<int> numbers = new List<int>();  // Аукцион қатысушылары ұсынған ақшалар жинақталатын List. 
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Teri bagasyn engiz: {0}. ", i + 1,"$");
                    try
                    {
                        numbers.Add(int.Parse(Console.ReadLine()));
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Durys emes format.");
                    }
                }

                Money maxM = delegate  // Анонимдік әдіс. Бұл әдісте numbers тізіміндегі ұсынған ақшалардың ең үлкенін табамыз. Тері сол бағаға сатылады.
                 {
                     int max = numbers.Max(); // Тізімнен ең үлкен ақшаны табу жолы.
                     Console.WriteLine($"\nAuyksonda satylgan teri bagasy: {max}$");  // Аукцион нәтижесі.
                 };

                maxM();  // Анонимдік әдісті шақыру.
                
            }
        }
    }
}
