using System;

namespace Ciclos_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("<<Rango>>");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("De donde empezamos el ciclo: ");
            Console.ForegroundColor = ConsoleColor.Black;
            x = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Escribe hasta donde terminamos el ciclo el ciclo:");
            Console.ForegroundColor = ConsoleColor.Black;
            y = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("De cuanto en cuanto? ");
            Console.ForegroundColor = ConsoleColor.Black;
            z = Convert.ToInt32(Console.ReadLine());

            if (x < y)
            {
                for (int i = x; i <= y; i += z)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("i = " + i);
                }
            }
            if (x > y)
            {
                for (int i = x; i >= y; i -= z)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("i = " + i);
                }
            }
        }
    }
}