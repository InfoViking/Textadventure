using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Textadventure
{
    internal static class Titlescreen
    {
        public static void StartingScreen()
        {
            Console.WriteLine("The Way Home");
            Console.WriteLine("Press Space to Start");
            Console.WriteLine("Press anything to Exit");

            ConsoleKeyInfo start = Console.ReadKey();
            if (start.Key == ConsoleKey.Spacebar)
            { 

            }
            else
            {
                Environment.Exit(0);

            } 


            
        }

    }
}
