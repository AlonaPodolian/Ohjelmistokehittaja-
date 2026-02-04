using System;

namespace If_Else_harjoituksia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IE01();
            //IE02();
            //IE02_2();
            //IE03();
            //IE04();
            //IE05();
            //IE06();
            //IE07();
            //IE09();
            //IE10();
            //IE11();
            //IE12();
            //IE13();
            //IE14();
            //IE15();
            //IE16();
            //IE17();
            IE18();

            Console.ReadLine();
        }

        //IE01();
        static void IE01()
        {
            Console.Write("Anna 1. luku: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Anna 2. luku: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Suurempi on: " + a);
            }
            else
            {
                Console.WriteLine("Suurempi on: " + b);
            }

        }

        //IE02();
        static void IE02()
        {
            Console.Write("Anna 1. luku: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Anna 2. luku: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Anna 3. luku: ");
            int c = int.Parse(Console.ReadLine());

            if(a >= b && a >= c)
            {
                Console.WriteLine("Suurin luku on " + a);
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine("Suurin luku on " + b);
            }
            else
            {
                Console.WriteLine("Suurin luku on " + c);
            }
        }

        //IE02_2();
        static void IE02_2()
        {
            int[] luvut = new int[3];
            Console.Write("Anna ensimmäinen kokonaisluku: ");
            luvut[0] = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen kokonaisluku: ");
            luvut[1] = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas kokonaisluku: ");
            luvut[2] = int.Parse(Console.ReadLine());

            Array.Sort(luvut);
            Console.WriteLine("Luvut järjestyksessä: ");
            foreach(int x in luvut)
            {
                Console.WriteLine("{0} ", x); 
            }
        }

        //IE03();
        static void IE03()
        {
            Console.Write("Anna luku: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
                Console.WriteLine("Positiivinen");
            else if (n < 0)
                Console.WriteLine("Negatiivinen");
            else
                Console.WriteLine("Nolla");
        }

        //IE04();
        static void IE04()
        {
            Console.Write("Anna luku: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 5 == 0 || n % 11 == 0)
                Console.WriteLine("Jaollinen 5:llä tai 11:llä");
            else
                Console.WriteLine("Ei ole jaollinen");
        }

        //IE05();
        static void IE05()
        {
            Console.Write("Anna vuosi:");
            int vuosi = int.Parse(Console.ReadLine());

            if ((vuosi % 4 == 0 && vuosi % 100 != 0) || vuosi % 400 == 0)
                Console.WriteLine("Karkausvuosi");
            else
                Console.WriteLine("Ei ole karkausvuosi");
        }

        //IE06();
        static void IE06()
        {
            Console.Write("Anna luku: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine("Parillinen");
            else
                Console.WriteLine("Pariton");
        }

        //IE07();
        static void IE07()
        {
            Console.Write("Anna merkki: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsLetter(c))
                Console.WriteLine("Kirjain");
            else
                Console.WriteLine("Ei ole kirjain");
        }

        //IE08();
        static void IE08()
        {
            Console.Write("Anna kirjain: ");
            char c = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if ("aeiouyäö".Contains(c))
                Console.WriteLine("Vokaali");
            else
                Console.WriteLine("Konsonantti");
        }

        //IE09();
        static void IE09()
        {
            Console.Write("Anna merkki: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsLetter(c))
                Console.WriteLine("Kirjain");
            else if (char.IsDigit(c))
                Console.WriteLine("Numero");
            else
                Console.WriteLine("Erikoismerkki");
        }

        //IE10();
        static void IE10()
        {
            Console.Write("Anna kirjain: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsUpper(c))
                Console.WriteLine("\nIso kirjain");
            else if (char.IsLower(c))
                Console.WriteLine("\nPieni kirjain");
            else
                Console.WriteLine("\nEi ole kirjain");
        }

        //IE11();
        static void IE11()
        {
            Console.Write("Anna ostohinta: ");
            double osto = double.Parse(Console.ReadLine());
            Console.Write("Anna myyntihinta: ");
            double myynti = double.Parse(Console.ReadLine());

            if (myynti > osto)
                Console.WriteLine("Voitto");
            else if (myynti < osto)
                Console.WriteLine("Tappio");
            else
                Console.WriteLine("EI voittoa eikä tappiota");
            
        }

        //IE12();
        static void IE12()
        {
            int[] pisteet = new int[5];
            string[] aineet = { "Matematiikka", "KeFY", "Äidinkieli", "Ruotsi", "Englanti" };

            for (int i = 0; i < pisteet.Length; i++)
            {
                Console.Write("Anna pisteet aineesta " + aineet[i] + "(0-100): ");
                pisteet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nArvosanat:");

            for (int i = 0; i < pisteet.Length;i++)
            {
                if (pisteet[i] >= 90)
                    Console.WriteLine(aineet[i] + ": K5");
                else if (pisteet[i] >= 80)
                    Console.WriteLine(aineet[i] + ": H4");
                else if (pisteet[i] >= 70)
                    Console.WriteLine(aineet[i] + ": H3");
                else if (pisteet[i] >= 60)
                    Console.WriteLine(aineet[i] + ": T2");
                else if (pisteet[i] >= 50)
                    Console.WriteLine(aineet[i] + ": T1");
                else
                    Console.WriteLine(aineet[i] + ": Hylätty");
            }
            Console.ReadLine();
        }

        //IE13();
        static void IE13()
        {
            Console.Write("Anna viikonpäivän numero (1-7): ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1: Console.WriteLine("Maanantai"); break;
                    case 2: Console.WriteLine("Tiistai"); break;
                    case 3: Console.WriteLine("Keskiviikko"); break;
                    case 4: Console.WriteLine("Torstai"); break;
                    case 5: Console.WriteLine("Perjantai"); break;
                    case 6: Console.WriteLine("Lauantai"); break;
                case 7: Console.WriteLine("Sunnuntai"); break;
                default: Console.WriteLine("Virheellinen numero"); break;
            }
        }

        //IE14();
        static void IE14()
        {
            Console.Write("Anna 1. luku: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Anna 2. luku: ");
            int b = int.Parse(Console.ReadLine());

            if (a == b)
                Console.WriteLine("Luvut ovat samat");
            else
                Console.WriteLine("Luvut eivät ole samat");
        }

        //IE15()
        static void IE15()
        {
            int ika;

            Console.Write("Anna ikäsi: ");
            ika = Convert.ToInt32(Console.ReadLine());

            if (ika < 18)
            {
                Console.WriteLine("Et ole vielä äänestysikäinen.");
                Console.WriteLine($"Voit äänestää {18 - ika} vuoden kuluttua.");
            }

            else
            {
                 Console.WriteLine("Onnittelut! Saat äänestää.");
            }

             Console.ReadLine(); 
               
        }

        //IE16()
        static void IE16()
        {
            Console.Write("Anna kuukauden numero (1-12): ");
            int kk = Convert.ToInt32(Console.ReadLine());

            switch (kk)
            {
                case 2: Console.WriteLine("28 päivää"); break;
                case 4:
                case 6:
                case 9:
                case 11: Console.WriteLine("30 päivää"); break;
                default: Console.WriteLine("31 päivää"); break;
            }
        }

        //IE17()
        static void IE17()
        {
            Console.Write("Anna summa: ");
            int summa = Convert.ToInt32(Console.ReadLine());

            int[] setelit = { 500, 100, 50, 20, 10, 5, 2, 1 };

            foreach (int s in setelit)
            {
                int kpl = summa / s;
                if (kpl > 0)
                {
                    Console.WriteLine($"{s} + {kpl}");
                    summa %= s;
                }
            }
        }

        //IE17();
        static void IE18()
        {
            Console.Write("Anna 1. kulma: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna 2. kulma: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna 3. kulma: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b + c == 180)
                Console.WriteLine("Kolmio on mahdollinen");
            else
                Console.WriteLine("Kolmio ei ole mahdollista");
        }
             
    }
}
