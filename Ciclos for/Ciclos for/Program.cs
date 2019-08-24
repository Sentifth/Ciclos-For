using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, w;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("<<Rango de tu ciclo>>");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("De donde arrancamos el ciclo: ");
            Console.ForegroundColor = ConsoleColor.Black;
            x = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("De donde terminamos el ciclo (Menor):");
            Console.ForegroundColor = ConsoleColor.Black;
            y = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("De donde terminamos el ciclo (Mayor):");
            Console.ForegroundColor = ConsoleColor.Black;
            w = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("De cuanto en cuanto: ");
            Console.ForegroundColor = ConsoleColor.Black;
            z = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("<<Ciclo Menor>>");
            for (int i = x; i > y; i -= z)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("i = " + i);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("<<Ciclo Mayor>>");
            for (int i = x; i < w; i += z)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("i = " + i);
            }
        }
    }
}