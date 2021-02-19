/*Proc13. Описать процедуру SortDec3(A, B, C), меняющую содержимое переменных A, B, C таким образом, 
     * чтобы их значения оказались упорядоченными по убыванию (A, B, C — вещественные параметры, являющиеся 
     * одновременно входными и выходными). С помощью этой процедуры упорядочить по убыванию два данных 
     * набора из трех чисел: (A1, B1, C1) и (A2, B2, C2). */
     
    class Program
    {
        static void ShiftRight3(double A, double B, double C)
        {
            if (A > B && A > C && B > C)
            {
                Console.WriteLine("Kemu retimen jazyluy(" + A + "," + B + "," + C + ")");
            }
            if (A > B && A > C && C > B)
            {
                Console.WriteLine("Kemu retimen jazyluy(" + A + "," + C + "," + B + ")");
            }
            if (B > A && A > C && B > C)
            {
                Console.WriteLine("Kemu retimen jazyluy(" + B + "," + A + "," + C + ")");
            }
            if (B > A && A < C && B > C)
            {
                Console.WriteLine("Kemu retimen jazyluy(" + B + "," + C + "," + A + ")");
            }
            if (A > B && A < C && C > B)
            {
                Console.WriteLine("Kemu retimen jazyluy(" + C + "," + A + "," + B + ")");
            }
            if (A < B && A < C && C > B)
            {
                Console.WriteLine("Kemu retimen jazyluy(" + C + "," + B + "," + A + ")");
            }
        }
        public static void Main(string[] args)
        {
            double A1, B1, C1, A2, B2, C2;
            Console.Write("A1:");
            A1 = double.Parse(Console.ReadLine());
            Console.Write("B1:");
            B1 = double.Parse(Console.ReadLine());
            Console.Write("C1:");
            C1 = double.Parse(Console.ReadLine());
            Console.Write("A2:");
            A2 = double.Parse(Console.ReadLine());
            Console.Write("B2:");
            B2 = double.Parse(Console.ReadLine());
            Console.Write("C2:");
            C2 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Algashqy natizhesi (A1,B1,C1): (" + A1 + "," + B1 + "," + C1 + ")");
            Console.WriteLine("Algashqy natizhesi (A2,B2,C2): (" + A2 + "," + B2 + "," + C2 + ")");
            ShiftRight3(A1, B1, C1);
            ShiftRight3(A2, B2, C2);
            Console.ReadKey();
        }
    }
