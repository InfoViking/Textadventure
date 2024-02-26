using System.Security.Cryptography;

namespace Textadventure
{
    /// <summary>
    /// Startingscreen method
    /// </summary>
    internal static class Titlescreen
    {
        internal static void StartingScreen()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("The Other Way Home\n" +
                "Press Enter to Start\n" +
                "Press anything to Exit\n");
            Console.ResetColor();

            ConsoleKeyInfo start = Console.ReadKey();
            if (start.Key != ConsoleKey.Enter)
            {
                Environment.Exit(0);
            }
        }
    }
}
