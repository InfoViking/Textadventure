using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    /// <summary>
    /// helper class: Game Over Screen
    /// </summary>
    internal class Gameover
    {
        internal static void GameOver(string deathReason)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(deathReason);


            Console.WriteLine("Game Over");
            ConsoleText.Continue();
            Program.Main();
            Environment.Exit(0);
        }
    }
}
