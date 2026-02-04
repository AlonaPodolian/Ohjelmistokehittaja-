namespace Silmukkaharjoituksia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //S01();
            //S02();
            S03();
            //S04();
            //S05();
            //S06();
            //S07();
            //S08();
            //S09();
            //S10();
            //S11();
            //S12();
            //S13();
            //S14();
            //S15();
            //S16();

            Console.ReadLine();
        }

        //S01()
        static void S01()
        {
            int laina = 5000;
            int lainaAika = 2;
            double korko = 0.02;
            double maksettava = laina;

            for (int i = 0; i < lainaAika; i++)
            {
                maksettava += maksettava * korko;
            }

            double korkosumma = maksettava - laina;

            Console.WriteLine("Maksettavaa tulee {0} + {1} = {2}", laina, korkosumma, maksettava);
        }

        //S02()
        static void S02()
        {
            Console.Write("Anna luku: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int kertoma = 1;

            for (int i = 1;i <= n;i++)
            {
                kertoma *= i;
            }
            Console.WriteLine("Kertoma on: " + kertoma);
        }

        //S03()
        static void S03()
        {
            int[] taulukko = new int[] { 6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3 };
            int luku = 3;

            for (int i = 0; i < taulukko.Length; i++) 
            {
                if (luku == taulukko[i])
                {
                    Console.WriteLine("Ensimmäinen esiintymä luvulle {0} on kohdassa {1}.", luku, i);
                    break;
                }
            }
        }
    }
}
