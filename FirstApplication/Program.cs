//Shaun Poweshiek
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Shaun");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Poweshiek");

            Console.Beep(2000, 500);

            Console.ReadKey();
        }
    }
}
