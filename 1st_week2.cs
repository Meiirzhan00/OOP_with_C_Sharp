   /*Описать процедуру ShiftRight3(A, B, C), выполняющую правый циклический сдвиг: 
     значение A переходит в B, значение B — в C, значение C — в A (A, B, C — вещественные 
     параметры, являющиеся одновременно входными и выходными). 
     С помощью этой процедуры выполнить правый циклический сдвиг для двух 
     данных наборов из трех чисел: (A1, B1, C1) и (A2, B2, C2).*/

using System;

namespace foo
{
    class Program
    {
        static void ShiftRight3(double A, double B, double C)
        {
            double t = A; A = B; B = C; C = t;

            Console.WriteLine("Solga zhylzhygandagy natizhesi: (" + A + "," + B + "," + C + ")");
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
            Program.ShiftRight3(A1, B1, C1);
            Program.ShiftRight3(A2, B2, C2);
            Console.ReadKey();
        }
    }
}
