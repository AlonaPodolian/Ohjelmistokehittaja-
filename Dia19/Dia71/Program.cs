namespace Dia71
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teht1();
            //Teht2();
            //Teht3();
            //Teht4();
            //Teht5();
            //Teht6();
            //Teht7();
            //Teht8();
            //Teht9();
            //Teht10();
            //Teht11();
            //Teht12();
            //Teht13();
            //Teht14();
            //Teht15();
            //Teht16();
            Teht17();

            Console.ReadLine();
        }
        //1
        static void Teht1()
        {
            int a = 3;
            int b = 5;
            Console.WriteLine(a + b);
        }
        //2
        static void Teht2()
        {
            double c = 10;
            double f = c * 1.8 + 32;
            Console.WriteLine(f);
        }

        //3
        static void Teht3()
        { double a = 8;
            double b = 5;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
        }

        //4
        static void Teht4()
        { int a = 5;
            int b = 2;
            Console.WriteLine(a % b);
        }

        //5
        static void Teht5()
        {
            Console.Write("Anna nimesi: ");
            string nimi = Console.ReadLine();
            Console.WriteLine("Hei " + nimi);
        }

        //6
        static void Teht6()
        {
            Console.Write("Anna 1. luku: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Anna 2. luku: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a + b);
        }

        //7
        static void Teht7()
        {
            Console.Write("Anna Celsius: ");
            double c = double.Parse(Console.ReadLine());
            double f = c * 1.8 + 32;
            Console.WriteLine(f);
        }

        //8
        static void Teht8()
        {
            Console.Write("Anna 1. luku: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Anna 2. luku: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);

        }

        //9
        static void Teht9()
        {
            Console.Write("Anna 1. luku: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Anna 2. luku: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a % b);
        }

        //10
        static void Teht10()
        {
            Console.Write("Anna kokonaisluku (1-10): ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + "x" + i + "=" + (n * i));
            }
        }

        //11
        static void Teht11()
        {
            Console.Write("Anna ikäsi: ");
            int ika = int.Parse(Console.ReadLine());

            Console.WriteLine(ika + " - näytät ikäistäsi nuoremmalta");
        }

        //12

        static void Teht12()
        {
            Console.Write("Anna kokonaisluku (yli 10): ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(n + " "); 
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            { 
                Console.WriteLine(n);
            }
            Console.WriteLine();
        }

        //13
        static void Teht13()
        {
            Console.Write("Anna sana: ");
            string s = Console.ReadLine();

            if (string.IsNullOrEmpty(s) || s.Length == 1)
            {
                Console.WriteLine(s);
                return;
            }

            char first = s[0];
            char last = s[s.Length - 1];
            string middle = s.Substring(1, s.Length - 2);
            Console.WriteLine(last + middle + first);
            
        }

        //14
        static void Teht14()
        {
            Console.Write("Anna 1. luku: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Anna 2. luku: ");
            int b = int.Parse(Console.ReadLine());

            if (a > 0 && b > 0)
                Console.WriteLine("Molemmat ovat positiivisia");
            else if (a < 0 && b < 0)
                Console.WriteLine("Molemmat ovat negatiivisia");
            else
                Console.WriteLine("Toinen on positiivinen ja toinen negatiivinen");
        }

        //15
        static void Teht15()
        {
            Console.Write("Anna lause: ");
            string lause = Console.ReadLine();

            string[] sanat = lause.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string pisin = "";
            foreach (string sana in sanat)
            {
                if (sana.Length > pisin.Length)
                    pisin = sana;
            }
            Console.WriteLine("Pisin sana: " + pisin);
        }

        //16
        static void Teht16()
        {
            for (int i = 1; i <=99; i +=2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        //17
        static void Teht17()
        {
            for (int i = 1; i <= 99; i++)       
            {
                if (i % 3 == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }


    }
}
