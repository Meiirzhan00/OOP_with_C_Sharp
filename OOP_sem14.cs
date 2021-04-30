  using System;

namespace test
{
    delegate int LengthLogin(string s);
    delegate bool BoolPassword(string s1, string s2);

    class Program
    {
        private static void SetLogin()
        {
            Console.Write("Login engiz : ");
            string login = Console.ReadLine();

            LengthLogin lengthLoginDelegate = s => s.Length;

            int lengthLogin = lengthLoginDelegate(login);
            if (lengthLogin > 25)
            {
                Console.WriteLine("Ote uzyn login !\n");

                SetLogin();
            }
        }

        static void Main()
        {
            SetLogin();

            Console.Write("Parol engiz : ");
            string password1 = Console.ReadLine();
            Console.Write("Paroldy kaytala : ");
            string password2 = Console.ReadLine();

            BoolPassword bp = (s1, s2) => s1 == s2;

            if (bp(password1, password2))
                Console.WriteLine("Satti tirkeldi !");
            else
                Console.WriteLine("Tirkelmedi. Paroldar saykes kelmeydi !");

            Console.ReadLine();
        }
    }
}
