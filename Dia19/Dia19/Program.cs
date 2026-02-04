using System;

namespace Dia19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plus();      
            //Minus();
            //Kerto();
            //Jako();
            //Modulo();
            //PlusEquals();
            //MinusEquals();
            //KertoEquals();
            //JakoEquals();

            Console.ReadLine();
        }

        // 1. x = y + 3
        static void Plus()
        {
            Console.WriteLine("Anna y:n arvo:");
            int y = int.Parse(Console.ReadLine());
            int x = y + 3;
            Console.WriteLine("x = " + x);
        }

        // 2. x = y - 2
        static void Minus()
        {
            Console.WriteLine("Anna y:n arvo:");
            int y = int.Parse(Console.ReadLine());
            int x = y - 2;
            Console.WriteLine("x = " + x);
        }

        // 3. x = y * 5
        static void Kerto()
        {
            Console.WriteLine("Anna y:n arvo:");
            int y = int.Parse(Console.ReadLine());
            int x = y * 5;
            Console.WriteLine("x = " + x);
        }

        // 4. x = x / y
        static void Jako()
        {
            Console.WriteLine("Anna x:n arvo:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna y:n arvo:");
            int y = int.Parse(Console.ReadLine());
            x = x / y;
            Console.WriteLine("x = " + x);
        }

        // 5. x = x % y
        static void Modulo()
        {
            Console.WriteLine("Anna x:n arvo:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna y:n arvo:");
            int y = int.Parse(Console.ReadLine());
            x = x % y;
            Console.WriteLine("x = " + x);
        }

        // 6. x += y
        static void PlusEquals()
        {
            Console.WriteLine("Anna x:n arvo:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna y:n arvo:");
            int y = int.Parse(Console.ReadLine());
            x += y;
            Console.WriteLine("x = " + x);
        }

        // 7. x -= y
        static void MinusEquals()
        {
            Console.WriteLine("Anna x:n arvo:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna y:n arvo:");
            int y = int.Parse(Console.ReadLine());
            x -= y;
            Console.WriteLine("x = " + x);
        }

        // 8. x *= y
        static void KertoEquals()
        {
            Console.WriteLine("Anna x:n arvo:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna y:n arvo:");
            int y = int.Parse(Console.ReadLine());
            x *= y;
            Console.WriteLine("x = " + x);
        }

        // 9. x /= y
        static void JakoEquals()
        {
            Console.WriteLine("Anna x:n arvo:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna y:n arvo:");
            int y = int.Parse(Console.ReadLine());
            x /= y;
            Console.WriteLine("x = " + x);
        }
    }
}