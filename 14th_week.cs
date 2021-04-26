/*
    7-нұсқа. [2, 77-78 бет] 10-тапсырма. 
    Жұмыс барысында келесі жағдайларды туынды аластама кластарының көмегімен өңдеңіз: 
    егер бөлшек санның алымы бөлімінен кіші болса,онда BurysBolshekEmes аластамасын, 
    егер бөлшек санның бөлімі нөлге тең болса, NolgeBolme аластамасын генерациялаңыз.
 */

using System;

namespace OOP_LAB
{
    class BurysBolshekEmes : Exception
    {
        public BurysBolshekEmes(string message) : base(message)
        {

        }
    }

    class NolgeBolme : Exception
    {
        public NolgeBolme(string message) : base(message)
        {

        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Bolshek alymyn engiz : ");
                int alym = int.Parse(Console.ReadLine());
                Console.Write("Bolshek bolimin engiz : ");
                int bolim = int.Parse(Console.ReadLine());

                if (bolim > alym)
                {

                    throw new BurysBolshekEmes("\nBurys bolshek emes !");

                }

                else if (bolim==0)
                {

                    throw new NolgeBolme("\nNolge bolme !");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nButin bolik : {alym / bolim}");
                    Console.ResetColor();
                }
            }

            catch (BurysBolshekEmes e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{e.Message}");
                Console.ResetColor();
            }

            catch (NolgeBolme e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{e.Message}");
                Console.ResetColor();
            }
        }
    }
}
