/*
    10. Функция вычисляет целую часть неправильной дроби, 
    представленной числителем и знаменателем - целыми числами.
*/

using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("\nBolshe alymyn engiz : ");
                int alym = int.Parse(Console.ReadLine());
                Console.Write("Bolshek bolimin engiz : ");
                int bolim = int.Parse(Console.ReadLine());
                double mani = alym/bolim;

                if ( bolim>alym)
                {
                    throw new Exception("Bul durys bolshek. Bizge burys bolshek kerek !\n");
                }
                
                else 
                {
                    Console.WriteLine($"Butin bolik : { mani }\n");
                }
            }
            
            catch (Exception e)
            {
                Console.WriteLine($"Katelik : {e.Message}\n");
            }
        }
    }    
}
