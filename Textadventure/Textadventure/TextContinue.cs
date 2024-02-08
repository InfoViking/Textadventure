using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal static class TextContinue
    {
        public static void Textscroll()
        {
            ConsoleKeyInfo start = Console.ReadKey();
            if (start.Key == ConsoleKey.Enter)
            {

            }
            else
            {
                Environment.Exit(0);

            }
        }

    }
}
