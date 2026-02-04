namespace perustehtäviä
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //P01();
            //P02();
            //P03();
            //P04();
            //P05();
            //P06();
            //P07();
            //P08();
            //P09();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16();
            //P17();
            P18();
            Console.ReadLine();
        }

        //P01
        static void P01()
        {
            Console.WriteLine("Hei maailma!");
        }

        //P02
        static void P02()
        {
            Console.Write("Syötä ensimmäinen luku: ");
            double luku1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Syötä toinen luku: ");
            double luku2 = Convert.ToDouble(Console.ReadLine());

            double summa = luku1 + luku2;

            Console.WriteLine($"Lukujen {luku1} ja {luku2} summa on {summa}");
        }

        //P03
        static void P03()
        {
            Console.Write("Syötä ensimmäinen luku: ");
            double luku1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Syötä toinen luku: ");
            double luku2 = Convert.ToDouble(Console.ReadLine());

            double erotus = luku1 - luku2;

            Console.WriteLine($"Lukujen erotus on {erotus}");
        }

        //P04
        static void P04()
        {
            Console.Write("Syötä ensimmäinen luku: ");
            double luku1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Syötä toinen luku: ");
            double luku2 = Convert.ToDouble(Console.ReadLine());

            double tulo = luku1 * luku2;

            Console.WriteLine($"Lukujen erotus on {tulo}");
        }

        //P05
        static void P05()
        {
            Console.Write("Syötä ensimmäinen luku: ");
            double luku1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Syötä toinen luku: ");
            double luku2 = Convert.ToDouble(Console.ReadLine());

            double osamaara = luku1 / luku2;

            Console.WriteLine($"Lukujen erotus on {osamaara}");
        }

        //P06
        static void P06()
        {
            Console.Write("Syötä Celsius-asteet: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine($"{celsius} °C on {fahrenheit} °F");
        }

        //P07
        static void P07()
        {
            Console.Write("Syötä Fahrenheit-asteet: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = (fahrenheit - 32) / 1.8;

            Console.WriteLine($"{fahrenheit} °F on {celsius} °C");
        }

        //P08
        static void P08()
        {
            Console.Write("Syötä mailit: ");
            double mile = Convert.ToDouble(Console.ReadLine());

            double km = mile * 1.609;

            Console.WriteLine($"{mile} mailia on {km} kilometriä");
        }

        //P09
        static void P09()
        {
            Console.Write("Syötä kilometrit: ");
            double km = Convert.ToDouble(Console.ReadLine());

            double mile = km / 1.609;

            Console.WriteLine($"{km} kilometriä on {mile} mailia");
        }

        //P10
        static void P10()
        {
            Console.Write("Syötä tuumat: ");
            double inch = Convert.ToDouble(Console.ReadLine());

            double cm = inch * 2.54;

            Console.WriteLine($"{inch} tuumaa on {cm} senttiä");
        }

        //P11 
        static void P11()
        {
            Console.Write("Syötä sentit: ");
            double cm = Convert.ToDouble(Console.ReadLine());

            double inch = cm / 2.54;

            Console.WriteLine($"{cm} senttiä on {inch} tuumaa");
        }

        //P12
        static void P12()
        {
            Console.Write("Syötä yardit: ");
            double yard = Convert.ToDouble(Console.ReadLine());

            double m = yard * 0.9144;

            Console.WriteLine($"{yard} yardia on {m} metriä");
        }

        //P13
        static void P13()
        {
            Console.Write("Syötä metrit: ");
            double m = Convert.ToDouble(Console.ReadLine());

            double yard = m / 0.9144;

            Console.WriteLine($"{m} metriä on {yard} yardia");
        }

        //P14
        static void P14()
        {
            Console.Write("Anna luku a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Anna luku b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nValitse laskutoimitus: ");
            Console.WriteLine($"Summa: {a + b}");
            Console.WriteLine($"Erotus: {a - b}");
            Console.WriteLine($"Tulo: {a * b}");
            Console.WriteLine($"Osamäärä:{a / b}");

            Console.Write("Anna valintasi (1-4): ");
            int valinta = Convert.ToInt32(Console.ReadLine());

            switch (valinta)
            {
                case 1:
                    Console.WriteLine($"\nSumma: {a} + {b} = {a + b}"); 
                    break;
                case 2: Console.WriteLine($"\nErotus: {a} - {b} = {a - b}"); 
                    
                    break;
                case 3: Console.WriteLine($"\nTulo: {a} * {b} = {a * b}"); 
                    break;
                case 4: 
                    if (b != 0)
                    {
                        Console.WriteLine($"\nOsamäärä: {a} / {b} = {a / b}");
                    }
                    else
                    {
                        Console.WriteLine("\nVirhe: Nollalla jakaminen ei ole sallittua!");
                    }
                    break;
                default: Console.Write("\nVirheellinen valinta! Valitse numero välillä 1-4.");
                    break;
            }
        }

        //P15
        static void P15()
        {
            Console.Write("Syötä ympyrän säde: ");
            double sade = Convert.ToDouble(Console.ReadLine());

            if (sade >= 0)
            {
                double pintaAla = Math.PI * Math.Pow(sade, 2);
                Console.WriteLine($"Ympyrän pinta-ala säteellä {sade} on {pintaAla:F2}");
            }
            else
            {
                Console.WriteLine("Virhe: Säde ei voi olla negatiivinen!");
            }
        }

        //P16
        static void P16()
        {
            Console.Write("Syötä neliön sivun mittä: ");
            double sivu = Convert.ToDouble(Console.ReadLine());

            if (sivu >= 0)
            {
                double pintaAla = Math.Pow(sivu, 2);
                Console.WriteLine($"Neliön pinta-ala sivun mitalla {sivu} on {pintaAla:F2}");
            }
            else
            {
                Console.WriteLine("Virhe: Sivun mitta ei ole voi olla negatiivinen");
            }
        }

        //P17

        static void P17()
        {
            Console.Write("Syötä suorakulmion pituus; ");
            double pituus = Convert.ToDouble(Console.ReadLine());

            Console.Write("Syötä suorakulmion leveys: ");
            double leveys = Convert.ToDouble(Console.ReadLine());

            if (pituus >= 0 && leveys >= 0)
            {
                double pintaAla = pituus * leveys;
                Console.WriteLine($"Suorakulmion pinta-ala pituudella {pituus} ja leveydellä {leveys} on {pintaAla:F2}");
            }
            else
            {
                Console.WriteLine("Virhe: Pituus ja leveys eivät voi olla negatiivisia!");
            }
        }

        //P18
        static void P18()
        {
            Console.Write("Syötä päivien määrä: ");
            int paivat = Convert.ToInt32(Console.ReadLine());

            if (paivat >= 0)
            {
                int vuodet = paivat / 365;
                int jaljellaPaivat = paivat % 365;
                int kuukaudet = jaljellaPaivat / 30;
                int paivatJaljella = jaljellaPaivat % 30;

                Console.WriteLine($"\n{paivat} päivää on noin: ");
                Console.WriteLine($"{vuodet} vuotta");
                Console.WriteLine($"{kuukaudet} kuukautta");
                Console.WriteLine($"{paivatJaljella} päivää");
            }
            else
            {
                Console.WriteLine("Virhe: Päivien määrä ei voi olla negatiivinen!");
            }
        }
    }
}
