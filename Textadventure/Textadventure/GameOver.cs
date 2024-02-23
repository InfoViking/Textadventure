using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal class Gameover
    {

        internal static void GameOver(string deathReason)
        {
            Console.WriteLine(deathReason);


            Console.WriteLine("Game Over");
            Textscroll.TextScroll();
            Program.Main();
            Environment.Exit(0);



        }
    }
}
