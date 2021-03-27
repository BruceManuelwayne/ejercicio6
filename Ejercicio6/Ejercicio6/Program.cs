using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            Console.TreatControlCAsInput = true;

            do
            {
                tecla = Console.ReadKey();
                Console.WriteLine();
                if((tecla.Key == ConsoleKey.F) &&
                    ((tecla.Modifiers & ConsoleModifiers.Shift)!=0) &&
                    ((tecla.Modifiers & ConsoleModifiers.Control) != 0))
                    {
                    break; 
                    }
                        

            } while (true);
        }
    }
}
