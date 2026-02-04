using System;

namespace Dia27
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // VaihdaPaikat(); //1
           // SuurinKolmesta(); //2
            // NumeroSanaksi(); //3
            //SuurinViidesta(); //4
            // SyotettavaTieto(); //5
            // Bonus(); //6
             NumerotSanoiksi(); //7


            Console.ReadLine();
        }
        //1
        static void VaihdaPaikat()
        {
            Console.Write("Anna1.luku: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Anna2.luku: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            Console.WriteLine("Suuruusjärjestys: " + a + " " + b);
        }

        //2
        static void SuurinKolmesta()
        {
            Console.Write("Anna1.luku: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Anna2.luku: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Anna3.luku: ");
            int c = int.Parse(Console.ReadLine());

            int suurin = a;
            if (b > suurin) suurin = b;
            if (c > suurin) suurin = c;

            Console.WriteLine("Suurin luku on:" + suurin);
        }

        //3
        static void NumeroSanaksi()
        {
            Console.Write("Anna kokonaisluku(0-9):");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 0: Console.WriteLine("Nolla"); break;
                case 1: Console.WriteLine("Yksi"); break;
                case 2: Console.WriteLine("Kaksi"); break;
                case 3: Console.WriteLine("Kolme"); break;
                case 4: Console.WriteLine("Neljä"); break;
                case 5: Console.WriteLine("Viisi"); break;
                case 6: Console.WriteLine("Kuusi"); break;
                case 7: Console.WriteLine("Seitsemän"); break;
                case 8: Console.WriteLine("Kahdeksan"); break;
                case 9: Console.WriteLine("Yhdeksän"); break;
                default: Console.WriteLine("Virhe:anna luku väliltä 0-9"); break;

            }
        }

        //4
        static void SuurinViidesta()
        {
            int[] luvut = new int[5];

            Console.Write("Anna 1. luku: ");
            luvut[0] = int.Parse(Console.ReadLine());

            Console.Write("Anna 2. luku: ");
            luvut[1] = int.Parse(Console.ReadLine());

            Console.Write("Anna 3. luku: ");
            luvut[2] = int.Parse(Console.ReadLine());

            Console.Write("Anna 4. luku: ");
            luvut[3] = int.Parse(Console.ReadLine());

            Console.Write("Anna 5. luku: ");
            luvut[4] = int.Parse(Console.ReadLine());

            Array.Sort(luvut);
            Console.WriteLine($"Suurin luku on: {luvut[4]}");
        }

        //5
        static void SyotettavaTieto()
        {
            Console.Write("Anna syötettävä tieto (i=kokonaisluku, d=double, m=merkkijono): ");
            string tieto = Console.ReadLine();

            Console.Write("Anna syötettävä arvo (numero tai merkkijono): ");
            string arvo = Console.ReadLine();

            switch (tieto)
            {
                case "i":
                    int iluku = int.Parse(arvo);
                    Console.WriteLine(iluku + 1); break;

                case "d":
                    double dluku = double.Parse(arvo);
                    Console.WriteLine(dluku + 1); break;

                case "m":
                    Console.WriteLine(arvo + "*"); break;

                default:
                    Console.WriteLine("Et antanut oikeaa valintaa (i, d, m)!"); break;
            }
        }

        //6
        static void Bonus()
        {
            Console.Write("Anna pisteet (0-9): ");
            int p = int.Parse(Console.ReadLine());

            if (p >= 1 && p <= 3)
            {
                Console.WriteLine("Tulos: " + (p * 10));
            }
            else if (p >= 4 && p <= 6)
            {
                Console.WriteLine("Tulos: " + (p * 100));
            }
            else if (p >= 7 && p <= 9)
            {
                Console.WriteLine("Tulos: " + (p * 1000));
            }
            else
            {
                Console.WriteLine("Virhe: pisteet pitää olla 1-9");
            }
        }

        //7
        static void NumerotSanoiksi()
        {
            Console.Write("Anna luku (0-999): ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n > 999)
            {
                Console.WriteLine("Virheellinen luku");
                return;
            }

            Console.WriteLine(NumerotSanoiksiTeksti(n));
        }

        static string NumerotSanoiksiTeksti(int n)
        {
            // 0-9
            if (n <= 9)
            {
                switch (n)
                {
                    case 0: return "Nolla";
                    case 1: return "Yksi";
                    case 2: return "Kaksi";
                    case 3: return "Kolme";
                    case 4: return "Neljä";
                    case 5: return "Viisi";
                    case 6: return "Kuusi";
                    case 7: return "Seitsemän";
                    case 8: return "Kahdeksan";
                    case 9: return "Yhdeksän";
                }
            }

            // 10-19
            if (n <= 19)
            {
                switch (n)
                {
                    case 10: return "Kymmenen";
                    case 11: return "Yksitoista";
                    case 12: return "Kaksitoista";
                    case 13: return "Kolmetoista";
                    case 14: return "Neljätoista";
                    case 15: return "Viisitoista";
                    case 16: return "Kuusitoista";
                    case 17: return "Seitsemäntoista";
                    case 18: return "Kahdeksantoista";
                    case 19: return "Yhdeksäntoista";
                }
            }

            // 20-99
            if (n <= 99)
            {
                int kymmenet = n / 10;
                int ykkoset = n % 10;

                string tulos = "";
                switch (kymmenet)
                {
                    case 2: tulos = "Kaksikymmentä"; break;
                    case 3: tulos = "Kolmekymmentä"; break;
                    case 4: tulos = "Neljäkymmentä"; break;
                    case 5: tulos = "Viisikymmentä"; break;
                    case 6: tulos = "Kuusikymmentä"; break;
                    case 7: tulos = "Seitsemänkymmentä"; break;
                    case 8: tulos = "Kahdeksankymmentä"; break;
                    case 9: tulos = "Yhdeksänkymmentä"; break;
                }

                if (ykkoset != 0)
                    tulos += " " + NumerotSanoiksiTeksti(ykkoset);

                return tulos;
            }

            // 100-999
            int sadat = n / 100;
            int loppu = n % 100;

            string vastaus;

            if (sadat == 1) vastaus = "Sata";
            else
            {
                // sadat on 2-9 täällä
                string sadatSana = NumerotSanoiksiTeksti(sadat); 
                vastaus = sadatSana + "sataa";
            }

            if (loppu != 0)
                vastaus += " " + NumerotSanoiksiTeksti(loppu);

            return vastaus;
        }
    }
}
        