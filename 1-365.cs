static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            Console.Write("Input any number from 1 to 365 : ");
            int num = int.Parse(Console.ReadLine());
            if (num < 0 && num > 365)
            {
                Console.WriteLine("Try again !");
            }
            else
            {
                float reminder = num % 7;
                switch (reminder)
                {
                    case 0: Console.WriteLine("2. Tuesday"); break;
                    case 1: Console.WriteLine("3. Wednesday"); break;
                    case 2: Console.WriteLine("4. Turthday");break;
                    case 3: Console.WriteLine("5. Friday"); break;
                    case 4: Console.WriteLine("6. Saturday"); break;
                    case 5: Console.WriteLine("7. Sunday"); break;
                    case 6: Console.WriteLine("1. Monday"); break;

                }

            }
        }
    }
